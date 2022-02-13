using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceW1_3
{
   public class Person
    {
        private int age;
        private string name;
        private string pcn; // storing the pcn as a string in case it starts with 0
        private int yearsAtSchool;

        protected int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        protected string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        protected string Pcn
        {
            get { return this.pcn; }
            set { this.pcn = value; }
        }

        protected int YearsAtSchool
        {
            get { return this.yearsAtSchool; }
            set { this.yearsAtSchool = value; }
        }

        public Person(string name, int age, string pcn, int yearsAtSchool)
        {
            this.name = name;
            this.age = age;
            this.pcn = pcn;
            this.yearsAtSchool = yearsAtSchool;
        }

        public void CelebrateBirthday()
        {
            Age++;
        }

        public virtual void StartAnotherSchoolyear()
        {
            // increase yearsatschool by one and every 3 years add 10% to teacher salary

            this.yearsAtSchool++;
        }

        public override string ToString()
        {
            string info = $"Person: {this.Name} (PCN: {this.Pcn}) is {this.Age} year(s) old with {this.YearsAtSchool} years at school";
            return info;
        }

        public virtual string GetPcn()
        {
            return this.pcn;
        }
    }
}
