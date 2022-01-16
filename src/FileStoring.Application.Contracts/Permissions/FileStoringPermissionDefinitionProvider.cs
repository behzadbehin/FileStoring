using FileStoring.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FileStoring.Permissions
{
    public class FileStoringPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FileStoringPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(FileStoringPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FileStoringResource>(name);
        }
    }
}
