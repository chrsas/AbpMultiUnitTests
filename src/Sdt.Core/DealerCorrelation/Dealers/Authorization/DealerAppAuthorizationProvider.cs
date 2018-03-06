using System.Linq;
using Abp.Authorization;
using Abp.Localization;
using Sdt.Authorization;

namespace Sdt.DealerCorrelation.Dealers.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="DealerAppPermissions"/> for all permission names.
    /// </summary>
    public class DealerAppAuthorizationProvider : AuthorizationProvider
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //在这里配置了Dealer 的权限。
            var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

            var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration)
                            ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

            var dealer = administration.CreateChildPermission(DealerAppPermissions.Dealer, L("Dealer"));
            dealer.CreateChildPermission(DealerAppPermissions.Dealer_CreateDealer, L("CreateDealer"));
            dealer.CreateChildPermission(DealerAppPermissions.Dealer_EditDealer, L("EditDealer"));
            dealer.CreateChildPermission(DealerAppPermissions.Dealer_DeleteDealer, L("DeleteDealer"));
            dealer.CreateChildPermission(DealerAppPermissions.Dealer_BatchDeleteDealers, L("BatchDeleteDealers"));

        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, SdtConsts.LocalizationSourceName);
        }
    }

}
