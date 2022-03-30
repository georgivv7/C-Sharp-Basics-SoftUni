    using System;

    namespace YardGreening
    {
        class Program
        {
            static void Main(string[] args)
            {
                double pricefor1square = 7.61;
                double discount = 0.18;
                double squares = double.Parse(Console.ReadLine());

                double price = pricefor1square * squares;
                double discountprice = discount * price;
                double finalPrice = price - discountprice;

                Console.WriteLine($"The final price is: {finalPrice} lv.");
                Console.WriteLine($"The discount is: {discountprice} lv.");

            }
        }
    }
