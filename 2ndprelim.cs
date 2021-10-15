using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, course, year, sem, subC, subD, profName, remarks;
            double monthlyG, fPrel, sPrel, mid, pre, final, average;


            Console.WriteLine("ENTER NAME : (Last name. First name Middle name,)");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ENTER COURSE : ");
            course = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ENTER YEAR: (1ST, 2ND, 3RD, 4TH) ");
            year = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ENTER SEMESTER : (1ST, 2ND, SUMMER)");
            sem = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ENTER SUBJECT CODE: ");
            subC = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ENTER PROFESSOR NAME: ");
            profName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\n////////////////////////////////////////////////////////////////////////\n");

            Console.Write("ENTER MONTHLY GRADE: ");
            monthlyG = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTER 1ST PRELIM GRADE: ");
            fPrel = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTER 2ND PRELIM GRADE: ");
            sPrel = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTER MIDTERM GRADE: ");
            mid = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTER PRE-FINAL GRADE: ");
            pre = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTER FINAL GRADE: ");
            final = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n////////////////////////////////////////////////////////////////////////\n");
            //SUBJECT CODES

            if (subC == "GE8" || subC == "ge8")
            {
                subD = "Probabilities & Statistics";
            } else if (subC == "GE7" || subC == "ge7")
            {
                subD = "Speech and oral communication";
            } else if (subC == "SDF104" || subC == "sdf104")
            {
                subD = "Object oriented programming";
            } else if (subC == "CC104" || subC == "cc104")
            {
                subD = "DATA STRUCTURES AND ALGORITHMS";
            } else if (subC == "DS102" || subC == "ds102")
            {
                subD = "DISCRETE STRUCTURES 2";
            } else if (subC == "PE3" || subC == "pe3")
            {
                subD = "INDIVIDUAL & DUAL SPORTS";
            } else 
            {
                subD = "INVALID OUTPUT";
            }

            //COURSES
            if (course == "BSCS" || course == "bscs")
            {
                course = "BACHELOR OF SCIENCE IN COMPUTER SCIENCE";
            } else if (course == "BSHRM" || course == "bshrm")
            {
                course = "BACHELOR OF SCIENCE IN HOTEL & RESTAURANT MANAGEMENT";
            } else if (course == "BSTM" || course == "bstm")
            {
                course = "BACHELOR OF SCIENCE IN TOURISM MANAGEMENT";
            } else if (course == "BSBA" || course == "bsba")
            {
                course = "BACHELOR OF SCIENCE IN BUSINESS ADMINISTRATION";
            } else if (course == "BEE" || course == "bee")
            {
                course = "BACHELOR OF ELEMENTARY EDUCATION";
            } else if (course == "BSED" || course == "bsed")
            {
                course = "BACHELOR OF SECONDARY EDUCATION";
            } else
            {
                course = "INVALID INPUT";
            }

            Console.WriteLine("FULLNAME: " + name);
            Console.WriteLine("COURSE: " + course);
            Console.WriteLine("YEAR: " + year + " YEAR");
            Console.WriteLine("SEMESTER: " + sem + " SEMESTER");
            Console.WriteLine("SUBJECT CODE: " + subC);
            Console.WriteLine("SUBJECT DESCRIPTION: " + subD);
            Console.WriteLine("PROFESSOR NAME: " + profName);

            Console.WriteLine("\n////////////////////////////////////////////////////////////////////////\n");
            average = (monthlyG + fPrel + sPrel + mid + pre + final) / 6;

            if (average >= 75 && average <= 100)
            {
                remarks = "PASSED";
            }
            else if (average >= 65 && average <= 74)
            {
                remarks = "FAILED";
            }
            else
            {
                remarks = "INVALID OUTPUT";
            }

            Console.WriteLine("AVERAGE GRADES: " + average);
            Console.WriteLine("REMARKS: " + remarks);
        }
    }
}
 
