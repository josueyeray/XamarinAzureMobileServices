using MontaditosAMS.Core.Services;
using MontaditosAMS.Core.ViewModels;
using MontaditosForms.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MontaditosForms.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = VMLocator.Resolve<FirstViewModel>();
        }
    }
}
