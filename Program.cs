using System;
using System.Collections;

namespace Collections // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic 
            List<int> numberList = new List<int>();

            numberList.Add(25);
            numberList.Add(20);
            numberList.Add(30);

            // Count
            Console.WriteLine(numberList.Count);

            // Print
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }

            // Custom Object in List
            List<Users> userList = new List<Users>();

            Users user1 = new Users();
            user1.Name = "Kemal";
            user1.Surname = "Saybakan";
            user1.Age = 36;

            Users user2 = new Users();
            user2.Name = "Aygul";
            user2.Surname = "Yakupoglu";
            user2.Age = 36;

            userList.Add(user1);
            userList.Add(user2);

            /////////////////////////////////////////////

            // ArrayList
            // System.Collections Namespace

            ArrayList list = new ArrayList();
            list.Add("Kemal");
            list.Add(36);
            list.Add(true);

            // Access for each
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Add range 
            ArrayList newList = new ArrayList();

            //string[] colors = { "red", "yellow", "yeşil"};
            List<int> numbers = new List<int>(){1,2,3};

            //newList.AddRange(colors);
            newList.AddRange(numbers);

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }

            // Binary Search
            Console.WriteLine("Binary Search");
            newList.BinarySearch(3);

            // Clear
            newList.Clear();

            /////////////////////////////////////////////

            // System.Collection.Generic
            // Dictionary 
            Dictionary<int, string> employers = new Dictionary<int, string>();
            employers.Add(5, "Kemal Saybakan");
            employers.Add(6, "Aygul Yakupoglu");

            // Access
            Console.WriteLine(employers[5]);

            // Contains 
            Console.WriteLine(employers.ContainsKey(6));
            Console.WriteLine(employers.ContainsValue("Kemal Saybakan"));

        }
    }

    public class Users
    {
        private string name;

        private string surname;

        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}