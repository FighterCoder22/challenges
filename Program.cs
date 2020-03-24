//Problem:
//-------------
//Given an array arr[] and a number K where K is smaller than size of array, the task is to find the Kth smallest element in the given array.It is given that all array elements are distinct.
//Expected Time Complexity: O(n)

//Input:
//The first line of input contains an integer T, denoting the number of testcases.Then T test cases follow.Each test case consists of three lines.First line of each testcase contains an integer N denoting size of the array.Second line contains N space separated integer denoting elements of the array. Third line of the test case contains an integer K.


//Output:
//Corresponding to each test case, print the kth smallest element in a new line.

//Constraints:
//1 <= T <= 100
//1 <= N <= 105
//1 <= arr[i] <= 105
//1 <= K <= N

//Example:
//Input:
//2
//6
//7 10 4 3 20 15
//3
//5
//7 10 4 20 15
//4
//Output:
//7
//15

//Explanation:
//Testcase 1: 3rd smallest element in the given array is 7.
//Testcase 2: 4th smallest elemets in the given array is 15.
//---------------------------------------------------------------------

//Solution:
//------------

using System;

namespace Practice2
{
    class tasks
    {
        public int FindKthSmallest(int N, int K, int[] arr1)
        {
            Array.Sort(arr1);
            return arr1[K - 1];
        }
    }
    public class GFG
    {
        static public void Main()
        {
            tasks mytask = new tasks();
            int T, N, K;
            string t = string.Empty;
            T = 0;
            t = Console.ReadLine(); //T - number of testcases
            T = Convert.ToInt32(t);
            string n, k;
            int opval = 0;
            while (T >= 1 && T <= 100)
            {
                opval = 0;
                N = 0; K = 0;
                n = string.Empty;
                k = string.Empty;
                n = Console.ReadLine();
                N = Convert.ToInt32(n); //N - size of the array
                string arrayString = Console.ReadLine();
                k = Console.ReadLine();
                K = Convert.ToInt32(k); //Kth smallest element to find
                if (string.IsNullOrEmpty(arrayString) || string.IsNullOrWhiteSpace(arrayString)) return;
                arrayString = (arrayString.TrimEnd()).TrimStart();
                string[] strarray = arrayString.Split(' ');

                int[] arr1 = Array.ConvertAll(strarray, x => int.Parse(x));

                //List<int> arr = new List<int>(); // arr - has the array elements
                if (strarray.Length == 0) return;
                if (T > 100 || T < 1) return;
                if (N < 1 || N > Math.Pow(10, 5)) return;
                if (N == 1 && (K <= 1)) return;
                if (K < 1 || K > N) return;
                if (N >= 1 && N <= (Math.Pow(10, 5)) && K <= N && K >= 1)
                {
                    //function to find the kth smallest element
                    opval = mytask.FindKthSmallest(N, K, arr1);
                    Console.WriteLine(opval);//Output
                    T--; //last line of while loop
                }
            }
            return;
        }
    }
}
