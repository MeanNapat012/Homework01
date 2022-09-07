using System;

public class Money
{
    public double Unitmoney;
    public double thousand_bath = 0;
    public double fivehundred_bath = 0;
    public double onehundred_bath = 0;
    public double fifty_bath = 0;
    public double twenty_bath = 0;
    public double ten_bath = 0;
    public double two_bath = 0;
    public double one_bath = 0;
    public double fifty_satang = 0;
    public double twenty_five_satang = 0;
    
    public  void  CalAllMoney(double Unitmoney)
    {
        do
        {
        if(Unitmoney >= 1000)
        {
            thousand_bath = ++ thousand_bath;
            Unitmoney = Unitmoney - 1000;
            
        }
        else if(Unitmoney < 1000 && Unitmoney >= 500)
        {
            fivehundred_bath = ++ fivehundred_bath;
            Unitmoney = Unitmoney - 500;
        }
        else if(Unitmoney < 500 && Unitmoney >= 100)
        {
            onehundred_bath = ++onehundred_bath;
            Unitmoney = Unitmoney - 100;
        }
        else if(Unitmoney < 100 && Unitmoney >= 50)
        {
            fifty_bath = ++ fifty_bath;
            Unitmoney = Unitmoney - 100;
        }
        else if(Unitmoney < 50 && Unitmoney >= 20)
        {
            twenty_bath = ++ twenty_bath;
            Unitmoney = Unitmoney - 50;
        }
        else if(Unitmoney < 20 && Unitmoney >= 10)
        {
            ten_bath = ++ten_bath;
            Unitmoney = Unitmoney - 20;
        }
        else if(Unitmoney < 10 && Unitmoney >= 2)
        {
            two_bath = ++two_bath;
            Unitmoney = Unitmoney - 2;

        }
        else if(Unitmoney < 2 && Unitmoney >= 1)
        {
            one_bath = ++one_bath;
            Unitmoney = Unitmoney - 1;
        }
        else if(Unitmoney < 1 && Unitmoney >= 0.5 )
        {
            fifty_satang = ++fifty_satang;
            Unitmoney = Unitmoney - 0.5;

        }
        else if(Unitmoney < 0.5 && Unitmoney >= 0.25)
        {
            twenty_five_satang = ++ twenty_five_satang;
            Unitmoney = Unitmoney - 0.25;
        }
        

        }while(Unitmoney > 0);
        PrintAllmoney(thousand_bath, fivehundred_bath, onehundred_bath, fifty_bath, twenty_bath, ten_bath, two_bath, one_bath, fifty_satang,twenty_five_satang);
        
    }

    public static void PrintAllmoney(double thousand_bath, double fivehundred_bath, double onehundred_bath, double fifty_bath, double twenty_bath, double ten_bath, double two_bath, double one_bath, double fifty_satang,double twenty_five_satang)
    {
        Console.WriteLine("1000 : {0}", thousand_bath );
        Console.WriteLine("500 : {0}", fivehundred_bath);
        Console.WriteLine("100 : {0}", onehundred_bath);
        Console.WriteLine("50 : {0}", fifty_bath);
        Console.WriteLine("20 : {0}", twenty_bath);
        Console.WriteLine("10 : {0}", ten_bath);
        Console.WriteLine(".50 : {0}", fifty_satang);
        Console.WriteLine(".25 : {0}", twenty_five_satang);
    }
}