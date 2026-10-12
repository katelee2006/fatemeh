using System;

namespace _14042480040

{
    public class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int YearsOfExperience { get; set; }

        public Teacher(string name, string subject, int yearsOfExperience)
        {
            Name = name;
            Subject = subject;
            YearsOfExperience = yearsOfExperience;
        }

        public void Teach()
        {
            Console.WriteLine(Name + " is teaching " + Subject);
        }

        public void GiveHomework()
        {
            Console.WriteLine(Name + " gave new homework on " + Subject);
        }
    }
}
