class Product {
  constructor({ name, price, category = "General" }) {
    this.name = name;
    this.price = price;
    this.category = category;
  }
  display = () => {
    console.log(`Product: ${this.name} Price: ${this.price} Category: ${this.category}`);
  }

  applyDiscount = (discountPercent = 0) => {
    this.price = this.price - (this.price * discountPercent) / 100;
    return this.price;
  }

  static createProducts = (...products) => {
    return products.map(p => new Product(p));
  }
}

const product1 = new Product({ name: "Laptop", price: 1200, category: "Electronics" });
const product2 = new Product({ name: "Notebook", price: 5 }); // category defaults to "General"

product1.display(); 
product2.display();

console.log("Discounted Price:", product1.applyDiscount(10));
const products = Product.createProducts(
  { name: "Phone", price: 800, category: "Electronics" },
  { name: "Pen", price: 2 }
);

products.forEach(p => p.display());