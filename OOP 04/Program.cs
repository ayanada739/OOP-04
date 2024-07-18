using OOP_04.Interfaces;

namespace OOP_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface

            ////IMyType myType = new IMyType(); // Invalid
            //// You Can not Create an object from interface
            ////IMyType myType;
            //// you can create a reference from interface
            //// CLR Will Allocate Bytes For Reference "my Type"
            //// References "my Type" Refer To Null
            ////References "myType" Can referto an Object From Class Or struct Implement Interface

            ////myType. Id= 20; // Invalid myType Refer To Null
            ////myType.myFun(1); // Invalid myType Refer To Null
            ////myType. Print(); // Invalid my Type Refer To Null

            ////MyType my Type1= new MyType();
            ////myType1.Id = 30;
            ////myType1. MyFun( 100) ;
            //////myType1. Print(); // Invalid [Default Implemented Method]
            /////
            //IMyType myType = new MyType();
            //// Ref From Interface --> Object From Class Implement Interface
            //myType.Id = 60;
            //myType.MyFun(600);
            //myType.Print();

            #endregion


        }
}
}
