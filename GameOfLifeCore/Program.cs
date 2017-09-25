using System;

namespace GameOfLifeCore
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( int i = 0; ; i++ )
            {
                Console.WriteLine( "Hello HyperScalers, This is running on OpenShift!" );
                Console.WriteLine( "Also, this loop never ends! Muhahaha, we are up to iteration number" + i + "!" );
                Console.ReadLine();
            }
        }
    }
}
