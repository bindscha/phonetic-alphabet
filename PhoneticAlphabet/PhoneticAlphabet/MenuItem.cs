﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PhoneticAlphabet
{
    public class MenuItem
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }

        public MenuItem(String name, String description, String image)
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
        }
    }
}
