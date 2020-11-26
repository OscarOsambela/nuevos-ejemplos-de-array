using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    //array multiple
    string[] hijos = {"Thelma", "Valentino", "Vernita", "Francisco"};
    int numero = 0;
    foreach(string hijo in hijos){
      numero++;
      string uLetra = hijo.Substring(hijo.Length -1, 1);
      if(uLetra == "a") Console.WriteLine("{0} es mi hija número {1}.", hijo, numero);
      else Console.WriteLine("{0} es mi hijo número {1}.", hijo, numero);
    }
    
    Console.WriteLine("===================");

    // Two-dimensional array.
    int[,] array2D = new int[,] { 
      { 1, 2 }, 
      { 3, 4 }, 
      { 5, 6 }, 
      { 7, 8 } 
    };
    // The same array with dimensions specified.
    int[,] array2Da = new int[4, 2] { 
      { 1, 2 }, 
      { 3, 4 }, 
      { 5, 6 }, 
      { 7, 8 } 
    };
    // A similar array with string elements.
    string[,] array2Db = new string[3, 2] { 
      { "one", "two" }, 
      { "three", "four" },
      { "five", "six" } 
    };

    //three-dimensional array
    int[, ,] array3D = new int[,,] { 
      { 
        { 1, 2, 3 }, 
        { 4, 5, 6 } 
      },
      { 
        { 7, 8, 9 }, 
        { 10, 11, 12 } 
      },
      {
        {13, 14, 15 },
        {16, 17, 18 }
      } 
    };
    // The same array with dimensions specified.
    int[, ,] array3Da = new int[4, 2, 3] { 
      { 
        { 1, 2, 3 }, 
        { 4, 5, 6 } 
      },
      { 
        { 7, 8, 9 }, 
        { 10, 11, 12 } 
      },
      { 
        { 13, 14, 15 }, 
        { 16, 17, 18 } 
      },
      { 
        { 19, 20, 21 }, 
        { 22, 23, 24 } 
      }  
    };

  // array2D
    Console.WriteLine("1: {0}", array2D[0,0]);
    Console.WriteLine("4: {0}", array2D[1,1]);
    Console.WriteLine("7: {0}", array2D[3,0]);
    Console.WriteLine("===============================");
  //array2Da
    Console.WriteLine("3: {0}", array2Da[1,0]);
    Console.WriteLine("7: {0}", array2Da[3,0]);
    Console.WriteLine("8: {0}", array2Da[3,1]);
    Console.WriteLine("2: {0}", array2Da[0,1]);
    Console.WriteLine("===============================");
  //array2Db
    Console.WriteLine("1= {0}", array2Db[0,0]);
    Console.WriteLine("4= {0}", array2Db[1,1]);
    Console.WriteLine("5= {0}", array2Db[2,0]);
  //Three-dimensional array
    Console.WriteLine("4= {0}", array3D[0,1,0]);
    Console.WriteLine("7= {0}", array3D[1,0,0]);
    Console.WriteLine("13= {0}", array3D[2,0,0]);
    Console.WriteLine("17= {0}", array3D[2,1,1]);
    Console.WriteLine("3= {0}", array3Da[0,0,2]);
    Console.WriteLine("5= {0}", array3Da[0,1,1]);
    Console.WriteLine("6= {0}", array3Da[0,1,2]);
    Console.WriteLine("15= {0}", array3Da[2,0,2]);
    Console.WriteLine("21= {0}", array3Da[3,0,2]);
    Console.WriteLine("22= {0}", array3Da[3,1,0]);
  }
}

