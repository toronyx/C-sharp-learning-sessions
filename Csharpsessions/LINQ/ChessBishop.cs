namespace Csharpsessions.LINQ
{
    internal static class ChessBishop
    {
        static readonly List<char> letters = new() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        static readonly List<(char letter, int number)> allPossibleSquares = new();

        internal static void Run()
        {
            var startingSquare = ('c', 3);

            GenerateAllPossibleSquares();

            Console.WriteLine($"Possible bishop moves starting from {startingSquare}:");
            foreach (var pair in GetBishopMoves(allPossibleSquares, startingSquare))
            {
                Console.Write($"{pair}");
            }
        }

        private static void GenerateAllPossibleSquares()
        {
            for (int i = 1; i <= 8; i++)
            {
                foreach (char letter in letters)
                {
                    allPossibleSquares.Add((letter, i));
                }
            }
        }

        private static IEnumerable<(char letter, int number)> GetBishopMoves(
            this List<(char letter, int number)> list, 
            (char letter, int number) startingSquare)
        {
            return allPossibleSquares.Where(square => square.SharesADiagonalWith(startingSquare));
        }

        private static int CharToInt(this char character)
        {
            return letters.IndexOf(character) + 1;
        }

        private static bool SharesADiagonalWith(this (char letter, int number) square1, (char letter, int number) square2)
        {
            int xdiff = square1.letter.CharToInt() - square2.letter.CharToInt();
            int ydiff = square1.number - square2.number;
            return Math.Abs(xdiff) == Math.Abs(ydiff);
        }
    }
}
