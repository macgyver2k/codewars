public class SumParts
{
    public static int[] PartsSums(int[] ls)
    {
        var result = new int[ls.Length + 1];

        for (int i = ls.Length - 1; i >= 0; i--)
        {
            result[i] = ls[i] + result[i + 1];
        }

        return result;
    }
}