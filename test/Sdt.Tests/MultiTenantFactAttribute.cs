﻿using Xunit;

namespace Sdt.Tests
{
    public sealed class MultiTenantFactAttribute : FactAttribute
    {
        public MultiTenantFactAttribute()
        {
            if (!SdtConsts.MultiTenancyEnabled)
            {
#pragma warning disable CS0162 // 检测到无法访问的代码
                Skip = "MultiTenancy is disabled.";
#pragma warning restore CS0162 // 检测到无法访问的代码
            }
        }
    }
}
