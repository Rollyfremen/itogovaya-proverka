Console.Clear();
Console.WriteLine("Введите каждый элемент массива через пробел");
string[]element=GetArraystring(Console.ReadLine()); 


string[]GetArraystring(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return numS;
}


