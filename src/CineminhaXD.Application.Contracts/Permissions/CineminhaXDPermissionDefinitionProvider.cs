using CineminhaXD.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CineminhaXD.Permissions;

public class CineminhaXDPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CineminhaXDPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CineminhaXDPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CineminhaXDResource>(name);
    }
}
