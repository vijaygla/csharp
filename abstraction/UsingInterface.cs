using System;

interface IPayment {
    void Pay();
}

class UpiPayment  : IPayment {
    public void Pay() {
        Console.WriteLine("Payment using upi");
    }
}

class CardPayment  : IPayment {
    public void Pay() {
        Console.WriteLine("Payment using card");
    }
}

class UsingInterface {
    static void Main(String[] args) {
        IPayment payment;

        payment = new UpiPayment(); // abstraction
        payment.Pay();
        
        payment = new CardPayment(); // abstraction
        payment.Pay();
    }
}
