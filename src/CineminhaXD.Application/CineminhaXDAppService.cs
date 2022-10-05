using System;
using System.Collections.Generic;
using System.Text;
using CineminhaXD.Localization;
using Volo.Abp.Application.Services;

namespace CineminhaXD;

/* Inherit your application services from this class.
 */
public abstract class CineminhaXDAppService : ApplicationService
{
    protected CineminhaXDAppService()
    {
        LocalizationResource = typeof(CineminhaXDResource);
    }
}
