internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhập số tiền $ cần chuyển đổi giá trị ");
        double USD = Convert.ToDouble(Console.ReadLine());
        const int curenccyRate = 25000;
        double VND = USD*curenccyRate;
        Console.WriteLine("Giá trị tiền Việt Nam là " + VND + " đồng");

    }
}