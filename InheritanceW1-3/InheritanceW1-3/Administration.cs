using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceW1_3
{
    public class Administration
    {
        private List<Person> people;
        private List<Student> students;
        private List<Teacher> teachers;

        public Administration()
        {
            this.people = new List<Person>();
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public void AddPerson(Person p)
        {
            people.Add(p);
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
            people.Add(s);
        }

        public void AddTeacher(Teacher t)
        {
            teachers.Add(t);
            people.Add(t);
        }

        public Person GetPerson(string pcn)
        {
            foreach (Person p in people)
            {
                if (p.GetPcn() == pcn)
                {
                    return p;
                }

            }
            return null;
        }

        public Student GetStudent(string pcn)
        {
            foreach (Student s in students)
            {
                if (s.GetPcn() == pcn)
                {
                    return s;
                }
            }
            return null;
        }

        public Teacher GetTeacher(string pcn)
        {
            foreach(Teacher t in teachers)
            {
                if(t.GetPcn() == pcn)
                {
                    return t;
                }
            }
            return null;
        }

        public Person[] GetPeople()
        {
           Person[] peopleArr = people.ToArray();
           return peopleArr;
            
        }

        public Student[] GetStudents()
        {
            Student[] studentsArr = students.ToArray();
            return studentsArr;
        }

        public Teacher[] GetTeachers()
        {
            Teacher[] teachersArr = teachers.ToArray();
            return teachersArr;
        }

        public void AddTestData()
        {
            Random rand = new Random();
            int personAge = rand.Next(1, 70);
            int studentAge = rand.Next(1, 40);
            int teacherAge = rand.Next(1, 70);
            Person p1 = new Person("generic", personAge, "1023", 2);
            Person p2 = new Person("generic2", personAge, "2045", 4);
            Person p3 = new Person("generic3", personAge, "7124", 6);
            Student s1 = new Student("generic4", studentAge, "5321", 2);
            Student s2 = new Student("generic5", studentAge, "2572", 4);
            Student s3 = new Student("generic6", studentAge, "6921", 6);
            Teacher t1 = new Teacher("generic7", teacherAge, "5829", 2);
            Teacher t2 = new Teacher("generic8", teacherAge, "1952", 4);
            Teacher t3 = new Teacher("generic9", teacherAge, "5829", 6);

            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            teachers.Add(t1);
            teachers.Add(t2);
            teachers.Add(t3);
            people.Add(s1);
            people.Add(s2);
            people.Add(s3);
            people.Add(t1);
            people.Add(t2);
            people.Add(t3);
        }
    }
}
