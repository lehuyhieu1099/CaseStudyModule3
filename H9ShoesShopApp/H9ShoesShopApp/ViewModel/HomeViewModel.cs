﻿using H9ShoesShopApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H9ShoesShopApp.ViewModel
{
    public class HomeViewModel
    {
        public Search Search { get; set; }
        public HomeView HomeView { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
