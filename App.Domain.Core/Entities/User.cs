using App.Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Entities
{
    public class User
    {
        [Display(Name = "شناسه")]
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [Required]
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [Required]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name = "تاریخ ثبت نام")]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "تاریخ تولد")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [RegularExpression(@"^\d{10,}$", ErrorMessage = "Invalid Id Number.")]
        [Display(Name = "کد ملی")]
        public string IdentificationNumber { get; set; }
        [Required]
        [RegularExpression(@"^0\d{10}$", ErrorMessage = "Invalid Phone Number.")]
        [Display(Name = "شماره موبایل")]
        public string PhoneNumber { get; set; }
        [Display(Name = "نوع عضویت")]
        public Subscription SubscriptionType { get; set; }
        [Display(Name = "جنسیت")]
        public Gender Gender { get; set; }

    }
}
