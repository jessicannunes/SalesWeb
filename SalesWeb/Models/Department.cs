using System.Collections.Generic;
using System.Linq;
using System;
namespace SalesWeb.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        //constructor without arguments
        public Department()
        {
        }

        //constructor with arguments
        public Department(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime inital, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(inital, final));
        }
    }
}
