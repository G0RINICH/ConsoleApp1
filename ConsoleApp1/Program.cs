using System;

namespace ConsoleApp1
{
      class Program
          {
                static void Main()
                {
                    //Console.Write("Введите ФИО -> ");
                    string familiya = "Иванов";//Console.ReadLine();
                    //Console.Write("Введите ФИО -> ");
                    string imya = "Иван";//Console.ReadLine();
                    //Console.Write("Введите ФИО -> ");
                    string otchestvo = "Иванович";//Console.ReadLine();
                    //Console.Write("Введите минимальную ЗП -> ");
                    int Dzp = 120000;//Convert.ToInt32(Console.ReadLine());
                    //Console.Write("Введите коэффициент сотрудника -> ");
                    double k = 1.25;//Convert.ToInt32(Console.ReadLine());
                    DateTime d = new DateTime(2024,1,1);//Convert.ToDateTime(Console.ReadLine());
                    DateTime tp = new DateTime(2024,2,1);//Convert.ToDateTime(Console.ReadLine());
                    Sotrudniki sotrudnik = new Sotrudniki(familiya, imya, otchestvo, k, d, tp);
                    string DName = "разработчик";//Console.ReadLine();
                    bool Dtst = true; //Convert.ToBoolean(Console.ReadLine());
                    
                    Doljnosti doljnost = new Doljnosti(DName, Dtst, Dzp);
                    
            if (sotrudnik.tp.Subtract(sotrudnik.d).TotalDays>90)//DateTime.Now> sotrudnik.tp)//sotrudnik.d> sotrudnik.tp)
            {
                Console.WriteLine("Имя: {0} {1} {2}\tиспытательный срок пройден, Зп по коэффициенту: {3}", familiya, imya, otchestvo, sotrudnik.k * doljnost.Dzp);
            }
            else
            {
                sotrudnik.k = 1;
                Console.WriteLine("Имя: {0} {1} {2}\tиспытательный срок не пройден, Зп по коэффициенту: {3}", familiya, imya, otchestvo, sotrudnik.k * doljnost.Dzp);
            }
                }
            }

        class Sotrudniki
        {
            public string f { get; set; }
            public string i { get; set; }
            public string o { get; set; }
            public double k { get; set; }
            public DateTime d { get; set; }
            public DateTime tp { get; set; }

        public Sotrudniki(string f, string i, string o, double k, DateTime d, DateTime tp)//Конструктор с параметрами
            {
                this.f = f;
                this.i = i;
                this.o = o;
                this.k = k;//коэффициент зп
                this.d = d;// дата устройства
                this.tp = tp;//дата окончания испытательного срока
            }


        }
//    class otdeli
//    {
//        public string otd { get; set; }



//        public class otdeli(string otd)//конструктор с параметрами
//        {
//            this.otd = otd;
//        }

//}
class Doljnosti
    {
        

        public Doljnosti(string DName, bool Dtst, int Dzp)//Конструктор с параметрами
        {
            this.DName = DName;
            this.Dtst = Dtst;//необходимость тестового задания
            //this.Dtstzadanie//тест тестового задания
            this.Dzp = Dzp;//базавая зп должности
            
        }

        public string DName { get; set; }
        public bool Dtst { get; set; }
        public int Dzp { get; set; }
    }
}