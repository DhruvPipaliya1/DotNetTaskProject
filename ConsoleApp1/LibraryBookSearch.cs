using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class LibraryBookSearch
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public bool Available { get; set; }

        public LibraryBookSearch(string title, string category, bool available)
        {
            Title = title;
            Category = category;
            Available = available;
        }
    }
}
