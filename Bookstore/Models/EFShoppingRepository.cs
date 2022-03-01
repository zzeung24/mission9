using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Models
{
    public class EFShoppingRepository : IShoppingRepository
    {
        private BookstoreContext context;

        public EFShoppingRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Shopping> Shoppings => context.Shoppings.Include(x => x.Lines).ThenInclude(x => x.Books);

        public void SaveShopping(Shopping shopping)
        {
            context.AttachRange(shopping.Lines.Select(x => x.Books));

            if (shopping.ShoppingId == 0)
            {
                context.Shoppings.Add(shopping);
            }

            context.SaveChanges();
        }
    }
}
