public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName() => name;
    public bool LivesInUSA() => address.IsInUSA();
    public string GetAddress() => address.GetFullAddress();
}
