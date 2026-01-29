
public class Product
{
    string _name;
    int _id;
    float _price;
    int _quantity;
    public Product(string name, int id, float price, int quantity)
    {
        SetName(name);
        SetId(id);
        SetPrice(price);
        SetQuantity(quantity);
    }
    public string GetPackingLabel()
    {
        return $"{_name}, {_id}";
    }
    public float GetPrice()
    {
        return _price * _quantity;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetId(int id)
    {
        _id = id;
    }
    public void SetPrice(float price)
    {
        _price = price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}