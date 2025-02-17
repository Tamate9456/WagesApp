namespace WagesApp;

class Program
{
    // global variables
    string employeeName;
    int mondayPay, tuesdayPay, wednesdayPay, thursdayPay, fridayPay, saturdayPay, sundayPay;
    int totalHours, totalPay, totalTax, bonusPay;
    // methods

    static void Main(string[] args)
    {
        Console.WriteLine("Enter Employee Name");
        string employeeName = Console.ReadLine();
        Console.WriteLine("Enter Monday pay");
        int mondayPay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Tusday pay");
        int tuesdayPay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Wednesday pay");
        int wednesdayPay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Thursday pay");
        int thurdayDay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter FridAY pay");
        int fridayPay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Saturday pay");
        int saturdayPay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Sunday pay");
        int sundayPay = Convert.ToInt32(Console.ReadLine());
        int totalHours = mondayPay + tuesdayPay + wednesdayPay + thursdayPay + fridayPay + saturdayPay + sundayPay;
        int totalPay = totalHours * 22;
        if (totalHours > 30)
        {
            int totalpay = totalHours + 5;
            Console.WriteLine("got bonus");
        }
        if(totalPay < 450  )
        {
            totalPay = totalPay * 0.925;
        }
        else
        {
            totalPay = totalPay * 0.92;
        }
        }
            
    }
}

