using System;
using System.Collections.Generic;

namespace taskLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student std1 = new Student() { FullName = "asif", GroupNo = "P283" };
            Student std2 = new Student() { FullName = "tural", GroupNo = "P223" };
            Student std3 = new Student() { FullName = "elvin", GroupNo = "P232" };

            List<Student> stdList = new List<Student> { std1, std2, std3 };

            foreach (var item in stdList)
            {
                Console.WriteLine($"Fullname - {item.FullName} - Grup nomresi - {item.GroupNo} - Nomresi - {item.No}");
            }

            Console.Write("silmek istediyiniz studentin nomresini daxil edin:  ");
            int input = int.Parse(Console.ReadLine());

            foreach (var item in stdList)
            {
                if (item.No == input)
                {
                    stdList.Remove(item);
                    break;
                }

            }
            foreach (var item in stdList)
            {
                Console.WriteLine($"Fullname - {item.FullName} - Grup nomresi - {item.GroupNo} - Nomresi - {item.No}");
            }



        }
    }
}
