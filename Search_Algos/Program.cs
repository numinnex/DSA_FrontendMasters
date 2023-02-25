// See https://aka.ms/new-console-template for more information


int[] arr = new int[5] { 1, 2, 3, 4, 5 };
var result = BinarySearch(arr,2);

Console.WriteLine(result);


bool LinearSearch(int[] hayStack, int needle)
{
    for (int i = 0; i < hayStack.Length;i++)
    {
        if (hayStack[i] == needle)
            return true;
    }
    return false;
}

bool BinarySearch(int[] hayStack, int needle)
{
    int lo = 0;
    int hi = hayStack.Length;

    do
    {
        int midPoint = lo + (hi - lo) / 2;
        int value = hayStack[midPoint];

        if (value == needle)
            return true;
        else if (value > needle)
            hi = midPoint;
        else
            lo = midPoint + 1; 
    } while (lo < hi);

    return false;
}

int TwoCrystalBall(bool[] breaks)
{
    int jumpAmount = (int)Math.Sqrt(breaks.Length);
    int i = jumpAmount;

    for (; i < breaks.Length; i += jumpAmount)
    {
        if (breaks[i])
        {
            break;
        }
    }
    i -= jumpAmount;
    for (int j = 0; j < jumpAmount && i < breaks.Length; j++, i++)
    {
        if (breaks[i])
            return i;
    }
    return -1;
}