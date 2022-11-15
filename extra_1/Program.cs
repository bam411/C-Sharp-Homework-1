// 1. В переменной string есть секретное сообщение, во второй есть пароль. Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.

string secret = "Well done, boy!";
string pswd = "password";
int a = 1;

while (a <= 3)
{
    Console.WriteLine("Please enter password: ");
    string message = Console.ReadLine();
    if (message == pswd)
    {
        Console.WriteLine(secret);
        break;
    }
    else
    {
        Console.WriteLine("Password is incorrect! Try again");
    }
    a++;
}