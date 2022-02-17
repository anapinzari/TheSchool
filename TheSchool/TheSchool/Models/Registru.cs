using System;

namespace TheSchool.Models
{
    public class Register
    {
        private Mark[] _marks;

        public Mark[] Marks
        {
            get
            {
                return _marks;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Marks cannot be empty.");
                _marks = value;
            }
        }

        public Register(Mark[] marks)
        {
            Marks = marks;
        }
    }
}
    