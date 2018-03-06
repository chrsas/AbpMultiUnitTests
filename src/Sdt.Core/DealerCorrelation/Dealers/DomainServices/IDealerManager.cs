using Abp.Domain.Services;

namespace Sdt.DealerCorrelation.Dealers.DomainServices
{
    public interface IDealerManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        /// </summary>
        void InitDealer();

    }
}
