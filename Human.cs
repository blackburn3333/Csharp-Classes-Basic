using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest
{
    class Human
    {
       private string name;
       private int age, gender;
       private bool civil_status;
       
        public Human(string name,int gender,int age,bool civil_status)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.civil_status = civil_status;
        }

        public void person_details()
        {
            string person_gender = generate_civil_status();
            string[] gender_type = generate_generator();
            Console.WriteLine("My name is {0} and im {1} years old. im {2} im {3}",name,age, gender_type[0], person_gender);
        }

        private string generate_civil_status()
        {
            return civil_status ? "Marred" : "Single";
        }

        public void work(int type)
        {
            string[] gender_type = generate_generator();
            string work = generate_work(type);
            Console.WriteLine("This is {0}, {1} is {2} now.",name,gender_type[1],work);
        }


        private string generate_work(int type)
        {
            switch (type)
            {
                case 0:
                    return "Walking";
                case 1:
                    return "Running";
                case 3:
                    return "Sleeping";
                case 4:
                    return "Working";
                default:
                    return "Not doing anything";
            }
        }

        private string[] generate_generator()
        {
            string[] male = { "Male", "He" };
            string[] female = { "Female", "She" };

            return gender == 0 ?male : female;
        }
    }
}
