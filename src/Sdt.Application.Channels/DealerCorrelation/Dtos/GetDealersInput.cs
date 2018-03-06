using System;
using Abp.Runtime.Validation;
using Sdt.Dto;

namespace Sdt.Application.Channels.DealerCorrelation.Dtos
{
    public class GetDealersInput : PagedAndSortedInputDto, IShouldNormalize
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
        public DcsMasterDataStatus?[] Statuses { get; set; }

        /// <summary>
        /// 大区
        /// </summary>
        public int? MarketingDepartmentId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime?[] CreationTime { get; set; }

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
