using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("C# Clas basics!");

            string name = "Jayendra Matarage";
            int gender = 0; //0 = male and 1 = female
            int age = 12;
            bool civil_status = false; //false = single true = married

            //create human object
            Human human = new Human(name, gender, age, civil_status);
            //view human
            human.person_details();
            //view work of human
            human.work(1); //0 = walking 1 = running 3 = sleeping 4 = working


            Console.ReadKey();
            
        }


        
    }
}
