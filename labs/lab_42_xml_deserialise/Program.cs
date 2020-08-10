using lab_42_xml_deserialise.Models;
using System;
using System.Xml.Resolvers;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace lab_42_xml_deserialise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();


            using (var db = new NorthwindContext())
            {
                products = db.Products.ToList();



            }
            products.ForEach(p => Console.WriteLine($"{p.ProductId,-10}{p.ProductName}"));

            var xmlProducts = new XElement(

                "Products",
                    from p in products
                    select new XElement("Product",
                        new XElement("ProductID", p.ProductId),
                        new XElement("ProductName", p.ProductName),
                        new XElement("UnitPrice", p.UnitPrice)
                    )
                );

            var xmlProductsDoc = new XDocument(xmlProducts);
            xmlProductsDoc.Save("Products.xml");

            using (var reader = new StreamReader("Products.xml"))
            {
                var serializer = new XmlSerializer(typeof(Products));
                var xmlProductsReadFromInternet = (Products)serializer.Deserialize(reader);
                Console.WriteLine(xmlProductsReadFromInternet);


            }
        }
    }
        
        [XmlRoot("Products")]
        public class Products
        {
            [XmlElement("Product")]
            public List<Product> XMLProductsFromBrazil { get; set; }
        }

}
