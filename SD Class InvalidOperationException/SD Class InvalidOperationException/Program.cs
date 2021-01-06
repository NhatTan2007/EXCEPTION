using System;
using System.Collections.Generic;

namespace SD_Class_InvalidOperationException
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPeople = new List<Person>(5);
            Person firstPerson = new Person("tan", 2, "male", 56, 173, "blue", "yellow");
            Person secondPerson = new Person("ly", 2, "female", 24, 133, "black", "black");
            Person thirdPerson = new Person("phuong", 5, "female", 42, 156, "black", "black");
            listOfPeople.Add(firstPerson);
            listOfPeople.Add(secondPerson);
            listOfPeople.Add(thirdPerson);
            try
            {
                foreach (var item in listOfPeople)
                {
                    listOfPeople.Remove(firstPerson);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
