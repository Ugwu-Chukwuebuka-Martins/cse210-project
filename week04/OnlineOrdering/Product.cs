public class Product
{
    public string _productName;
    public string _productId;
    public int _price;
    public int _productQuantity;
    public int _totalCost;
    
    public int SetTotalCost()
    {
        return _totalCost = _price * _productQuantity;
    }
}