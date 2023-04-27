using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A2
{
    public class StudentGrade
    {
        public string StudentName { get; set; }
        public float FirstGrade { get; set; }
        public float SecondGrade { get; set; }

        internal string ShowStudentName() { return StudentName; }
        internal void ShowStudentStatus() { }
        internal float ShowStudentHalfGrades(float fstGrade, float scndGrade) { return (fstGrade + scndGrade) / 2; }
    }
}
