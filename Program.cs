using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLibrary
{
    public class Program
    {
        //UC_1
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Collection libarary");

           List<Person> listperson = new List<Person>();
            AddRecords(listperson);
           DuplicateEntry(listperson);
            SerchPerson(listperson);
            SerchNumber(listperson);
            
        }

       // UC_2
        private static void AddRecords(List<Person> listperson)
        {
            listperson.Add(new Person("Pratik", "Chitruk", "junabudhawar peth", "kolhapur", 8208508814, "pratik.chitruk@gmail.com", 416002, "india"));
            listperson.Add(new Person("Rohit", "satpute", "vathar", "kolhapur", 8854775466, "rohit.satpute@gmail.com", 416005, "india"));

        }

       // UC_3

        private static void DuplicateEntry(List<Person> listPerson)
        {
            if (listPerson.Count != listPerson.Distinct().Count())
            {
                Console.WriteLine("duplicate");

            }
            else
            {
                Console.WriteLine("No duplicate");
            
            }
        }

        //UC_4

        private static void SerchPerson(List<Person> listPerson)
        {
            foreach (Person oPerson in listPerson.FindAll(e => (e.City == "kolhapur")))
            {

                Console.WriteLine("PERSONS IN KOLHAPUR" + oPerson.FirstName);
            }
      
        
        }

        //UC_5

        private static void SerchNumber(List<Person> listPerson)
        {
            foreach (Person oPerson in listPerson.FindAll(e => (e.City == "kolhapur" )))
            {

                Console.WriteLine("number of contact person" + oPerson.Phone);
            }


        }



    }
}