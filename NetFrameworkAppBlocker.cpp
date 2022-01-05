// NetFrameworkAppBlocker.cpp
//
// Only the C++ test for NetFrameworkAppBlocker.cs
//
// Use it after compiling and running NetFrameworkAppBlocker.cs

#include "stdafx.h"

using namespace System;
using namespace System::IO;

int main(array<System::String ^> ^args)
{
	try {
		Path::GetTempFileName();
		Console::WriteLine( "OK!" );
	} catch( Exception ^e ) {
		Console::WriteLine( "Exception!" );
		Console::WriteLine( e->Message );
	}
    return 0;
}
