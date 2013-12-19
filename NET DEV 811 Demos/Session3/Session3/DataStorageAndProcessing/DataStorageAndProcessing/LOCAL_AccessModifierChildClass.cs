using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStorageAndProcessing
{
    // Create a class that inherits code from AccessModiferTest
    //default modifier is internal
    internal class AccessModifierChildClass : AccessModiferTests
    {
        public AccessModifierChildClass()
        {
            // These modifiers work from this location (But, they did before too!)
            TestPublic = 2;
            TestInternal = 2;
            TestProtectedInternal = 2;

            // The private modifier still does not work from this location...
            //TestPrivate = 3;

            // What is new, is that the protected access modifier now works!
            TestProtected = 2;
        }

    }
}
