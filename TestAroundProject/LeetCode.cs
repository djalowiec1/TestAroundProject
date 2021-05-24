using System;
using System.Collections.Generic;
using System.Text;

namespace TestAroundProject
{
    class LeetCode
    {
        public int StrStr(string hayStack, string needle)
        {
            int location = 0;
            bool found = false;
            //foreach(var item in hayStack)
            if (hayStack.Length > 0)
            {
                //if needle bigger neevr find
                if (hayStack.Length < needle.Length)
                {
                    found = true;  
                    location = -1;
                }
                    for (var i = 0; i < hayStack.Length && !found; i++)
                {
                    if (needle.Length > 0 && location <= 0)
                    {
                        if (hayStack[i] == needle[0])
                        {
                            //now check next one.
                            //if()
                            location = -1;
                            if (needle.Length > 1)
                            {
                                for (var j = 1; j < needle.Length; j++)
                                {
                                    if (i + j < hayStack.Length)
                                    {
                                        if (hayStack[i + j] != needle[j])
                                        {
                                            location = -2;
                                        }
                                        //at max and still 0 then send back
                                        if (j == needle.Length - 1 && location != -2)
                                        {
                                            location = i;
                                            found = true;
                                        }
                                    }
                                }
                            } else
                            {
                                location = i;
                                found = true;
                            }
                        } else
                        {
                            if(needle.Length > 0)
                            {
                                location = -1;
                            } 

                        }
                    }

                }
            } else
            {
                if (needle.Length > 0)
                {

                    location = -1;
                } 
            }
            //console
            Console.WriteLine("haystack: " + hayStack + "\n" +
                              "needle  : " + needle + "\n" +
                              "result  : " + location);
            return location;

        }
        public int StrStrBetter(string haystack, string needle)
        {
            int location = 0;
            bool done = false; 

            if (haystack == null && needle == null)
            {
                location = 0;
                done = true;
            }
            if(!done && haystack.Length < needle.Length)
            {
                location = -1; 
                done = true;
            }
           for (var i = 0; i < haystack.Length && !done; i++)
            {
                for (var j = 0; i < needle.Length; j ++)
                {
                    if (haystack[i + j] == haystack[j])
                    {
                        if (j == needle.Length - 1)
                        {
                            Console.WriteLine("haystack: " + haystack + "\n" +
                            "needle  : " + needle + "\n" +
                            "result  : " + i);
                            return i;
                        }
                    }
                }
            }

            Console.WriteLine("haystack: " + haystack + "\n" +
            "needle  : " + needle + "\n" +
             "result  : " + location);

            return location;
        }
    }
}
