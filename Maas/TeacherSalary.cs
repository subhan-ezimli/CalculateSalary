using System;
using System.Collections.Generic;
using System.Text;

namespace Maas
{
    class TeacherSalary
    {
        private int[] lessonHour = new int[11];
        private double[] lessonIncome = new Double[11];
        private double _totalIncome;

        public void AddLesson(int level, int hour)
        {

            if (level >= 1 && level <= 4)
            {
                lessonHour[level - 1] += hour;
                lessonIncome[level - 1] += hour * 10;

                
                
            }
            else if (level >= 5 && level <= 9)
            {
                lessonHour[level - 1] += hour;
                lessonIncome[level - 1] += hour * 15;
               
            }
            else
            {
                lessonHour[level - 1] += hour;
                lessonIncome[level - 1] += hour * 20;
                
            }

            }

            public double CalcSalary()
            {
                for (int i = 0; i < 11; i++)
                {
                    _totalIncome += lessonIncome[i];
                }
                return _totalIncome;


            }
        public void Show()
        {
            for (int i = 0; i < 11; i++)
            {
                if (lessonHour[i]!=0)
                {
                    Console.WriteLine($"{i + 1} sinfe {lessonHour[i]} saat ders deyilib");
                }
                
            }


        }
        public void Removelesson(int lesson)
            {
               
                _totalIncome = _totalIncome - lessonIncome[lesson - 1];
               



            }
       

         
        }
    } 
       
        
        


    
