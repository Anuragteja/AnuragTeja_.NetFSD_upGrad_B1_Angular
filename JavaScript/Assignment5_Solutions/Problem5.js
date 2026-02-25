class Employee {
    constructor(name, salary) {
        this.name = name;
        this.salary = salary;
    }

    getDetails() {
        return `Name: ${this.name}, Salary: ${this.salary}`;
    }
}

class Manager extends Employee {
    constructor(name, salary, bonus) {
        super(name, salary);
        this.bonus = bonus;
    }

    getTotalSalary() {
        return this.salary + this.bonus;
    }
}

class Director extends Manager {
    constructor(name, salary, bonus, stockOptions) {
        super(name, salary, bonus);
        this.stockOptions = stockOptions;
    }

    getFullCompensation() {
        return this.salary + this.bonus + this.stockOptions;
    }
}

const director1 = new Director("John", 50000, 10000, 20000);

console.log(director1.getDetails());
console.log("Total Salary:", director1.getTotalSalary());
console.log("Full Compensation:", director1.getFullCompensation());