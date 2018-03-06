using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Runtime.Session;
using Sdt.Application.Channels.DealerCorrelation.DealerSalesInfos;
using Sdt.Application.Channels.DealerCorrelation.DealerSalesInfos.Dtos;
using Sdt.DealerCorrelation.DealerSaleInfoes;
using Sdt.Users;
using Shouldly;
using Xunit;

namespace Sdt.Channels.Tests.DealerCorrelation
{
    public class DealerSalesInfoAppService_Tests : ChannelsTestBase
    {
        private readonly IDealerSalesInfoAppService _dealerSalesInfoAppServices;

        public DealerSalesInfoAppService_Tests()
        {
            _dealerSalesInfoAppServices = Resolve<IDealerSalesInfoAppService>();
        }

        [Fact]
        public async Task GetById_Test()
        {
            CreateTestData();
            // Act
            var output = await _dealerSalesInfoAppServices.GetById(new EntityDto { Id = 1 });

            // Assert
            output.ShouldNotBeNull();
        }

        protected void CreateTestData()
        {
            UsingBusinessDbContext(context =>
            {
                context.DealerSalesInfoes.AddRange(
                    new DealerSalesInfo
                    {
                        Address = "南京市秦淮区大明路178号",
                        BranchId = 6,
                        DealerId = 79,
                        Email = "xxx@163.com",
                        ErpServiceCode = "15613",
                        Fax = "002552635617",
                        ZipCode = "210012",
                        Id = 1
                    });
            });
        }
    }
}
