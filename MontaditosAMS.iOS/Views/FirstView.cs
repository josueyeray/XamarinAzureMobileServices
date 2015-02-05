using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;
using CoreGraphics;
using Foundation;
using Microsoft.WindowsAzure.MobileServices;
using ObjCRuntime;
using UIKit;

namespace MontaditosAMS.iOS.Views
{
    [Register("FirstView")]
    public class FirstView : MvxTableViewController
    {
        public override void ViewDidLoad()
        {
            CurrentPlatform.Init();
            base.ViewDidLoad();
            TableView.BackgroundColor = UIColor.White;
            TableView.SeparatorColor = UIColor.White;
            Title = "MONTADITOS";
			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
            {
               EdgesForExtendedLayout = UIRectEdge.None;
            }
            // TableView
            var source = new MvxStandardTableViewSource(TableView, "TitleText Name");
            TableView.Source = source;

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(source).To(vm => vm.Montaditos);
            set.Apply();
        }
    }
}