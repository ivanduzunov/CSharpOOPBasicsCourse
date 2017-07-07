﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price)
            : base(title, author, price)
        {

        }

        public override decimal Price
        {
            get
            {
                return base.Price * (decimal)1.3;
            }
        }



    }
}
