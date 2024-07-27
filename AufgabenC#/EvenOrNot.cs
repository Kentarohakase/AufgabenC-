using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenC_ {
 internal class EvenOrNot {

  

  internal static void Even( )
  {
   Console.Write( "Gebe eine Zahl ein, die überprüft worden soll, ob Sie gerade ist oder nicht: " );
   int zahl1 = Convert.ToInt32( Console.ReadLine( ) );

   if(zahl1 % 2 == 0)
   {
    Console.WriteLine( "Deine Zahl ist gerade" );

   }
   else
   {
    Console.WriteLine( "Deine Zahl ist nicht gerade" );
   }
  }
 }
}
