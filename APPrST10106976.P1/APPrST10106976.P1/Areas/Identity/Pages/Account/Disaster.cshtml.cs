using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace APPrST10106976.P1.Areas.Identity.Pages.Account
{
    public class DisasterModel : PageModel
    { 
        public void OnGet()
        { }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public List<string>? RequiredAidTypes { get; set; }
    }
    public enum Er
    {
        Defalut = 0,
        Clothes = 1,
        Foods = 2,
        Water = 3,
        Etc = 4,
    }
}

