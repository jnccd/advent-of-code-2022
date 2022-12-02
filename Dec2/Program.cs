
// Maps Input Piece and Game Outcome to the required Piece
int[][] rpcMatrix = new int[][]{ 
    new int[] { 2, 0, 1 },
    new int[] { 0, 1, 2 },
    new int[] { 1, 2, 0 }
};

var solution = File.ReadAllText("input.txt").Split("\n").SkipLast(1).
    Select(line => 
        (line.Last() - 'X') * 3 +                               // Winscore
        rpcMatrix[line.First() - 'A'][line.Last() - 'X'] + 1).  // Piecescore
    Sum();

Console.WriteLine(solution);