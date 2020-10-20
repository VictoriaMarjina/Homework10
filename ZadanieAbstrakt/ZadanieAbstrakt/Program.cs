using System;

namespace ZadanieAbstrakt
{
    class Program
    {
        static void Main()
        {
            int n = 1000;
            Student first = new Student(n);
            int w = 0;
            Aspirant firstAsp = new Aspirant(n);
            int z = 0;

            for (; ; )
            {
                Console.WriteLine("нажмите 1 чтобы добавить Студента");
                Console.WriteLine("нажмите 2 чтобы добавить Аспиранта");
                Console.WriteLine("нажмите 3 чтобы узнать информацию о Студентах");
                Console.WriteLine("нажмите 4 чтобы узнать информацию о Аспирантах ");

                string myMenyu = Console.ReadLine();
                switch (myMenyu)
                {
                    case "1":
                        first = AddStu(first, w);
                        w++;
                        break;
                    case "2":
                        firstAsp = AddAsp(firstAsp, z);
                        z++;
                        break;
                    case "3":
                        PrintInfoStu(first, w);
                        break;
                    case "4":
                        PrintInfoAsp(firstAsp, z);
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
        static bool CheckNum(string a)
        {
            if (int.TryParse(a, out int b))
                return true;
            else
                return false;
        }
        static bool CheckStr(string a)
        {
            char[] ch = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < ch.Length; j++)
                {
                    if (a[i] == ch[j])
                        return false;
                }
            }
            return true;
        }
        static string CheckName()
        {
            string name = Console.ReadLine();
            char[] eng = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] big_eng = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] rus = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
            char[] big_rus = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я' };
            char first = name[0];
            int j = 0;
            for (int i = 0; i < big_eng.Length; i++)

            {
                if (first == big_eng[i])
                {
                    j++;

                    break;
                }

            }

            if (j == 0)
            {
                for (int i = 0; i < big_rus.Length; i++)

                {
                    if (first == big_rus[i])
                    {
                        j++;

                        break;
                    }

                }

            }

            if (j == 0)
            {
                Console.WriteLine(j);
                Console.WriteLine("Введите правильные данные");
                CheckName();
                return name;
            }
            else// j=1;
            {

                for (int k = 1; k < name.Length; k++)
                {
                    char second = name[k];
                    for (int i = 0; i < eng.Length; i++)

                    {

                        if (name[k] == eng[i])
                        {
                            j++;

                            break;
                        }
                    }
                }
                for (int k = 1; k < name.Length; k++)
                {
                    char second = name[k];
                    for (int i = 0; i < rus.Length; i++)

                    {

                        if (name[k] == rus[i])
                        {
                            j++;

                            break;
                        }
                    }
                }
            }
            if (j != name.Length)
            {
                Console.WriteLine(j);
                Console.WriteLine("Введите правильные данные");
                CheckName();
                return name;
            }
            else
            {
                return name;
            }

        }
        static string CheckLastName()
        {
            string lastname = Console.ReadLine();
            char[] eng = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] big_eng = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] rus = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
            char[] big_rus = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я' };
            char first = lastname[0];
            int j = 0;
            for (int i = 0; i < big_eng.Length; i++)

            {
                if (first == big_eng[i])
                {
                    j++;

                    break;
                }

            }

            if (j == 0)
            {
                for (int i = 0; i < big_rus.Length; i++)

                {
                    if (first == big_rus[i])
                    {
                        j++;

                        break;
                    }

                }

            }

            if (j == 0)
            {
                Console.WriteLine("Введите правильные данные");
                CheckName();
                return lastname;
            }
            else// j=1;

            {

                for (int k = 1; k < lastname.Length; k++)
                {
                    char second = lastname[k];
                    for (int i = 0; i < eng.Length; i++)

                    {

                        if (lastname[k] == eng[i])
                        {
                            j++;

                            break;
                        }


                    }
                }
                for (int k = 1; k < lastname.Length; k++)
                {
                    char second = lastname[k];
                    for (int i = 0; i < rus.Length; i++)

                    {

                        if (lastname[k] == rus[i])
                        {
                            j++;

                            break;
                        }

                    }
                }
            }
            if (j != lastname.Length)
            {
                Console.WriteLine("Введите правильные данные");
                CheckName();
                return lastname;
            }
            else
            {
                return lastname;
            }

        }
        static int InNum()
        {
            for (; ; )
            {
                string a = Console.ReadLine();
                bool b = CheckNum(a);
                if (b == true)
                {
                    int c = Convert.ToInt32(a);
                    return c;
                }
                else
                    Console.WriteLine("не коректные данные повторите ввод");
            }
        }
        static string InStr()
        {
            for (; ; )
            {
                string a = Console.ReadLine();
                bool b = CheckStr(a);
                if (b == true)
                    return a;
                else
                    Console.Write("не коректные данные повторите ввод:\t");
            }
        }
        static string InZachet()
        {
            for (; ; )
            {
                int a = InNum();
                if (a < 10000000 && a > 99999999)
                {
                    string b = Convert.ToString(a);
                    return b;
                }
                else
                    Console.Write("номер зачетной книжки дожен быть не меньше и не длиннее 8символов");
            }
        }
        public static Student AddStu(Student first, int i)
        {
            for (; ; )
            {
                first[i] = new Student();
                Console.WriteLine("Введите имя студента");
                first[i].Name = CheckName();
                Console.WriteLine("Введите фамилию студента");
                first[i].Lastname = CheckLastName();
                Console.WriteLine("Введите курс обучения");
                first[i].Kurs = InNum();
                Console.WriteLine("Введите номер зачетной книжки");
                first[i].Zachet = InNum();
                Console.WriteLine($"Хэш-код имени студента {first[i].GetHashCode()}");

                Console.WriteLine("чтобы добавить ещё 1 студента нажмите 1");
                Console.WriteLine("чтобы выйти в меню нажмите любую цифру");
                int a = InNum();
                if (a == 1)
                {
                    AddStu(first, i + 1);
                }
                else
                    break;
            }
            return first;

        }
        static Aspirant AddAsp(Aspirant firstAsp, int i)
        {
            Console.WriteLine(i);
            for (; ; )
            {
                firstAsp[i] = new Aspirant();
                Console.WriteLine("Введите имя аспиранта");
                firstAsp[i].Name = CheckName();
                Console.WriteLine("Введите фамилию аспиранта");
                firstAsp[i].Lastname = CheckLastName();
                Console.WriteLine("Введите курс обучения");
                firstAsp[i].Kurs = InNum();
                Console.WriteLine("Введите номер зачетной книжки");
                firstAsp[i].Zachet = InNum();
                Console.WriteLine("Введите тему дисертации");
                firstAsp[i].Diss = InStr();
                Console.WriteLine(firstAsp[i].ToString());
                if (firstAsp[i].GetType() == typeof(Aspirant))
                    Console.WriteLine("Это реально Аспирант");

                Console.WriteLine("нажмите 1 чтобы добавить ещё аспиранта");
                Console.WriteLine("Нажмите любую цифру чтобы выйти");
                int a = InNum();
                if (a == 1)
                    AddAsp(firstAsp, i + 1);
                else
                    break;
            }
            return firstAsp;
        }
        static void PrintInfoStu(Student first, int stud)
        {
            Console.WriteLine($"Всего {stud} студентов");
            Console.WriteLine("Введите номер студента для вывода информации");
            int a = InNum();
            first[a]?.PrintInfo();
        }
        static void PrintInfoAsp(Aspirant firstAsp, int asp)
        {
            Console.WriteLine($"Всего {asp} аспирантов");
            Console.WriteLine("Введите номер аспиранта для вывода информации");
            int a = InNum();
            firstAsp[a]?.PrintInfo();
        }
    }

    abstract class People
    {
        public string Name { get; set; }
        public string Lastname { get; set; }

        public People()
        {

        }

        public People(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }

    }
    class Student : People
    {
        private int kurs;
        public int Kurs { get; set; }
        private int zachet;
        public int Zachet { get; set; }
        private int n;
        public int N { get; set; }
        public Student[] data;
        public Student() { }
        public Student(int n)
        {
            data = new Student[n];
        }
        public Student(string name, string lastname, int kurs, int zachet, int n) : base(name, lastname)
        {
            data = new Student[n];
        }

        public Student this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Имя и  фамилия студента: {Name} {Lastname} \n Курс обучения: {Kurs} \n Номер зачетной книжки: {Zachet}");
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
    class Aspirant : People
    {
        private int kurs;
        public int Kurs { get; set; }
        private int zachet;
        public int Zachet { get; set; }
        private int n;
        public int N { get; set; }

        private Aspirant[] dataAsp;
        public Aspirant() { }
        public Aspirant(int n)
        {
            dataAsp = new Aspirant[n];
        }
        public Aspirant(string name, string lastName, int kurs, int zachet, string diss, int n)
            : base(name, lastName)
        {
            dataAsp = new Aspirant[n];
        }
        public string Diss { get; set; }

        public new Aspirant this[int index]
        {
            get
            {
                return dataAsp[index];
            }
            set
            {
                dataAsp[index] = value;
            }
        }
        public new void PrintInfo()
        {
            Console.WriteLine($"Имя и фамилия аспиранта: {Name} {Lastname} \n  Номер зачетной книжки: {Zachet} \n Тема дисертации: {Diss}");

        }
        public override string ToString()
        {
            return $"Студент {Name} {Lastname} пишет дисертацию на тему {Diss}";
        }
    }
}
