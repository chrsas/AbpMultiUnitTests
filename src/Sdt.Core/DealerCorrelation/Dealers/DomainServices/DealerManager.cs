using System;
using Abp.Domain.Repositories;

namespace Sdt.DealerCorrelation.Dealers.DomainServices
{
    /// <summary>
    /// Dealer领域层的业务管理
    /// </summary>
    public class DealerManager : SdtDomainServiceBase, IDealerManager
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        private readonly IRepository<Dealer, int> _dealerRepository;
        /// <summary>
        /// Dealer的构造方法
        /// </summary>
        public DealerManager(IRepository<Dealer, int> dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        //TODO:编写领域业务代码
        /// <summary>
        ///     初始化
        /// </summary>
        public void InitDealer()
        {
            throw new NotImplementedException();
        }

    }

}
