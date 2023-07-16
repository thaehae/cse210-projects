using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");

        Product order1p1 = new Product("Haier Washing machine", "K982", 1, 350);
        order1p1.DisplayProduct();
        Product order1p2 = new Product("Royal Hair dryer", "S505", 10, 55);
        order1p2.DisplayProduct();
        Product order1p3 = new Product("Royal Hair Straightener", "S673", 22, 45);
        order1p3.DisplayProduct();
        Console.WriteLine();

        Product order2s1 = new Product("Manuka Honey Soap", "M11", 100, 15);
        order2s1.DisplayProduct();
        Product order2s2 = new Product("M8 Eye Lash Curler", "M844", 150, 12);
        order2s2.DisplayProduct();
        Product order2s3 = new Product("Nuti Cleanser", "M945", 200, 35);
        order2s3.DisplayProduct();

    }
}