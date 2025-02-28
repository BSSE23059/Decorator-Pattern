# Decorator-Pattern

# Observer Pattern in C#

## Overview
This project demonstrates the **Decorator Design Pattern** in C#. It allows dynamic addition of functionalities (like Milk and Sugar) to a base coffee object without modifying its structure.**.

## Table of Contents
- [Introduction](#introduction)
- [Implementation](#implementation)
- [Running the Program](#running-the-program)

## Introduction
** The **Decorator Pattern**  is a structural design pattern that allows behavior to be added to an individual object without modifying its structure.**.
1. **Coffee Interface (`ICoffee`)** – Defines methods for coffee descriptions and costs.  
2. **SimpleCoffee Class (`SimpleCoffee`)** – A basic coffee implementation.  
3. **CoffeeDecorator (Abstract Class) (`CoffeeDecorator`)** – The base decorator class.  
4. **MilkDecorator & SugarDecorator (`MilkDecorator`, `SugarDecrator`)** – Concrete decorators adding milk and sugar to coffee dynamically.  
5. **Client (`Program.cs`)** – Demonstrates the use of the decorators.  

## Implementation
- The `ICoffee` interface defines the core methods for coffee objects.
- The `SimpleCoffee` class provides a basic implementation of a coffee. 
- The `CoffeeDecorator` class serves as a base for all decorators, allowing them to modify the behavior of the coffee object they wrap.
- The` MilkDecorator` and `SugarDecorator` classes extend the functionality of the coffee by adding their respective descriptions and costs.
- The `Program` class demonstrates how to create a coffee, decorate it, and print the results.

## Running the Program
```sh
# Clone the repository
git clone <https://github.com/BSSE23059/Decorator-Pattern>

# Build and run the application
