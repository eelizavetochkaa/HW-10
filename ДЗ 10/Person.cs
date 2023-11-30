using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_10
{
    public class Person
    {
        public string Name { get; set; }
        public string Hobby { get; set; }

        public event EventHandler<string> HobbyEvent; 
        public void OnHobbyEvent(string eventDescription)
        {
            HobbyEvent?.Invoke(this, eventDescription);
        }

    }
}
