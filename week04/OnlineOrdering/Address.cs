public class Address
{
    string _address;
    string _city;
    string _county;
    string _state;

    public Address()
    {
        SetAddress("333 Timbuktu Place");
        SetCity("The City");
        SetCounty("");
        SetState("Timbuktu");
    }

    public Address(string address, string city, string county, string state)
    {
        SetAddress(address);
        SetCity(city);
        SetCounty(county);
        SetState(state);
    }
    public string GetFullAddress()
    {
        return $"{_address} \n {_city} {_county}, {_state}";
    }
    public bool IsUsa()
    {
        string[] states =
        {
            "AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA",
            "HI","ID","IL","IN","IA","KS","KY","LA","ME","MD",
            "MA","MI","MN","MS","MO","MT","NE","NV","NH","NJ",
            "NM","NY","NC","ND","OH","OK","OR","PA","RI","SC",
            "SD","TN","TX","UT","VT","VA","WA","WV","WI","WY"
        };
        return states.Contains(_state);
    }
    public void SetAddress(string address)
    {
        _address = address;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public void SetCounty(string county)
    {
        _county = county;
    }
    public void SetState(string state)
    {
        _state = state;
    }
}