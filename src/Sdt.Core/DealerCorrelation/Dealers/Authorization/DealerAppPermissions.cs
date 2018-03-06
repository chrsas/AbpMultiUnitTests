namespace Sdt.DealerCorrelation.Dealers.Authorization
{
    /// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="DealerAppAuthorizationProvider"/>中对权限的定义.
    /// </summary>
    public static class DealerAppPermissions
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION

        /// <summary>
        /// Dealer管理权限_自带查询授权
        /// </summary>
        public const string Dealer = "Pages.Dealer";

        /// <summary>
        /// Dealer创建权限
        /// </summary>
        public const string Dealer_CreateDealer = "Pages.Dealer.CreateDealer";
        /// <summary>
        /// Dealer修改权限
        /// </summary>
        public const string Dealer_EditDealer = "Pages.Dealer.EditDealer";
        /// <summary>
        /// Dealer删除权限
        /// </summary>
        public const string Dealer_DeleteDealer = "Pages.Dealer.DeleteDealer";

        /// <summary>
        /// Dealer批量删除权限
        /// </summary>
        public const string Dealer_BatchDeleteDealers = "Pages.Dealer.BatchDeleteDealers";

    }

}

