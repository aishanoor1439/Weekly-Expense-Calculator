using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Expense_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Array for storing expenses
                double[] expenses = new double[7];
                //Array for displaying days
                string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                double totalExpense = 0;

                Console.WriteLine("Enter the refreshment and entertainment expenses for each day of the week.");

                for (int i = 0; i < days.Length; i++)
                {
                    Console.WriteLine($"Enter expense for {days[i]}:");
                    //Input: Expense for each day
                    expenses[i] = double.Parse(Console.ReadLine());
                    //Process: Adding all the expenses up
                    totalExpense += expenses[i];
                }

                //Output: Displaying Output
                Console.WriteLine($"The total weekly refreshment entertainment expense is: PKR {totalExpense}");
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
