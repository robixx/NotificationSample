using NotificationSample.Data;
using NotificationSample.IService;
using NotificationSample.Models;

namespace NotificationSample.Services
{
    public class NotiServices : INotiServices
    {

        private readonly DataBaseConnection _connection;

        public NotiServices(DataBaseConnection connection)
        {

            _connection = connection;
        }



        public List<Noti> GetNotifications(int nToUserId, bool bIsGetOnlyUnread)
        {
            try
            {
                List<Noti> _oNotifications = new List<Noti>();
                var data = from n in _connection.Notification
                           join o in _connection.Users on n.FromUserId equals o.UserId
                           join u in _connection.Users on n.ToUserId equals u.UserId
                           select new Noti
                           {
                               NotiId = n.NotiId,
                               FromUserId = n.FromUserId,
                               ToUserId = n.ToUserId,
                               NotiHeader = n.NotiHeader,
                               NotiBody = n.NotiBody,
                               IsRead = n.IsRead,
                               Url = n.Url,
                               CreatedDate = n.CreatedDate,
                               FromUserName = o.UserName,
                               ToUserName = u.UserName
                           };
                if (bIsGetOnlyUnread)
                {
                    data = data.Where(n => !n.IsRead);
                }


                return data.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
