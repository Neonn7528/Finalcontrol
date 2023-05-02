Console.WriteLine("Введите элементы массива через пробел:");
string[] firstArray = Console.ReadLine().Split(' ');
string[] nums = new string[firstArray.Length];
SecondArray(firstArray, nums);
PrintArray(nums);

void SecondArray(string[] firstArray, string[] nums)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            nums[count] = firstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
       Console.WriteLine($"[{string.Join(" ", array)}]");
}