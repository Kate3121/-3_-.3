using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лр3_См3
{
    internal class Program
    {
        class Parent
        {
            protected string Pole1;//ім'я;
            protected int Pole2;//рік народження
            protected double Pole3;//дохід
            protected double Pole4;//податок;
            public Parent() { }//Конструктор без параметрів;
                               //Конструктор, з трьома параметрами, що привласнює значення всім полям
            public Parent(string Pole1, int Pole2, double Pole3)
            {
                this.Pole1 = Pole1; this.Pole2 = Pole2; this.Pole3 = Pole3;
            }
            public void Print()//виводить на екран значення полів
            {
                Console.WriteLine($"{Pole1}, рік народження {Pole2}, дохiд {Pole3}, податок {Pole4}");
            }
            public double Metod1(int Pole2)
            {
                // Виконуємо необхідні перевірки і обчислення
                if (Pole2 < 17 || Pole3 < 1000)
                { Pole4 = 0; }
                else if (Pole2 >= 17 && Pole3 >= 1000 && Pole3 <= 10000)
                { Pole4 = Pole3 * 0.2; }
                else
                { Pole4 = Pole3 * 0.25; }
                return Pole4;
            }
            class Child : Parent//дочірній клас
            {
                public double Pole5 { get; set; }
                public Child(string pole1, int pole2, double pole3, double pole5) : base(pole1, pole2, pole3)
                {
                    Pole5 = pole5;//знижки
                }
                public void Print()//виводимо на екран
                {
                    base.Print();
                    Console.WriteLine("% знижки: " + Pole5);
                }
                public double Metod2()//визначається знижка на податки
                {
                    double discount = Pole4 * (Pole5 / 100);
                    return discount;
                }
            }
            internal class Program
            {
                static void Main(string[] args)
                {
                    Parent parent = new Parent("Iван", 1990, 1000);
                    parent.Metod1(2022);
                    parent.Print();
                    Console.WriteLine();
                    Child child = new Child("Петро", 2005, 2000, 10);
                    child.Metod1(2022);
                    child.Print();
                    double discount = child.Metod2();
                    Console.WriteLine("Знижка на податки: " + discount);
                }
            }
        } 
    }

}
    

