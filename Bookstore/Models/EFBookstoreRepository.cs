﻿using System;
using System.Linq;

namespace Bookstore.Models
{
    public class EFBookstoreRepository: IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Books> Books => context.Books;

    }
}
