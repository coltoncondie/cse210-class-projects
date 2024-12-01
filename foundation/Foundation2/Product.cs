using System;


public class Product
{
    // Variables for name, productID, price, and quantity
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    // Constructor converting the variables to simpler to use variables to call later
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    // GetTotalCost function 
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    //GetName Function
    public string GetName() => _name;
    // GetProductID function
    public string GetProductID() => _productID;
}