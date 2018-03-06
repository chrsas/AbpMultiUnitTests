using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Sdt.Application.Channels.DealerCorrelation.DealerSalesInfos.Dtos;

namespace Sdt.Application.Channels.DealerCorrelation.DealerSalesInfos
{
    /// <summary>
    /// DealerSalesInfo应用层服务的接口方法
    /// </summary>
    public interface IDealerSalesInfoAppService : IApplicationService
    {
        /// <summary>
        /// 获取DealerSalesInfo的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<DealerSalesInfoListDto>> GetPaged(GetDealerSalesInfosInput input);

        /// <summary>
        /// 通过指定id获取DealerSalesInfoListDto信息
        /// </summary>
        Task<DealerSalesInfoListDto> GetById(EntityDto<int> input);


        /// <summary>
        /// 修改DealerSalesInfo的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Update(DealerSalesInfoEditDto input);
    }
}
