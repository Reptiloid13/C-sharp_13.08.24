namespace Playground.Order;

class Order<T> where T : Delivery
{
    private List<ProductItem> _products;
    private T _delivery;
    private Customer _customer;

    public Order(List<ProductItem> products, Customer customer, T delivery)
    {
        _products = products;
        _delivery = delivery;
        _customer = customer;
    }
}