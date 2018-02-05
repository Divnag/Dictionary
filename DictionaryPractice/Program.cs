using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax-Dictionary<key dta type,value data type>dictionary name
            Dictionary<String, int> studentGrades = new Dictionary<string, int>()
            {
                {"Kerry",90 },
                {"Barry",85 },
                {"Michelle",100 }
            };


            Dictionary<String, String> snackMachine = new Dictionary<string, string>()
            {
                {"A1","Snickers" },
                {"A2","Swedish Fish" },
                {"A3" ,"Sour patch Kids"},
                {"A4","Funyuns\n" }
            };

            Dictionary<int, String> drinkMachine = new Dictionary<int, string>();
            //using add method ,lets add drinks to our drink machine
            //this machine uses just number to vend an item instead of a letter number pair

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Bottled water");
            drinkMachine.Add(12, "Soda");
            drinkMachine.Add(13, "milk");
            drinkMachine.Add(14, "orange Juice");
            drinkMachine.Add(15, "Sparkled water\n");


            //count is a property.Returns the size of the dictionary
            Console.WriteLine(drinkMachine.Count);



            //we have another property,called .key and .value
            foreach (KeyValuePair<int, String> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }

            foreach (KeyValuePair<int, String> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }


            //create adictionary for a theater coat check with 10 elements
            //the key will be a number and the value will be the coat style
            //print all values to the console

            Dictionary<int, String> coatStyles = new Dictionary<int, string>()
            {
                {1,"Long coat" },
                {2,"Wool coat" },
                {3,"Leather Jacket" },
                {4,"Black Leather jacket " },
                {5,"Blazer" },
                { 6,"Long coat" },
                { 7,"Wool coat" },
                { 8,"Leather Jacket" },
                { 9,"Black Leather jacket " },
                { 10,"Blazer\n" }
            };

            foreach (KeyValuePair<int, string> style in coatStyles)
            {
                Console.WriteLine(style.Value);
            }


            //Create  a dictionary for a car valet services with 10 cars
            //The key will be customers last name and the value
            //will be the car make .Print all keys to the console.

            Dictionary<String, String> carValet = new Dictionary<String, string>()
            {
                {"london","Toyota" },
                {"alex","Mazda" },
                {"joseph","Honda" },
                {"barr","kia " },
                {"beth","jeep" },
                { "sus","toyota" },
                { "marin","honda" },
                { "catholic","BMW" },
                { "bap","Benz " },
                { "paschal","Acura \n" }
            };

            foreach (KeyValuePair<string, string> lastname in carValet)
            {
                Console.WriteLine(lastname.Key);
            }
            //create a dictionary of 10 zoo animals.the key will be 
            // the animlas type and the value will be the number of that
            //animal type at the zoo.print the animal with the highest quantity to the console

            Dictionary<String, int> zooAnimals = new Dictionary<string, int>()
            {
                {"Monkey",5},
                {"Elephant",4 },
                {"Flemingo",6 },
                {"Lion",3 },
                {"Tiger",1 },
                {"Gorilla",2 },
                {"Zibra" ,2},
                {"Kangaroo",10 },
                {"Bear",2 },
                {"Camel",2 }


            };
            int highest = 0;
            foreach (KeyValuePair<String, int> animals in zooAnimals)
            {

                if (animals.Value > highest)
                {
                    highest = animals.Value;
                }

            }
            foreach (KeyValuePair<string, int> animals in zooAnimals)

            {
                if(animals.Value==highest)
                {
                    Console.WriteLine("\n"+animals.Key);
                }
            }
        }
    }
}

