using Mc.ApplicationContracts.CookApplication;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MC.Presentations.MVCCore.Areas.Admin.Models
{
    public class CookesDteails
    {
        public CreateCookes createcookes { get; set; }
        public List<SelectListItem> listed { get; set; }
    }
}
