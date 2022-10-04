Console.Clear();
Console.WriteLine("Введите каждый элемент массива через пробел");
string[]element=GetArraystring(Console.ReadLine()); 
for (int i = 0; i <= element.Length ; i++)
{
      if (element[i].Length <= 3)
      {
            Console.WriteLine($" {element[i]}");
      }
}

string[]GetArraystring(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return numS;
}


