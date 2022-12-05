using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Week1Assignment
{
    public class Program
    {
        

        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of courses");
            int noOfCourses = int.Parse(Console.ReadLine());

            string[] courseCode = new string[noOfCourses];
            int[] courseUnit = new int[noOfCourses];
            int[] score = new int[noOfCourses];
            char[] grade = new char[noOfCourses];
            int[] gradeUnit = new int[noOfCourses];
            double[] weightPoint = new double[noOfCourses];
            string[] remark = new string[noOfCourses];
            double totalCourseUnitReg = 0;
            double totalCourseUnitPass = 0;
            double totalweightPoint = 0;
            double GPA = 0;

            for (int i = 0; i < noOfCourses; i++)
            {
                Console.WriteLine("Enter course:");
                courseCode[i] = Console.ReadLine();
                Console.WriteLine("Enter course unit for " + courseCode[i] + ":");
                courseUnit[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter score for " + courseCode[i] + ":");
                score[i] = int.Parse(Console.ReadLine());   

            }
            for (int i = 0; i < noOfCourses; i++)
            {
                if (score[i] >= 70 && score[i] <= 100)
                {
                    grade[i] = 'A';
                    gradeUnit[i] = 5;
                    weightPoint[i] = 5 * courseUnit[i];
                    remark[i] = "Excellent";
                }
                else if (score[i] >= 60 && score[i] <= 69)
                {
                    grade[i] = 'B';
                    gradeUnit[i] = 4;
                    weightPoint[i] = 4 * courseUnit[i];
                    remark[i] = "Very Good";
                }
                else if (score[i] >= 50 && score[i] <= 59)
                {
                    grade[i] = 'C';
                    gradeUnit[i] = 3;
                    weightPoint[i] = 3 * courseUnit[i];
                    remark[i] = "Good";
                }
                else if (score[i] >= 45 && score[i] <= 49)
                {
                    grade[i] = 'D';
                    gradeUnit[i] = 2;
                    weightPoint[i] = 2 * courseUnit[i];
                    remark[i] = "Fair";
                }
                else if (score[i] >= 40 && score[i] <= 44)
                {
                    grade[i] = 'E';
                    gradeUnit[i] = 1;
                    weightPoint[i] =  courseUnit[i];
                    remark[i] = "Pass";
                }
                else if (score[i] >= 0 && score[i] <= 39)
                {
                    grade[i] = 'F';
                    gradeUnit[i] = 0;
                    weightPoint[i] = 0;
                    remark[i] = "Fail";
                }
               

               
            }

         
        
            for (int i = 0; i < noOfCourses; i++)
            {
                totalCourseUnitReg += courseUnit[i];
                totalCourseUnitPass += gradeUnit[i];
                totalweightPoint += weightPoint[i];
                GPA = totalweightPoint / totalCourseUnitPass;
            }

            Console.Clear();
            PrintTable.PrintHeader();
            Console.WriteLine("| {0,-9} | {1,-9}| {2,-9} | {3,-9} | {4,-9} |{5,-9}  |", "COURSE CODE", "COURSE UNIT",
                "GRADE", "GRADE PT", "WEIGHT PT", "REMARK");
            PrintTable.PrintHeadPockets();

            for(int i = 0; i < noOfCourses; i++)
            {
                Console.WriteLine("| {0,-11} | {1,-9} | {2,-9} | {3,-9} | {4,-9} |{5,-9}  |", courseCode[i], courseUnit[i], 
                    grade[i], gradeUnit[i], weightPoint[i], remark[i]);
            }

            PrintTable.PrintHeadPockets();

            Console.WriteLine("Total Course Unit Registered is {0}", totalCourseUnitReg);
            Console.WriteLine("Total Course Unit Passed is {0}", totalCourseUnitPass);
            Console.WriteLine("Total Weight Point is {0}", totalweightPoint);
            Console.WriteLine("Your GPA is {0:F2}", GPA);

             
        }
    }
}
