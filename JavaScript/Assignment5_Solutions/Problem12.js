class Wallet {
  #balance = 0;

  addMoney(amount) {
    if (amount > 0) {
      this.#balance += amount;
    }
  }

  spendMoney(amount) {
    if (amount > 0 && amount <= this.#balance) {
      this.#balance -= amount;
    } else {
      console.log("Insufficient balance");
    }
  }

  getBalance() {
    return this.#balance;
  }
}

const myWallet = new Wallet();

myWallet.addMoney(40000);
myWallet.addMoney(5000);
console.log(myWallet.getBalance());

myWallet.spendMoney(10000);
console.log(myWallet.getBalance());

myWallet.spendMoney(40000);
console.log(myWallet.getBalance());