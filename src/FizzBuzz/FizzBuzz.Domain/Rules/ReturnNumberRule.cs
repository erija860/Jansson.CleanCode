namespace FizzBuzz.Domain
{
    public class ReturnNumberRule : IFizzBuzzRule
    {
        public string GetResult(int number)
        {
            return number.ToString();
        }

        public bool IsApplicable(int number)
        {
            return true;
        }
    }
}