using System;

namespace Classes
{


    class Program
    {
        static void Main(string[] args)
        {
            Optiuni();
            string optiune;
            optiune = Console.ReadLine();
            int optiuneConvertita = 0;
            int i = 0;
            int j = 0;
            int temp = 0;
            string name, password;
            bool ok = false, found = false;

            Users[] person = new Users[1];


            while (optiuneConvertita != 1 && optiuneConvertita != 2 && optiuneConvertita != 3 && optiuneConvertita != 4)
            {
                try
                {
                    optiuneConvertita = int.Parse(optiune);
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("This option does not exist. Please try again ");
                    Optiuni();
                    optiune = Console.ReadLine();
                }
                if (optiuneConvertita < 1 || optiuneConvertita > 4)
                {
                    Console.Clear();
                    Console.WriteLine("This option does not exist. Please try again ");
                    Optiuni();
                    optiune = Console.ReadLine();
                }
                Console.Clear();

            }
            while (optiuneConvertita == 1 || optiuneConvertita == 2 || optiuneConvertita == 3)
            {
                if (optiuneConvertita == 1)
                {   //Login
                    Console.Clear();
                    Console.WriteLine("Introduceti numele: ");
                    name = Console.ReadLine();
                    ok = false;
                    temp = 0;
                    found = false;
                    while (ok == false)
                    {
                        ok = true;
                        for (j = 0; j < person.Length; j++)
                        {
                            if (name == person[j].username)
                            {
                                temp = j;
                                found = true;
                            }
                        }
                        if (found == false)
                        {
                            Console.WriteLine("Numele " + name + " nu exista, introduceti un nume valid ");
                            name = Console.ReadLine();
                            ok = false;
                        }
                    }
                    if (found == true)
                    {
                        Console.WriteLine(" Introduceti parola ");
                        password = Console.ReadLine();
                        if (person[temp].password == password)
                        {
                            Console.WriteLine(" The log in was a succes! ");
                            Optiuni();
                            optiune = Console.ReadLine();
                            try
                            {
                                optiuneConvertita = int.Parse(optiune);
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("This option does not exist. Please try again ");
                                Optiuni();
                                optiune = Console.ReadLine();
                            }
                            if (optiuneConvertita < 1 || optiuneConvertita > 4)
                            {
                                Console.Clear();
                                Console.WriteLine("This option does not exist. Please try again ");
                                Optiuni();
                                optiune = Console.ReadLine();
                            }
                            Console.Clear();
                        }
                    }
                }
                if (optiuneConvertita == 2)
                {
                    ok = false;
                    //Register
                    Console.WriteLine("Introduceti numele: ");
                    name = Console.ReadLine();
                    while (ok == false)
                    {
                        ok = true;
                        for (j = 0; j < person.Length; j++)
                        {
                            if (name == person[j].username)
                            {
                                Console.WriteLine("This username already exist, please introduce a different username ");
                                ok = false;
                                Console.WriteLine("Introduceti numele: ");
                                name = Console.ReadLine();
                            }
                        }
                    }
                    person[i].username = name;
                    Console.WriteLine("Introduceti parola: ");
                    person[i].password = Console.ReadLine();
                    person[i].blocked = false;
                    Console.WriteLine(" You are registered ");
                    Array.Resize(ref person, person.Length + 1);
                    i = i + 1;
                    Optiuni();
                    optiune = Console.ReadLine();
                    try
                    {
                        optiuneConvertita = int.Parse(optiune);
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("This option does not exist. Please try again ");
                        Optiuni();
                        optiune = Console.ReadLine();
                    }
                    if (optiuneConvertita < 1 || optiuneConvertita > 4)
                    {
                        Console.Clear();
                        Console.WriteLine("This option does not exist. Please try again ");
                        Optiuni();
                        optiune = Console.ReadLine();
                    }
                    Console.Clear();
                }
                if (optiuneConvertita == 3)
                {
                    Console.WriteLine("Introduceti numele: ");
                    name = Console.ReadLine();
                    ok = false;
                    temp = 0;
                    found = false;
                    while (ok == false)
                    {
                        ok = true;
                        for (j = 0; j < person.Length; j++)
                        {
                            if (name == person[j].username)
                            {
                                temp = j;
                                found = true;
                            }
                        }
                        if (found == false)
                        {
                            Console.WriteLine("Numele " + name + " nu exista, introduceti un nume valid ");
                            name = Console.ReadLine();
                            ok = false;
                        }
                    }
                    Console.WriteLine(" Introduceti parola ");
                    password = Console.ReadLine();
                    if (person[temp].password == password)
                    {
                        Console.WriteLine(" Introduceti noua parola ");
                         person[temp].password = Console.ReadLine();
                        Console.WriteLine(" Parola a fost schimbata cu succes! ");
                        Optiuni();
                        optiune = Console.ReadLine();
                        try
                        {
                            optiuneConvertita = int.Parse(optiune);
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("This option does not exist. Please try again ");
                            Optiuni();
                            optiune = Console.ReadLine();
                        }
                        if (optiuneConvertita < 1 || optiuneConvertita > 4)
                        {
                            Console.Clear();
                            Console.WriteLine("This option does not exist. Please try again ");
                            Optiuni();
                            optiune = Console.ReadLine();
                        }
                        Console.Clear();
                    }

                }

            }
            if (optiuneConvertita == 4) Console.WriteLine("The program will close now");
        }
        public static void Optiuni()
        {
            Console.WriteLine("Alegeti numarul corespunzator uneia dintre urmatoarele optiuni: ");
            Console.WriteLine("1) Log in ");
            Console.WriteLine("2) Register ");
            Console.WriteLine("3) change password ");
            Console.WriteLine("4) exit ");
        }
        public static void Login()
        {

        }
        public static void Register()
        {
        }
        public static void ChangePassword()
        {

        }
    }
}