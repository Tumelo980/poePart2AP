using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace APPrST10106976.P1.Areas.Identity.Pages.Account
{
    public class DonationsModel
    {
       
        public int Id { get; set; }
        [Required]
        public DateTime DonationDate { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public bool Anonymous { get; set; }
    }
}