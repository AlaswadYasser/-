// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


Console.WriteLine("Сколька элемент массива?");
int elements = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [elements];
void array(string [] stringArray)
{
  for (int i = 0; i<stringArray.Length; i++)
  {
     Console.WriteLine($"({i+1}) элемент массива:");
     stringArray[i] = Console.ReadLine();
  }
}
string [] symbol(string [] stringArray)
{
  int n = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    n++;
  }
  string [] result = new string [n];
  int x = 0;
  for (int i = 0; i<stringArray.Length; i++)
  {
    if(stringArray[i].Length <=3)
    {
        result[x] = stringArray[i];
        x++;
    }
  }
  return result;
}
void print(string [] stringArray)
{
    Console.Write("Массивы у которых меньше трех элементов:[");
    for (int i = 0; i<stringArray.Length; i++)
    {
    Console.Write($"“{stringArray[i]}”,");
    }
    Console.Write("]");
}
array(stringArray);
print(symbol(stringArray));