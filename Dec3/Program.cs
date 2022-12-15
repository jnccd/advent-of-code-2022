
var solution = File.ReadAllText("input.txt").Split("\n").
    Select(line =>
    {
        string firstHalf = line.Substring(0, line.Length / 2);
        string secondHalf = line.Substring(line.Length / 2);

        char hit = firstHalf.Where(x => secondHalf.Any(y => x == y)).First();

        if ('a' <= hit && hit <= 'z')
            return hit - 'a' + 1;
        else if ('A' <= hit && hit <= 'Z')
            return hit - 'A' + 27;
        else
            return 0;
    }).Sum();


Console.WriteLine(solution);
