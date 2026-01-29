public class Customer
{
    string _name;
    Address _address;
    
    public Customer(string name, Address address)
    {
        SetName(name);
        SetAddress(address);
    }

    public bool USCheck()
    {
        return _address.IsUsa(); 
    }
    public string GetShippingLabel()
    {
        string address = _address.GetFullAddress();
        return $"{_name} \n {address}";
    }
    private void SetName(string name)
    {
        _name = name;
    }
    private void SetAddress(Address address)
    {   
        _address = address;
    }
}