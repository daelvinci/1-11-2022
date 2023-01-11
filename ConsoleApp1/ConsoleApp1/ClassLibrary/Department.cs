using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ClassLibrary
{
    internal class Department
    {
        public string Name;
        public int EmployeeLimit;
        public double SalaryLimit;
        private List<Employee> _employees;
        public List<Employee> Employees => _employees;

        public void AddEmployee(Employee newEmployee)
        {
            if (CheckEmployeeLimit())
            {
                _employees.Add(newEmployee);
            }
            else
            {
                try
                {
                    throw new Exception(" Isci limiti dolub! Isci elave etmek mumkun deyil");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}\n");
                }
            }
        }
        public bool CheckSalaryLimit(double salary)
        {

            if (!(salary >= 250))
            {
                try
                {
                    throw new Exception(" Maas 250 den yuxari olmalidir");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}\n");
                    return false;
                }
            }

            else
            {
                if ((SalaryLimit - CalculateCurrentAllSalary()) >= salary)
                    return true;

                else
                {
                    if (SalaryLimit - CalculateCurrentAllSalary() >= 250)
                    {
                        try
                        {
                            throw new Exception($" Maas max {SalaryLimit - CalculateCurrentAllSalary()} Teyin oluna biler");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"\n{e.Message}\n");
                            return false;
                        }
                    }
                    else
                    {
                        try
                        {
                            throw new Exception("Isci elave dile bilmez. Maas llimiti kecir");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"\n{e.Message}\n");
                            return false;
                        }
                    }
                }
            }
        }

        public double CalculateCurrentAllSalary()
        {
            double allSalary = 0;
            foreach (var item in _employees)
            {
                allSalary += item.Salary;
            }
            return allSalary;
        }
        public bool CheckEmployeeLimit()
        {
            if (_employees.Count < EmployeeLimit)
                return true;
            else
            {
                try
                {
                    throw new Exception(" Isci limiti dolmusdur!");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}\n");
                    return false;
                }
            }
        }
    }
}
//Department class
// -Name
// - EmployeeLimit
// - SalaryLimit
// - Employees
// - AddEmployee()


//Employee ve Department classlarını ClassLibrary-de yazın
//Employee Name və Surname dəyərləri yalnız hərflərdən
//ibarət olmalıdır və Böyük hərflə başlamalıdır
//Salary dəyəri 250-dən aşağı ola bilməz
//AddEmployee metodu employees array-e employee obyekti
//əlavə etmək üçündür.

