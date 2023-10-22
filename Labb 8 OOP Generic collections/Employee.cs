using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8_OOP_Generic_collections
{
    internal class Employee
    {
        public string ID { get; set; }      //Egenskaper för anställda
        public string Name { get; set; }
        public string Gender; /*{ get; set; }*/
        public int Salary { get; set; }

        public Employee(string id, string name, string gender, int salary)      //Konstruktor för att sedan kunna sätta värden i main 
        {
            ID = id;        //Initierar värden från konstruktor till egenskaper
            Name = name;
            Gender = gender;
            Salary = salary;

        }
        //Kör override på ToString för att inte använda metoden som ligger i system, vill använda en egen som ligger i klassen.
        //Använder ToString för att jag vill på ett enkelt sätt returnera en sträng som inehåller egenskaperna och informationien
        //som är sparat i objekten. Jag gör om objektet till dess sträng den representerar. 
      
     
       
        public override string ToString()       
        {
            string list= ($"ID: {ID}, Namn: {Name}, Kön: {Gender}, Lön: {Salary}");
            return list;
        }
    }
}
