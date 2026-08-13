using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    internal class StackSpan
    {
        public List<int> calculateSpan(int[] arr)
        {

            // Brute Force Approach
            // List<int> list= new List<int>();
            // for(int i=arr.Length-1;i>=0;i--){
            //     int count=1;
            //     int x=i;
            //     for(int j=i-1;j>=0;j--){
            //         if(arr[i]>=arr[j]){
            //             count++;
            //         }
            //         else{
            //             i=-1;
            //             break;
            //         }
            //     }
            //     i=x;
            //     list.Insert(0,count);
            // }
            // return list;

            // Optimized Solution

            List<int> list = new List<int>();
            Stack<int> st = new Stack<int>(); // store indicies

            st.Push(0);
            list.Add(1);

            for (int i = 1; i < arr.Length; i++)
            {
                while (st.Count != 0 && arr[st.Peek()] <= arr[i])
                {
                    st.Pop();
                }
                int span = 1;
                if (st.Count == 0)
                {
                    span = i + 1;
                }
                else
                {
                    span = i - st.Peek();
                }
                list.Add(span);
                st.Push(i);
            }
            return list;
        }
    }
}
