namespace KataPractice;
public class Smoothie
{

    public string[] Ingredients { get; set; }
    public Smoothie(string[] ingredients)
    {
        this.Ingredients = ingredients;
    }
    public double GetCost()
    {
        double totalCost = 0;
        foreach (string s in Ingredients)
        {
            if (SmoothieInfo.Prices.ContainsKey(s))
            {
                totalCost += SmoothieInfo.Prices[s];
            }
        }
        return totalCost;
    }

    public double GetPrice()
    {
        return GetCost() + (GetCost() * 1.5);
    }

    public string GetName()
    {
        string[] sortedIngredients = Ingredients.OrderBy(s => s).ToArray();
        string name = string.Empty;
        bool isVegan = false;
        int amountOfIngredients = 0;
        foreach (string s in sortedIngredients)
        {
            if (SmoothieInfo.Prices.ContainsKey(s))
            {
                name += SmoothieInfo.Singulars[s] + " ";
                amountOfIngredients += 1;
            }
            else if (SmoothieInfo.VeganAlternatives.Contains(s))
            {
                isVegan = true;
            }
        }

        if (amountOfIngredients > 1)
            name += "Fusion";
        else
            name += "Smoothie";

        if (isVegan)
            name += " (VGN)";

        return name;
    }
}