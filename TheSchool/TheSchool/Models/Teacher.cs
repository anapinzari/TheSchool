using System;

namespace TheSchool.Models
{
    public class Teacher : Employee
    {
        private TeacherRole[] _roles;

        public TeacherRole[] Roles
        {
            get
            {
                return _roles;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Teacher roles cannot be empty.");
                _roles = value;
            }
        }

        public Teacher(string firstName, string lastName, string id, string address, string phoneNumber, float salary) 
            : base(firstName, lastName, id, address, phoneNumber, salary)
        {
        }
    }
}
    