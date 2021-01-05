using System;

namespace ETHEREUM_CALCULATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double EthValue = 8.33273612;
                double investedValue = 3500;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("INPUT ETH PRICE: ");
                double input = double.Parse(Console.ReadLine());
                double walletamount = EthValue * input;
                double gain = walletamount / investedValue;
                double loss = investedValue - walletamount;
                var result = Math.Round((walletamount - investedValue) / investedValue * 100, 0);


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nCurrent wallet amount: "+Math.Round(walletamount, 0));


                if (walletamount - investedValue > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Profit: {Math.Round(walletamount - investedValue, 0)} EUROS  --> {result} %"); 
                }
                else if (walletamount - investedValue < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Loss: {Math.Round(loss, 0)} EUROS -->  {Math.Round(loss/investedValue * 100)} %");
                }
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
            }  
        }
    }
}
