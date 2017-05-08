using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_InotifyPropertyChanged
{
    public class Person
    {

        private string _firstName;
        private string _lastName;
        private string _fullName;

        public string FullName
        {
            get { return _fullName = _firstName +" " + _lastName; }
            set { _fullName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }


        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

    }
}
