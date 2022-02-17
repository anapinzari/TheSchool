using System;

namespace TheSchool.Models
{
    public class Group
    { 
        private Student[] _students;
        private Register _register;

        public GroupName Name { get; set; }
        public Grade Grade { get; set; }
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
        public Register Register
        {
            get
            {
                return _register;
            }
            set
            {
                if (value == null) throw new Exception("Register cannot be empty.");
                _register = value;
            }
        }

        public Group(GroupName groupName, Grade grade, Student[] students, Register register)
        {
            Name = groupName;
            Grade = grade;
            Students = students;
            Register = register;
        }
    }
}
    