using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace TripleNumbers.Services {
    public class NumberService {
        public const string expectedInputFormat = "^\\[-?\\d+(,-?\\d+)*\\]$";

        private readonly static Regex inputValidator = new(expectedInputFormat, RegexOptions.Compiled);

        public bool TryGetTripleIntegers(string input, [NotNullWhen(true)] out string? output) {
            output = null;

            if (!inputValidator.IsMatch(input)) {                
                return false;
            }

            try {
                var integers = input[1..^1].Split(',').Select(int.Parse);                
                var triples = integers
                    .GroupBy(i => i)
                    .Where(i => i.Count() >= 3)
                    .Select(i => i.Key)
                    .OrderByDescending(i => i);

                output = $"[{string.Join(",", triples)}]";
                return true;
            }
            catch {
                return false;
            }
        }
    }
}
