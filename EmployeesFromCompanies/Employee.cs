using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EmployeesFromCompanies
{
    public class Employee : INotifyPropertyChanged
    {

        private string fullname;
        private string address;
        private string number;
        private string position;
        private string work_place;

        public int Id { get; set; }

        public string FullName
        {
            get { return fullname; }
            set
            {
                fullname = value;
                OnPropertyChanged("FullName");
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }
        public string PhoneNumber
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        public string Position
        {
            get { return position; }
            set
            {
                position = value;
                OnPropertyChanged("Position");
            }
        }
        public string WorkPlace
        {
            get { return work_place; }
            set
            {
                work_place = value;
                OnPropertyChanged("WorkPlace");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
