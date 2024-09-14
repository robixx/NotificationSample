using Microsoft.AspNetCore.Mvc;
using NotificationSample.IService;
using NotificationSample.Models;

namespace NotificationSample.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly INotiServices _notiservices;

        public NotificationsController(INotiServices notiservices)
        {
            _notiservices = notiservices;
        }
        [HttpGet]
        public IActionResult AllNotifications()
        {
            return View();
        }


        [HttpGet]
        public JsonResult GetNotifications(bool bIsGetOnlyUnread = false)
        {
            int nToUserId = 2;
            List<Noti> _oNotifications = new List<Noti>();
            _oNotifications = _notiservices.GetNotifications(nToUserId, bIsGetOnlyUnread);
            return Json(_oNotifications);
        }
    }
}
