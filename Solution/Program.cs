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



