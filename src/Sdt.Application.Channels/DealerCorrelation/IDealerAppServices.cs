using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Sdt.Application.Channels.DealerCorrelation.Dtos;

namespace Sdt.Application.Channels.DealerCorrelation
{
    /// <summary>
    /// Dealer应用层服务的接口方法
    /// </summary>
    public interface IDealerAppService : IApplicationService
    {
        /// <summary>
        /// 获取Dealer的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<DealerListDto>> GetPaged(GetDealersInput input);

        /// <summary>
        /// 通过指定id获取DealerListDto信息
        /// </summary>
        Task<DealerListDto> GetById(EntityDto<int> input);

        ///// <summary>
        ///// 导出Dealer为excel表
        ///// </summary>
        ///// <returns></returns>
        //  Task<FileDto> GetDealersToExcel();

        //todo:缺少Dto的生成GetDealerForEditOutput
        /// <summary>
        /// 添加或者修改Dealer的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Update(DealerEditDto input);
    }
}
