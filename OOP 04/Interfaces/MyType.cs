using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04.Interfaces
{

    //Developer 02
    //Interface is a Code Contract Between 2 Developers

    //Class : Class ==> Inherit
    //Class :Interface ==> Implement
    //Struct:Interface ==> Implement
    //Interface : Interfaces ==> inherit
    //Interface Can Be Implemented Through Class Or Struct


    internal class MyType : IMyType  //Implement
    {
        public int Id { get; set;} //Automatic Property
                                   // Compiler Witt generate Private Hidden Attribute (Backing Field]

        //Non Static Function [Object Member Function]
        public void MyFun(int X)
        {
            Console.WriteLine($"Hello Route : X = {X} , Id = {Id}");

        }
    }
}
