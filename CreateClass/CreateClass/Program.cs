using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        protected enum Genders
        {
            Male,
            Female
        };

        protected String name;
        protected DateTime birthDate;
        protected Genders gender;

        public override string ToString()
        {
            String result = "Name:" + name + ", Birth Date:" + birthDate.ToString("yyyy-MM-dd") + ", Gender:" + gender;
            return result;
        }

    }

    class Employee : Person
    {
        private int salary;
        private String profession;
        private Room room;

        public override string ToString()
        {
            String result = base.ToString() + ", Salary:" + salary + "$ ," + " Profession:" + profession + ", Room number:" + room.roomNumber;
            return result;
        }

        static void Main(string[] args)
        {
            Employee person = new Employee()
            {
                name = "Kiss János",
                birthDate = new DateTime(1974, 2, 9),
                gender = Genders.Male,
                salary = 9000,
                profession = "Programmer"
            };
            Room room = new Room(1);
            person.room = room;
            Console.WriteLine(person.ToString());
            Console.ReadKey();
        }
    }

    class Room
    {
        public int roomNumber;

        public Room(int number)
        {
            roomNumber = number;
        }
    }
}
