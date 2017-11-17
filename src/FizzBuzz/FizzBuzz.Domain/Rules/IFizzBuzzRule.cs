namespace FizzBuzz.Domain
{
    public interface IFizzBuzzRule
    {
        string GetResult(int number);
        bool IsApplicable(int number);
    }
}