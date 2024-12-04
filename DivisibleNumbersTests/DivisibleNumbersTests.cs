using EvenDivisibleNumbers;
using Shouldly;

namespace DivisibleNumbersTests
{
    public class DivisibleNumbersTests
    {
        /*
        •	Given 17 and 4, the output will be 4, 8, 12, 16
        •	Given 21 and 7, the output will be 14
        •	Given 5 and 20, the output will be 10, 20
        •	Given 3 and 10, the output will be 6
        •	Given 2 and 2, the output will be 2
        */
        [Fact] //In real prod code I would pass params into test
        public void GetEvenDivisibleNumbers_ShouldReturnCorrectValues()
        {
            var response = DivisibleNumbers.GetEvenDivisibleNumbers(17, 4);
            response.Count().ShouldBe(4);
            var listResponse = response.ToList();

            listResponse[0].ShouldBe(4);
            listResponse[1].ShouldBe(8);
            listResponse[2].ShouldBe(12);
            listResponse[3].ShouldBe(16);

            response = DivisibleNumbers.GetEvenDivisibleNumbers(21, 7);
            response.Count().ShouldBe(1);
            response.FirstOrDefault().ShouldBe(14);

            response = DivisibleNumbers.GetEvenDivisibleNumbers(5, 20);
            response.Count().ShouldBe(2);
            listResponse = response.ToList();
            listResponse[0].ShouldBe(10);
            listResponse[1].ShouldBe(20);

            response = DivisibleNumbers.GetEvenDivisibleNumbers(3, 10);
            response.Count().ShouldBe(1);
            response.FirstOrDefault().ShouldBe(6);

            response = DivisibleNumbers.GetEvenDivisibleNumbers(2, 2);
            response.Count().ShouldBe(1);
            response.FirstOrDefault().ShouldBe(2);
        }
    }
}