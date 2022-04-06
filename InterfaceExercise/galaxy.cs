using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Galaxy : IMobilePhone
    {

        public void MakeCall() 
        {
            Console.WriteLine($"Galaxy: Calling so and so at such time");
        } 
    {   public void Text(string phoneNumber, string message) 
        {
           Console.WriteLine($"{phoneNumber}: \"{message}\" sent at {DateTime.Now}");
        }
        public void VideoCall() 
        {
            Console.WriteLine($"{DateTime.Now}: Video Chat starting");
        }
    }









    }
}
