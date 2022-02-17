using System;

namespace TheSchool.Models
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _id;
        private string _address;
        private string _phoneNumber;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("First name cannot be empty.");
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Last name cannot be empty.");
                _lastName = value;
            }
        }
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value == null || value.Length != 13) throw new Exception("Id must contain 13 digits.");
                _id = value;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Address cannot be empty.");
                _address = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value == null) throw new Exception("Phone number cannot be empty.");
                _phoneNumber = value;
            }
        }

        public Person(string firstName, string lastName, string id, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
    