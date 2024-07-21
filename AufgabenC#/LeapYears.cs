using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenC_ {
 internal class LeapYears {


  internal static void Leaps( )
  {
   Console.WriteLine( "Gebe ein Jahr ein" );
   int leapZahl = Convert.ToInt32( Console.ReadLine( ) );

   if (leapZahl % 4 == 0)
   {
    if (leapZahl % 100 == 0)
    {
     if (leapZahl % 400 == 0)
     {
      Console.Write( "Das ist ein Schaltjahr" );
      return;
     }
     Console.Write( "Das ist kein Schaltjahr" );
     return;
    }
    Console.WriteLine( "Das ist ein Schaltjahr" );
    return;
   }
   Console.WriteLine( "Das ist kein Schaltjahr" );
  }
 }

}

