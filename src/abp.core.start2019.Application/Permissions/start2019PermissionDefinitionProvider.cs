using abp.core.start2019.Localization.start2019;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace abp.core.start2019.Permissions
{
    public class start2019PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(start2019Permissions.GroupName);

            //Define your own permissions here. Examaple:
            //myGroup.AddPermission(start2019Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<start2019Resource>(name);
        }
    }
}
