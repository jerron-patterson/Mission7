using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private BookstoreContext context { get; set; }
        public EFBookStoreRepository (BookstoreContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Book> Books => context.Books;
    }
}