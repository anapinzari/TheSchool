using System;

namespace TheSchool.Models
{
    public class Mark
    {
        private float _value;
        
        private Student _student;
        
        private Teacher _teacher;


        public Simester Simester { get; set; }
        public Student Student
        {
            get
            {
                return _student;
            }
            set
            {
                if (value == null) throw new Exception("Student cannot be empty.");
                _student = value;
            }
        }
        public Subject Subject { get; set; }
        public Teacher Teacher
        {
            get
            {
                return _teacher;
            }
            set
            {
                if (value == null) throw new Exception("Teacher cannot be empty.");
                _teacher = value;
            }
        }
        public float Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value < 1 || value > 10) throw new Exception("The value must be from 1 to 10.");
                _value = value;

            }
        }

        public Mark(Simester simester, Student student, Subject subject, Teacher teacher, float value)
        {
            Simester = simester;
            Student = student;
            Subject = subject;
            Teacher = teacher;
            Value = value;
        }
    }
}
    