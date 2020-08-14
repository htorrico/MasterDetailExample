using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio04.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Example,
        ListViewDemo
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
