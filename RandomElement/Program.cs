string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway" };

Random random = new Random();

int randomIndex = random.Next(0, snacks.Length);

Console.WriteLine($"Tonight we going to eat {snacks[randomIndex]}.");
