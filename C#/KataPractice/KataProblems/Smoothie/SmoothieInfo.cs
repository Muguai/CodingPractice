namespace KataPractice;
public static class SmoothieInfo{
    public static Dictionary<string, double> Prices { get; set; } = new Dictionary<string, double>() {
        {"Strawberries", 1.50},
        {"Banana", 0.50},
        {"Mango", 2.50},
        {"Blueberries", 1.0},
        {"Raspberries", 1.0},
        {"Apple", 1.75},
        {"Pineapple", 3.50}
    };

    public static Dictionary<string, string> Singulars { get; set; } = new Dictionary<string, string>() {
        {"Strawberries", "Strawberry"},
        {"Banana", "Banana"},
        {"Mango", "Mango"},
        {"Blueberries", "Blueberry"},
        {"Raspberries", "Raspberry"},
        {"Apple", "Apple"},
        {"Pineapple", "Pineapple"}
    };

    public static List<string> VeganAlternatives {get; set;} = new List<string>() {
        "Almond",
        "Oat",
        "Soy"
    };
}