namespace DesignPattern.AbstractFactory;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();

    IAbstractProductB CreateProductB();
}