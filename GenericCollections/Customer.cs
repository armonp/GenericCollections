using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections {
    class Customer {
        public int Id {get; set;}
        public string Name {get; set;}
        public bool Active { get; set; } = true; //Active set to true by default

        public Customer(int Id, string Name, bool Active) { //constructor
            this.Id = Id; //this.property = parameter
            this.Name = Name;
            this.Active = Active;
        }
        public Customer() { } //default constructor, included by default but is erased after constructor is defined
    }
}
