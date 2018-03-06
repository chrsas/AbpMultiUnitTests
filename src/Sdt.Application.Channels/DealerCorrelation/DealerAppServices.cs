using System.Collections.Generic;
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
using Sdt.Application.Channels.DealerCorrelation.Dtos;
using Sdt.DealerCorrelation;
using Sdt.DealerCorrelation.Dealers.Authorization;
using Sdt.DealerCorrelation.Dealers.DomainServices;

namespace Sdt.Application.Channels.DealerCorrelation
{
    /// <summary>
    /// Dealer应用层服务的接口实现方法
    /// </summary>
    [AbpAuthorize(DealerAppPermissions.Dealer)]
    public class DealerAppService : ChannelsAppServiceBase, IDealerAppService
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        private readonly IRepository<Dealer, int> _dealerRepository;
        private readonly IDealerManager _dealerManager;

        /// <summary>
        /// 构造函数
        /// </summary>
        public DealerAppService(IRepository<Dealer, int> dealerRepository, IDealerManager dealerManager)
        {
            _dealerRepository = dealerRepository;
            _dealerManager = dealerManager;
        }

        /// <summary>
        /// 获取Dealer的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<DealerListDto>> GetPaged(GetDealersInput input)
        {
            var query = _dealerRepository.GetAll()
                .Where(d => d.Type == DcsDealerType.一级经销商)
                .WhereIf(!input.Filter.IsNullOrWhiteSpace(), d => d.Code.Contains(input.Filter) || d.Name.Contains(input.Filter))
                .WhereIf(input.Statuses != null, d => input.Statuses.Contains(d.Status));
            var dealerCount = await query.CountAsync();

            var dealers = await query
                .OrderBy(input.Sorting)
                .PageBy(input)
                .ToListAsync();

            var dealerListDtos = dealers.MapTo<List<DealerListDto>>();

            return new PagedResultDto<DealerListDto>(
                dealerCount,
                dealerListDtos
            );
        }

        /// <summary>
        /// 通过指定id获取DealerListDto信息
        /// </summary>
        public async Task<DealerListDto> GetById(EntityDto<int> input)
        {
            var entity = await _dealerRepository.GetAsync(input.Id);

            return entity.MapTo<DealerListDto>();
        }

        public async Task Update(DealerEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新
            var entity = await _dealerRepository.GetAsync(input.Id);
            input.MapTo(entity);

            // ObjectMapper.Map(input, entity);
            await _dealerRepository.UpdateAsync(entity);
        }

        ///// <summary>
        ///// 导出Dealer为excel表
        ///// </summary>
        ///// <returns></returns>
        //public async Task<FileDto> GetDealersToExcel(){
        //var users = await UserManager.Users.ToListAsync();
        //var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
        //await FillRoleNames(userListDtos);
        //return _userListExcelExporter.ExportToFile(userListDtos);
        //}
    }
}
