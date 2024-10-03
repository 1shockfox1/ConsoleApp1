try
{
    Console.WriteLine("Добро пожаловать введите 4 значения");
    double A = double.Parse(Console.ReadLine());
    double B = double.Parse(Console.ReadLine());
    double C = double.Parse(Console.ReadLine());
    double D = double.Parse(Console.ReadLine());

    bool log = (A % 7 == 0) || (B % 7 == 0) || (C % 7 == 0) || (D % 7 == 0);
    bool gol = (A % 2 != 0) || (B % 2 != 0) || (C % 2 != 0) || (D % 2 != 0);
    bool result = log && gol;
    Console.WriteLine("Условие выполнено: " + result);

}
catch
{
    Console.WriteLine();
}