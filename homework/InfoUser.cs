public class infoUser
{
    public string nameMarket;
    public string name;
    public double num;
    public double money;
    

    public void PrintAllinfo(string nameMarket, string name, double num, double money)
    {
        Console.WriteLine();
        Console.WriteLine("---------Shop information---------");
        Console.WriteLine("Name : {0}", nameMarket);
        Console.WriteLine("Number : {0}", num);
        Console.WriteLine("Owner Name : {0}", name);
        Console.WriteLine("Registered Value : {0}", money);
        Console.WriteLine("----------------------------------");
    }


}
