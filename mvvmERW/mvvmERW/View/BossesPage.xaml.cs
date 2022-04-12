using MVVMSample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvmERW.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BossesPage : ContentPage
    {
        public BossesViewModel ViewModel { get; private set; }
        public BossesPage(BossesViewModel bossesViewModel)
        {
            ViewModel = bossesViewModel;
            this.BindingContext = ViewModel;
        }
    }
}