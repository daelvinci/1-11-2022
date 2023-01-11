using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe_4
{
    internal class Employee
    {
        public Employee()
        {
            _counter++;
            _no = _counter;

        }
        private int _counter;
        public int No => _no;
        static int _no;

        public string FullName;
        public Dictionary<string, bool> Attendances => _attendances;
        private Dictionary<string, bool> _attendances;

        public void AddAttendances(string tarix, bool istirak)
        {
            if (_attendances.ContainsKey(tarix))
                _attendances.Add(tarix, istirak);
        }

        public int GetQayibSayi()
        {
            int count = 0;
            foreach (var item in _attendances)
            {
                if (item.Value == false)
                {
                    count++;
                }

            }
            return count;
        }
        public int? GetIstirakFaizi()
        {
            if (Attendances.Count > 0)
                return (GetQayibSayi() / Attendances.Count) * 100;

            return null;

        }




    }
}
