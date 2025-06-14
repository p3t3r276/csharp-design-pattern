namespace DesignPattern.FactoryMethod;

public interface IProduct
{
    string Operation();
}

class ConcreteProduct1 : IProduct
{
    public string Operation()
    {
        return "{Result of ConcreteProduct1}";
    }
}

class ConcreteProduct2 : IProduct
{
    public string Operation()
    {
        return "{Result of ConcreteProduct2}";
    }
}
