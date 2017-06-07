using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public enum Genders
        {
            Male,
            Female
        };

        private String name;
        private DateTime birthDate;
        private Genders gender;

        public String Name
        {
            get => name;
            set => name = value;
        }

        public DateTime BirthDate
        {
            get => birthDate;
            set => birthDate = value;
        }

        public Genders Gender
        {
            get => gender;
            set => gender = value;
        }

        protected Person(String name, DateTime time, Genders gender)
        {
            this.name = name;
            birthDate = time;
            this.gender = gender;
        }

        public override string ToString()
        {
            String result = "Name:" + name + ", Birth Date:" + birthDate.ToString("yyyy-MM-dd") + ", Gender:" + gender;
            return result;
        }

    }

    class Employee : Person, ICloneable
    {
        private int salary;
        private String profession;
        private Room room;

        public Room Room
        {
            get => room;
            set => room = value;
        }

        Employee(String name, DateTime time, Genders gender,int salary, String profession) : base (name, time, gender)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public override string ToString()
        {
            String result = base.ToString() + ", Salary:" + salary + "$," + " Profession:" + profession + ", Room number:" + room.RoomNumber;
            return result;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.RoomNumber);
            return newEmployee;
        }

        /*public object Clone()
        {
            return this.MemberwiseClone();
        }*/

        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Kovacs János", new DateTime(1974, 2, 9), Genders.Male, 9000, "Programmer");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }

    class Room
    {
        private int roomNumber;

        public int RoomNumber
        {
            get => roomNumber;
            set => roomNumber = value;
        }

        public Room(int number)
        {
            roomNumber = number;
        }
    }
}
