using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Nokia : IMobilePhone
    {
        public void MakeCall()
        {
            Console.WriteLine($"blah blah blah who cares");
        }

        public void Text( string phoneNumber, string message) 
        {
            Console.WriteLine($"texting {phoneNumber}: \"{message}\" from Nokia");
        }

        public void VideoCall() 
        {
            Console.WriteLine($"We're sorry. Nokia doesn't have this");
        }



    }
}
