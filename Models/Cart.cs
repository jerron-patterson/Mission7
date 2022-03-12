using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public class Cart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public virtual void AddItem (Book bro, int qty)
        {
            CartItem Line = Items
                .Where(b => b.Book.BookId == bro.BookId)
                .FirstOrDefault();

            if (Line == null)
            {
                Items.Add(new CartItem
                {
                    Book = bro,
                    Quantity = qty
                });
            }
            else
            {
                Line.Quantity += qty;
            }
        }
        public double CalTot()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);
            return sum;
        }
        public virtual void RemoveItem (Book book)
        {
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }
        public virtual void ClearCart()
        {
            Items.Clear();
        }
    }
    public class CartItem
    {
        [Key]
        public int ItemID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
