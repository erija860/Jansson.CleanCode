using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Domain
{
    public class FizzBuzzRuleRunner
    {
        private readonly List<IFizzBuzzRule> _rules;

        public FizzBuzzRuleRunner(List<IFizzBuzzRule> rules)
        {
            _rules = rules;
        }

        public string GetResultFromNumber(int number)
        {
            return _rules.First(r => r.IsApplicable(number)).GetResult(number);
        }
    }
}