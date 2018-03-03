using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] toyArray = { "action figure", "doll", "legos" };

            List<string> toyList = new List<string>() { "action figure", "stuffed animal", "legos" };

            toyList.Add("Barbie");
            toyList.Add("remote control car");
            toyList.Add("yo-yo");

            //foreach(string toy in toyList)
            //{
            //    Console.WriteLine(toy);
            //}

            //the properties and methods we will use the most are
            //.Count
            //.Insert()
            //.Add()
            //.Remove()

            Console.WriteLine(toyList.Count);

            toyList.Remove("Barbie");
            Console.WriteLine(toyList.Count);

            //Insert allows us to put a new element in the list and
            //Specify which index we want for that element

            toyList.Insert(0, "kite");
            toyList.Insert(2, "baby doll");
            toyList.Insert(1, "plastic dinosaur");

            //foreach(string toy in toyList)
            //{
            //    Console.WriteLine(toy);
            //}

            //Another method that will often use is .Contains()
            //It returns a boolean value

            if(toyList.Contains("plastic dinosaur"))
            {
                Console.WriteLine("Daniel would never buy the dino");
            }
            else
            {
                Console.WriteLine("Daniel might buy many of these toys.");
            }

            List<bool> shelfStatus = new List<bool>() { true, false, true, true, false };
            for(int i = 0; i < shelfStatus.Count; i++)
            {
                if(shelfStatus[i] == true)
                {
                    Console.WriteLine("There are toys in this shelf");
                }
                else if(shelfStatus[i] == false)
                {
                    Console.WriteLine("This shelf is empty");

                }
                else
                {
                    Console.WriteLine("You broke the code");
                }

            }

            //create a liste. add five stuffed animals to your list
            //print each stuffed animal in your list

            List<string> stuffedAnimals = new List<string> { "bear", "dog", "cat", "pig", "snake" };

            foreach(string animal in stuffedAnimals)
            {
                Console.WriteLine(animal);
            }


            List<int> numList = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5, };

            






            List<string> employeeNames = new List<string>();
        }
    }
}
