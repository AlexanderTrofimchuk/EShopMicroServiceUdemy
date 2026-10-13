namespace Catalog.API.Exsecptons;

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(): base("Product not found")
    {}
}