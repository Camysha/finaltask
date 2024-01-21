int Prompt(string message) // Вывод сообщения и запись введённых данных
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int amount = Convert.ToInt32(value);

    return amount;
}

string[] CreateArray(int number) // создание массива
{
    string[] arr = new string[number];
    for (int i = 0; i < number; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr) // вывод массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write($"'{arr[i]}', ");
        else Console.Write($"'{arr[i]}'");
    }
    Console.Write("]");
}

int CountElement(string[] array) //метод подсчета элементов массива <3
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count ++;
    }
    return count;
}

string[] NewArray(string[] arr) //запись нового массива
{   
    int j = 0;
    string[] arr_A = new string[CountElement(arr)];
    if(arr_A.Length == 0) return arr_A;
    else
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i].Length <= 3)
            {
                arr_A[j] = arr[i];
                j ++;
            } 
        }
        return arr_A;
    } 
     
}

int number = Prompt("Введите количество элементов массива >0: ");

Console.Write("Введите элементы массива: ");

string[] result = CreateArray(number);
PrintArray(result);

string[] finalresult = NewArray(result);
Console.Write(" -> ");
PrintArray(finalresult);