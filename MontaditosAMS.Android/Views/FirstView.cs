using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using Microsoft.WindowsAzure.MobileServices;

namespace MontaditosAMS.Android.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            CurrentPlatform.Init();
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}