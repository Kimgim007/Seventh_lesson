using Seventh_lesson.Hospital;

namespace Seventh_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //            1.Создать класс Квадрат
            //              Поля:

            //              1.Длина cтороны
            //              2.Цвет
            //              3.Площадь

            //              Метод:

            //              1.Вывести на экран информацию о фигуре
            //              2.Конструктор принимает параметры:
            //              3.Длина стороны, цвет

            //              Высчитывает площадь фигуры
            //              Создать объекты:
            //              Зеленый квадрат, длина стороны 5
            //              Синий квадрат, длина стороны 2
            //              Голубой квадрат, длина стороны 15
            //              Вывести информацию о фигурах на экран
            //              Поменять длину стороны зеленого квадрата = длина стороны синего квадрата * 3
            //              Вывести информацию о фигурах на экран


            //Square squareGreen = new Square(5, "Green");


            //Square squareBrown = new Square(2, "Brown");


            //Square squareBlue = new Square(15, "Blue");
           
            //Console.WriteLine(squareGreen.ToString());
            //Console.WriteLine(squareBrown.ToString());
            //Console.WriteLine(squareBlue.ToString());

            //squareGreen.Sidelength = squareBlue.Sidelength * 3;
            //Console.WriteLine();

            //Console.WriteLine(squareGreen.ToString());
            //Console.WriteLine(squareBrown.ToString());
            //Console.WriteLine(squareBlue.ToString());



            //2.Создать программу для имитации работы клиники.
            //Пусть в клинике будет три врача: хирург, терапевт и дантист.
            //Каждый врач имеет метод «лечить», но каждый врач лечит по - своему.Так же
            //предусмотреть класс «Пациент» и класс «План лечения». Создать объект класса
            //«Пациент» и добавить пациенту план лечения.Так же создать метод, который
            //будет назначать врача пациенту согласно плану лечения.
            //Если план лечения имеет код 1 – назначить хирурга и выполнить метод лечить.
            //Если план лечения имеет код 2 – назначить дантиста и выполнить метод лечить.
            //Если план лечения имеет любой другой код – назначить терапевта и выполнить
            //метод лечить.


            Doctor doctor = new Doctor();

            Patient patient = new Patient();

            TreatmentPlan treatment = new TreatmentPlan();

            treatment.Plan = "2";

            patient.TreatmentPlan = treatment;

            doctor.WhoWillTreatYou(patient.TreatmentPlan);
        }
    }
}
