using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays

            int[] numArray = new int[10];
            int[] newNumArray = {0,1,2,3,4,5,6,7,8,9};
            string[] nameArray = new string[4];
            string[] newNameArray={"Tim", "Martin", "Nikki", "Sarah"};
            bool[] boolArray = new bool[10];
            bool[] newBoolArray = {true, false, true, false, true, false, true, false, true, false};
            
            //List of Flavors

            string[] icecreamArray;
            icecreamArray = new string[] {"Vanilla", "Chocolate", "Rainbow Sherbet", "Rocky Road", "Fudge Brownie"};
            Console.WriteLine($"Length of Icecream Array: {icecreamArray.Length}");
            List<string> icecream = new List<string>();
            icecream.Add("Vanilla");
            icecream.Add("Chocolate");
            icecream.Add("Rainbow Sherbet");
            icecream.Add("Rocky Road");
            icecream.Add("Fudge Brownie");
            Console.WriteLine("Types of Icecream: ");
            for (var i=0; i < icecream.Count; i++){
                Console.WriteLine($"Flavor: {icecream[i]}");
            }
            Console.WriteLine(icecream[2]);
            icecream.Remove("Rainbow Sherbet");
            Console.WriteLine("New Icecream List:");
            foreach (string x in icecream)
            {
            Console.WriteLine("-" + x);
            }

            Random randomNumber = new Random();
            Console.WriteLine("List of People and their favorite Icecream: ");
            Dictionary<string,string> icecreamPeople = new Dictionary<string,string>();
            for (var i=0; i<newNameArray.Length; i++){
                icecreamPeople.Add(newNameArray[i], icecream[randomNumber.Next(0,4)]);
            }
            foreach (KeyValuePair<string,string> item in icecreamPeople)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
            
        }
    }
}
