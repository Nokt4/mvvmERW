using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace mvvmERW.ViewModel
{
    internal class BossesViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        BossesListViewModel BossesLVM;

        public Bosses Bosses { get; private set; }

        public BossesViewModel() => Bosses = new Bosses();

        public BossesListViewModel ListViewModel
        {
            get { return BossesLVM; }
            set
            {
                if (bossesLVM != value)
                {
                    bossesLVM = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }
        public string Name
        {
            get { return Bosses.Name; }
            set
            {
                if (Bosses.Name != value)
                {
                    Bosses.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Group
        {
            get { return Bosses.Group; }
            set
            {
                if (Bosses.Group != value)
                {
                    Bosses.Group = value;
                    OnPropertyChanged("Group");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim())) ||
                    (!string.IsNullOrEmpty(Group.Trim())));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
