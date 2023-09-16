namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int termOfDeposi = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());
            double rate = annualInterestRate / 100;


            //amount = deposited amount + term of deposit *(deposited amount* annual interest rate) / 12

            double amount = depositedAmount + termOfDeposi * (depositedAmount * rate) / 12;
            Console.WriteLine(amount);
        }
    }
}