using System;
namespace ElectricityBill;
class Program 
{
    public static void Main(string[] args)
    {
        
        System.Console.WriteLine("Enter the customer id: ");
        int customerId=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the customer name: ");
        string customerName=Console.ReadLine();
        System.Console.WriteLine("Unit consumed: ");
        double unit=double.Parse(Console.ReadLine());
        System.Console.WriteLine("Customer Id: "+customerId);
        System.Console.WriteLine("CustomerName: "+customerName);
        System.Console.WriteLine("Unit consumed: "+unit);
        if(unit<84 && unit>0)
        {
            System.Console.WriteLine("Unit charged is Rs.100");
        }
        else if(unit >=84 && unit<=199)
        {
            double unitCharged=unit*1.20;
             System.Console.WriteLine("Amount charges @ Rs.1.20 per unit \nUnit charged :{0}",unitCharged);
             System.Console.WriteLine("Net amount paid by customer : "+unitCharged);
        }
        else if(unit>=200 && unit<400)
        {
            double unit1Charged=unit*1.50;
            System.Console.WriteLine("Amount charges @ Rs.1.50 per unit \nUnit charged :{0}",unit1Charged);
            System.Console.WriteLine("Net amount paid by customer :"+unit1Charged);
        }
        else if(unit>=400 && unit<600)
        {
            double unit2Charged=unit*1.80;
            double surcharge=unit2Charged*15/100;
            double netAmount=unit2Charged+surcharge;
            System.Console.WriteLine("Amount charges @ Rs.1.80 per unit \nUnit charged :{0}",unit2Charged);
            System.Console.WriteLine("Surcharge Amount: "+surcharge);
            System.Console.WriteLine("Net amount paid by customer :"+netAmount);
        }
        else if(unit >=600)
        {
            double unit3Charged=unit*2.00;
            double surcharge1=unit3Charged*15/100;
            double netAmount1=unit3Charged+surcharge1;
            System.Console.WriteLine("Amount charges @ Rs.2.00 per unit \nUnit charged :{0}",unit3Charged);
            System.Console.WriteLine("Surcharge Amount: "+surcharge1);
            System.Console.WriteLine("Net amount paid by customer :"+netAmount1);   
        }
    }
}
