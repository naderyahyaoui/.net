using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Service;
using MyFinance.Domain.Entities;

namespace MyFinance.Console
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IProductService MyService = new ProductService();

            MyService.Add(new Product { Name = "Pomme de terre", Category = new Category { Name ="AA"} });
            MyService.Commit();

        }
    }
}
