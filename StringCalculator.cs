public class StringCalculator 
{
  public int Add(string input)
  {
   if (string.IsNullOrEmpty(input))
        {
            return 0;
        }
    var separator = new List<string> { ",", "\n" };
    // Split the input string using the separator
        string[] splitNumbers = input.Split(separator.ToArray(), StringSplitOptions.None);

        // Convert the split strings to integers
        List<int> numbers = splitNumbers.Select(int.Parse).ToList();

        var negativeNumbers = numbers.Where(n => n < 0).ToList();

        if (negativeNumbers.Any())
        {
            throw new Exception($"Negatives not allowed: {string.Join(", ", negativeNumbers)}");
        }

        return numbers.Where(n => n <= 1000).Sum();
  }
}
