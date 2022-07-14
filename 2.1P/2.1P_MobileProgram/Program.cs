class MobileProgram
{
    static void Main(string[] args)
    {
        Mobile jimMobile = new Mobile("Monthly", "Samsung Glaxy S6", "07712223344");

        MobileProgram pr = new MobileProgram();

        pr.checkAccount(jimMobile);

        jimMobile.setAccType("PAYG");
        jimMobile.setDevice("Iphone 6S");
        jimMobile.setNumber("0449005985");
        jimMobile.setBalance(15.50);

        pr.checkAccount(jimMobile);
    }

    public void checkAccount(Mobile account)
    {
        Console.WriteLine($"Account Type: \t{account.getAccType()}");
        Console.WriteLine($"Mobile Number: \t{account.getNumber()}");
        Console.WriteLine($"Device:  \t{account.getDevice()}");
        Console.WriteLine($"Balance: \t{account.getBalance()}");
        Console.ReadLine();
    }
}