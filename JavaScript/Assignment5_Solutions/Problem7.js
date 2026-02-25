class Animal {
    makeSound() {
        console.log("animal sound");
    }
}
class Dog extends Animal {
    makeSound() {
        console.log("bark");
    }
}
class Cat extends Animal {
    makeSound() {
        console.log("Meow");
    }
}
let animals = [new Dog(), new Cat()];

animals.forEach(a => a.makeSound());