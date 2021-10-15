using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, course, year, sem, subC, subD, profName, remarks, numEq;
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

            if (subC == "CC101" || subC == "cc101")
            {
                subD = "INTRODUCTION TO COMPUTING";
            } else if (subC == "CC102" || subC == "cc102")
            {
                subD = "FUNDAMENTALS OF PROGRAMMING";
            } else if (subC == "GE1" || subC == "ge1")
            {
                subD = "COMMUNICATION SKILLS 1";
            } else if (subC == "GE2" || subC == "ge2")
            {
                subD = "KOMUNIKASYON SA AKEDEMIKONG FILIPINO";
            } else if (subC == "GE3" || subC == "ge3")
            {
                subD = "COLLEGE ALGEBRA";
            } else if (subC == "NSTP1" || subC == "nstp1")
            {
                subD = "NATIONAL SERVICE TRAINING PROGRAM 2";
            } else if (subC == "PE1" || subC == "pe1") {
                subD = "PHYSICAL FITNESS";
            } else if (subC == "CC103" || subC == "cc103")
            {
                subD = "INTERMEDIATE PROGRAMMING";
            } else if (subC == "GE4" || subC == "ge4")
            {
                subD = "COMMUNICATION SKILLS 2";
            } else if (subC == "GE5" || subC == "ge5")
            {
                subD = "PAGBASA AT PAG SULAT TUNGO SA PANANALIKSIK";
            } else if (subC == "GE6" || subC == "ge6")
            {
                subD = "ART APPRECIATION";
            } else if (subC == "DS101" || subC == "DS101")
            {
                subD = "DIISCRETE STRUCTION 1";
            } else if (subC == "NSTP2" || subC == "nstp2")
            {
                subD = "NATIONAL SERVICE TRAINING PROGRAM 2";
            } else if (subC == "PE2" || subC == "pe2")
            {
                subD = "RHYTMIC ACTIVITIES";
            } else
            {
                subD = "INVALID INPUT"; 
            }


            //COURSES
            if (course == "BSCS" || course == "bscs")//
            {
                course = "BACHELOR OF SCIENCE IN COMPUTER SCIENCE";
            } else if (course == "BSHRM" || course == "bshrm")
            {
                course = "BACHELOR OF SCIENCE IN HOTEL & RESTAURANT MANAGEMENT";
            } else if (course == "BSTM" || course == "bstm")//
            {
                course = "BACHELOR OF SCIENCE IN TOURISM MANAGEMENT";
            } else if (course == "BSBA" || course == "bsba")//
            {
                course = "BACHELOR OF SCIENCE IN BUSINESS ADMINISTRATION";
            } else if (course == "BEED" || course == "beed")//
            {
                course = "BACHELOR OF ELEMENTARY EDUCATION";
            } else if (course == "BSED MATH" || course == "bsed math")//
            {
                course = "BACHELOR OF SECONDARY EDUCATION MAJOR IN MATHEMATICS";
            } else if (course == "ABPOLSCI" || course == "abpolsci")//
            {
                course = "BBACHELOR OF ARTS IN POLITICAL SCIENCE";
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
            else if (average <=74 && average >= 65)
            {
                remarks = "FAILED";
            }
            else
            {
                remarks = "INVALID OUTPUT";
            }

            if (average >= 97 && average <= 100)
            {
                numEq = "1.00 EXCELLENT";
            } else if (average >= 94 && average <= 96)
            {
                numEq = "1.25 EXCELLENT";
            } else if (average >= 91 && average <= 93)
            {
                numEq = "1.50 VERY GOOD";
            } else if (average >= 88 && average <= 90)
            {
                numEq = "1.75 very good";
            } else if (average >= 85 && average <= 87)
            {
                numEq = "2.00 GOOD";
            } else if (average >= 82 && average <= 84)
            {
                numEq = "2.25 GOOD";
            } else if (average >= 79 && average <= 81)
            {
                numEq = "2.50 SATISFACTORY";
            } else if (average >= 76 && average <= 78)
            {
                numEq = "2.75 SATISFACTORY";
            } else if (average >= 75)
            {
                numEq = "3.00 PASSING";
            } else
            {
                numEq = "5.00 FAILURE";
            }

            Console.WriteLine("NUMERIC EQUIVALENT: " + numEq);
            Console.WriteLine("AVERAGE GRADES: " + average);
            Console.WriteLine("REMARKS: " + remarks);

        }
    }
}
 
