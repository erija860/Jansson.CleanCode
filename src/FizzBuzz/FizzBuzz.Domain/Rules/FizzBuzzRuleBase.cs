namespace FizzBuzz.Domain
{
    public abstract class FizzBuzzRuleBase
    {
        protected bool IsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }

        protected bool IsDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }
    }
}