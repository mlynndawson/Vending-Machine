//git push origin master 

//git pull origin master NOT upstream

using System;

namespace MartianWeight
{
    /*
    In case you've ever pondered how much you weight on Mars, here's the calculation:
    Wm = We* 0.378
    where 'Wm' is the weight on Mars, and 'We' is the weight on Earth

    Write a command line program which accepts a series of Earth weights from the user  
    and displays each Earth weight as itself, and its Martian equivalent.


    Enter a series of Earth weights (space-separated): 98 235 185

    98 lbs.on Earth, is 37 lbs.on Mars.
    235 lbs.on Earth, is 88 lbs.on Mars.
    185 lbs.on Earth, is 69 lbs.on Mars. 


        - Message your weight on mars
        - message to enter data
        - prompt for input string of weights
        - split the strings into the array
            - parse the strings
            - equation
            -print message
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your weight on Mars!");
            Console.Write("Enter all users' weight values on earth in lbs (separate spaces)");
            string weights = Console.ReadLine();
            string[] weightsArray = weights.Split(' ');
            for (int i = 0; i < weightsArray.Length; i++) 
            { 
                decimal earthWeight = decimal.Parse(weightsArray[i]);
                decimal martianWeight = earthWeight * (decimal)0.378;
                Console.WriteLine($"{earthWeight}lbs on Earth, is {martianWeight}lbs on Mars.");
            }
            
        }
    }
}
