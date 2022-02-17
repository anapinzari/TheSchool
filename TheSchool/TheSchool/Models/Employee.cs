using System;

namespace TheSchool.Models
{
    public class Employee : Person
    {
        private float _salary;

        public float Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 0) throw new Exception("Salary cannot be negative.");
                _salary = value;
            }
        }

        public Employee(string firstName, string lastName, string id, string address, string phoneNumber, float salary) 
            : base(firstName, lastName, id, address, phoneNumber)
        {
            Salary = salary;
        }
    }
}
    