using DocumentsDataInfo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Documents.Application
{
    internal class Documents 
    {
        [Document("This is id property")]
        public Guid _Id { get; set; }

        [Document("This is the User name property")]
        public string _Name { get; set; }
        public long _PhoneNumber { get; set; }

        public Documents()
        {

        }

        public Documents(Guid id, string name, long phoneNumber)
        {

            _Id = id;
            _Name = name;
            _PhoneNumber = phoneNumber;
        }

        [Document("This method performs a calculation.", "The input is a number.", "The output is the square of the input.")]
        public int Square(int number)
        {
            return number * number;
        }
    }

    public class Product
    {
        [Document("This is the Product id property")]
        public Guid _Id { get; set; }
        public string _Name { get; set; }
        public int _Quantity { get; set; }
        public decimal _Price { get; set; }
        public string _Category { get; set; }
        public int _OrderCount { get; set; }


        public Product()
        {

        }

        public Product(Guid id, string name, int quantity, decimal price, string category, int orderCount)
        {
            _Id = id;
            _Name = name;
            _Quantity = quantity;
            _Price = price;
            _Category = category;
            _OrderCount = orderCount;

        }


    }

    [Document("These are they Food i want to cook this Weekend")]
    enum Foods
    {
        FriedRice,
        JollofRice,
        EgusiSoup
    }


}
