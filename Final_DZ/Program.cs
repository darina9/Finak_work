Console.Write("Какое количество компонентов массива хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите элемент {i+1} : ");
    string component = Convert.ToString(Console.ReadLine());
    arrayStrings[i] = component;
}

string[] arrayFinal = new string[size];
int lengthLimit = 3;
int temp = 0;

for (int j = 0; j < size; j++)
{
    if (arrayStrings[j].Length <= lengthLimit)
    {
        arrayFinal[temp] = arrayStrings[j];
        temp++;
    }
}

Console.WriteLine("Новый массив");
PrintArray(arrayFinal);
void PrintArray(string[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write( array[i]+"\t");
    }
    
}


