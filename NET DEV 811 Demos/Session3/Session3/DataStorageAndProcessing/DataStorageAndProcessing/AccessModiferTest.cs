using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStorageAndProcessing
{
    class AccessModiferTests
    {
        private int TestPrivate; // can be used within the class
        public int TestPublic;// can be used everywhere
        protected int TestProtected;// can be used in any Child class
        internal int TestInternal;// can be used anywhere in the same assembly (exe or dll)
        protected internal int TestProtectedInternal; //can be used from either in any Child class OR in the same assembly

        public void AccessModiferTest()
        {
            TestPrivate = 1;
            TestPublic = 1;
            TestInternal = 1; 
            TestProtected = 1;
            TestProtectedInternal = 1;
        }

        public void ShowData()
        {
            Console.WriteLine("TestPrivate" + ": " + TestPrivate);
            Console.WriteLine("TestPublic" + ": " + TestPublic);
            Console.WriteLine("TestInternal" + ": " + TestInternal);
            Console.WriteLine("TestProtected" + ": " + TestProtected);
            Console.WriteLine("TestProtectedInternal" + ": " + TestProtectedInternal);
            Console.WriteLine("---------");
        }
    }
}
