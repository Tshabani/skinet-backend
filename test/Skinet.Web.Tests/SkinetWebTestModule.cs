using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Skinet.EntityFrameworkCore;
using Skinet.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Skinet.Web.Tests
{
    [DependsOn(
        typeof(SkinetWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SkinetWebTestModule : AbpModule
    {
        public SkinetWebTestModule(SkinetEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SkinetWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SkinetWebMvcModule).Assembly);
        }
    }
}