
Console.WriteLine(VatCalculator.CalculateVat(new Product(50f, "food"), "Italy"));
Console.WriteLine(VatCalculator.CalculateVat(new Product(50f, "food"), "Japan"));
Console.WriteLine(VatCalculator.CalculateVat(new Product(50f, "food"), "Germany"));
Console.WriteLine(VatCalculator.CalculateVat(new Product(50f, "not food"), "Germany"));

// Unlike a struct or a class, records come with this free constructor
public record Product(float price, string type);

public static class VatCalculator
{
    public static float CalculateVat(Product product, string country)
    {
        switch (country)
        {
            case "Italy":
                return product.price * 0.22f;
            case "Japan":
                return product.price * 0.08f;
            case "Germany":
                if (product.type == "food")
                    return product.price * 0.08f;
                else
                    return product.price * 0.22f;
            default:
                throw new ArgumentException();
        }
    }
}

