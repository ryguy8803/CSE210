using System; // Required for Console.WriteLine
using System.Collections.Generic; // Required for List<T>

// Base class: Vehicle
// This class defines a common interface for all vehicles.
public abstract class Vehicle
{
    // Protected fields can be accessed by derived classes
    protected string Make;
    protected string Model;

    // Constructor for the Vehicle class
    public Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
    }

    // Virtual method: This is the key to polymorphism in C#.
    // The 'virtual' keyword allows derived classes to override this method.
    // 'abstract' makes it a pure virtual-like method, making Vehicle an abstract class.
    // This means you cannot create an object directly from Vehicle;
    // you must create objects from its derived classes.
    public abstract string StartEngine();

    // No explicit destructor needed in C# like in C++ due to automatic garbage collection.
    // The default constructor is implicitly provided.
}

// Derived class: Car, inherits publicly from Vehicle
public class Car : Vehicle
{
    private int _numDoors; // Private field for number of doors

    // Constructor for Car, calls the base class (Vehicle) constructor using 'base'
    public Car(string make, string model, int numDoors)
        : base(make, model) // Calls the Vehicle base constructor
    {
        _numDoors = numDoors;
    }

    // Override the virtual StartEngine method from the base class.
    // The 'override' keyword is mandatory in C# to indicate overriding a base method.
    public override string StartEngine()
    {
        return $"The {Make} {Model} (Car) is roaring to life!";
    }
}

// Derived class: Motorcycle, inherits publicly from Vehicle
public class Motorcycle : Vehicle
{
    private bool _hasSidecar; // Private field for sidecar status

    // Constructor for Motorcycle, calls the base class (Vehicle) constructor
    public Motorcycle(string make, string model, bool hasSidecar)
        : base(make, model) // Calls the Vehicle base constructor
    {
        _hasSidecar = hasSidecar;
    }

    // Override the virtual StartEngine method from the base class.
    public override string StartEngine()
    {
        return $"The {Make} {Model} (Motorcycle) is kicking over.";
    }
}

// Main class to run the program
public class Program
{
    // Main method where the program execution begins
    public static void Main(string[] args)
    {
        // Demonstrating Polymorphism using a List of Vehicle.
        // List<T> is similar to std::vector in C++, a dynamic array.
        // In C#, memory management for objects is handled automatically by the Garbage Collector,
        // so no need for unique_ptr.
        List<Vehicle> vehicles = new List<Vehicle>();

        // Add different types of vehicles to the list.
        // Notice we're storing them as Vehicle type, even though
        // we're creating Car and Motorcycle objects. This is the essence
        // of polymorphism: treating derived objects as their base type.
        vehicles.Add(new Car("Toyota", "Camry", 4));
        vehicles.Add(new Motorcycle("Harley-Davidson", "Iron 883", false));
        vehicles.Add(new Car("Honda", "Civic", 2));

        // Iterate through the list and call StartEngine() on each vehicle.
        // Because StartEngine() is an overridden method, the correct version
        // (Car's or Motorcycle's) will be called automatically at runtime.
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.StartEngine());
        }

        // C# handles memory cleanup automatically, so no explicit deletion is needed.
    }
}
