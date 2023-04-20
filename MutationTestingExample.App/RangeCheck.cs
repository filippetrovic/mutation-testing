namespace MutationTestingExample.App;

public class RangeCheck
{
    private const int AllowedMin = 5;
    private const int AllowedMax = 10;

    public string Check(params int[] elements)
    {
        var min = elements.Min();
        var max = elements.Max();

        if (min >= AllowedMin && max <= AllowedMax)
        {
            return "In range";
        }

        return "Not in range";
    }
}