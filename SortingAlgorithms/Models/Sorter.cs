using System;
using System.Collections.Generic;

namespace SortingAlgorithms.Models
{
    public class Sorter
    {
        //int k = 0;
        // public List<int> Integers = new List<int>(){};

        // public void AddInteger()
        // {
        //     string userInput = Console.ReadLine();
        //     if (userInput!="q" && userInput!="Q")
        //     {
        //         int newInt = int.Parse(userInput);
        //         Integers.Add(newInt);
        //         this.AddInteger();
        //     }
        //     else
        //     {
        //         //Console.WriteLine(this.MySort());
        //     }
        // }

        // public void BubbleSort()
        // {
        //     int unsortedItems = Integers.Count;
        //     for(int j = 0; j <Integers.Count; j++)
        //     {            
        //         for(int i = 0; i < unsortedItems-1; i++)
        //         {
        //             if(Integers[i]>Integers[i+1])
        //             {
        //                 int largerValue = Integers[i];
        //                 Integers[i] = Integers[i+1];
        //                 Integers[i+1] = largerValue;
        //             }
        //             else
        //             {}
        //         }
        //         unsortedItems--;
        //     }
        //     foreach (int integer in Integers)
        //     {
        //         Console.WriteLine(integer);
        //     }
        // }
        

        // public void InsertSort()
        // {
        //     int length = arr.Count;
            
        //     for (var i=1; i<length; ++i)
        //     {
        //         int m = i;
        //         while(m>0 && arr[m]<arr[m-1])
        //         {
        //             ++k;
        //             Console.WriteLine("Movements: " + k);
        //             int swap = arr[m-1];
        //             arr[m-1]=arr[m];
        //             arr[m]=swap;
        //             --m;
        //         }
                
        //     }
        //     foreach(int num in arr)
        //     {
        //         Console.WriteLine(num);
        //     }
        // }

        // public void MergeSort()
        // {

        // }

        
        private List<int> arr = new List<int>()
        {100,3,3, 3, 4002, 425, 24, 435, 2425, 1, 6, 7};

        public List<int> GetList()
        {
            return arr;
        }
    
        int m=6;
        public void RunList(List<int> arr)
        {   
            int max= arr.Count;
            int c=0;
            int length = arr.Count;

            List<int> rightSide = new List<int>(){};
            List<int> leftSide = new List<int>(){};
            c=0;

            for (int i=0; i<max; i++)
            {
                
                if(arr[c]<arr[i])
                {
                    rightSide.Add(arr[i]);
                }
                else if(arr[c]>arr[i])
                {
                    leftSide.Add(arr[i]);
                }
            }
            int duplicates = arr.Count -(leftSide.Count+rightSide.Count);
            if(duplicates==arr.Count)
            {
                Console.WriteLine("Congrats! " + arr[0]);
            }
            else
            {
                Console.WriteLine("Left Side");
                foreach(int num in leftSide)
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine("Right Side");
                foreach (int num in rightSide)
                {
                    Console.WriteLine(num);
                }
                if(leftSide.Count>=m)
                {
                    if(leftSide.Count!=m)
                    {
                        this.RunList(leftSide);
                    }
                    else
                    {
                        Console.WriteLine("Success Via Left Side! " + arr[0]);
                    }
                }
                else
                {
                    m-=leftSide.Count+(duplicates);
                    if (m==0)
                    {
                        Console.WriteLine("Success via right side?!" + arr[0]);
                    }
                    else
                    {
                        this.RunList(rightSide);
                    }
                }
            }
            
        }


        


            // while(previousLocation!=m)
            // {
            //         //m is still in right side of array
            //         c=min;
            //         for(i=min; i<max; i++)
            //         {
            //             if(arr[c]<arr[i])
            //             {
            //                 arr.Insert(max, arr[i]);
            //                 arr.RemoveAt(i);
            //             }
            //             else if(arr[c]>arr[i])
            //             {
            //                 arr.Insert(min, arr[i]);
            //                 arr.RemoveAt(i+1);
            //                 c++;
            //             }
            //             else
            //             {
            //                 Console.WriteLine("Congratulations! Array at " + c + " equals " + " array at " +i);
            //             }
                        
            //         }
            //         previousLocation = c;
            //         if(previousLocation<m)
            //         {
            //             min = previousLocation+1;
            //             Console.WriteLine("New min is array index " + min);
            //         }
            //         else if(previousLocation>m)
            //         {
            //             max = previousLocation-1;
            //             Console.WriteLine("New max is array index " + max);
            //         }
            //     }
        
                //Console.WriteLine(c);
        //     foreach(int num in arr)
        //     {
        //         Console.WriteLine(num);
        //     }
        //     Console.WriteLine("number at index " + m + " is " + arr[m]);
        //     return arr[m];
        // }


        // public bool MySort()
        // {
        //     Console.WriteLine("Pick an index of your list and I'll tell you if it's sorted");
        //     int startingPoint = int.Parse(Console.ReadLine());
        //     int listLength=Integers.Count;
        //     int counter=0;
        //     for (int i = 0; i < listLength; i++)
        //     {       
        //         if(Integers[startingPoint] > Integers[i])
        //         {
        //             counter++;
        //         }
        //         else{}
        //     }
        //     if(counter==startingPoint)
        //     {
        //        return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        //}
    }
}