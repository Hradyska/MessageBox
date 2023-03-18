using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class MessageBox
    {
        public event EventHandler<State> OnWinClosed;
        public async void Open()
        {
            Console.WriteLine("Window is opened.");
            await Task.Delay(300);
            Console.WriteLine("Window is closed.");
            OnWinClosed?.Invoke(this, StateOnClosed());
        }
        public enum State
        {
            Ok,
            Cancel
        }
        
        public static State StateOnClosed()
        {
            Random rand = new Random();
            int i = rand.Next(0, 100);
            if (i<50)
            {
                return State.Ok;
            }
            else
            {
                return State.Cancel;
            }
        }
    }
}
