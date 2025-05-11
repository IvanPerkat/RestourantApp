namespace RestourantApp
{
    class Article
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public string? Image { get; set; }
    }

    public enum Category
    {
        ColdAppetizer,
        MainCourse,
        Dessert,
        Soup,
        HotAppetizer
    }
}
