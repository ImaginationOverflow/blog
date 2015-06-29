using System;
using System.Collections.Generic;
using System.Text;
using Android.Content;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Model;
using PtXug.Android.Model;
using ViewModel;

namespace PtXug
{
    public static class DependencyInjectorConfigurator
    {
        public static void Register(Context ctx)
        {
            SimpleIoc.Default.Reset();
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register(() => ctx);
            SimpleIoc.Default.Register<IToastNotificationService, AndroidToastNotificationService>();
            SimpleIoc.Default.Register<AppViewModel>();
        }
    }
}
