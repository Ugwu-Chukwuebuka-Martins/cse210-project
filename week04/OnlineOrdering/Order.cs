public class Order
{
    public List<string> _products = [];
    public List<Product> _packingLabel = [];
    public List<Customer> _shippingLabel = [];
    public int shoppingCost;
    
    public int TotalCostOrder(int totalCost,int shopCost)
    {
       return totalCost + shopCost;
    }

}