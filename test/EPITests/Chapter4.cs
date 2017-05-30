using System.Collections.Generic;
using Xunit;

namespace EPITests
{
    public class Chapter4
    {
        public class Parity
        {
            [Theory, MemberData(nameof(Cases))]
            public void Solution_1(uint input, int result)
            {
                Assert.Equal(result, EPI.Chapter4.Problem_1_Parity.Solution_1(input));
            }

            [Theory, MemberData(nameof(Cases))]
            public void Solution_2(uint input, int result)
            {
                Assert.Equal(result, EPI.Chapter4.Problem_1_Parity.Solution_2(input));
            }

            [Theory, MemberData(nameof(Cases))]
            public void Solution_3(uint input, int result)
            {
                Assert.Equal(result, EPI.Chapter4.Problem_1_Parity.Solution_3(input));
            }

            [Theory, MemberData(nameof(Cases))]
            public void Solution_4(uint input, int result)
            {
                Assert.Equal(result, EPI.Chapter4.Problem_1_Parity.Solution_4(input));
            }

            public static IEnumerable<object[]> Cases =>
                new[]
                {
                    new object[] { 0b0000_0000_0000_0000_0000_0000_0000_1011, 1 },
                    new object[] { 0b0000_0000_0000_0000_0000_0000_1000_1000, 0 },
                    new object[] { 0b0000_0000_0000_0000_0000_0000_0000_0000, 0 },
                    new object[] { 0b1111_1111_1111_1111_1111_1111_1111_1111, 0 },
                    new object[] { 0b0000_0000_0000_0000_0000_0000_0000_0001, 1 },
                    new object[] { 0b1000_0000_0000_0000_0000_0000_0000_0000, 1 },
                    new object[] { 0b1000_0000_0000_0000_0000_0000_0000_0001, 0 },
                    new object[] { 0b0000_0000_0000_0000_0000_0000_0000_1111, 0 },
                    new object[] { 0b0000_0000_0000_0000_0000_0000_0001_1111, 1 },
                    new object[] { 0b0010_0000_1100_0000_0100_0001_0001_0001, 1 },
                    new object[] { 0b1000_0000_1000_0010_0001_0001_1111_0000, 1 },
                    new object[] { 0b0000_0001_0000_0001_0000_0001_0000_0001, 0 }
                };
        }
    }
}
