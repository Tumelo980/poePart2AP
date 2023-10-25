using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace APPrST10106976.P1.Areas.Identity.Pages.Account
{
   
    public class Good_DonationsModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime DonationDate { get; set; }
        [Required]
        public int Num_Item { get; set; }
        public string? Description { get; set; }
        public bool Anonymous { get; set; }
    }

    public enum Eroles
    {
        Defalut = 0,
        Clothes = 1,
        Foods = 2,

    }
}
