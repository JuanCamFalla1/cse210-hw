public class Order {
    private List<Product> _productList;
    private Customer _customer;
    private double _shippingPrice;

    public Order(List<Product> productList, Customer customer)
    {
        _productList = productList;
        _customer = customer;
        _shippingPrice = SetShippingPrice();
    }

    public string PackingLabel()
    {
        string str = "";
        foreach(Product item in _productList){
            str += $"Name:{item.GetName()} - ID:{item.GetID()}\n";
        }
        return str;
    }
    public string ShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";   
    }
    private double SetShippingPrice()
    {
        if(_customer.LiveInUSA())
        { 
            return 5.00;
        }
        return 35.00;
    }
    public double CalcTotalPrice()
    {
        double price = 0;
        foreach(Product item in _productList)
        {
            price += item.GetPrice();
        }
        price += _shippingPrice;
        return price;
    }
    public double GetShippingPrice()
    {
        return _shippingPrice;
    }
}