
var theNumbersMason = File.ReadAllText("input.txt").
    Split("\n\n").
    Select(x => x.TrimEnd('\n').Split("\n").
        Select(y => Convert.ToInt32(y)).
        Sum()).ToArray().
        OrderByDescending(x => x);

Console.WriteLine($"Chonkiest Boy: {theNumbersMason.First()}, Sum of the Top 3 Chonks: {theNumbersMason.Take(3).Sum()}");