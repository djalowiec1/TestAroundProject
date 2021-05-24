using System;

namespace TestAroundProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var LeetCode = new LeetCode(); //leetCode class 

            //28. needle in hay stack           
            string hayStack = "hello";
            string needle = "llo";
            
            int result = LeetCode.StrStr(hayStack, needle);



            

        }
    }

}
