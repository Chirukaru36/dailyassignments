using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_1
{
    internal class Program
    {
        public interface IOperations
        {
            void AddToCart(int prodid, string city, int qty, int price);
            void PaymentGateway(int amt);
            void BuyNow();
        }
        static void Main(string[] args)
        {

        }
    }
}
