using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace mvvmERW.ViewModel
{
    internal class BossesListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<BossesViewModel> Bosses { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CreateBossesCommand { protected set; get; }
        public ICommand DeleteBossesCommand { protected set; get; }
        public ICommand BossesCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }

        BossesViewModel selectedBosses;

        public INavigation Navigation { get; set; }

        public BossesListViewModel()
        {
            Bosses = new ObservableCollection<BossesViewModel>();
            CreateBossesCommand = new Command(CreateBosses);
            DeleteBossesCommand = new Command(DeleteBosses);
            SaveSBossesCommand = new Command(SaveBosses);
            BackCommand = new Command(Back);
        }

        public BossesViewModel SelectedBosses
        {
            get { return selectedBosses; }
            set
            {
                if (selectedBosses != value)
                {
                    BossesViewModel tempBosses = value;
                    selectedBosses = null;
                    OnPropertyChanged("SelectedBosses");
                    Navigation.PushAsync(new BossesPage(tempBosses));
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private void CreateBosses()
        {
            Navigation.PushAsync(new BossesPage(new BossesViewModel() { ListViewModel = this }));
        }
        private void Back()
        {
            Navigation.PopAsync();
        }
        private void SaveBosses(object bossesObj)
        {
            BossesViewModel bosses = bossesObj as BossesViewModel;
            if (bosses != null && bosses.IsValid && !Bosses.Contains(bosses))
            {
                Bosses.Add(Bosses);
                Back();
            }
        }
        private void DeleteBosses(object BossesObject)
        {
            BossesViewModel bosses = BossesObject as BossesViewModel;
            if (bosses != null)
            {
                bosses.Remove(bosses);
                Back();
            }
        }
    }
}
