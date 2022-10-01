using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        (string firstName, string lastName, int age, bool anyPets, string[] petName, string[] favotireColors) User;

        (User.firstName, User.lastName, User.age) = MainInforfationOfUser();
        (User.anyPets, User.petName) = PetsOfUser();


        //MainInforfationOfUser(ref User.firstName, ref User.firstName, ref User.age);

        //Console.WriteLine($"Ваше имя: {User.firstName}; фамилия: {User.lastName}; возраст: {User.age}");
        //Console.WriteLine("Ваш возраст: {0}", User.age);

        //string[] favoriteColors = new string[3];


        //for (int i = 0; i < favoriteColors.Length; i++)
        //{
        //    favoriteColors[i] = ShowColor();
        //}

    }

    private static (string firstName, string lastName, int age) MainInforfationOfUser()
    {
        string firstName, lastName;
        int age;

        Write("Введите имя: ");
        firstName = Console.ReadLine();
        Write("Введите фамилию: ");
        lastName = Console.ReadLine();
        Console.Write("Введите возраст с цифрами:");
        age = Convert.ToInt32(Console.ReadLine());

        return (firstName, lastName, age);
    }

    private static (bool anyPets, string[] petName) PetsOfUser()
    {
        bool anyPets = false;
        string[] petName = new string[0];

        string tmpString = "";

        Write("Есть ли питомцы? да/нет : ");
        tmpString = Console.ReadLine();

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
            Write("Сколько у вас питомцев?");
            var petsCount = Convert.ToInt32(Console.ReadLine());

            petName = new string[petsCount];
        }

        for (int i = 0; i <= petName.Length - 1; i++)
        {
            string pet = "";
            Write($"Как зовут {i + 1} питомца? "); ;
            petName[i] = Console.ReadLine();
        }

        return (anyPets, petName);
    }
    private static void FavotireColorsOfUser(ref string[] favColors)
    {
        string[] favotireColors;
        Write("Сколько у вас любимых цветов?");
        var favCount = Convert.ToInt32(Console.ReadLine());
        favotireColors = new string[favCount];


        for (int i = 0; i <= favotireColors.Length - 1; i++)
        {
            string pet = "";
            Write($"{i + 1} любимый цвет: "); ;
            favotireColors[i] = Console.ReadLine();
        }



    }

    private void PrintOn()
    {

    }

}