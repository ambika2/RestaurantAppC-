﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    interface IMenuItem
    {
       string Name { get;  }
       int Price { get; }

    }
}
