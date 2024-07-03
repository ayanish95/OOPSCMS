using Microsoft.VisualBasic;
using System;
using System.Reflection.Emit;
using System.Security.AccessControl;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI.Model
{
    /*
     *   => A class holds the objects
     *   => Class should have one responsiblity
     */
    public class Student
    {
        /*                 Objects
         *      => Object is a member of class
         *      => Objects create instance of a class
         *      => Objects are created using new keywords
         * 
         *              Constructor
         *      => It is Special Methods When Objects are created.
         *      
         *              Abstract Class
         *      => Abstraction is showing main idea and hidding the background thinks
         *          Example :- Students Class   is Abstrcation
         *                     Students Courses, Marks, Exam Details all are the background details.
         *      > Abstract Reduces Complexity
         * 
         */

        public Student()
        {
            /*
             *                  Constructor
             *         
             *         
             *                  Types of Constructor
             *      1. Default Constructor
             *       => Implicit Default Constructor: If no constructor is explicitly defined in a class, the compiler automatically provides a default constructor with no parameters.
             *       => Explicit Default Constructor: A constructor explicitly defined by the programmer without parameters.
             *
             *      2. Parameterized Constructor 
             *       => A constructor that takes one or more parameters, allowing the programmer to pass values to initialize the object at the time of creation.
             *      
             *      3. Static Constructor
             *       => A constructor used to initialize static fields of a class or to perform actions that need to be performed only once. 
             *       => It is called automatically before any static members are accessed or any instance is created.
             *      
             *      4. Copy Constructor
             *       => A constructor that creates a new object as a copy of an existing object.
             *       => It's commonly used in languages like C++, but not explicitly supported in C#; 
             *      
             *      5. Private Constructor
             *       => A constructor that cannot be accessed outside the class, typically used in singleton patterns to restrict instantiation.
             */

            // All Initializations goes here.

            //      Assign the readonly field.
            MaxEnrolledCoursesExternal = 6;
            MaxEnrolledCoursesInternal = 7;
        }

        /*
         *            Fields
         *    => Fields are used to store data
         *    => It includes
         *        -> access modifire
         *        -> types of objects
         *        -> name of fields 
         *   
         *          Types of Fields
         *      1. Normal    :-  Store data for the Objects. Their value can be changed.
         *      2. Read Only :-  Except in constructor. Their value can't be changes.
         *      3. Constant  :-  Their value can't be changes.
         *      
         *              Readonly    VS    Constant
         *      1. Both are assign value during compile time
         *      2. Readonly assign value during runtime.
         *      3. Const is compile time assign value. So, Rebuild required if Const value change. 
         *      
         *      
         *              Static Fields
         *      => Static Fields are shared across all instance of a class.
         *      => Static member is always accessed by the class name.
         *
         */

        public int StudentId;
        public string FirstName;
        public string LastName;
        public const int MaxEnrolledCourses = 3;
        public readonly int MaxEnrolledCoursesExternal = 3;
        public static int MaxEnrolledCoursesInternal = 3;
        public static readonly int MaxEnrolledCoursesExternalOnline = 3;


        //           1. const
        // => Usage: For compile-time constants.
        // => Initialization: Must be initialized at the time of declaration.
        // => Mutability: Immutable after initialization.
        // => Scope: Accessible at class level, without needing an instance of the class.
        // => Memory: Stored in the assembly metadata, not in heap or stack.

        //            2. static
        // => Usage: For members that are shared across all instances of a class.
        // => Initialization: Can be initialized in the declaration or a static constructor.
        // => Mutability: Can be mutable or immutable, depending on the context.
        // => Scope: Accessible at class level, without needing an instance of the class.
        // => Memory: Stored in a special memory area for static members.

        //            3. static readonly
        // => Usage: For runtime constants that are shared across all instances of a class.
        // => Initialization: Can be initialized at the time of declaration or in a static constructor.
        // => Mutability: Immutable after initialization.
        // => Scope: Accessible at class level, without needing an instance of the class.
        // => Memory: Stored in a special memory area for static members.

        //             4. readonly
        // => Usage: For runtime constants that need to be assigned once and not modified thereafter.
        // => Initialization: Can be initialized at the time of declaration or in any constructor of the class.
        // => Mutability: Immutable after initialization.
        // => Scope: Instance level, though it can also be used with static for class-level scope.
        // => Memory: Stored on the heap if it is an instance member, or in a special memory area for static members if declared as static readonly.


        /*                  Values Type VS Refrence Type
         * 
         *      1. Store value to Directly                      1. Store Memory Address, Where the data is store
         *      2. Changes are applied to Current Instances     2. Changes are applied to Both Instances
         * 
         *      Example :- char, int, float, bool               Example :- string, object, class
         * 
         *      Note :- Class is refrence type
         * 
         */


        //                  private
        // => Scope: Accessible only within the same class or struct where it is declared.
        // => Use Case: Used to encapsulate and hide implementation details from other classes, ensuring that certain class members are not accessible from outside the class.
        // => Inheritance: Not accessible by derived classes.


        //                  protected
        // => Scope: Accessible within the same class and by derived classes.
        // => Use Case: Used when you want to allow derived classes to access and possibly modify the base class's members, but you still want to prevent external classes from accessing those members directly.
        // => Inheritance: Accessible by derived classes.

    }
}
