using Leavemanagement.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace Leavemanagement.Web.Models
{
    public class LeaveAllocationVM 
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Number Of Days")]
        [Range(1,50,ErrorMessage = "Invalid number entered.")]
        [Required]
        public int NumberOfDays { get; set; }

        [Display(Name = "Allocation period")]
        [Required]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }

    }
}