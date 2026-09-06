using System;

namespace BamawWebApi.Models
{
    public enum AccountType
    {
        Admin = 1,
        User = 2
    }
	public class Account
	{
		public int Id { get; set; }

		public string Mobile { get; set; } = string.Empty;

		public AccountType Type { get; set; }

		public string? VerifyCode { get; set; }

		public DateTime? ExpirationVerifyCode { get; set; }

		public DateTime? UpdatedVerifyCode { get; set; }

		public bool IsVerified { get; set; }

	}
}
