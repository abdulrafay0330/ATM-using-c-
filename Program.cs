// See https://aka.ms/new-console-template for more information
using ATM;

void printoptions()
{
    Console.WriteLine("Please select any one option ");
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. showBalance");
    Console.WriteLine("4. exit");
}

void deposite(cardHolder currentuser)
{
    Console.WriteLine("How much do you want to deposite");
    double deposit=double.Parse(Console.ReadLine());
    currentuser.setbalance(deposit);
    Console.WriteLine("Thank you ! ");
}

void Withdraw (cardHolder currentuser)
{
    Console.WriteLine("How much do you want to withdraw ? ");
    double withdraw = double.Parse(Console.ReadLine());
    if(currentuser.getbalance() < withdraw)
    {
        Console.WriteLine("Insuffiecient balance");
    }
    else
    {
        currentuser.setbalance(currentuser.getbalance()-withdraw);
        Console.WriteLine("Thankyou your current balance is " + currentuser.getbalance());
    }

}    

void showBalance(cardHolder currentuser)
{
    Console.WriteLine("Your Balance is " + currentuser.getbalance());

}
List<cardHolder> cardHolder=new List<cardHolder> ();
cardHolder.Add(new cardHolder( 1234, "1213232323452323" ,"Abdul", "rafay", 158.90));
cardHolder.Add(new cardHolder(1234, "1313232323452323", "Abdul", "Hannan", 198.52));
cardHolder.Add(new cardHolder(1234, "1413232323452323", "Hamza", "Aslam", 204.90));

//now here it is the start of the project to register his or her card

Console.WriteLine("Welcome to the ATM");
Console.WriteLine("Inter your Card");
string DebitCard = "";
cardHolder currentuser;

//now if someone going to enter the wrong cardnumber the program is not going to crash 
//instead here is the logic for the program going on
while (true)
{
    try
    {
        DebitCard= Console.ReadLine();
        //now going to check card number to our card number which we have entered 
        currentuser = cardHolder.FirstOrDefault(a => a.cardNum == DebitCard);
        if(currentuser != null) { break; }
        else { Console.WriteLine("Please try again"); }

    }
    catch
    {
        Console.WriteLine("Please try again");
    }


}

Console.WriteLine("Please enter your PIN");
int USerpin = 0;
while (true)
{

    try
    {
        USerpin = int.Parse(Console.ReadLine());
        //here checing the pin
        if (currentuser.getPin() == USerpin) { break; }
        else { Console.WriteLine("Incorrect PIn"); }

    }
    catch
    {
        Console.WriteLine("Incorrect PIN");
    }
}

Console.WriteLine("Welcome to XYZ ATM"+ currentuser.getFirstname());
int options=0;
do
{//look this function
    printoptions();
    try
    {
        options = int.Parse(Console.ReadLine());
    }
    catch{ }
    if (options == 1) { deposite(currentuser); }
    else if (options == 2) {  Withdraw(currentuser); }
    else if (options==3) { showBalance(currentuser); } 
    else if (options == 4) { break; }
    else { options = 0; }
}
while (options == 4);
Console.WriteLine("Thank you for using this ATM");






