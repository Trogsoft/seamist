using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Trogsoft.SeaMist.Core;

namespace Trogsoft.SeaMist.Admin.Areas.SeaMist
{
    [Authorize]
    public class _SeaMistModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
