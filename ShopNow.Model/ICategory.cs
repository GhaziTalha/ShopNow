﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Model
{
    public class ICategory : IEntity<int>
    {
        int IEntity<int>.Id { get ; set; }
    }
}
