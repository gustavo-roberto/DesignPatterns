﻿using Abstract_Factory.IProducts;
using System;

namespace Abstract_Factory.Products.Mac
{
    public class MacButton : IButton
    {
        public void paint()
        {
            Console.WriteLine("Reinderiza um botão segundo o padrão MacOS");
        }
    }
}
