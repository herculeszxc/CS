using System;

namespace gradingsheet
{
    class Program
    {
        static void Main(string[] args)
        {
            string course, name, section, subjectD, subjectCode, sem, year;
            double month, pre1, pre2, midt, pref, final, average;
            
            Console.Write("COURSE: ");
            course = Convert.ToString(Console.ReadLine());

            Console.Write("YEAR: ");
            year = Convert.ToString(Console.ReadLine());

            Console.Write("SECTION: ");
            section = Convert.ToString(Console.ReadLine());

            Console.Write("SEMESTER: ");
            sem = Convert.ToString(Console.ReadLine());

            Console.Write("SUBJECT CODE: ");
            subjectCode = Convert.ToString(Console.ReadLine());

            Console.Write("SUBJECT DESCRIPTION: ");
            subjectD = Convert.ToString(Console.ReadLine());

            Console.Write("FULL NAME: ");
            name = Convert.ToString(Console.ReadLine());
            //

            Console.Write("//////////////////////////////////////////////////////////////////////////////////////////////////\n");
            Console.Write("COURSE: " + course + "\t\t\t\t");
            Console.Write("SEMESTER: " + sem + " SEM\n");
            Console.Write("YEAR: " + year + " YEAR\t\t\t");
            Console.Write("SUBJECT CODE: " + subjectCode + "\n");
            Console.Write("SECTION: " + section + "\t\t\t\t");
            Console.Write("SUBJECT DESCRIPTION: " + subjectD + "\n");
            Console.Write("//////////////////////////////////////////////////////////////////////////////////////////////////\n");

            Console.Write("MONTHLY: ");
            month = Convert.ToDouble(Console.ReadLine());

            Console.Write("1ST PRELIM: ");
            pre1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2ND PRELIM: ");
            pre2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("MIDTERM: ");
            midt = Convert.ToDouble(Console.ReadLine());

            Console.Write("PRE FINAL: ");
            pref = Convert.ToDouble(Console.ReadLine());

            Console.Write("FINAL: ");
            final = Convert.ToDouble(Console.ReadLine());

            average = (month + pre1 + pre2 + midt + pref + final) / 6;

            Console.Write("\nAVERAGE: " + average);

            if (average >= 75 && average <= 100)
            {
                Console.Write("\nREMARKS: PASSED\n");
            } else if (average >= 65 && average <= 74)
            {
                Console.Write("REMARKS: FAILED\n");
            }
            else
            {
                Console.Write("INVALID INPUT\n");
            }
        }
    }
}
