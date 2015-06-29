using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Model;

namespace PtXug.Android.Model
{
    public class AndroidToastNotificationService : IToastNotificationService
    {
        private readonly Context _ctx;

        public AndroidToastNotificationService(Context ctx)
        {
            _ctx = ctx;
        }

        public void ShowToast(string s)
        {
            Toast.MakeText(_ctx, s, ToastLength.Short).Show();
        }
    }
}