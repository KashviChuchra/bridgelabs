using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class TextNode
    {
        public string Text;
        public TextNode Next;
        public TextNode Prev;

        public TextNode(string text)
        {
            Text = text;
            Next = null;
            Prev = null;
        }
    }
    internal class UndoRedo
    {
    }
}
