using System;
using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;
using Sdt.Authorization.Users;
using Sdt.Common;

namespace Sdt.MultiTenancy
{
    public class Tenant : AbpTenant<User>, IRowVersion
    {
        public new const string DefaultTenantName = "2000";
        public const string DefaultName = "安徽奇瑞汽车销售有限公司";
        public const int DefaultId = 6;

        public Tenant()
        {
        }

        public Tenant(string tenancyName, string name, TenantCategory category)
            : base(tenancyName, name)
        {
            Category = category;
        }

        public int? EntNodeTemplateId { get; set; }

        public TenantCategory Category { get; set; }

        [MaxLength(SdtConsts.DefaultRemarkLength)]
        public string Remark { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
