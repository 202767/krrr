void ShowArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("] ");
    Console.WriteLine();
}

string[] CreateArray(int length)
{
    string[] myArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Input an element of array: ");
        myArray[i] = Console.ReadLine();
    }
    return myArray;
}

string[] CreateNewArrayOfThreeLengthElements(string[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) count++;
    string[] newArray = new string[count];
    if (count > 1)
    {
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[j] = array[i];
                j++;
            }
        }
    }
    else newArray[0] = "You haven't input anything! ";
    return newArray;
}