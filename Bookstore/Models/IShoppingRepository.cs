using System;
using System.Linq;

namespace Bookstore.Models
{
    public interface IShoppingRepository
    {
        IQueryable<Shopping> Shoppings { get; }

        void SaveShopping(Shopping shopping);
    }
}
