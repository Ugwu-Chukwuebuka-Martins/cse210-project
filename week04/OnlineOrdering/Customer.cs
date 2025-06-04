public class Customer
{
    private string _name;
    Address address = new Address();

    public int ResideCheck()
    {
        if(address.GetCountry() == "usa" || address.GetCountry() == "USA")
        {
            return 35;
        }
        else
        {
            return 5;
        }
    }

    public string GetCustomerName()
    {
        return  _name;
    }

    public string GetCustomerAddress()
    {
        return address.GetAddress();
    }

    public void SetCustomer(string name,string street,string city, string state, string country)
    {
        _name = name;
        address.SetAddress(street,city,state,country);
    } 
}