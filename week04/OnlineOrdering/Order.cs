
public class Order
{
    List<Product> _products;
    Customer _customer;
    public Order(List<Product>products, Customer customer)
    {
        SetProducts(products);
        SetCustomer(customer);
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach(Product product in _products)
        {
            string label = product.GetPackingLabel();
            packingLabel += $" {label} \n";
        }

        return packingLabel;
    }
    public string GetShippingLabel()
    {
        string shippingLabel = _customer.GetShippingLabel();

        return shippingLabel;
    }
    public float GetTotalPrice()
    {
        float total = 0;
        foreach(Product product in _products)
        {
            total += product.GetPrice();
        }
        if (_customer.USCheck())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    private void SetProducts(List<Product> products)
    {
        _products = products;
    }
    private void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
}