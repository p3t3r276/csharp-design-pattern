# Factory Method

## Concept:
[Source](https://refactoring.guru/design-patterns/factory-method)

**Factory Method** is a *creational* design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

**The Factory Method** pattern suggests that you replace direct object construction calls (using the `new` operator) with calls to a special factory method. (the objects are still created via the new operator, but it’s being called from within the factory method). 
Objects returned by a factory method are often referred to as products.

## C# Example:
[Code](https://refactoring.guru/design-patterns/factory-method/csharp/example#lang-features)
