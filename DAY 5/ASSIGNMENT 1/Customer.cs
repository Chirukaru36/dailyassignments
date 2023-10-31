using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_1
{
    public interface IOperations
    {
        void AddToCart(int prodid, string city, int qty, int price);
        void PaymentGateway(int amt);
        void BuyNow();
    }
    public class Customer
    {
		public int custid {  get; set; }
        public string custname { get; set; }

	}




}
