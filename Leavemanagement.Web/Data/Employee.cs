using Microsoft.AspNetCore.Identity;

namespace Leavemanagement.Web.Data
{
    public class Employee : IdentityUser
    {
        /// <summary>
        /// 
        /// </summary>
        public string? Firstname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Lastname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? TaxId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateJoined { get; set; }

    }
}
