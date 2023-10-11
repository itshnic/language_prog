# language_prog - директория создана для знакомства и работы с языкам программирования!!!

## 1. Первый язык C#

### Установка C#

### 1. Переходим по [ссылке](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) - скачиваем и устанавливаем программу подходящую под ПО

### 2. Устанавливаем плагин C# в VSCode (смотрим самый популярный)

### 3. Создаем директорию, для нее создаем (открываем) терминал, при помощи команды {dotnet new console} - создаем новый проект. Запуск командой {dotnet run}

### 4. Встроенные функции:

```C#
Console.Write(); Вывод в одну строку
Console.WriteLine(); В конце перейти на новую строку
Console.ReadLine(); Считать строку из терминала
Math.Pow(x,степень); возведение в степень
Math.Sqrt(x,степень); корень квадратный

new Random().Next(от, до(не включ)) - рандомные числа.
Math.Round(число, количество знаков после запятой);
Math.Round(5.9234,2);//5.92

int b = int.Parse(Console.ReadLine()); int.Parse приведение к типу number (будет предупреждение)

int b = Convert.ToInt32(Console.ReadLine()); более правильное приведение к типу number

string b = Convert.ToString(Console.ReadLine()); приведение к типу STRING

Пример с конкатинацией:
Console.Write($"введите ваше имя: {переменная}"); или
Console.Write("введите ваше имя: {0} {1}", переменная1, переменная2);
```

### 5. Ветвления

```C#
if(условие){} else if(условие){}else{}

switch(параметр){
case вариант: действие break;
case вариант: действие break;
default: действие;
}

```

### 6. Циклы

```C#
while(условие){body break(выход); or confirm(повтор цикла);}
do{body break(выход); or confirm(повтор цикла);}
while(условие);
for(int i=0; условие; счетчик){body}
foreach(int key in type[]arr){body}
Цикл для двумерного массива
void PrintArr(double[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i,j]:f2}\t");
        }
        Console.WriteLine();
    }

}
```

### 7. Массивы

```C#
type []name = {};
int[] numbers = new int[указать количество символов]; для заполнения циклом
string []text = {"text1", "text2"};
Массивы менять и дополнять нельзя, только копировать.
string[,] text = new string[2(строки),5(столбцов)]; - многомерный массив
text[0, 0] - первая строка/ первый столбец
text.GetLength(0) - кол-вл строк
text.GetLength(1) - кол-вл столбцов
```

### 8. Function

```C#
void name(arg1, arg2){body function} не возвращает ни чего
int or string or int[] name(arg1, arg2){body function return}
```
