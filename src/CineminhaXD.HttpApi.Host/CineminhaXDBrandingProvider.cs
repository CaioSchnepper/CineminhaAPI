using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CineminhaXD;

[Dependency(ReplaceServices = true)]
public class CineminhaXDBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CineminhaXD";
}
