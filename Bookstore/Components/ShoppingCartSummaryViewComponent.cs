using System;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Components
{
    public class ShoppingCartSummaryViewComponent : ViewComponent
    {
        private Basket basket;

        public ShoppingCartSummaryViewComponent(Basket basketService)
        {
            basket = basketService;
        }

        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
