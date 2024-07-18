using OOP_04.Interfaces;
using System;
using System.Text;

namespace OOP_04
{
    internal class Program
    {
        public static void PrintlONunbersFromSeries(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{series.Current}"); //0
                    series.GetNext();
                }

                series.Reset();
            }
        }

         
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

            #region Interface Ex 01

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);
            ////0 2 4 6 8 10 12 14 16 18



            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);
            ////0 3 6 9 12 15 18 21 24 27 


            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10NumbersFromSeries(seriesByFour);
            #endregion

            #region Interface Ex 02
            //Car car = new Car();
            //car.Backward(); //Can Move Backword On Ground

            //Airplane airplane = new Airplane();
            //airplane.Backward(); //Airplane Move Backword  
            ////airplane.Forword(); // Invalid
            //IMovable MovablePlan = new Airplane();
            //MovablePlan.Forward(); //Airplane Move Forword On Ground

            //IFlyable FlyablePlane = new Airplane();
            //FlyablePlane.Forward(); //Airplane Move Forword On Air

            #endregion

            #region Shallow Copy And Deep Copy

            #region Array Of Value Type
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3]; //{0 , 0 , 0}

            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}");

            #region Shallow Copy [Stack]

            //Arr02 = Arr01; // Shallow Copy
            //               // Copy Occurred at Stack
            //               // References [Arr01 Arr02]==>Same Object

            //Console.WriteLine("After Shallow Copy");

            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}");
            //Arr02[0] = 100;

            //Console.WriteLine("After   Arr02[0] = 100");


            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");
            #endregion

            #region Deep Copy [Heap]

            //Arr02 =(int[]) Arr01.Clone();
            ///Clone ==> Deep Copy
            /// Deep Copy Occurred At Heap
            /// Create New Object With Different and New Identity
            /// That Object Will be The Same Object State (Data) Of Caller [Arr0l]
            /// Return to An Object


            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");//1
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");//1

            //Arr01[0] = 100;


            //Console.WriteLine("After   Arr01[0] = 100");


            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");//100
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");//1

            #endregion







            #endregion


            #region Array Of Reference Type

            #region Array Of String [Immutable Type]

            //string[] Names01 = { "Aya" };
            //string[] Names02 = new string[1]; // { null }

            //Console.WriteLine($"HC Of Names01 ={Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 ={Names02.GetHashCode()}");

            #region Shallow Copy

            //Names02 = Names01; //Shalow Copy [References ---Stack]
            //                   //References [Name01 , Name02 ] ==> Same Object

            //Console.WriteLine("After Shallow Copy");

            //Console.WriteLine($"HC Of Names01 ={Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 ={Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] = {Names01[0]}"); //Aya
            //Console.WriteLine($"Names02[0] = {Names02[0]}"); //Aya

            //Names02[0] = "Nada";


            //Console.WriteLine($"Names01[0] = {Names01[0]}"); //Nada
            //Console.WriteLine($"Names02[0] = {Names02[0]}"); //Nada


            #endregion

            #region Deep Copy


            //Names02 = (string[])Names01.Clone();
            //// Create New Object With New And Different Identity
            //// Object Will Have Same Object State [Data]OF Caller Name01

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HC Of Names01 ={Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 ={Names02.GetHashCode()}");


            // Console.WriteLine($"Names01[0] = {Names01[0]}"); //Aya
            // Console.WriteLine($"Names02[0] = {Names02[0]}"); //Aya

            //Names02[0] = "Nada";

            //Console.WriteLine($"Names01[0] = {Names01[0]}"); //Aya
            //Console.WriteLine($"Names02[0] = {Names02[0]}"); //Nada



            #endregion

            #endregion

            #region Array Of StringBuilder [Mutable Type]

            //StringBuilder[] Names01 = new StringBuilder[1];
            ////Name01[0].Append("Omar"); //NullReferenceException
            //Names01[0] = new StringBuilder("Omar");

            //StringBuilder[] Names02 = new StringBuilder[1];
            //Console.WriteLine($"HC Of Names01 ={Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 ={Names02.GetHashCode()}");

            #region Shallow Copy [Stack]
            //Names02 = Names01; // Shallow Copy [Stack]
            //                   // 2 References [ Names01 , Names02] ==> Same Object


            //Console.WriteLine("Names02 = Names01");
            //Console.WriteLine($"HC Of Names01 ={Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 ={Names02.GetHashCode()}");


            //Console.WriteLine($"Names01[0] = {Names01[0]}"); //Omar
            //Console.WriteLine($"Names02[0] = {Names02[0]}"); //Omar

            //Names02[0].Append("Amr");
            //Console.WriteLine("Names02[0].Append(\"Amr\")");

            //Console.WriteLine($"Names01[0] = {Names01[0]}"); //Omar Amr
            //Console.WriteLine($"Names02[0] = {Names02[0]}"); //Omar Amr
            #endregion

            #region deep Copy [Heap]

            //Names02 = (StringBuilder[])Names01.Clone(); //Deep Copy
            //                                            //References [Names01 , Names02 ] ==> 2 different Objects



            //Console.WriteLine("Names02 = (StringBuilder[])Names01.Clone();");
            //Console.WriteLine($"HC Of Names01 ={Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 ={Names02.GetHashCode()}");


            //Console.WriteLine($"Names01[0] = {Names01[0]}"); //Omar
            //Console.WriteLine($"Names02[0] = {Names02[0]}"); //Omar

            //Names02[0].Append("Amr");
            //Console.WriteLine("Names02[0].Append(\"Amr\")");

            //Console.WriteLine($"Names01[0] = {Names01[0]}"); //Omar Amr
            //Console.WriteLine($"Names02[0] = {Names02[0]}"); //Omar Amr
            #endregion

            #endregion
            #endregion

            #endregion






        }


    }
}
