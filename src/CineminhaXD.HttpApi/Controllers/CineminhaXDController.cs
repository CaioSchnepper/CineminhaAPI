using CineminhaXD.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CineminhaXD.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CineminhaXDController : AbpControllerBase
{
    protected CineminhaXDController()
    {
        LocalizationResource = typeof(CineminhaXDResource);
    }
}
