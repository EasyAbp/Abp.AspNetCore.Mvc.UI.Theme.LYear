using LYearUiSample.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LYearUiSample.Permissions
{
    public class LYearUiSamplePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LYearUiSamplePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(LYearUiSamplePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LYearUiSampleResource>(name);
        }
    }
}
