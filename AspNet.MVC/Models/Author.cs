﻿namespace AspNet.MVC.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nationality { get; set; }
        public string FullName => $"{Name} {Surname}";
    }
}
