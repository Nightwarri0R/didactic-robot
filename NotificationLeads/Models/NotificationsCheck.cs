using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationLeads.Models
{
    public class NotificationsCheck
    {
        [Display(Name = "Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
           ErrorMessage = "Invalid email format")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your email address")]
        public string EmailAddress { get; set; }
        [Required]
        public string LeadNotification { get; set; }
        public string[] LeadNotifications = new[] { "Lead with full personal data", "Notification of lead", "No notifications" };


        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your phone number")]
        [StringLength(maximumLength: 11)]
        public int PhoneNumber { get; set; }
        [Required]
        public string PhoneCheck { get; set; }
        public string[] PhoneChecks = new[] { "Yes", "No", };



        [Required(AllowEmptyStrings = false, ErrorMessage = "Webhook cannont be empty")]

        public int WebHook1 { get; set; }



        public NotificationsCheck(string emailAddress, string leadNotifications, int phoneNumber, string phoneCheck, int webHook1)
        {
            this.EmailAddress = emailAddress;
            this.LeadNotification = leadNotifications;
            this.PhoneNumber = phoneNumber;
            this.PhoneCheck = phoneCheck;
            this.WebHook1 = webHook1;
        }
    }
}
