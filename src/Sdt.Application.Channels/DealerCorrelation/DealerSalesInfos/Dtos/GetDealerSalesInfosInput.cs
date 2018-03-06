using System;
using Abp.Runtime.Validation;
using Sdt.Dto;

namespace Sdt.Application.Channels.DealerCorrelation.DealerSalesInfos.Dtos
{
    public class GetDealerSalesInfosInput : PagedAndSortedInputDto, IShouldNormalize
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        /// <summary>
        /// 模糊搜索使用的关键字, 此处针对经销商编号和名称
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public DcsMasterDataStatus?[] DealerStatus { get; set; }

        /// <summary>
        /// 大区
        /// </summary>
        public int? MarketingDepartmentId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime?[] DealerCreationTime { get; set; }

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
