using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1.ClassLibrary
{
    internal class Employee
    {
        public string Name => _name;
        string _name
        {
            get => _name;
           
            set
            {
                if(CheckName(value))
                {
                    _name = value;
                }
            }
        }
        public string Surname => _surname;
        string _surname
        {
            get => _surname;

            set
            {
                if (CheckName(value))
                {
                    _surname = value;
                }
            }
        }

        public double Salary;

        public static bool CheckName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                if (name.Length > 1 && name.Length > 1)
                {
                    if (char.IsUpper(name[0]))
                    {
                        if (!HasSymbolAndHasDigitAndHasUpper(name))
                            return true;
                        else
                        {
                            try
                            {
                                throw new Exception(" Yalniz herfler olmalidir ! ");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"\n {e.Message}\n");
                                return false;
                            }
                        }


                    }
                    else 
                    {
                        try
                        {
                            throw new Exception(" Bas herfler boyuk olmalidir ! ");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"\n {e.Message}\n");
                            return false;
                        }
                    }

                }
                else
                {
                    try
                    {
                        throw new Exception(" Ad ve soyadin uzunlugu min. 2 olmalidi!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"\n{e.Message}\n");
                        return false;
                    }
                }
            }
            else
            {

                try
                {
                    throw new Exception(" Herf daxil edin");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}\n");
                    return false;
                }
            }
        }

        public static bool CheckSurname(string surName)
        { 
            if (!string.IsNullOrWhiteSpace(surName))
            {
                if (surName.Length > 1 && surName.Length > 1)
                {
                    if (char.IsUpper(surName[0]))
                    {
                        if (!HasSymbolAndHasDigitAndHasUpper(surName))
                            return true;
                        else
                        {
                            try
                            {
                                throw new Exception(" Yalniz herfler olmalidir ! ");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"\n {e.Message}\n");
                                return false;
                            }
                        }


                    }
                    else
                    {
                        try
                        {
                            throw new Exception(" Bas herfler boyuk olmalidir ! ");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"\n {e.Message}\n");
                            return false;
                        }
                    }

                }
                else
                {
                    try
                    {
                        throw new Exception(" Ad ve soyadin uzunlugu min. 2 olmalidi!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"\n{e.Message}\n");
                        return false;
                    }
                }
            }
            else
            {

                try
                {
                    throw new Exception(" Herf daxil edin");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}\n");
                    return false;
                }
            }
        }
       
        public static bool HasSymbolAndHasDigitAndHasUpper(string input)
        {
            
            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsSymbol(input[i]) || char.IsDigit(input[i]) || char.IsUpper(input[i]))
                    return true;
            }
            return false;
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

}
