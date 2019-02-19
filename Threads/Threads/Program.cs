using System;
using System.Threading;

namespace Threads
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            #region Thread1
            //    Thread t = new Thread(Print1);

            //    t.Start();
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        Console.Write(0);
            //    }
            //}  

            //static void Print1()
            //{
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        Console.Write(1);
            //    }

            #endregion

            #region Sleep
            //int num = 1;

            //for(int i= 0; i < 10; i++)
            //{
            //    Console.WriteLine(num);
            //    Thread.Sleep(1000);
            //    num++;
            //}
            //Console.WriteLine("Thread Ends");

            #endregion
            #region BankAccount
            //        BankAcct acct = new BankAcct(10);
            //        Thread[] threads = new Thread[15];

            //        Thread.CurrentThread.Name = "main";

            //        for(int i = 0; i < 15; i++)
            //        {
            //            Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
            //            t.Name = i.ToString();
            //            threads[i] = t;
            //        }
            //        for(int i = 0; i < 15; i++)
            //        {
            //            Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);

            //            threads[i].Start();

            //            Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
            //        }

            //        Console.WriteLine("Current Priority : {0}", Thread.CurrentThread.Priority);

            //        Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);
            //    }

            //}

            //class BankAcct
            //{
            //    private Object acctLock = new object();
            //    double Balance { set; get; }
            //    public BankAcct(double bal)
            //    {
            //        Balance = bal;
            //    }
            //    public double Withdraw(double amt)
            //    {
            //        if((Balance - amt) < 0)
            //        {
            //            Console.WriteLine($"Sorry ${Balance} in Account");
            //            return Balance;
            //        }
            //        lock(acctLock)
            //        {
            //            if(Balance >=amt)
            //            {
            //                Console.WriteLine("Removed {0} and {1} left in Account", amt, (Balance - amt));
            //                Balance -= amt;
            //            }
            //            return Balance;
            //        }

            //    }
            //    public void IssueWithdraw()
            //    {
            //        Withdraw(1);
            //    }
            #endregion

            Thread t = new Thread(()=> CountTo(10));
            t.Start();

            new Thread

        }


        static void CountTo(int maxNum)
        {
            for(int i = 0; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}