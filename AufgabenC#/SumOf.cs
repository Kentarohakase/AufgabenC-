using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenC_ {
 internal class SumOf {

  
  internal static int Sum( )
  {
   Console.Write( "Gebe die erste zahl ein die Summiert werden soll: " );
   int zahl1 = Convert.ToInt32( Console.ReadLine( ) );
   Console.Write( "Gebe die erste zahl ein die Summiert werden soll: " );
   int zahl2 = Convert.ToInt32( Console.ReadLine( ) );
   Console.Write( $"Die Summe von {zahl1} und {zahl2} ist {zahl1 + zahl2}." );

   return zahl1 + zahl2;
  }
 }
}
