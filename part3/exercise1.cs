using System;

namespace part3
{
    public class PrintHello
    {
        public void Hello(int n)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Hello!");
                Hello(n-1);
            }
        }
    } 

    //annotation
}