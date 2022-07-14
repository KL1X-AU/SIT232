class MobileProgram
{
    static void Main(string[] args)
    {
        //creating object of class program
        MobileProgram pr = new MobileProgram();
        Mobile jimMobile = new Mobile("Monthly", "Samsung Glaxy S6", "07712223344");
        Mobile lachlanMobile = new Mobile("Monthly", "Samsung Glaxy S21 Ultra", "0449005985");

        pr.checkAccount(jimMobile);

        jimMobile.setAccType("PAYG");
        jimMobile.setDevice("Iphone 6S");
        jimMobile.setNumber("0449005985");
        jimMobile.setBalance(15.50);

        pr.checkAccount(jimMobile);

        jimMobile.AddCredit(10.0);
        jimMobile.MakeCall(5);
        jimMobile.sendText(2);
        Console.ReadLine();

        pr.checkAccount(lachlanMobile);

        lachlanMobile.AddCredit(10.0);
        lachlanMobile.MakeCall(2);
        lachlanMobile.sendText(4);
        Console.ReadLine();
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