using System;
namespace FinalProject
{
    public class Gold : PreciousMetal
    {
        private const double GoldPricePerGramFactor10K = 26.20;
        private const double GoldPricePerGramFactor14K = 36.68;
        private const double GoldPricePerGramFactor18K = 47.16;
        private const double GoldPricePerGramFactor22K = 57.64;
        private const double GoldPricePerGramFactor24K = 62.88;

        public override double CalculatePrice(double weight)
        {
            Console.WriteLine("Enter karat (10k, 14k, 18k, 22k, or 24k):");
            string karatInput = Console.ReadLine();

            double purity;
            double priceFactor;
            switch (karatInput.ToLower())
            {
                case "10k":
                    purity = 0.4167;
                    priceFactor = GoldPricePerGramFactor10K;
                    break;
                case "14k":
                    purity = 0.5833;
                    priceFactor = GoldPricePerGramFactor14K;
                    break;
                case "18k":
                    purity = 0.75;
                    priceFactor = GoldPricePerGramFactor18K;
                    break;
                case "22k":
                    purity = 0.9167;
                    priceFactor = GoldPricePerGramFactor22K;
                    break;
                case "24k":
                    purity = 1.0;
                    priceFactor = GoldPricePerGramFactor24K;
                    break;
                default:
                    Console.WriteLine("Invalid karat!");
                    return 0;
            }

            double price = weight * purity * priceFactor;
            return price;
        }

        public override string MetalType => "Gold";
    }

}

