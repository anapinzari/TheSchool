using System;

namespace TheSchool.Models
{
    public class Student : Person
    {
        private Supervisor[] _supervisors;
        private Mark[] _marks;

        public byte Age { get; set; }      
        public bool IsFemale { get; set; }
        public Supervisor[] Supervisors
        {
            get
            {
                return _supervisors;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Supervisors cannot be empty.");
                _supervisors = value;
            }
        }

        public Mark[] Marks
        {
            get
            {
                return _marks;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("The student must have marks.");
                _marks = value;
            }
        }

        public Student(string firstName, string lastName, string id, string address, string phoneNumber, byte age, bool isFemale, Supervisor[] supervisors) 
            : base(firstName, lastName, id, address, phoneNumber)
        {
            Age = age;
            IsFemale = isFemale;
            Supervisors = supervisors;
        }
    }
}
    