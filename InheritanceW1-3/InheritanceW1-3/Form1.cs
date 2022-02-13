using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceW1_3
{
    public partial class Form1 : Form
    {

        Administration admin = new Administration();
        public Form1()
        {
            admin.AddTestData();
            InitializeComponent();
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            string pcn = tbxPCN.Text;
            string name = tbxName.Text;
            int age = Convert.ToInt32(tbxAge.Text);
            int years = Convert.ToInt32(tbxYears.Text);

            Person comparedPerson = admin.GetPerson(pcn);
            Person newPerson = new Person(name, age, pcn, years);
            admin.AddPerson(newPerson);
            
            if(comparedPerson == null)
            {
                admin.AddPerson(newPerson);
            }
            else
            {
                if(newPerson.GetPcn() == comparedPerson.GetPcn())
                {
                    MessageBox.Show("PCN already exists");
                }
                else
                {
                    admin.AddPerson(newPerson);
                }
            }

        }

        private void btnShowPeople_Click(object sender, EventArgs e)
        {
            lbxData.Items.Clear();

            foreach(Person p in admin.GetPeople())
            {
                lbxData.Items.Add(p.ToString());
            }
        }

        private void btnShowInfoPerson_Click(object sender, EventArgs e)
        {

            Person foundPerson = admin.GetPerson(tbxComparePcn.Text);
            lbxData.Items.Clear();
            lbxData.Items.Add(foundPerson.ToString());

        }

      

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            lbxData.Items.Clear();

            foreach(Student s in admin.GetStudents())
            {
                lbxData.Items.Add(s.ToString());
            }
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            string pcn = tbxPCN.Text;
            string name = tbxName.Text;
            int age = Convert.ToInt32(tbxAge.Text);
            int years = Convert.ToInt32(tbxYears.Text);
            int EC = Convert.ToInt32(tbxEC.Text);

            Student comparedStudent = admin.GetStudent(pcn);
            Student newStudent = new Student(name, age, pcn, years, EC);
            
            if(comparedStudent == null)
            {
                admin.AddStudent(newStudent);
            }
            else
            {
                if(newStudent.GetPcn() == comparedStudent.GetPcn())
                {
                    MessageBox.Show("PCN already exists");
                }
                else
                {
                    admin.AddStudent(newStudent);
                }
            }
        }

        private void btnNewTeacher_Click(object sender, EventArgs e)
        {
            string pcn = tbxPCN.Text;
            string name = tbxName.Text;
            int age = Convert.ToInt32(tbxAge.Text);
            int years = Convert.ToInt32(tbxYears.Text);
            double salary = Convert.ToDouble(tbxSalary.Text);

            Teacher comparedTeacher = admin.GetTeacher(pcn);

            Teacher newTeacher = new Teacher(name, age, pcn, years, salary);

            if(comparedTeacher == null)
            {
                admin.AddTeacher(newTeacher);
            }
            else
            {
                if(newTeacher.GetPcn() == comparedTeacher.GetPcn())
                {
                    MessageBox.Show("PCN already exists");
                }
                else
                {
                    admin.AddTeacher(newTeacher);
                }
            }
           
        }

        private void btnShowTeachers_Click(object sender, EventArgs e)
        {
            lbxData.Items.Clear();

            foreach(Teacher t in admin.GetTeachers())
            {
                lbxData.Items.Add(t.ToString());
            }
        }

        private void btnShowInfoStudent_Click(object sender, EventArgs e)
        {
            Student foundStudent = admin.GetStudent(tbxPcnStudent.Text);
            
            if(foundStudent == null)
            {
                MessageBox.Show("no student found");
            }
            else
            {

                lbxData.Items.Clear();

                lbxData.Items.Add(foundStudent.ToString());
            }
        }



        private void btnAddEC_Click(object sender, EventArgs e)
        {
            int Ec = Convert.ToInt32(tbxAddEc.Text);

            Student foundStudent = admin.GetStudent(tbxPcnStudent.Text);

            if(foundStudent == null)
            {
                MessageBox.Show("no student found");
            }
            else
            {
                foundStudent.AddECs(Ec);
            }
        }

        private void btnNewYearStudent_Click_1(object sender, EventArgs e)
        {
            Student foundStudent = admin.GetStudent(tbxPcnStudent.Text);

            if (foundStudent == null)
            {
                MessageBox.Show("No student found");
            }
            else
            {
                foundStudent.StartAnotherSchoolyear();
            }
        }

        private void btnShowInfoTeacher_Click(object sender, EventArgs e)
        {
            Teacher foundTeacher = admin.GetTeacher(tbxComparePcn.Text);
            lbxData.Items.Clear();
            lbxData.Items.Add(foundTeacher.ToString());
        }

        private void btnNewYearTeacher_Click(object sender, EventArgs e)
        {
            Teacher foundTeacher = admin.GetTeacher(tbxPcnTeacher.Text);
            
            if(foundTeacher == null)
            {
                MessageBox.Show("no teacher found");
            }
            else
            {
                foundTeacher.StartAnotherSchoolyear();
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            Teacher foundTeacher = admin.GetTeacher(tbxPcnTeacher.Text);

            if(foundTeacher == null)
            {
                MessageBox.Show("no teacher found");
            }
            else
            {
                foundTeacher.MakePromotion();
            }
        }
    }
}
