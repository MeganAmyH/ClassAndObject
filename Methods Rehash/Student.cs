using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Rehash
{
    class Student : Person //pulls the properties and methods of Person into the Student Class
    {

        public string Bootcamp { get; set; }
        public int Year { get; set; }

        public override string SayHello() //changes the method for this class
        {
            string result = base.SayHello() + ". I am a Student";
            return result;
            //return base.SayHello() + ". I am a Student"; 
            //Above is a 1 line version
            //Can also turn it into:
            //string result1 = "Hello, my name is" + LastName + ", " + FirstName + ". I am a Student";
        }

    }
}
