using Mc.ApplicationContracts.CookesCategory;
using Microsoft.AspNetCore.Mvc;

namespace MC.Presentations.MVCCore.Areas.Admin.Models
{
    public class EditedViewmodel
    {
        [BindProperty]
        public EditCategory editcategory { get; set; }
    }
}
