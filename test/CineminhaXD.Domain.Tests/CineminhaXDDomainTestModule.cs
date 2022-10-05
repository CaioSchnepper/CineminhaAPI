using CineminhaXD.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CineminhaXD;

[DependsOn(
    typeof(CineminhaXDEntityFrameworkCoreTestModule)
    )]
public class CineminhaXDDomainTestModule : AbpModule
{

}
