using System;

class Vehicle {
    public virtual void StartEngine() {
        Console.WriteLine("Starting generic engine...");
    }
}

class Car : Vehicle {
    public override void StartEngine() {
        Console.WriteLine("Starting car engine...");
    }
}

class Motorcycle : Vehicle {
    public override void StartEngine() {
        Console.WriteLine("Starting motorcycle engine...");
    }
}

class Bus : Vehicle {
    public override void StartEngine() {
        Console.WriteLine("Starting bus engine...");
    }
}

class Program {
    static void Main(string[] args) {
        Vehicle vehicle1 = new Car();
        Vehicle vehicle2 = new Motorcycle();
        Vehicle vehicle3 = new Bus();
        
        vehicle1.StartEngine(); // Output: Starting car engine...
        vehicle2.StartEngine(); // Output: Starting motorcycle engine...
        vehicle3.StartEngine(); // Output: Starting bus engine...
    }
}
