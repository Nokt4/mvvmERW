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
    public partial class BossesListPage : ContentPage
    {
        public BossesListPage()
        {
            InitializeComponent();
            BindingContext = new BossesListViewModel { Navigation = this.Navigation };
        }
    }
}