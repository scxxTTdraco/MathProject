using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;

namespace NewProject
{

    class SystemMain
    {

        static Login id = new Login();


        static void Main(string[] args)
        {

            Login user = new Login();       

            Console.WriteLine("Create your username: ");
            user.NameCreate = Console.ReadLine();
            Console.WriteLine("Create your password: ");
            user.PasswordCreate = Console.ReadLine();

            while (id.IdFor1 < 3)
            {

                Console.WriteLine("Enter your username: ");
                user.NameDef = Console.ReadLine();

                Console.WriteLine("Enter your password: ");
                user.PasswordDef = Console.ReadLine();
                id.IdFor1++;

                if (user.NameDef == user.NameCreate && user.PasswordCreate == user.PasswordDef)
                {

                    id.IdFor1++;
                    Console.WriteLine("\t\t--------------Login Acceptd----------------");

                    while (id.IdChooseFor == 0)
                    {
                        Console.WriteLine("\n(1) For Calculator \n(2) For Average Calculator \n(3) Radius Calculator \n(4) Triangle Calculator \n(5) Notes of students notes \n(6) For exit");
                        id.IdFun = Math.Abs(double.Parse(Console.ReadLine()));

                        if (id.IdFun >= 1 && id.IdFun <= 5)
                        {
                            
                            Func();
                        }
                        else if (id.IdFun == 6){
                            Console.WriteLine("(ENTER FOR EXIT PROGAM)");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Number must be to 1 for 5, Try again");
                        }
                    }
                }
                if (id.IdFor1 == 3)
                {
                    Console.WriteLine("Max tentatives");
                }
                else
                {
                    Console.WriteLine("Invalid password or username, try other chance");
                }
            }
        }

        static void Func()
        {

            if (id.IdFun == 1)
            {
                Console.WriteLine("\t\t-------------Calculator--------------");
                while (id.CalcFor < 1)
                {
                    Console.WriteLine("(1) For Sum \t (2) For Division \t (3) For Subtracion \t (4) For Multiplication");
                    id.Calc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Enter first number of operation: ");
                    double a = Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                    Console.WriteLine("Enter second number of operation: ");
                    double b = Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                    if (id.Calc >= 1 && id.Calc <= 4)
                    {
                        id.CalcFor++;

                        switch (id.Calc)
                        {

                            case 1:

                                Console.WriteLine("Result: "
                                + a.ToString("F2", CultureInfo.InvariantCulture)
                                + " + "
                                + b.ToString("F2", CultureInfo.InvariantCulture)
                                + " = "
                                + Calculate.ResSoma(a, b));
                                break;

                            case 2:

                                if (b == 0)
                                {
                                    Console.WriteLine("No exist division with 0");
                                }
                                else
                                {
                                    Console.WriteLine("Result: "
                                   + a.ToString("F2", CultureInfo.InvariantCulture)
                                   + " / "
                                   + b.ToString("F2", CultureInfo.InvariantCulture)
                                   + " = "
                                   + Calculate.ResDivi(a, b));
                                }
                                break;

                            case 3:

                                Console.WriteLine("Result: "
                                + a.ToString("F2", CultureInfo.InvariantCulture)
                                + " - "
                                + b.ToString("F2", CultureInfo.InvariantCulture)
                                + " = "
                                + Calculate.ResSubtr(a, b));
                                break;

                            case 4:

                                Console.WriteLine("Result: "
                                + a.ToString("F2", CultureInfo.InvariantCulture)
                                + " x "
                                + b.ToString("F2", CultureInfo.InvariantCulture)
                                + " = "
                                + Calculate.ResMult(a, b));
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Number he must be 1 to 4");
                    }
                }
            }
            else if (id.IdFun == 2)
            {

                Console.WriteLine("\t\t-----------Calculator of average-------------");

                Average ava = new Average();

                Console.WriteLine("Enter how many number for know their average: ");
                ava.n1 = Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                for (int i = 0; i < ava.n1; i++)
                {
                    Console.WriteLine("Number {0}: ", i + 1);
                    ava.n2 += Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                }

                Console.WriteLine("Result of average: " + ava.CalAverage().ToString("F2"), CultureInfo.InvariantCulture);
            }

            else if (id.IdFun == 3)
            {
                Console.WriteLine("\t\t----------Radius measures------------");

                Console.WriteLine("Type the radius: ");
                double ra = Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine("Circumference: " + Calculate.Circ(ra).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Volume: " + Calculate.Vol(ra).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Value of pi: " + Calculate.pi.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (id.IdFun == 4)
            {
                Console.WriteLine("\t\t------------Area of triangle----------------");

                double aX = 0.0;
                double aY = 0.0;
                Triangle x = new Triangle();
                Triangle y = new Triangle();

                Console.WriteLine("Enter with of 3 measures of triangle X: ");
                x.A = Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                x.B = Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                x.C = Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine("Enter with of 3 measures of triangle Y: ");
                y.A = Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                y.B = Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                y.C = Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                aX = x.CalTriagle(x.A, x.B, x.C);
                aY = y.CalTriagle(y.A, y.B, y.C);

                if (aX > aY)
                {
                    Console.WriteLine("Bigger area is triangle (X): " + aX.ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (aY == aX)
                {
                    Console.WriteLine("Triangle X and Y is iguality and area");
                }
                else
                {
                    Console.WriteLine("Bigger area is triangle (Y) : " + aY.ToString("F2", CultureInfo.InvariantCulture));
                }
            }

            else if (id.IdFun == 5)
            {
                Student stud = new Student();

                Console.WriteLine("-----------Student Notes--------------");

                Console.WriteLine("Enter name of student: ");
                stud.Name = Console.ReadLine();

                Console.WriteLine("Enter how many number of avaliations notes: (From 0 to 10)");
                while (id.ForAvarage < 1 && id.ForAvarage < 3)
                {
                    stud.Num = Math.Abs(Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                    {
                        if (stud.Num <= 10)
                        {
                            for (int i = 0; i < stud.Num; i++)
                            {
                                Console.WriteLine("Note ({0}): ", i + 1);
                                stud.Note += Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                            }

                            if (stud.CalAvarege() >= 7 && stud.CalAvarege() <= 10)
                            {
                                id.ForAvarage++;
                                Console.WriteLine("Approved " + stud);
                            }
                            else if (stud.CalAvarege() < 7)
                            {
                                id.ForAvarage++;
                                Console.Write("Reproved " + stud);
                                Console.WriteLine(", Missed " + stud.RemoNote().ToString("F2", CultureInfo.InvariantCulture) + " Points");
                            }
                            else
                            {
                                id.ForAvarage++;
                                Console.WriteLine("The number insered in notes must be from 0 to 10");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The number must be from 1 to 10, Try again: ");
                        }
                    }
                }
            }
        }
    }
}