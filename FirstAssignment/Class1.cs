using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAssignment
{
    internal class BOOK
    {
        public string title;
        public int pages;

        public override string ToString()
        {
            return $"title = {title}, pages {pages}";
        }
    }
}