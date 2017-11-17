namespace FizzBuzz.Domain
{
    public class ReturnNumberRule : IFizzBuzzRule
    {
        public string GetResult(int number)
        {
            return number.ToString();
        }
    }
}