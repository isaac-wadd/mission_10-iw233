
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< Updated upstream
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> Stashed changes

namespace bookApp.Models {
    public class Cart {
        public List<CartLineItem> items { get; set; } = new List<CartLineItem>();

<<<<<<< Updated upstream
        public virtual void AddItem(Books item, int qty) {
=======
        public void AddItem(Books item, int qty) {
>>>>>>> Stashed changes
            CartLineItem line = items
                .Where(x => x.book.BookId == item.BookId)
                .FirstOrDefault();
            if (line == null) {
                items.Add(new CartLineItem {
                    book = item,
                    quantity = qty
                });
            }
<<<<<<< Updated upstream
            else { line.quantity += qty; }
        }

        public virtual void RemoveItem(Books book) { items.RemoveAll(x => x.book.BookId == book.BookId); }

        public virtual void ClearCart() { items.Clear(); }

=======
            else {
                line.quantity += qty;
            }
        }
>>>>>>> Stashed changes
        public double getTotal() {
            double total = items.Sum(b => b.quantity * 25);
            return total;
        }
    }

    public class CartLineItem {
<<<<<<< Updated upstream

        [Key]
=======
>>>>>>> Stashed changes
        public int lineID { get; set; }
        public Books book { get; set; }
        public int quantity { get; set; }
    }
<<<<<<< Updated upstream
=======


>>>>>>> Stashed changes
}
