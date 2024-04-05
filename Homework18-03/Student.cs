using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Homework18_03
{
    public class Student
    {
        public string Name { get; set; }
        public double LabGrade { get; set; }
        public double TestGrade { get; set; }

        public Student(string name, double labGrade, double testGrade)
        {
            Name = name;
            LabGrade = labGrade;
            TestGrade = testGrade;
        }

        public double CalculateOverallGrade()
        {
            return (LabGrade * 0.4) + (TestGrade * 0.6);
        }
    }
}

