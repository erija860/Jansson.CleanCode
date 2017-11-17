namespace FizzBuzz.Domain
{
    public class FizzBuzzLogic
    {
        public string GetResultFromNumber(int number)
        {
            if (IsDivisibleByThree(number) && IsDivisibleByFive(number))
                return "FizzBuzzLogic";

            if (IsDivisibleByThree(number))
                return "Fizz";

            if (IsDivisibleByFive(number))
                return "Buzz";

            return number.ToString();
        }

        private bool IsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }

        private bool IsDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }
    }
}