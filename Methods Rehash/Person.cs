using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Rehash
{
    class Person
    {
        private string v1;
        private string v2;

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DOB { get; set; }

        public Person()
        {

        }

        public Person(string lname, string fname, DateTime dob)
        {
            LastName = lname;
            FirstName = fname;
            DOB = dob;
        }

        public Person(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        //public string SayHello()
        //{
            //return "Hello, my name is " + LastName + ", " + FirstName;
        //}
        public virtual string SayHello()  //adding virtual means that any class can change the definition of SayHello
        {
            return "Hello, my name is " + LastName + ", " + FirstName;
        }
    }
}
