using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceW1_3
{
  
    public class Student : Person
    {
        private int nrOfECs;

        protected int NrOfECs
        {
            get { return this.nrOfECs; }
            set { this.nrOfECs = value; }
        }

        public Student(string name, int age, string pcn, int yearsAtSchool) : base(name, age, pcn, yearsAtSchool)
        {
            this.Name = name;
            this.Age = age;
            this.Pcn = pcn;
            this.YearsAtSchool = yearsAtSchool;
        }

        public Student(string name, int age, string pcn, int yearsAtSchool, int nrOfECs) : base(name, age, pcn, yearsAtSchool)
        {
            this.Name = name;
            this.Age = age;
            this.Pcn = pcn;
            this.YearsAtSchool = yearsAtSchool;
            this.nrOfECs = nrOfECs;
        }

        public void AddECs(int n)
        {
            nrOfECs += n;
        }

        public override string ToString()
        {
            string info = "Student";

            info += $" - Name:{Name} (PCN: {Pcn}) is {Age} year(s) old with {YearsAtSchool} years at school and {NrOfECs} EC";

            return info;
        }

        public override string GetPcn()
        {
            return base.GetPcn();
        }

       

    }
}
