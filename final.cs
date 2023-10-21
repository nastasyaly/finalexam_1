//Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше,
 //либо равна 3 символам. Первоначальный массив можно 
 //ввести с клавиатуры, либо задать на старте выполнения 
 //алгоритма. При решении не рекомендуется пользоваться
  //коллекциями, лучше обойтись исключительно массивами
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

 string[] array = {"afgdfgdfg", "b", "c", "d"};
 string[] newArray = new string[array.Length];
void ReduceArraySymbol(string[] array1, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[index] = array1[i];
        index++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ReduceArraySymbol(array, newArray);
PrintArray(array);
PrintArray(newArray);


 