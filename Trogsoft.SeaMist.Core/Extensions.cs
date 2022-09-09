using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trogsoft.SeaMist.Core.Abstractions;
using Trogsoft.SeaMist.Core.Services;

namespace Microsoft.AspNetCore.Builder
{
    public static class Extensions
    {

        private static void privateAddSeaMist(IServiceCollection isc, SeaMistConfiguration smc)
        {

            isc.AddRazorPages(rp =>
            {
                rp.Conventions.AuthorizeFolder("/seamist");
            });

            isc.AddTransient<ISeaMistContentService, SeaMistContentService>();

        }

        public static void AddSeaMist(this IServiceCollection isc) => privateAddSeaMist(isc, new SeaMistConfiguration());

        public static void AddSeaMist(this IServiceCollection isc, Action<SeaMistConfiguration> config)
        {

            var smc = new SeaMistConfiguration();
            if (config != null)
            {
                isc.Configure<SeaMistConfiguration>(config);
            }
            else
            {
                isc.Configure<SeaMistConfiguration>(x => { });
            }

            privateAddSeaMist(isc, smc);

        }

        public static void UseSeaMist(this WebApplication? wa)
        {
            wa?.MapRazorPages();
        }

    }

}

