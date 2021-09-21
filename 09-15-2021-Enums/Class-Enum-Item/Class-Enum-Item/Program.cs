using Class_Enum_Item.Data;
using System;
using System.Collections.Generic;

namespace Class_Enum_Item
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employment> jobs = new List<Employment>();
            
            //declare and load employment instance seperatly
            //Default Constructor
            Employment job1 = new Employment();
            //Property set
            job1.Title = "Lab Assistant";
            //the level property has a private set, so you cannot directly assign a value to the Level property
            //instead, use the method provided which will assign the given argument value to the property
            job1.SetEmployeeResponsibility(SupervisoryLevel.TeamLeader);
            job1.Years = 7.4;

            jobs.Add(job1); //add to the job List<T> Where T is the Employment

            //Declare and load Employment using constructor
            //We can reuse the Employment variable job1 BECAUSE we are creating a new instance of the Employment class
            //Greedy Constructor
            job1 = new Employment("Lab Research", SupervisoryLevel.TeamMember, 5.8);
            jobs.Add(job1);

            //Declare and load Employment instance using object instantiation
            job1 = new Employment()
            {
                Title = "Gander Cooking Club",
                Years = 1.2
            };
            job1.SetEmployeeResponsibility(SupervisoryLevel.Owner);
            jobs.Add(job1);

            Person me = new Person()
            {
                FirstName = "Jacob",
                LastName = "Dunbar",
                EmploymentPositions = jobs
            };

            //Display the contents of Person
            Console.WriteLine("Person:\n");
            Console.WriteLine($"{me.LastName}, {me.FirstName}:\n");
            Console.WriteLine("Past/Present Employment:\n");
            foreach(Employment item in me.EmploymentPositions)
            {
                Console.WriteLine($"\t{item.ToString()}");
            }
            /*
            Employment badJob;
            Person badPerson;
            try
            {
                //badJob = new Employment("testing bads", SupervisoryLevel.TeamMember, 5.8);
                badPerson = new Person()
                {
                    FirstName = "",
                    LastName = ""
                };
            }
            catch(Exception ex)
            {
                Console.WriteLine($"***********\n{ex.Message}\n***********");
            }
            */
        }
    }
}
