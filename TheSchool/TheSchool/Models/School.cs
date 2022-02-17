using System;

namespace TheSchool.Models
{
    public class School
    {
        private Teacher[] _teachers;
        private Group[] _groups;
        private Administrator _administrator;

        public Teacher[] Teachers
        {
            get
            {
                return _teachers;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Teachers cannot be empty.");
                _teachers = value;
            }
        }
        public Group[] Groups
        {
            get
            {
                return _groups;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("");
                _groups = value;
            }
        }
        public Administrator Administrator
        {
            get
            {
                return _administrator;
            }
            set
            {
                if (value == null) throw new Exception("Administrator cannot be empty.");
                _administrator = value;
            }
        }

        public School(Teacher[] teachers, Group[] groups, Administrator administrator)
        {
            Teachers = teachers;
            Groups = groups;
            Administrator = administrator;
        }
    }
}
    