Console.Clear();
Console.WriteLine("Введите каждый элемент массива через пробел");
int[]element=GetArraystring(Console.ReadLine());



int[]GetArraystring(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i]= int.Parse(numS[i]);
    }
    return result;
}

