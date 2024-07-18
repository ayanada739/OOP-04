using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04.Interfaces
{
    // Default Access Modifier Of Interface ==>Internat
    //Developer 01
    internal interface IMyType
    {
        // Default Access Modifier Inside Interface Public
        // Private Access Modifier is not allowed inside interface
        //What You Can Write Inside The Interface

        // 1. Signature for Property
        public int Id { get; set; }
        // Inside Class Or Struct Automatic Property
        // Compiler Witt generate Private Hidden Attribute (Backing Field]
        // Inside Interface ==> Signature For Property


        // 2. Signature for method [Name - Return Type - Parameter]
        public void MyFun(int X);


        // 3. Default Implemented Method [8.0 Feature (.Net core 3.1 2019)]
        public void Print()
        {
            Console.WriteLine("Hello Default Implemented Method From Interface");
        }



    }
}
