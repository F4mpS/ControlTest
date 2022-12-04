int CountStrings(string[] list)
{
    int lenght = list.Length;
    int count = 0;

    for (int i = 0; i < lenght; i++)
    {
        if (list[i].Length <= 3) count++;
    }

    return count;
}


string[] SortList(string[] list)
{
    int sortedListLenght = CountStrings(list);
    string[] sortedList = new string[sortedListLenght];

    for (int i = 0; i < list.Length; i++)
    {
        if (list[i].Length <= 3)
        {
            sortedList.Append(list[i]);
        }

    }

    return sortedList;
}


Console.Write("Введите размер массива строк >>> ");
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

