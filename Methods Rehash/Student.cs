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
            return base.SayHello() + ". I am a Student";
        }

    }
}
