using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Manager
{
    public class Member
    {
        private string _name;
        private int _age;
        private bool _isStudent;
        private int _visits;

        public string Name { get { return _name; } set { value = _name; } }
        public int Age { get { return _age; } set { value = _age; } }
        public bool IsStudent { get { return _isStudent; }set { value = _isStudent; } }
        public int Visits { get { return _visits; } set { value = _visits; } }

        public Member(string name, int age, bool isstudent)
        {
            _name = name;
            _age = age;
            _isStudent = isstudent;
        }
    }
}
