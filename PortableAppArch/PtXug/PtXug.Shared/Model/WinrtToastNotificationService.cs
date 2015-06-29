using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Notifications;
using Model;
using NotificationsExtensions.ToastContent;

namespace PtXug.Model
{
    public class WinrtToastNotificationService : IToastNotificationService
    {
        public void ShowToast(string s)
        {
            var toast = ToastContentFactory.CreateToastImageAndText02();
            toast.TextBodyWrap.Text = s;
            toast.TextHeading.Text = "Windows Toast";
            ToastNotificationManager.CreateToastNotifier().Show(toast.CreateNotification());
        }
    }
}
