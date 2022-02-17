using System;

namespace TheSchool.Models
{
    public class Supervisor : Person
    {
        private Student[] _students;

        public Student[] Students
        {
            get
            {
                return _students;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Students cannot be empty.");
                _students = value;
            }
        }

        public Supervisor(string firstName, string lastName, string id, string address, string phoneNumber) 
            : base(firstName, lastName, id, address, phoneNumber)
        {
        }
    }
}
    