using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Data;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotChocoAuthExample.GraphQL
{
    public class Query
    {
        [Authorize(Policy = "TestValidate")]
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        public IEnumerable<Book> GetBooks() => new List<Book>
        {
            new Book { name = "Harry Potter" },
            new Book { name = "Boxcar Children" }
        };
    }

    public class Book
    {
        public string name { get; set; }
    }
}
