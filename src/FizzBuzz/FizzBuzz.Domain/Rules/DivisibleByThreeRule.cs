namespace FizzBuzz.Domain
{
    public class DivisibleByThreeRule : FizzBuzzRuleBase, IFizzBuzzRule
    {
        public string GetResult(int number)
        {
            return IsDivisibleByThree(number) ? "Fizz" : null;
        }
    }
}