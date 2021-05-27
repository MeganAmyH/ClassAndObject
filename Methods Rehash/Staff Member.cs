using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Rehash
{
    class Staff_Member : Person
    {

        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string SayHello()
        {
            return base.SayHello() + $"I am a staff member working in {Department} Team";
        }
    }
}
