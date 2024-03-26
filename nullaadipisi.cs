public static string GetPrettyDate(DateTime date)
{
    // Assuming you want a format like "March 22, 2024"
    return date.ToString("MMMM dd, yyyy");
}

// Usage
Console.WriteLine(GetPrettyDate(DateTime.Now.AddDays(-15)));
