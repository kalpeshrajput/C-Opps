using System;

namespace simpleIntrest
{
    class Program
    {
        static void Main(string[] args)
        {
         getValue();
        }
        static void getValue()
        {
            simpleInterest objInterest = new simpleInterest();
            Console.WriteLine("Enter the Loan Ammount");
            objInterest.principleAmt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Year");
            objInterest.year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the rate of Interest");
            objInterest.rate = Convert.ToDouble(Console.ReadLine());
            printValues(objInterest);
        }
        static void printValues(simpleInterest objInterest) {
            objInterest.interest = objInterest.principleAmt * objInterest.year * objInterest.rate / 100;
            objInterest.total_Amt = objInterest.principleAmt + objInterest.interest;
           
            Console.WriteLine("Total Ammount = " + objInterest.interest);
            Console.WriteLine("Total Ammount = " + objInterest.total_Amt);
        }
    }
    public class simpleInterest
    {
        internal int year { get; set; }
        internal double principleAmt { get; set; }
        internal double interest { get; set; }
        internal double rate { get; set; }
        internal double total_Amt { get; set; }
    }
}
