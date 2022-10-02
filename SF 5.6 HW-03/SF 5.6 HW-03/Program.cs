using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        (string firstName, string lastName, int age, bool anyPets, string[] petName, string[] favotireColors) User;

        User = UserInformation();
        PrintOnConsole(User);

        ReadKey();


    }

    static (string firstName, string lastName, int age, bool anyPets, string[] petName, string[] favotireColors) UserInformation()
    {
        (string firstName, string lastName, int age, bool anyPets, string[] petName, string[] favotireColors) User;

        (User.firstName, User.lastName, User.age) = MainInforfationOfUser();
        (User.anyPets, User.petName) = PetsOfUser();
        User.favotireColors = FavotireColorsOfUser();

        return User;
    }

    private static (string firstName, string lastName, int age) MainInforfationOfUser()
    {
        string firstName, lastName, tmpString;
        int age;

        firstName = StringConsoleRequest("Введите имя: ");

        lastName = StringConsoleRequest("Введите фамилию: ");

        age = IntConsoleRequest("Введите возраст с цифрами: ");

        return (firstName, lastName, age);
    }

    private static (bool anyPets, string[] petName) PetsOfUser()
    {
        bool anyPets = false;
        string[] petName = new string[0];

        string tmpString = "";

        tmpString = StringConsoleRequest("Есть ли питомцы? да/нет : ", "да", "нет");

        if (tmpString == "да")
        {
            anyPets = true;
        }
        else if (tmpString == "нет")
        {
            anyPets = false;
        }

        if (anyPets)
        {
            var petsCount = IntConsoleRequest("Сколько у вас питомцев?");
            petName = new string[petsCount];
        }

        for (int i = 0; i <= petName.Length - 1; i++)
        {
            petName[i] = StringConsoleRequest($"Как зовут {i + 1} питомца? ");
        }

        return (anyPets, petName);
    }
    private static string[] FavotireColorsOfUser()
    {
        string[] favotireColors;
        //string tmpString;

        var favCount = IntConsoleRequest("Сколько у вас любимых цветов?");
        favotireColors = new string[favCount];

        for (int i = 0; i <= favotireColors.Length - 1; i++)
        {
            favotireColors[i] = StringConsoleRequest($"{i + 1} любимый цвет: ");
        }
        return favotireColors;
    }

    private static void PrintOnConsole((string firstName, string lastName, int age, bool anyPets, string[] petName, string[] favotireColors) User)
    {
        WriteLine($"Ваше имя: {User.firstName}; фамилия: {User.lastName}; возраст: {User.age}");
        WriteLine("Ваш возраст: {0}", User.age);

        if (User.anyPets)
        {
            Write("Ваши питомцы: ");
            foreach (var item in User.petName)
            {
                Write(item + " ");

            }
            WriteLine();
        }
        else { WriteLine("Питомцев нет."); }


        Write("Ваши любимые цвета: ");
        foreach (var item in User.favotireColors)
        {
            Write(item + " ");
        }
        WriteLine();
    }

    private static string StringConsoleRequest(string message)
    {
        string result = "";
        string tmpString;
        bool parseSuccess = false;
        int intTemp;
        do
        {
            Write($"{message} ");
            tmpString = Console.ReadLine();
            parseSuccess = int.TryParse(tmpString, out intTemp);
            if (tmpString == "" || parseSuccess)
            {
                WriteLine("Ввод некоректный");
            }
            else
            {
                result = tmpString;
            }
        }
        while (result == "" || parseSuccess);

        return result;
    }

    private static int IntConsoleRequest(string messageIn)
    {
        string message = (string)messageIn;
        int result = 0;
        bool parseSuccess = false;
        do
        {
            Write($"{message} ");
            parseSuccess = int.TryParse(Console.ReadLine(), out result);
            if (!parseSuccess || result <= 0)
            {
                WriteLine("Ввод некоректный");
            }
        }
        while (!parseSuccess || result <= 0);

        return result;
    }

    private static string StringConsoleRequest(string messageIn, object strA, object strB)
    {
        string message = (string)messageIn;
        string result = "";
        string tmpString;
        bool parseSuccess = false;
        int intTemp;
        string strATemp = (string)strA;
        string strBTemp = (string)strB;

        do
        {
            Write($"{message} ");
            tmpString = Console.ReadLine();
            parseSuccess = int.TryParse(tmpString, out intTemp);

            if (tmpString == strATemp)
            {
                result = tmpString;
            }
            else if (tmpString == strBTemp)
            {
                result = tmpString;
            }
            else
            {
                WriteLine("Ввод некоректный");
            }
        }
        while (result == "" || parseSuccess);

        return result;
    }
}