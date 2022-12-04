int CountStrings(string[] list)     // Получение количества строк с длинной меньшей или равной 3
{
    int lenght = list.Length;
    int count = 0;

    for (int i = 0; i < lenght; i++)
    {
        if (list[i].Length <= 3) count++;
    }

    return count;
}


string[] SortList(string[] list)    // Сортировка заданного массива по условию задачи
{
    int sortedListLenght = CountStrings(list);
    int startPos = 0;   // 0 элемент отсортированного массива
    string[] sortedList = new string[sortedListLenght];

    for (int i = 0; i < list.Length; i++)
    {
        if (list[i].Length <= 3)
        {
            sortedList[startPos] = list[i];
            startPos++;     // Переход на следующий элемент отсортированного массива
        }
    }

    return sortedList;
}


string GetList(string[] list)   // Вывод любого массива
{
    return "[" + string.Join(", " , list) + "]";
}


Console.Write("Введите длинну массива строк >>> ");
int l = Convert.ToInt32(Console.ReadLine());
string[] userList = new string[l];
string userString;

for (int i = 0; i < l; i++)
{
    Console.Write("Введите любой текст >>> ");
    userString = Console.ReadLine();
    userList[i] = userString;
}

string[] sortedList = SortList(userList);
Console.WriteLine(GetList(userList) + " >>> " + GetList(sortedList));
