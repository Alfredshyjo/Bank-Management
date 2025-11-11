using BankApp.Entity.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Entity.Models
{
    [Table("tblCustomerApplication")]

    public class CustomerApplication : BaseEntity
    {
        [Key]
        public int ApplicationID { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }

        [MaxLength(50)]
        public string? Occupation { get; set; }

        [Required]
        [MaxLength(10)]
        public string MobileNumber { get; set; }

        [Required]
        [MaxLength(12)]
        public string AadharNumber { get; set; }

        [Required]
        [MaxLength(10)]
        public string PAN { get; set; }

        public string? CustomerImageURL { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        [Required]
        public int AccountTypeID { get; set; }

        public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;

        public string? ApprovedByUserID { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? RejectionReason { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.Now;

    }
}
