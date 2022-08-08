double Factorial(int n) //int хранит малое количество символов. для того,что бы кооректно считались большие факториалы нужно использовать тип double
{
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
Console.WriteLine("Введите число, для поисука факториала:");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Факториал " + p + " равен " + Factorial(p));
