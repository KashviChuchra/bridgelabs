using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    internal class SortedStack
    {
        public void insertSorted(Stack<int> st, int x)
        {
            if (st.Count == 0 || st.Peek() < x)
            {
                st.Push(x);
                return;
            }
            int top = st.Pop();
            insertSorted(st, x);
            st.Push(top);
        }
        public void sortStack(Stack<int> st)
        {
            if (st.Count == 0) return;

            int top = st.Pop();
            sortStack(st);
            insertSorted(st, top);
        }
    }
}
