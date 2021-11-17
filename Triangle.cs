using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korsunovwebform
{
    class Triangle
    {
        public double a; //первая сторона
        public double b; //вторая сторона
        public double c; //третья сторона
        public double hb; //высота привязанная к стороне b
        public Triangle(double A, double B, double C) // Конструктор
        {
            a = A; // создаём с заданными длинами сторон согласно заданию
            b = B;
            c = C;
        }
        public Triangle(double A, double C, double B, double HB) // Конструктор
        {
            b = B;
            hb = HB;
            a = A;
            c = C;
        }

        public string outputA() // выводим строку a, данный метод возвращает строковое значени
        {
            return Convert.ToString(a);
        }
        public string outputB() // выводим сторону b
        {
            return Convert.ToString(b);
        }
        public string outputC() // выводим сторону c
        {
            return Convert.ToString(c);
        }
        public string outputHB() // выводим сторону h
        {
            return Convert.ToString(hb);
        }
        public double Ploshad() // площадь
        {
            double S = 0;
            if (ExistTriangle == true)
            {
                S = b * hb / 2;
            }
            else
            {
                S = 0;
            }
            return S;
        }
        public double Perimeter() // сумма всех сторон типа
        {
            double p = 0;
            if (ExistTriangle == true)
            {
                p = a + b + c; // вычисление...
                return p; // возврат
            }
            else
            {
                p = 0;
            }
            return p;
        }
        public double Surface() // аналогично периметру..
        {
            double s = 0;
            double p = 0;
            if (ExistTriangle == true)
            {
                p = (a + b + c) / 2;
                s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            }
            else
            {
                s = 0;
            }
            return s;
        }
        public double GetSetA // свойство позволяющее установить либо изменить значение стороны a
        {
            get // устанавливаем
            { return a; }
            set // меняем
            { a = value; }
        }
        public double GetSetB // свойство позволяющее установить либо изменить значение стороны b
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC // свойство позволяющее установить либо изменить значение стороны c
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public double GetSetHB // свойство позволяющее установить либо изменить значение стороны c
        {
            get
            { return hb; }
            set
            { hb = value; }
        }
        public bool ExistTriangle // свойство позволяющее установить, существует ли треугольник с заданными сторонами
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))//сумма 2 сторон должна быть больше третьей
                    return true;
                else return false;
            }
        }
        public string TriangleType // свойство позволяющее установить, существует ли треугольник с заданными сторонами
        {
            get
            {
                if(ExistTriangle==true)
                {
                    if (a == b && a == c && b == c)
                        return "равносторонний";
                    else if (a == b || a == c || b == c)
                        return "равнобедренный";
                    else return "разносторонний";
                }
                else
                {
                    return "???";
                }
            }
        }
    }
}
