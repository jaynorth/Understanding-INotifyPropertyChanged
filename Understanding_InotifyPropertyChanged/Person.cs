using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_InotifyPropertyChanged
{
    public class Person : INotifyPropertyChanged
    {

        private string _firstName;
        private string _lastName;
        private string _fullName;

        

        public string FullName
        {
            get { return _fullName = _firstName +" " + _lastName; }
            set { _fullName = value;
                OnPropertychanged("FullName");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value;
                OnPropertychanged("LastName");
                OnPropertychanged("FullName");
            }
        }


        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value;
                OnPropertychanged("FirstName");
                OnPropertychanged("FullName");
            }
        }

        private void OnPropertychanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
