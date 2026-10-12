using System;

namespace _14042480040

{
    public class Student
    {
        public string Name { get; set; }
        public int StudentNumber { get; set; }
        public string Major { get; set; }

        public Student(string name, int studentNumber, string major)
        {
            Name = name;
            StudentNumber = studentNumber;
            Major = major;
        }

        public void Study()
        {
            Console.WriteLine(Name + " is studying " + Major);
        }

        public double CalculateAverage(double grade1, double grade2, double grade3)
        {
            return (grade1 + grade2 + grade3) / 3;
        }
    }
}
