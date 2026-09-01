using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LibraryManagementSystem
{
    internal class MediaItem
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }

        public MediaItem(int id, string title, string category)
        {
            ItemId = id;
            Title= title;
            Category = category;
        }
        
    }
    [NonCirculating("Restricted")]
    internal class ReferenceMediaItem : MediaItem
    {
        public ReferenceMediaItem(int itemId, string title, string category): base(itemId, title, category)
        {
        }
    }

}
