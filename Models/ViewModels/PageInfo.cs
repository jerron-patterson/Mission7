using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models.ViewModels
{
    public class PageInfo
    {
        public int TtlNumBooks { get; set; }
        public int BooksPerPg { get; set; }
        public int CurrentPg { get; set; }
        public int TtlPgs => (int) Math.Ceiling((double) TtlNumBooks / BooksPerPg);
    }
}
