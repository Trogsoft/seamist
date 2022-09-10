using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trogsoft.SeaMist.Core;

namespace Trogsoft.SeaMist.Admin
{
    [Authorize]
    public class SeaMistPageModel : PageModel
    {
        public SeaMistPageModel(IOptions<SeaMistConfiguration> smc)
        {
            this.SeaMistConfiguration = smc.Value;
        }

        public SeaMistConfiguration SeaMistConfiguration { get; }
    }
}
