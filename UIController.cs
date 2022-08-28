using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class UIController
    {
        public event EventHandler OnAPressed;
        public event EventHandler OnDPressed;

        public void StartMove()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key.Equals(ConsoleKey.A))
                    OnAPressed?.Invoke(this, new EventArgs());
                else if (keyInfo.Key.Equals(ConsoleKey.D))
                    OnDPressed?.Invoke(this, new EventArgs());
                else
                    ;
            }
        }
    }
}
