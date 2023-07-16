using System;

public class Product
{

    private string _nameOfProduct;

    private string _productId;

    private int _quantity;

    private int _price;

    public Product(string nameOfProduct, string productId, int quantity, int price)
    {
        _nameOfProduct =    nameOfProduct;
        _productId =        productId;
        _quantity =         quantity;
        _price =            price;

    }

    public int ComputeProductPrices(int quantity, int price)
    {
       int total = quantity * price;
       return total;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Name of Product: {_nameOfProduct}, Product ID: {_productId}, Quantity: {_quantity}, Price per item: ${_price}");
    
    }
}