namespace _06.Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6. Redecorating
            Rumen wants to repaint the living room and has hired craftsmen for this purpose. Write a program that calculates the cost of the repair, taking the following prices for the calculation:
            · Protective nylon - 1.50 BGN per square meter
            · Paint - 14.50 BGN per liter
            · Paint thinner - 5.00 BGN per liter

            Just in case, to the necessary materials, Rumen wants to add another 10% of the amount of paint and 2 square meters of nylon, also 0.40 leva for bags. The amount paid to the craftsmen for 1 hour of work is equal to 30% of the sum of all material costs.

            Input
            The input is read from the console and contains exactly 4 lines:
            1. Required amount of nylon (in sq.m.) - an integer number in the range [1... 100]
            2. Required amount of paint (in liters) - an integer number in the range [1... 100]
            3. Quantity of thinner (in liters) - integer number in the range [1... 30]
            4. Hours needed for the craftsmen to do the work - an integer number in the range [1... 9]

            Output
            Print out only one line on the console:
            · "{the sum of all costs}"
            Example Input/Output

              Input 10
                    11
                    4
                    8

             Output 727.09
                    Nylon amount: (10 + 2) * 1.50 = 18 BGN 
                    Amount for paint: (11 + 10%) * 14.50 = 175.45 BGN 
                    Amount for thinner: 4 * 5.00 = 20.00 BGN Amount for bags: 0.40 BGN 
                    Total amount for materials: 18 + 175.45 + 20.00 + 0.40 = 213.85 BGN 
                    Amount for craftsmen: (213.85 * 30%) * 8 = 513.24 BGN 
                    Total amount: 213.85 + 513.24 = 727.09 BGN

              Input 5
                    10
                    10
                    1

             Output 286.52
                    Amount for nylon: (5 + 2) * 1.50 = 10.50 BGN
                    Amount for paint: (10 + 10%) * 14.50 = 159.50 BGN 
                    Amount for thinner: 10 * 5.00 = 50.00 BGN Amount for bags: 0.40 BGN 
                    Total amount for materials: 10.50 + 159.50 + 50.00 + 0.40 = 220.40 BGN 
                    Amount for masters: (220.40 * 30%) * 1 = 66.12 BGN 
                    Total: 220.40 + 66.12 = 286.52 BGN
             */
        }
    }
}