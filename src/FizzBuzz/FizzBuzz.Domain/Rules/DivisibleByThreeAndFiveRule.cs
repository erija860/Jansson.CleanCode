namespace FizzBuzz.Domain
{
    public class DivisibleByThreeAndFiveRule : FizzBuzzRuleBase, IFizzBuzzRule
    {
        public string GetResult(int number)
        {
            return IsDivisibleByFive(number) && IsDivisibleByThree(number) ? "FizzBuzz" : null;
        }
    }
}