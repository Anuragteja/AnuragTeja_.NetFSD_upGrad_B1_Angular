class Payment {
  pay(amount) {
    console.log(`Processing payment of amount: ${amount}`);
  }
}

class CreditCardPayment extends Payment {
  pay(amount) {
    super.pay(amount);
    console.log(`Paid ${amount} using Credit Card`);
  }
}

class UPIPayment extends Payment {
  pay(amount) {
    super.pay(amount);
    console.log(`Paid ${amount} using UPI`);
  }
}

class CashPayment extends Payment {
  pay(amount) {
    super.pay(amount);
    console.log(`Paid ${amount} using Cash`);
  }
}

const creditCard = new CreditCardPayment();
const upi = new UPIPayment();
const cash = new CashPayment();

creditCard.pay(40000);
upi.pay(23456);
cash.pay(90000);