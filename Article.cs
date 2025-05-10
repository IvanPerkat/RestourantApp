using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestourantApp
{
    class Article
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        //public Image Image { get; set; }
    }

    public enum Category
    {
        Appetizer,
        MainCourse,
        Dessert,
        Pasta
    }
}
