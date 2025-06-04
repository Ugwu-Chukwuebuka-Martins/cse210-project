public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;


    public string GetAddress()
    {
        return $"Street: {_street}, City: {_city}, State: {_state} Country: {_country}";
    }
    
    public string GetCountry()
    {
        return _country;
    }

    public void SetAddress(string street,string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }    

}