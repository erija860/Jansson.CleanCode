namespace FizzBuzz.Domain
{
    public class DivisibleByThreeRule : FizzBuzzRuleBase, IFizzBuzzRule
    {
        public string GetResult(int number)
        {
            return "Fizz";
        }

        public bool IsApplicable(int number)
        {
            return IsDivisibleByThree(number);
        }
    }
}