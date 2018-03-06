using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using Sdt.Application.Channels.DealerCorrelation.DealerSalesInfos.Dtos;
using Sdt.Companies;
using Sdt.DealerCorrelation;
using Sdt.DealerCorrelation.DealerSaleInfoes;
using Sdt.DealerCorrelation.DealerSaleInfoes.Authorization;

namespace Sdt.Application.Channels.DealerCorrelation.DealerSalesInfos
{
    /// <summary>
    /// DealerSalesInfo应用层服务的接口实现方法
    /// </summary>
    [AbpAuthorize(DealerSalesInfoAppPermissions.DealerSalesInfo)]
    public class DealerSalesInfoAppService : ChannelsAppServiceBase, IDealerSalesInfoAppService
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        private readonly IRepository<DealerSalesInfo, int> _dealersalesinfoRepository;
        private readonly IRepository<Dealer, int> _dealerRepository;
        private readonly IRepository<Company, int> _companyRepository;
        private readonly IRepository<DealerMarketDptRelation> _dealerMarketDptRelationRepository;

        public DealerSalesInfoAppService(IRepository<DealerSalesInfo, int> dealersalesinfoRepository,
            IRepository<Dealer, int> dealerRepository,
            IRepository<Company, int> companyRepository,
            IRepository<DealerMarketDptRelation> dealerMarketDptRelationRepository)
        {
            _dealersalesinfoRepository = dealersalesinfoRepository;
            _dealerRepository = dealerRepository;
            _companyRepository = companyRepository;
            _dealerMarketDptRelationRepository = dealerMarketDptRelationRepository;
        }

        /// <summary>
        /// 获取DealerSalesInfo的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<DealerSalesInfoListDto>> GetPaged(GetDealerSalesInfosInput input)
        {
            var tenantId = CurrentUnitOfWork.GetTenantId();
            var company = await _companyRepository.FirstOrDefaultAsync(c => c.Id == tenantId);
            if (company == null)
                return null;

            var dealerMarketDptRelations = _dealerMarketDptRelationRepository.GetAll()
                .WhereIf(input.MarketingDepartmentId.HasValue, dm => dm.MarketId == input.MarketingDepartmentId);
            var dealerSalesInfoes = _dealersalesinfoRepository.GetAll();
            dealerSalesInfoes = company.Type == DcsCompanyType.分公司
                ? dealerSalesInfoes.Where(d => d.BranchId == tenantId) : dealerSalesInfoes.Where(d => d.DealerId == tenantId);

            var dealers = _dealerRepository.GetAll()
                .Where(d => dealerMarketDptRelations.Any(dm => d.Id == dm.DealerId) && d.Type == DcsDealerType.一级经销商)
                .WhereIf(!input.Filter.IsNullOrWhiteSpace(), d => d.Code.Contains(input.Filter) || d.Name.Contains(input.Filter))
                .WhereIf(input.DealerStatus != null, d => input.DealerStatus.Contains(d.Status));
            var query = from dsi in dealerSalesInfoes
                        join d in dealers on dsi.DealerId equals d.Id
                        join c in _companyRepository.GetAll() on d.Id equals c.Id
                        select new DealerSalesInfoListDto
                        {
                            Id = dsi.Id,
                            DealerCode = d.Code,
                            DealerCompanyBusinessScope = c.BusinessScope,
                            DealerCompanyFoundDate = c.FoundDate,
                            DealerCompanyLegalRepresentative = c.LegalRepresentative,
                            DealerCompanyRegisterCapital = c.RegisterCapital,
                            DealerCreateTime = d.CreationTime,
                            DealerCreatorName = d.CreatorName,
                            DealerId = d.Id,
                            DealerModifierName = d.ModifierName,
                            DealerModifyTime = d.LastModificationTime,
                            DealerName = d.Name,
                            DealerShortName = d.ShortName,
                            DealerStatus = d.Status,
                            DealerType = d.Type,
                            ErpServiceCode = dsi.ErpServiceCode,
                            SalesHotline = dsi.SalesHotline,
                            ShopLevel = dsi.ShopLevel,
                            ShopProperty = dsi.ShopProperty
                        };

            var dealersalesinfoCount = await query.CountAsync();

            var dealersalesinfos = await query
                .OrderBy(input.Sorting)
                .PageBy(input)
                .ToListAsync();
            //var dealersalesinfoListDtos = dealersalesinfos.Select(d => d.dsi).MapTo<List<DealerSalesInfoListDto>>();

            return new PagedResultDto<DealerSalesInfoListDto>(
                dealersalesinfoCount,
                dealersalesinfos
            );
        }

        /// <summary>
        /// 通过指定id获取DealerSalesInfoListDto信息
        /// </summary>
        public async Task<DealerSalesInfoListDto> GetById(EntityDto<int> input)
        {
            var entity = await _dealersalesinfoRepository.GetAsync(input.Id);

            return ObjectMapper.Map<DealerSalesInfoListDto>(entity);
        }

        /// <summary>
        /// 修改DealerSalesInfo的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task Update(DealerSalesInfoEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新
            var entity = await _dealersalesinfoRepository.GetAsync(input.Id);
            input.MapTo(entity);

            // ObjectMapper.Map(input, entity);
            await _dealersalesinfoRepository.UpdateAsync(entity);
        }
    }
}

