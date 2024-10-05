internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Giai phuong trinh bac nhat");
        Console.Write("Nhap a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        if (a != 0)
        {
            double ketqua = -b / a;
            Console.Write("Ket qua la: {0}!", ketqua);
        }
        else
        {
            if (b == 0)
            {
                Console.Write("The solution is all x!");
            }
            else
            {
                Console.Write("Nod solution!");
            }
        }
    }
}