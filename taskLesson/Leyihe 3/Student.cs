using System;
using System.Collections.Generic;
using System.Text;

namespace Leyihe_3
{
    internal class Student
    {
        public Student()
        {
            _count++;
            _no = _count;
        }
        private static int _count;
        private int _no;
        public int No => _no;

        public string FullName;
        public Dictionary <string,double>Exams => _exams;

        private Dictionary<string, double> _exams;
        public void AddExam(string ad, double bal)
        {
            _exams.TryAdd(ad, bal);
        }

        public double? GetExamResult(string key)
        {
            if (_exams.ContainsKey(key))
            {
                return _exams[key];
            }
            return null; 
        }

        public double GetExamResultAvg()
        {          
            double sum=0;
            foreach (var item in _exams)
            {
                sum += item.Value;
            }
            return sum / _exams.Count;

        }
    }

}
