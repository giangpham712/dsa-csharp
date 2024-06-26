﻿namespace ConsoleApp.Problems.LeetCode.SignOfTheProductOfAnArray;

public class ProblemTest
{
    [Theory]
    [InlineData(default, default)]
    public void TestSolve(object input, object expected)
    {
        var solution = new ProblemSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}