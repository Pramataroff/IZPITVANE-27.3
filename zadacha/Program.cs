namespace zadacha
{
    internal class Program
    {
        //        Да се създаде масив, който съдържа 26 елемента
        //1) Напишете и извикайте метод за въвеждане на оценките на учениците от Вашата група /от 14-26 номер/ - 3т.
        //2) Изведете на конзолата празните /0/ оценки - 3т.
        //3) Да се изведе на конзолата БРОЯ на 6-ците в класа - 2т. /с метод/
        //4) Напишете метод, който връща всички оценки /като List<int> /, които са по-големи от Вашата оценка - 4т.
        //5) Изведете на конзолата оценката на Вашия номер - 1т.
        //6) Да се изведе на конзолата ПОСЛЕДНИЯТ елемент на масива  - 1т.
        //7) Да се отпечати средно-аритметичното на елементите, които са в средата на масива - 3т.
        //8) Да се постави оценка "Отличен" на Вашия номер - 1т.
        //9). Да се въведе името Ви и да се отпечати, като средната / средните букви БЪДАТ ЗАМЕНЕНИ с @ - 2т.
        static int[] ocenki = new int[26];
        static int mygrade = 0;
        static void Main(string[] args)
        {
            Input();
            Zeros();
            Excelent();
            BetterThanMyGrades();
            Console.WriteLine($"My grade is {ocenki[14]} ");
            LastElement();
            mygrade = 6;
            Console.WriteLine($"My grade now is {mygrade}");
            Middle();
            cenzura();
        }
        static void Input()
        {
            for (int i = 13; i < ocenki.Length; i++)
            {
                Console.Write($"Enter number's {i + 1} grade: ");
                ocenki[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Zeros()
        {
            int counter = 0;
            for (int i = 0; i < ocenki.Length; i++)
            {
                if (ocenki[i] == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"There are: {counter} students without grades.");
        }
        static void Excelent()
        {
            int counter6ci = 0;
            for (int i = 0; i < ocenki.Length; i++)
            {
                if (ocenki[i] == 6)
                {
                    counter6ci++;
                }
            }
            Console.WriteLine($"The number of the sixes in class is: {counter6ci}.");
        }
        static void BetterThanMyGrades()
        {
            int mygrade = ocenki[14];
            for (int i = 0; i < ocenki.Length; i++)
            {
                if (mygrade < ocenki[i])
                {
                    Console.WriteLine($"Student {i + 1} is better than me with grade {ocenki[i]}");
                }
            }
        }
        static void LastElement()
        {
            Console.WriteLine("Last grade is: " + ocenki[ocenki.Length - 1]);
        }
        static void Middle()
        {
            int middle = ocenki.Length / 2;
            Console.WriteLine($"the grade of the middle element is {ocenki[middle]}");
        }
        static void cenzura()
        {
            Console.Write("Write your name: ");
            string name = Console.ReadLine();
            char[] duma = name.ToArray();
            char cenzura = '@';
            if (name.Length % 2 == 1)
            {
                name.Replace(name[name.Length / 2], cenzura);
                name.Replace(name[(name.Length / 2) + 1], cenzura);
                name.Replace(name[(name.Length / 2) - 1], cenzura);
                Console.WriteLine(name);
            }
            else
            {
                name.Replace(name[name.Length / 2], cenzura);
                Console.WriteLine(name);
            }
        }
    }

}
