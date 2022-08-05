using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Sitecore.DependencyInjection;
using SitecoreCDP.Foundation.Integrations.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreCDP.Foundation.Integrations
{
    public class ServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.Replace(ServiceDescriptor.Transient(typeof(BoxeverServiceController),
                typeof(BoxeverServiceController)));

            serviceCollection.Replace(ServiceDescriptor.Transient(typeof(IdentityServiceController),
                typeof(IdentityServiceController)));
        }
    }
}