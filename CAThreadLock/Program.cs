class Program
{
    public static void Main(string[] args)
    {
        //Race Condition 
        //Critical Section
        Thread t1 = new Thread();
        Thread t2 = new Thread();
    }
}

class Account
{
    decimal balance;

    //Bu field anahtar görevi görür.
    private Object thisLock = new Object();

    public void WithDraw(decimal amount)
    {
        lock (thisLock)
        {
            if (amount > balance)
            {
                throw new Exception("Insufficient funds");
            }

            balance -= amount;
        }
    }
}