using System.Linq;
using Abp.Authorization;
using Abp.Localization;
using Sdt.Authorization;

namespace Sdt.DealerCorrelation.DealerSaleInfoes.Authorization {
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="DealerSalesInfoAppPermissions"/> for all permission names.
    /// </summary>
    public class DealerSalesInfoAppAuthorizationProvider : AuthorizationProvider {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        public override void SetPermissions(IPermissionDefinitionContext context) {
            //在这里配置了DealerSalesInfo 的权限。
            var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

            var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration)
                            ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

            var dealersalesinfo = administration.CreateChildPermission(DealerSalesInfoAppPermissions.DealerSalesInfo, L("DealerSalesInfo"));
            dealersalesinfo.CreateChildPermission(DealerSalesInfoAppPermissions.DealerSalesInfo_CreateDealerSalesInfo, L("CreateDealerSalesInfo"));
            dealersalesinfo.CreateChildPermission(DealerSalesInfoAppPermissions.DealerSalesInfo_EditDealerSalesInfo, L("EditDealerSalesInfo"));
            dealersalesinfo.CreateChildPermission(DealerSalesInfoAppPermissions.DealerSalesInfo_DeleteDealerSalesInfo, L("DeleteDealerSalesInfo"));
            dealersalesinfo.CreateChildPermission(DealerSalesInfoAppPermissions.DealerSalesInfo_BatchDeleteDealerSalesInfos, L("BatchDeleteDealerSalesInfos"));

        }

        private static ILocalizableString L(string name) {
            return new LocalizableString(name, SdtConsts.LocalizationSourceName);
        }
    }

}
