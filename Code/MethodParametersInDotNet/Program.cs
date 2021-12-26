using System;

namespace MethodParametersInDotNet
{
    public class Employee
    {
        public string Name { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.WriteLine($"Before calling ValByVal, x = {x}"); // expected x = 1
            ValByVal(x);
            Console.WriteLine($"After calling ValByVal, x = {x}"); // expected x = 1

            x = 1;
            Console.WriteLine($"Before calling ValByRef, x = {x}"); // expected x = 1
            ValByRef(ref x);
            Console.WriteLine($"After calling ValByRef, x = {x}"); // expected x = 2

            Employee ahmed = new Employee { Name = "Ahmed" };

            Console.WriteLine(
                $"Before calling RefByVal, ahmed = Employee ({ahmed.Name})"); // expected ahmed = Employee (Ahmed)

            RefByVal(ahmed);

            Console.WriteLine(
                $"After calling RefByVal, ahmed = Employee ({ahmed.Name})"); // expected ahmed = Employee (Tarek)

            ahmed = new Employee { Name = "Ahmed" };

            Console.WriteLine(
                $"Before calling RefByRef, ahmed = Employee ({ahmed.Name})"); // expected ahmed = Employee (Ahmed)

            RefByRef(ref ahmed);

            Console.WriteLine(
                $"After calling RefByRef, ahmed = Employee ({ahmed.Name})"); // expected ahmed = Employee (Hasan)

            Console.ReadLine();
        }

        public static void ValByVal(int x)
        {
            x++;
        }

        public static void ValByRef(ref int x)
        {
            x++;
        }

        public static void RefByVal(Employee x)
        {
            x.Name = "Tarek";
            x = new Employee { Name = "Hasan" };
        }

        public static void RefByRef(ref Employee x)
        {
            x.Name = "Tarek";
            x = new Employee { Name = "Hasan" };
        }
    }
}