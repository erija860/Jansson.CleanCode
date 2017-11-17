namespace FizzBuzz.Domain
{
    public class DivisibleByFiveRule : FizzBuzzRuleBase, IFizzBuzzRule
    {
        public string GetResult(int number)
        {
            return "Buzz";
        }

        public bool IsApplicable(int number)
        {
            return IsDivisibleByFive(number);
        }
    }
}