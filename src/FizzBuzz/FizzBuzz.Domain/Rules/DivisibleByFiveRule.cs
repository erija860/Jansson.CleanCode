namespace FizzBuzz.Domain
{
    public class DivisibleByFiveRule : FizzBuzzRuleBase, IFizzBuzzRule
    {
        public string GetResult(int number)
        {
            return IsDivisibleByFive(number) ? "Buzz" : null;
        }
    }
}