using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        public const int LowerGrade = 0;
        public const int LowerGradeD = 40;
        public const int LowerGradeC = 50;
        public const int lowerGardeB = 60;
        public const int LowerGradeA = 70;
        public const int HighestMark = 100;

        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public void Student()
        {
            Students = new string[]
            {
                "Luke","Euan","Munir", "Qasim","JoySon",
                "Keegan","Muhammad","Hamza","mike","justin",

            };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }
        public void InputMarks()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// list all the student and Display their
        /// name and current mark 
        /// </summary>
       
        public void OutputMarks()
        {
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("             Student  Marks        ");
                Console.WriteLine("           By Mohammad Qasim Matloob  ");
                Console.WriteLine("---------------------------------------------\n");

            }


        }
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowerGradeD)
            {
                return Grades. F;
            }

            else return Grades.D;
  
        }

        public void CalculateStats()
        {
            double total = 0;
            foreach(int mark in Marks)
            {
                total = total + mark;
            }
            Mean = total / Marks.Length;
        }
        public void CalculateGradeProfile()
        {
            for(int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach(int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

            OutputGradeProfile();
        }
        private void OutputGradeProfile()
        {
            Grades grades = Grades.X;
            Console.WriteLine();

            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grades} {percentage}% Count {count}");
                grades++;
            }
        }
       

    }

}
