class Vehicle {
    constructor(brand, speed) {
        this.brand = brand;
        this.speed = speed;
    }

    start() {
        console.log(`${this.brand} car speed is ${this.speed} km/h`);
    }
}

class Car extends Vehicle {
    constructor(brand, speed, fuelType) {
        super(brand, speed);
        this.fuelType = fuelType;
    }

    showDetails() {
        super.start();
        console.log(`Fuel Type: ${this.fuelType}`);
    }
}

const car1 = new Car("Toyota", 120, "Petrol");
car1.showDetails();