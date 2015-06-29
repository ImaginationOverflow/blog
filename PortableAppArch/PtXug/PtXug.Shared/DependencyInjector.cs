using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Model;
using PtXug.Model;
using ViewModel;

namespace PtXug
{
    public static class DependencyInjectorConfigurator
    {
        public static void Register()
        {
            SimpleIoc.Default.Reset();
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<IToastNotificationService, WinrtToastNotificationService>();
            SimpleIoc.Default.Register<AppViewModel>();
        }
    }
}
