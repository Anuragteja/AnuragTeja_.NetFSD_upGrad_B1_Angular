class person {
    constructor(name,age){
        this.name=name;
        this.age=age;
    }
    greet(){
        console.log(`Hello, my name is ${this.name} and i am ${this.age} years old.`)
    }
}
const p1=new person("Teja",123);
p1.greet();
