using Mc.ApplicationContracts.CookApplication;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MC.Presentations.MVCCore.Areas.Admin.Models
{
    public class Editedclass
    {
        public EditCookes editcook { get; set; }
        public List<SelectListItem> selectlist { get; set; }
    }
}
