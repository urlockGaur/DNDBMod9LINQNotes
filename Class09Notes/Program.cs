﻿using System.Linq;

namespace Class09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IList<string> myList = new List<string>();


            myList.Add("dog");
            myList.Add("cat");
            myList.Add("pig");
            myList.Add("cow");
            myList.Add("chicken");
            myList.Add("pig");
            myList.Add("horse");

            ////Console.WriteLine("Enter the search term: ");
            ////var searchTerm = Console.ReadLine();

            // how to we pass in our search term
            //var results = myList.Where(item => MyFunction(item)); //references or goes to a method); //Where returns a list Func<T, TResult> T = parameter TResult = output
            //item is placeholder for list items - below it is ph at first item

            // normally use x or other letter in place of item, etc
            //// var results = myList.Where(item => item == searchTerm).ToList(); //does item = search term? Returns true of false
            // var results = myList.Where(MyFunction); //shorthand of above



            //.toList - will use this alot
            //// Console.WriteLine($"Results: ");
            //// results.ForEach(item => Console.WriteLine(item)); //iterating over list of results

            //LINQPAD - DOWNLOAD/INSTALL IT AT HOME
            //LINQ OFFERS A BETTER WAY TO DO THIS
            //foreach (var item in myList)
            //{
            //  if (searchTerm == item)
            //{
            //  Console.WriteLine($"Found {item}! ");
            //break;
            //}
            //}

            //take and skip
           ///// var pageSize = 3;
            /////var pageNumber = 0;// first page
           ///// var results = myList.Skip(pageSize*pageNumber).Take(pageSize).ToList(); //order of ops matters. have to undertand builder pattern
          
           ///// results.ForEach(Console.WriteLine);

            /////Distinct
            /////var results2 = myList.Distinct().ToList();
           ///// results2.ForEach(Console.WriteLine);

            Console.WriteLine("************************");

            /////if (results2.Any())
           ///// {

           ///// }
            //contains
           ///// results2.Contains("pig");

           var result = myList.FirstOrDefault(x => x == "horse");
            Console.WriteLine(result);

        }
        
    }
}
