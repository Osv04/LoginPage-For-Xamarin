﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoginPage.Models
{
    public class MenuOption
    {
        public string Title { get; set; }
        public string Image { get; set; }

        public MenuOption(string title, string image)
        {
            Title = title;
            Image = image;
        }
    }
}
