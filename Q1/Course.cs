using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public delegate void Mydelagate(int oldNumber, int newNumber);
    internal class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public Course()
        {
            
        }
        public Course(int courseId, string courseName)
        {
            CourseID = courseId;
            CourseName = courseName;
        }
        Dictionary<Student, double> students = new Dictionary<Student, double>();
        public Mydelagate OnNumberOfStudentChange = new Mydelagate(Tong);
        public void AddStudent(Student p, double g) {
            int oldS = students.Count;
            students.Add(p, g);
            int newS = students.Count;
            OnNumberOfStudentChange(oldS, newS);
        }
        public void RemoveStudent(int StudentID)
        {
            int oldS = students.Count;
            foreach (var student in students.Keys) { 
                if(student.StudentID == StudentID)
                {
                    students.Remove(student);
                }
            }
            int newS =students.Count;
            OnNumberOfStudentChange(oldS, newS);
        }
        public static void Tong(int a, int b)
        {
           
        }
        public override string? ToString()
        {
            string ans = "";
            ans += "Course: " + CourseID + " - " + CourseName + "\n";
            foreach(var student in students.Keys)
            {
                ans += "Student: " + student.StudentID + " - " + student.StudentName + " - " + students[student]+"\n";
                
            }
            return ans;
        }
    }
}
