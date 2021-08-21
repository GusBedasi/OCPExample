using System;

namespace OCPLibrary.Messages
{
    public static class StandardMessages
    {
        public static void EndApplicationMessage()
        {
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}