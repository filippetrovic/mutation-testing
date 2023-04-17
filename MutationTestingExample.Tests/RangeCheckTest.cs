using FluentAssertions;
using MutationTestingExample.App;

namespace MutationTestingExample.Tests;

public class RangeCheckTest
{
    private readonly RangeCheck _rangeCheck;

    public RangeCheckTest()
    {
        _rangeCheck = new RangeCheck();
    }

    // ...

    [Fact]
    public void TestNotInRange()
    {
        var result = _rangeCheck.Check(1, 2, 3, 4);

        result.Should().Be("Not in range");
    }

    [Fact]
    public void TestInRange()
    {
        var result = _rangeCheck.Check(6, 7, 8);

        result.Should().Be("In range");
    }
}