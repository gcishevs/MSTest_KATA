
namespace UnitTests.Core
{
    public class Calculator
    {



        public int Add(string parameters)
        {
            if (string.IsNullOrEmpty(parameters))
                return 0;
            else
            {
                string[] summands = parameters.Split(',');
                if (summands.Length == 1)
                {
                    int summand = 0;
                    int.TryParse(summands[0], out summand);
                    return summand;
                }
            }
            return 0;
        }








        // первый раз, как в первый класс

        //public int Add(string numbers)
        //{
        //    if (string.IsNullOrEmpty(numbers))
        //    {
        //        return 0;
        //    }

        //    string[] terms = numbers.Split(',');
        //    if (terms.Length == 1)
        //    {
        //        int parameter = 0;
        //        int.TryParse(terms[0], out parameter);
        //        return parameter;
        //    }
        //    else if (terms.Length == 2)
        //    {
        //        int firstSummand = int.Parse(terms[0]);
        //        int secondSummand = int.Parse(terms[1]);
        //        return firstSummand + secondSummand;
        //    }

        //    return 0;
        //}
    }
}