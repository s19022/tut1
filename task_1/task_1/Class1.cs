using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    public class Person
    {
        private string _firstName;
      

        public string FirstName  //property
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        //auto property
        public string LastName
        {
            get; set;
        }
    }
}
