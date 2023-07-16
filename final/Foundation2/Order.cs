using System;

public class Order
{

    private string _orderName;

    private string _packingLabel;

    private string _shippingLabel;

    private List<Product> _product = new List<Product>();

    public Order(string orderName, string packingLabel, string shippingLabel)
    {
        _orderName =       orderName;
        _packingLabel =    packingLabel;
        _shippingLabel =   shippingLabel;
        _product =         new List<Product>();

    }

    public void CalculateTotalCosts()
    {
        
    }

    public void GetShippingLabel()
    {

    }

    public void GetPackingLabel()
    {

    }


}