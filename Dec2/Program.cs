var win = new string[]  { "A Y", "B Z", "C X" };
var draw = new string[] { "A X", "B Y", "C Z" };
var loss = new string[] { "A Z", "B X", "C Y" };
var outcomes = new string[][] { loss, draw, win };

var solution = File.ReadAllText("input.txt").Split("\n").Where(x => !string.IsNullOrWhiteSpace(x)).
    Select(line =>
    {
        int hit = -1;
        for (int i = 0; i < outcomes.Length; i++)
            if (outcomes[i].Any(x => x == line))
                hit = i;

        if (hit == -1)
            outcomes.GetHashCode();

        int winscore = hit * 3;
        int piecescore = line.Last() - 'X' + 1;
        return winscore + piecescore;
    }).Sum();

Console.WriteLine(solution);