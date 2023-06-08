Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [m];

//Ввод данных в массив
void array(string [] stringArray)
{
  for (int i = 0;i<stringArray.Length;i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     stringArray[i] = Console.ReadLine();
  }
}


