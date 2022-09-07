using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        string nameMarket = InputNameMarket();
        string non = InputNumber();
        double num = ConvertNumberToDouble(non);
        string name = InputName();
        string numMoney = InputMoney();
        double money = ConvertMoneyTodouble(numMoney);
        infoUser info = new infoUser();
        info.PrintAllinfo(nameMarket, name, num, money);

        string unit = InputExchangMoney();
        double Unitmoney = ConvertStringTodouble(unit);
        Money mon = new Money();
        mon.CalAllMoney(Unitmoney);
        

    }
    public static string InputNameMarket(){
        Console.Write("Please input Name :  ");
        return Console.ReadLine();
    }

    public static string InputNumber(){
        Console.Write("Please input Number : ");
        return Console.ReadLine();

    }
    public static double ConvertNumberToDouble(string non){
        if(double.TryParse(non, out double number)){
            return number;
        }
        throw new Exception("Please Input num!!!!");
    }


    public static string InputName(){
        Console.Write("Please input Ower Name :  ");
        return Console.ReadLine();
    }

    public static string InputMoney(){
        Console.Write("Please input Registered Value : ");
        return Console.ReadLine();
    }
    public static double ConvertMoneyTodouble(string numMoney)
    {
        if(double.TryParse(numMoney, out double number))
        {
            return number;
        }
        throw new Exception("Please input num!!!");
    }

    public static string InputExchangMoney()
    {
        Console.Write("Please input money : ");
        return Console.ReadLine();
    }
    public static double ConvertStringTodouble(string value)
    {
        if(double.TryParse(value, out double number)){
            return number;
        }
        throw new Exception("Please Input money!!!!");
    }
}