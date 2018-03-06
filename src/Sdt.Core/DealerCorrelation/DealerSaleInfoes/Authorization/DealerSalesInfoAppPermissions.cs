namespace Sdt.DealerCorrelation.DealerSaleInfoes.Authorization {
    /// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="DealerSalesInfoAppAuthorizationProvider"/>中对权限的定义.
    /// </summary>
    public static class DealerSalesInfoAppPermissions {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION

        /// <summary>
        /// DealerSalesInfo管理权限_自带查询授权
        /// </summary>
        public const string DealerSalesInfo = "Pages.DealerSalesInfo";

        /// <summary>
        /// DealerSalesInfo创建权限
        /// </summary>
        public const string DealerSalesInfo_CreateDealerSalesInfo = "Pages.DealerSalesInfo.CreateDealerSalesInfo";
        /// <summary>
        /// DealerSalesInfo修改权限
        /// </summary>
        public const string DealerSalesInfo_EditDealerSalesInfo = "Pages.DealerSalesInfo.EditDealerSalesInfo";
        /// <summary>
        /// DealerSalesInfo删除权限
        /// </summary>
        public const string DealerSalesInfo_DeleteDealerSalesInfo = "Pages.DealerSalesInfo.DeleteDealerSalesInfo";

        /// <summary>
        /// DealerSalesInfo批量删除权限
        /// </summary>
        public const string DealerSalesInfo_BatchDeleteDealerSalesInfos = "Pages.DealerSalesInfo.BatchDeleteDealerSalesInfos";

    }

}

