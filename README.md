# Factory Patterns

# Simple Factory Pattern in C#

## Overview
This project demonstrates the **Simple Factory Pattern** in C#. The Simple Factory Pattern centralizes object creation in a single factory class. It uses a method to create instances of objects based on a parameter, hiding the creation logic from the client. While not part of the Gang of Four (GoF) design patterns, it’s a common starting point for understanding factories.**.
### Example
A pizza store uses a factory to create different types of pizzas (Cheese, Veggie, etc.).

## Table of Contents
- [Introduction](#introduction)
- [Implementation](#implementation)

## Introduction
** The **Simple Factory Pattern** is a creational design pattern that provides a simple way to create objects without explicitly specifying their concrete classes. It centralizes object creation in a single factory class.**.
1. **Pizza Interface (`IPizza`)** – Defines methods for pizza descriptions.  
2. **Concrete Pizza Class (`CheesePizza`,`VeggiePizza`, etc.)** – Basic pizza implementations. 
3. **SimplePizzaFactory Class (`SimplePizzaFactory`)** – The factory class that creates pizza instances.  
4. **PizzaStoreClass (`PizzaStore`)** – The client that uses the factory. 
5. **Client (`Program.cs`)** – Demonstrates the use of the factory.  

## Implementation
- The `IPizza` interface defines the core methods for pizza objects.
- The `CheesePizza`, `VeggiePizza`, `ClamPizza`, and `PepperoniPizza` classes provide basic implementations of different pizza types.
- The `SimplePizzaFactory` class serves as the central factory, creating instances of pizza based on a type parameter.
- The `PizzaStore` class acts as the client, ordering pizzas through the factory.
- The `Program` class demonstrates how to create and order pizzas using the factory.

# Factory Method Pattern in C#

## Overview
This project demonstrates the **Factory Method Pattern** in C# is a creational design pattern that defines an abstract method for creating objects, allowing subclasses to decide which class to instantiate. It promotes loose coupling and extensibility.**.

## Table of Contents
- [Introduction](#introduction)
- [Implementation](#implementation)

## Introduction

1. **Car Interface (`ICar`)** – Defines methods for car details.
2. **Concrete Car Classes (`Sedan`,`SUV`)** – Basic car implementations. 
3. **CarFactory Class(Abstract Class) (`SimplePizzaFactory`)** – The abstract creator with a factory method. 
4. **SedanFactory & SUVFactory (`SedanFactory`, `SUVFactory`)** – Concrete factories for specific car types.
5. **Dealership Class (`Dealership`)** – The client that uses the factories.
6. **Client (`Program.cs`)** – Demonstrates the use of the factory method.  

## Implementation
- The `ICar` interface defines the core methods for car objects.
- The `Sedan` and `SUV` classes provide basic implementations of different car types.
- The `CarFactory` abstract class defines the factory method CreateCar and additional logic.
- The `SedanFactory` and SUVFactory classes implement the factory method to create specific cars.
- The `Dealership` class acts as the client, selling cars using the factories.
- The `Program` class demonstrates how to create and sell cars using different factories.

# Abstract Factory Pattern in C#

## Overview
This project demonstrates the **Abstract Factory Pattern** in C# is a creational design pattern that creates families of related objects without specifying their concrete classes. It ensures that products from the same family are compatible.**.

## Table of Contents
- [Introduction](#introduction)
- [Implementation](#implementation)

## Introduction

1. **Engine Interface (`IEngine`)** – Defines methods for engine details.
2. **Body Interface (`IBody`)** – Defines methods for body details.
3. **Concrete Product Classes (`SportsEngine`,`SportsBody`, `TruckEngine` and `TruckBody`)** – Implementations of engine and body types. 
4. **IVehicleFactory Interface (`IVehicleFactory`)** – The abstract factory interface.
5. **SportsCarFactory & TruckFactory (`SportsCarFactory`, `TruckFactory`)** – Concrete factories for specific vehicle families.
6. **VehicleManufacturer Class (`VehicleManufacturer`)** – The client that uses the factories.
7. **Client (`Program.cs`)** – Demonstrates the use of the abstract factories. 

## Implementation
- The `IEngine` and IBody interfaces define the core methods for vehicle components.
- The `SportsEngine`, `SportsBody`, `TruckEngine`, and `TruckBody` classes provide implementations of different component types.
- The `IVehicleFactory` interface defines methods to create families of products (engine and body).
- The `SportsCarFactory` and `TruckFactory` classes implement the factory interface to create specific families of components.
- The `VehicleManufacturer` class acts as the client, assembling vehicles using the factories.
- The `Program` class demonstrates how to create and assemble vehicles using different factories.

