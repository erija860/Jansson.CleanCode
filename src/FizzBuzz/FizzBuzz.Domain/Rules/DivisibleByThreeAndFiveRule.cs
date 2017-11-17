namespace FizzBuzz.Domain
{
    public class DivisibleByThreeAndFiveRule : FizzBuzzRuleBase, IFizzBuzzRule
    {
        public string GetResult(int number)
        {
            return "FizzBuzz";
        }

        public bool IsApplicable(int number)
        {
            return IsDivisibleByFive(number) && IsDivisibleByThree(number);
        }
    }
}