namespace EvenDivisibleNumbers;

public static class DivisibleNumbers
{
    public static IEnumerable<int> GetEvenDivisibleNumbers(int number1, int number2)
    {
        var response = new List<int>();
        int bigNumber = Math.Max(number1, number2);
        int smallNumber = Math.Min(number1, number2);
         
        for (int i = 2; i <= bigNumber; i++)
        { 
            if (i % 2 == 0 && i % smallNumber == 0)
            {
                response.Add(i);
            }
        }

        return response;
    }
}

