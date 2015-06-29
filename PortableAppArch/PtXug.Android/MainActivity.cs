using System;
using IOToolkit.Android.DumbBinding;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Helpers;
using Microsoft.Practices.ServiceLocation;
using ViewModel;

namespace PtXug.Android
{
    [Activity(Label = "PtXug.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            DependencyInjectorConfigurator.Register(this);
           var  vm = ServiceLocator.Current.GetInstance<AppViewModel>();
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var but = FindViewById<Button>(Resource.Id.MyButton);
            var text = FindViewById<TextView>(Resource.Id.toastText);

            but.SetCommand("Click", vm.ShowToastCommand as RelayCommand);
            vm.CreateBinding(v => v.CurrentToast).BindTo(text);
        }
    }
}

