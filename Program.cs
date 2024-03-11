//Time complexity O(NlogN) Space complexity O(1)
public class Program
{
    static void Main(string[] args)
    {
        int[] coins = { 5, 7, 1, 1, 2, 3, 22 };
        int result = NonConstructibleChange(coins);
        Console.WriteLine("Result: " + result);
    }

    public static int NonConstructibleChange(int[] coins)
    {
        if (coins.Length < 1) return 1;
        Array.Sort(coins); //O(NlogN)

        int change = 0;
        foreach (int elt in coins)
        { //O(N)
            if (elt > change + 1)
                return change + 1;
            change = elt + change;
        }

        return change + 1;
    }
}