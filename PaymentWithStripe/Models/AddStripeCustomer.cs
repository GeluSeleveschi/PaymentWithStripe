namespace PaymentWithStripe.Models
{
    public record AddStripeCustomer(string Email, string Name, AddStripeCard CreditCard);
}
