namespace kansasCityShuffle;

class Program
{
    static void Main(string[] args)
    {
        int[] numberArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        Shuffle(numberArray);

        Console.WriteLine(string.Join(", ", numberArray));
    }

    static void Shuffle(int[] value)
    {
        Random random = new();

        int tempArray;

        for (int i = value.Length - 1; i > 0; i--)
        {
            int randomRange = i + 1;
            int randomNumber = random.Next(randomRange);

            tempArray = value[i];
            value[i] = value[randomNumber];
            value[randomNumber] = tempArray; 
        }
    }
}
