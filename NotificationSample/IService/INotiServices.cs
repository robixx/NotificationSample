using NotificationSample.Models;

namespace NotificationSample.IService
{
    public interface INotiServices
    {
        List<Noti> GetNotifications(int nToUserId, bool bIsGetOnlyUnread);
    }
}
