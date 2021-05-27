using System;

namespace Methods_Rehash
{
    class Program
    {
        static void Main(string[] args)
        {
            int call = sum(2, 3);
            Console.WriteLine(call);

            Person p = new Person();
            p.LastName = "Ngoudjou";
            p.FirstName = "Albert";
            Person m = new Person();
            m.FirstName = "Megan";
            m.LastName = "Heberlein";
            string q = m.SayHello();


            string s = p.SayHello();
            Console.WriteLine(s);
            string w = p.SayHello();
            Console.WriteLine(q);

            Person inst = new Person("Baseley", "Anna");
            string ans = p.SayHello();
            Console.WriteLine(ans);

            Person pt = new Person()
            {
                FirstName = "Balalal",
                LastName = "Heyo"
            };

            Person[] people = { p, m, pt, inst, };
            Console.WriteLine("List of first names:");

            GetFirstNames(people);

            //student
            Student st = new Student()
            {
                FirstName = "Student1", 
                LastName = "StudentName", 
                Bootcamp = "AHFSBE C#, 2021", 
                Year = 2021
            };
            //Inheritance
            string stname = st.SayHello();
            Console.WriteLine(stname);

            Staff_Member _staff1 = new Staff_Member
            {
                Department = "Learning",
                FirstName = "Albert",
                LastName = "Ngoudjou",
                StartDate = new DateTime(2021, 05, 24) //How to type DateTime, NOT 5/24/2021
            };

            string _fnamestaff = _staff1.SayHello();
            Console.WriteLine(_fnamestaff);
            


        }

        static void GetFirstNames(Person[] listOfPerson)
        {
            foreach (Person p in listOfPerson)
            {
                Console.WriteLine(p.FirstName);
            }
        }


        //This is the defination of the function 
        static int sum(int a, int b) //This is the signature of the method
        {
            int result = a + b;
            return result;
        }
    }
}

    