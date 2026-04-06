using System;

namespace DiscountSolution.Services
{
    public interface IDiscountService
    {
        int ApplyDiscount(int price, bool isPremium);
    }

    public class DiscountService : IDiscountService
    {
        public int ApplyDiscount(int price, bool isPremium)
        {
            if (price < 0)
            {
                throw new ArgumentException("Price cannot be negative.", nameof(price));
            }

            if (price == 0)
            {
                return 0;
            }

            double finalPrice = isPremium ? price * 0.8 : price;

            return (int)Math.Round(finalPrice, MidpointRounding.AwayFromZero);
        }
    }
}
