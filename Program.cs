﻿Console.Write("Введите количество элементов массива: ");
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

//Подсчет количества элементов массива с тремя и менее символами,
//после создается массив, в который они добавляются .
string [] symbol(string [] stringArray)
{
  int n = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    n++;
  }
  string [] rez = new string [n];
  int j = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    {
        rez[j] = stringArray[i];
        j++;
    }
  }
  return rez;
}


