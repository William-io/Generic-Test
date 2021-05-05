using System;

namespace Generic_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var plan = new Plan();
            var payment = new Payment();
            var subscription = new Subscription();
            var context = new DataContext<IPlan, Payment, Subscription>();

            context.Save(plan); 
            context.Save(payment);
            context.Save(subscription);
        }
    }
}
