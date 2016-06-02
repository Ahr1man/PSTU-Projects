using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Print
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public Print(string Name, string Author)
        {
            this.Name = Name;
            this.Author = Author;
        }

        public abstract void Display();
    }

    public class Book : Print
    {
        public string Publishing_House { get; set; }
        public string Year { get; set; }

    }


}
