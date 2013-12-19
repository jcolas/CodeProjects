using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoClassLibrary
{
    public class DLLAccessModifierTest
    {
        private int TestPrivate; // can be used within the class
        public int TestPublic;// can be used everywhere
        protected int TestProtected;// can be used in any Child class
        internal int TestInternal;// can be used anywhere in the same assembly (exe or dll)
        protected internal int TestProtectedInternal; //can be used from either in any Child class OR in the same assembly

        public DLLAccessModifierTest()
        {
            TestPrivate = 3;
            TestPublic = 3;
            TestInternal = 3; 
            TestProtected = 3;
            TestProtectedInternal = 3;
        }

        public void ShowData()
        {
            Console.WriteLine(TestPrivate);
            Console.WriteLine(TestPublic);
            Console.WriteLine(TestInternal);
            Console.WriteLine(TestProtected);
            Console.WriteLine(TestProtectedInternal);        
        }
    }


}
