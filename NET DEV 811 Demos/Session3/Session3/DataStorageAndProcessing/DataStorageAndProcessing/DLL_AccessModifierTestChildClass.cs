using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStorageAndProcessing
{
    //This class inherits from a parent class in a different assembly
    class DLLAccessModifierTestChildClass: DemoClassLibrary.DLLAccessModifierTest
    {
        public DLLAccessModifierTestChildClass()
        {
            // These modifiers work from this location (But, they did before too!)
            TestPublic = 4;
            
            //This no longer works since the parent class is not part of the same assembly
            //TestInternal = 4;
            
            //This works due to is protected status!
            TestProtectedInternal = 4;

            // The private modifier still does not work from this location...
            //TestPrivate = 4;

            // What is new, is that the protected access modifier now works!
            TestProtected = 4;
        }

    }
}
