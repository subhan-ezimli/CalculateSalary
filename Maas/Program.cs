using System;

namespace Maas
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherSalary salary = new TeacherSalary();

            salary.AddLesson(5, 10);//150
            salary.AddLesson(7, 3); //45
            salary.AddLesson(10, 2);//40


            salary.Show();
            salary.Removelesson(10);
            
            Console.WriteLine("Total Salary:" + salary.CalcSalary());

            Console.WriteLine("==================");
            

        }
    }
}
