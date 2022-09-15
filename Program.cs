/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"]-> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
string[] array1 = { "123", "Length", "23", "098", "hello", "res", "world", "yes", "dzo"};
string[] array2 = new string[array1.Length];
SecondArrayWithIF(array1, array2);
array2 = array2.Where(x => x != null).ToArray();
Console.WriteLine($"\n" + '[' + string.Join(", ", array1) + ("] -> [") + string.Join(", ", array2) + ']' + "\n");