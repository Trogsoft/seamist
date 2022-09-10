using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Trogsoft.SeaMist.Admin;

namespace Trogsoft.SeaMist.Core.MyFeature.Pages
{
    [Authorize]
    public class Page1Model : SeaMistPageModel
    {
        public Page1Model(IOptions<SeaMistConfiguration> smc) : base(smc)
        {
        }

        public void OnGet()
        {

        }
    }
}