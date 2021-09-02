using System;
using System.Linq;
using Exercises;
using Xunit;

namespace ProgramTests
{
    public class ExerciseTests
    {
        [Theory]
        [InlineData(2, 3)]
        [InlineData(4, 9)]
        public void GetNumbersFromTo(int from, int to)
        {
            var result = Program.GetNumbersFromTo(from, to);

            int[] expected;

            if (from == 2 && to == 3)
                expected = new[] {2, 3};
            else
                expected = new[] {4, 5, 6, 7, 8, 9};

            Assert.True(expected.SequenceEqual(result));
        }

        [Theory]
        [InlineData("Vilius")]
        [InlineData("Milda")]
        [InlineData("Ginte")]
        public void ReverseString(string someString)
        {
            var result = Program.ReverseString(someString);

            var expected = someString switch
            {
                "Vilius" => "suiliV",
                "Milda" => "adliM",
                "Ginte" => "etniG",
            };

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData("Vilius Zobela")]
        [InlineData("Milda Jakstaite")]
        [InlineData("Ginte Zobeliene")]
        public void GetNameInitials(string fullName)
        {
            var result = Program.GetNameInitials(fullName);

            var expected = fullName switch
            {
                "Vilius Zobela" => "V.Z.",
                "Milda Jakstaite" => "M.J.",
                "Ginte Zobeliene" => "G.Z.",
            };

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("39712043371")]
        [InlineData("39812043371")]
        [InlineData("39711043371")]
        [InlineData("39711053371")]
        public void ExtractBirthdateFromPersonalCode(string personalCode)
        {
            var result = Program.ExtractBirthdateFromPersonalCode(personalCode);

            var expected = personalCode switch
            {
                "39712043371" => new DateTime(1997, 12, 4),
                "39812043371" => new DateTime(1998, 12, 4),
                "39711043371" => new DateTime(1997, 11, 4),
                "39711053371" => new DateTime(1997, 11, 5),
            };

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] {1, 2, 3, 4})]
        [InlineData(new[] {1, 7, 3, 4})]
        [InlineData(new[] {1, 7, 9, 4})]
        public void GetAverageGrade(int[] grades)
        {
            var result = Program.GetAverageGrade(grades);
            var expected = grades.Average();

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(330, 10)]
        [InlineData(330, 20)]
        [InlineData(440, 10)]
        [InlineData(440, 20)]
        public void CalculateDiscount(int originalPrice, int discount)
        {
            var result = Program.CalculateDiscount(originalPrice, discount);

            var expected = (originalPrice, discount) switch
            {
                (330, 10) => 330 * 0.9,
                (330, 20) => 330 * 0.8,
                (440, 10) => 440 * 0.9,
                (440, 20) => 440 * 0.8,
            };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void PositiveNegativeNumbers()
        {
            var result = Program.PositiveNegativeNumbers(new[] {-5, 1, 5, -10, -3});

            var expected = new[] {"negative", "positive", "positive", "negative", "negative"};

            var correct = !result.Where((t, i) => !t.Equals(expected[i])).Any();

            Assert.True(correct);
        }
    }
}