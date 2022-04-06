using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[] { "daniel@truecoders.io, "michael@truecoders.io, "tanner@truecoders.io" };

            var list = new List<string>() { "sombody@truecoders", "daniel@truecoders.io" };
            list.Add("michael@truecoders.io");
            list.Add("daniel@truecoders.io");


            fun_with_collections.PrintItems(spamList);
            
            
            
            var galaxy = new Galaxy();
            var nokia = new Nokia();

            var phones = new List<IMobilePhone>();
            phones.Add(galaxy);
            phones.Add(nokia);

            foreach (var mobile in phones) 
            {
                mobile.MakeCall();
                mobile.Text("555-5555-5555", "you suck");
                mobile.VideoCall();
            }
            
            
            
            
            
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
