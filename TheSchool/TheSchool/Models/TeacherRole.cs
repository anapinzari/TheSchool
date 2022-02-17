using System;

namespace TheSchool.Models
{
    public class TeacherRole
    {
        private Group[] _groups;

        public Subject Subject { get; set; }
        public Group[] Groups
        {
            get
            {
                return _groups;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Groups cannot be empty.");
                _groups = value;
            }
        }

        public TeacherRole(Subject subject, Group[] groups)
        {
            Subject = subject;
            Groups = groups;
        }
    }
}
    