namespace Events
{
    internal class Program
    {
        
        /// <summary>
        /// Calling the subscriber class in the main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
           MovieAppActivator movieAppActivator = new MovieAppActivator();
            movieAppActivator.ActOnPayment();
            
        }
    }

    
}

