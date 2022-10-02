using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        (string firstName, string lastName, int age, bool anyPets, string[] petName, string[] favotireColors) User;

        (User.firstName, User.lastName, User.age) = MainInforfationOfUser();
        (User.anyPets, User.petName) = PetsOfUser();
        User.favotireColors= FavotireColorsOfUser();






        //string[] favoriteColors = new string[3];


        //for (int i = 0; i < favoriteColors.Length; i++)
        //{
        //    favoriteColors[i] = ShowColor();
        //}


        //PrintOnConsole(ref User);
        ReadKey();


    }

    private static (string firstName, string lastName, int age) MainInforfationOfUser()
    {
        string firstName, lastName, tmpString;
        int age;

        tmpString = "Введите имя: ";
        firstName = StringConsoleRequest(tmpString);


        tmpString = "Введите фамилию: ";
        lastName = StringConsoleRequest(tmpString);

        tmpString = "Введите возраст с цифрами: ";
        age = IntConsoleRequest(tmpString);

        return (firstName, lastName, age);
    }

    private static (bool anyPets, string[] petName) PetsOfUser()
    {
        bool anyPets = false;
        string[] petName = new string[0];

        string tmpString = "";
        string strA = "да";
        string strB = "нет";
        tmpString = $"Есть ли питомцы? {strA}/{strB} : ";
        tmpString = StringConsoleRequest(tmpString, "да", "нет");

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
            tmpString = "Сколько у вас питомцев?";
            var petsCount = IntConsoleRequest(tmpString);
            petName = new string[petsCount];
        }

        for (int i = 0; i <= petName.Length - 1; i++)
        {
            tmpString = $"Как зовут {i + 1} питомца? ";
            petName[i] = StringConsoleRequest(tmpString);
        }

        return (anyPets, petName);
    }
    private static string[] FavotireColorsOfUser()
    {
        string[] favotireColors;
        string tmpString;

        tmpString = "Сколько у вас любимых цветов?";
        var favCount = IntConsoleRequest(tmpString);
        favotireColors = new string[favCount];

        for (int i = 0; i <= favotireColors.Length - 1; i++)
        {
            tmpString = $"{i + 1} любимый цвет: ";
            favotireColors[i] = StringConsoleRequest(tmpString);
        }
        return favotireColors;
    }

    private static void PrintOnConsole(ref (string firstName, string lastName, int age, bool anyPets, string[] petName, string[] favotireColors) User)
    {
        //Console.WriteLine($"Ваше имя: {User.firstName}; фамилия: {User.lastName}; возраст: {User.age}");
        //Console.WriteLine("Ваш возраст: {0}", User.age);
    }

    private static string StringConsoleRequest(object messageIn)
    {
        string message = (string)messageIn;
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
            if (!parseSuccess || result == 0)
            {
                WriteLine("Ввод некоректный");
            }
        }
        while (!parseSuccess || result == 0);

        return result;
    }

    private static string StringConsoleRequest(string messageIn, object strA, object strB)
    {
        string message = (string)messageIn;
        string result = "";
        string tmpString;
        bool parseSuccess = false;
        int intTemp;
        string strATemp= (string)strA;
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