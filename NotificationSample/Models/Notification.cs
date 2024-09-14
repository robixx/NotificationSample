using System.ComponentModel.DataAnnotations;

namespace NotificationSample.Models
{
    public class Notification
    {
        [Key]
        public int NotiId { get; set; } = 0;
        public int FromUserId { get; set; } = 0;
        public int ToUserId { get; set; } = 0;
        public string NotiHeader { get; set; } = "";
        public string NotiBody { get; set; } = "";
        public bool IsRead { get; set; } = false;
        public string Url { get; set; } = "";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
