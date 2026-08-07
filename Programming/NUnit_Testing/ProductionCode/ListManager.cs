using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionCode
{
    public class ListManager
    {
        List<int> list = new List<int>();
        public void AddElement(List<int> list, int elements)
        {
            list.Add(elements);
        }
        public void RemoveElement(List<int> list, int element)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] == element)
                {
                    list.RemoveAt(i);
                }
            }

        }
        public int GetSize() { return list.Count; }
    }
}
