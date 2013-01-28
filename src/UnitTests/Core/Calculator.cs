
namespace UnitTests.Core
{
    public class Calculator
    {

        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            string[] terms = numbers.Split(',');
            if (terms.Length == 1)
            {
                int parameter = 0;
                int.TryParse(terms[0], out parameter);
                return parameter;
            }
            else if (terms.Length == 2)
            {
                int firstSummand = int.Parse(terms[0]);
                int secondSummand = int.Parse(terms[1]);
                return firstSummand + secondSummand;
            }

            return 0;
        }
    }
}