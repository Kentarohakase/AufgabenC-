using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenC_ {
 internal class BiggerThan {

  internal static void Bigger( )
  {
   Console.Write( "Gebe eine Zahl ein: " );
   int zahl1 = Convert.ToInt32( Console.ReadLine( ) );
   Console.Write( "Gebe eine zweite Zahl ein: " );
   int zahl2 = Convert.ToInt32( Console.ReadLine( ) );

   if (zahl1 > zahl2)
   {
    Console.WriteLine( $"{zahl1} ist größer als {zahl2}" );
   }
   else if (zahl2 > zahl1)
   {
    Console.WriteLine( $"{zahl2} ist größer als {zahl1}" );
   }
   else
   {
    Console.WriteLine( $"{zahl1} und {zahl2} sind gleich groß" );
   }
  }
 }
}
