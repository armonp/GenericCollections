using System;
using System.Collections.Generic;

namespace GenericCollections {
    class Program {
        static void Main(string[] args) {
            #region generic collection
            var ints = new List<int>(); //new generic collection named ints. Needs System.Collections.Generic namespace
            ints.Add(1);
            ints.Add(2); //adds to end of the List
            ints.Add(3);
            Console.WriteLine($"Number of ints {ints.Count}"); //Count is a property to find length

            foreach (int anInt in ints) {
                Console.Write($" {anInt} ");
            }

            ints.Remove(2);
            Console.WriteLine($"Number of ints {ints.Count}");
            foreach (int anInt in ints) {
                Console.Write($" {anInt} ");
            }

            var names = new List<string>();
            names.Add("Ian"); names.Add("Robbie"); names.Add("Danae"); names.Add("Traci"); names.Add("Vaugh"); names.Add("Manish"); names.Add("George"); names.Add("Parker"); names.Add("Sarah"); names.Add("David"); names.Add("Armon"); names.Add("Laura");

            foreach (string name in names) { Console.WriteLine($"Student name: {name}"); }
            #endregion
            #region generic array of strings
            var customers = new List<Customer>(); //type of list is Customer. Class created in customer.cs
            var amazon = new Customer(1, "Amazon", true);
            var pg = new Customer(2, "P&G", true);
            var meijer = new Customer { Active = true, Id = 3, Name = "Meijer" }; //preferred syntax, you can omit properties that can be null or default
            var target = new Customer { Id = 4, Name = "Target" };
            var microsoft = new Customer { Id = 5, Name = "Microsoft", Active = false };

            customers.Add(amazon);
            customers.Add(pg);
            var custArray = new Customer[] { meijer, target, microsoft };
            customers.AddRange(custArray); //AddRange adds an array to a collection

            foreach (Customer cust in customers) {
                if (cust.Active == true) {
                    Console.WriteLine($"Custer Id: {cust.Id}, Customer name is: {cust.Name}, Active: {cust.Active} ");
                }
            }
            #endregion
            #region Name of Customer whose Id is 3
            var custName = "Not Found";
            foreach (Customer cust in customers) {
                if (cust.Id == 3) {
                    custName = cust.Name;
                    break;
                }
            }
            Console.WriteLine($"{custName}");
            #endregion
            #region Dictionary
            //var D = new Dictionary<int, Customer>();  
            //pass a primary key value and give one value that matches 
            var custDictionary = new Dictionary<int, Customer>();
            //add items to dictionary
            custDictionary.Add(amazon.Id, amazon);
            custDictionary.Add(target.Id, target);
            custDictionary.Add(meijer.Id, meijer);
            custDictionary.Add(pg.Id, pg);
            custDictionary.Add(microsoft.Id, microsoft);

            var custName2 = custDictionary[3];
            Console.WriteLine($"Customer id 3 is {custName2.Name}");
            //better to skip defining variable that is only used once
            Console.WriteLine($"Customer id 2 is {custDictionary[2].Name}");

            foreach (var key in custDictionary.Keys) {
                var customer = custDictionary[key];
                Console.WriteLine($"{customer.Name}");
            }
            #endregion
 
        } //main
    } //program
} //namespace
