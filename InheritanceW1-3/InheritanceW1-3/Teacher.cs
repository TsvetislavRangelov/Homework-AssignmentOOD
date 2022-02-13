using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceW1_3
{
   public class Teacher : Person
    {
        private JobPosition position;
        private double salary;
        

        protected JobPosition Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        protected double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public Teacher(string name, int age, string pcn, int yearsAtSchool) : base(name, age, pcn, yearsAtSchool)
        {
            this.Name = name;
            this.Age = age;
            this.Pcn = pcn;
            this.YearsAtSchool = yearsAtSchool;
            this.salary = RandomSalary();
            this.position = JobPosition.JUNIOR_TEACHER;
        }

        public Teacher(string name, int age, string pcn, int yearsAtSchool, double salary) : base(name, age, pcn, yearsAtSchool)
        {
            this.Name = name;
            this.Age = age;
            this.Pcn = pcn;
            this.YearsAtSchool = yearsAtSchool;
            this.salary = salary;
            this.position = JobPosition.JUNIOR_TEACHER; // starting position for any teacher-object. 
        }

        public void MakePromotion()
        {
            switch (position)
            {
                case JobPosition.JUNIOR_TEACHER:
                    this.position = JobPosition.TEACHER1;
                    break;

                case JobPosition.TEACHER1:
                    this.position = JobPosition.TEACHER2;
                    break;

                case JobPosition.TEACHER2:
                    this.position = JobPosition.TEACHER3;
                    break;

                case JobPosition.TEACHER3:
                    this.position = JobPosition.COORDINATOR;
                    break;

                case JobPosition.COORDINATOR:
                    this.position = JobPosition.DIRECTOR;
                    break;

                case JobPosition.DIRECTOR:
                    this.position = JobPosition.DIRECTOR;
                    break;

                default:
                    this.position = JobPosition.JUNIOR_TEACHER;
                    break;
            } 
        }

        public override void StartAnotherSchoolyear()
        {
            // incrementing the years from base class and checking if the new number is divisible by 3
            // if it is, we add 10% (base salary * 1.1(10%)) and we thus get the new salary.
            base.StartAnotherSchoolyear();

            if(YearsAtSchool % 3 == 0)
            {
                salary *= 1.1;
                double roundedSalary = Math.Round(salary);
                salary = roundedSalary;
            }
        }

        public override string ToString()
        {
            string info = "Teacher";

            info += $" - Name:{Name} (PCN: {Pcn}) is {Age} year(s) old - {YearsAtSchool} years at school - Salary: {Salary} - Position: {Position}";

            return info;
        }

        public override string GetPcn()
        {
            return base.GetPcn();
        }

        private int RandomSalary()
        {
            Random randSalary = new Random();

            int salary = randSalary.Next(1600, 4000);
            return salary;
        }


    }
}
