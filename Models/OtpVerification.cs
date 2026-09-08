using System.ComponentModel.DataAnnotations;
using BamawWebApi.Models.Listing;

namespace BamawWebApi.Models
{
    public class OtpVerification
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string MobileNumber { get; set; } = null!;
        [MaxLength(10)]
        public string Code { get; set; } = null!;
        public DateTime ExpiresAt { get; set; }
        public bool IsUsed { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}