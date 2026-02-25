class BankAccount{
    constructor(accountHolder,balance){
        this.accountHolder=accountHolder;
        this.balance=0;
    }
    deposit(amount){
        if (amount){
            this.balance +=amount;
            console.log(`Total amount after deposit ${this.balance}`)
        }
    }
    withdraw(amount){
        if (amount=>this.balance){
            this.balance -=amount;
            console.log(`Total amount after deposit ${this.balance}`)
        }
        else{
            console.log("Cannot with Draw more than balance")
        }
    }
    checkBalance(){
        console.log(`${this.accountHolder} the total balance amount is ${this.balance}`);
    }
}

const b1 = new  BankAccount;
b1.deposit(4000);
b1.withdraw(250);
b1.checkBalance();