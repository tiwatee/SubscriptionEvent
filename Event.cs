using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class SubscriptionAccount //publisher class
    {
        public delegate void SubscriptionHandler(); //a delegate
        public event SubscriptionHandler NotifyActivator; //an event based on the delegate

        /// <summary>
        /// A method to tell the activator that subscription fee has been paid successfully
        /// </summary>
        public void PaymentSuccess()
        {
            Console.WriteLine("Payment is being confirmed. Reloading soon");
            System.Threading.Thread.Sleep(5000);
            OnPaymentSuccess(); //using the event raised in a method
        }

        protected virtual void OnPaymentSuccess() //raise an event
        {
            NotifyActivator?.Invoke();
        }
    }

    public class MovieAppActivator //subscriber class
    {
        public void ActOnPayment()
        {
            var subscription = new SubscriptionAccount();
            subscription.NotifyActivator += SubscriptionActivationProcess;

            subscription.PaymentSuccess(); //an instance where payment is successful
        }

        public void SubscriptionActivationProcess()
        {
            Console.WriteLine("Account has been activated successfully");
        }
    }
}
