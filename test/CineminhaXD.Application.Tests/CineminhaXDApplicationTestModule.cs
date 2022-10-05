using Volo.Abp.Modularity;

namespace CineminhaXD;

[DependsOn(
    typeof(CineminhaXDApplicationModule),
    typeof(CineminhaXDDomainTestModule)
    )]
public class CineminhaXDApplicationTestModule : AbpModule
{

}
