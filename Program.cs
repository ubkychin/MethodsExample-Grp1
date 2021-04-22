using System;

namespace MethodsExample_Grp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            int age = CalcAge(1324);
            System.Console.WriteLine(age);

        }

        
        public static int CalcAge(int YearOfBirth) {
            int age = GetCurrentYear() - YearOfBirth;
            return age;
        }

        public static int GetCurrentYear() {
            return DateTime.Now.Year;
        }
    }
}
