using System;
using System.Collections.Generic;
using System.Text;

namespace taskLesson
{
    internal class Student
    {
        static Student()
        {
            _counter = 100;
        }
        public Student()
        {
            _counter++;
            _no = _counter;
        }
        
        private static int _counter;
        private int _no;
        public int No => _no;
        public string FullName;
        public string GroupNo;
    }
}
