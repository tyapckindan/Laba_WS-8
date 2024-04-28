class Store<T>
{
    public T[] AddInfoArr(T[] arr, T info)
    {
        T[] temp = new T[arr.Length + 1];

        for (int i = 0; i < arr.Length; i++)
        {
            temp[i] = arr[i];
        }
        temp[temp.Length - 1] = info;
        return temp;
    }
    public T[] DeleteInfoArr(T[] arr, T info)
    {
        T[] temp = new T[arr.Length - 1];

        for (int i = 0, k = 0; i < arr.Length; i++)
        {
            if (Convert.ToString(arr[i]) != Convert.ToString(info))
            {
                temp[k] = arr[i];
                k++;
            }
        }
        return temp;
    }
    public void GetInfoArr(T[] arr, int index) => Console.WriteLine($"{index} элемент массива - это {arr[index - 1]}");
    public void GetInfoLengthToArr(T[] arr) => Console.WriteLine($"Длина массива: {arr.Length}");
}
class PasswordStore: Store<string> 
{
    public string[] Passwords = Array.Empty<string>();

    public string[] AddNewPassword(PasswordStore passwords, string password) => passwords.Passwords = passwords.AddInfoArr(passwords.Passwords, password);
}
class LoginStore : Store<string>
{
    public string[] Logins = Array.Empty<string>();

    public string[] AddNewLogin(LoginStore logins, string login) => logins.Logins = logins.AddInfoArr(logins.Logins, login);
}
internal class Program
{
    private static void Main(string[] args)
    {
        PasswordStore passwordStore = new PasswordStore();
        LoginStore loginStore = new LoginStore();

        Console.Write("Добро пожаловать в систему!\nВведите логин: ");
        string login = Console.ReadLine();
        loginStore.AddNewLogin(loginStore, login);

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();
        passwordStore.AddNewPassword(passwordStore, password);
    }
}