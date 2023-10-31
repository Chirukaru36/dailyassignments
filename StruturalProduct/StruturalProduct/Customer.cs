using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StruturalProduct
{
    public class Customer
    {
        public int custId {  get; set; }
        public string custName { get; set; }
        public string custAddress { get; set;}
        public string custCity { get; set;}

    }

    public class CustomerProduct
    {
        public int custId { get; set; }
        public List<Products> Products { get; set; }
    }

    public class Products
    {
        public int prodId { get; set; }
        public string prodName { get; set; }
        public string price { get; set; }
    }
}
