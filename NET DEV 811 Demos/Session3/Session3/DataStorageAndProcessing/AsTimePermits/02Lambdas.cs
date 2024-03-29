﻿// Fig. 10.28: Lambdas.cs
// Using lambda expressions.
using System;
using System.Collections.Generic;

class DelegatesAndLambdas
{
   // delegate for a function that receives an int and returns a bool
   public delegate bool NumberPredicate( int number );

   public static void LambdasMain()
   {
      int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

      // create an instance of the NumberPredicate delegate type using an
      // implicit lambda expression
      NumberPredicate evenPredicate = number => ( number % 2 == 0 );

      // call a lambda expression through a variable
      Console.WriteLine( "Use a lambda expression variable: {0}",
         evenPredicate( 4 ) );

      // filter the even numbers using a lambda expression
      List< int > evenNumbers = FilterArray( numbers, evenPredicate );

      // display the result
      DisplayList( "Use a lambda expression to filter even numbers: ",
         evenNumbers );

      // filter the odd numbers using an explicitly typed lambda 
      // expression
      List< int > oddNumbers = FilterArray( numbers, 
         ( int number ) => ( number % 2 == 1 ) );

      // display the result
      DisplayList( "Use a lambda expression to filter odd numbers: ",
         oddNumbers );

      // filter numbers greater than 5 using an implicit lambda statement
      List< int > numbersOver5 = FilterArray( numbers, 
         number => { return number > 5; } );

      // display the result
      DisplayList( "Use a lambda expression to filter numbers over 5: ",
         numbersOver5 );
   } // end Main

   // select an array's elements that satisfy the predicate
   private static List< int > FilterArray( int[] intArray, 
      NumberPredicate predicate )
   {
      // hold the selected elements
      List< int > result = new List< int >();

      // iterate over each element in the array
      foreach ( int item in intArray )
      {
         // if the element satisfies the predicate
         if ( predicate( item ) )
            result.Add( item ); // add the element to the result
      } // end foreach

      return result; // return the result
   } // end method FilterArray

   // display the elements of a List
   private static void DisplayList( string description, List< int > list )
   {
      Console.Write( description ); // display the output's description

      // iterate over each element in the List
      foreach ( int item in list )
         Console.Write( "{0} ", item ); // print item followed by a space

      Console.WriteLine(); // add a new line
   } // end method DisplayList
} // end class Lambdas

/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/