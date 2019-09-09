// C# Showcase project
// Clear and concise examples for C# features and keywords up to C# 8.0 (September 2019)
// Project target: .Net Framework 4.7.2 (September 2019)
// This project samples are not intended to demonstrate the correct, optimal or recommended use of C# features and keywords, but just a compilation of them.
// Recommended tools to follow the examples:
//      * dnSpy: To browse the core libraries and IL
//      * Visual Studio 2019: Visual Studio community is free.
//      * https://referencesource.microsoft.com/ : The .Net Framework source code. Version 4.8 (September 2019)

// TODO:
//      Add using comments

// This is an example of a single-line comment
/* This is an example of
   a comment block.
*/
using System;

// C# 1.0: Namespaces are used to group objects into the same scope. They are used to limite the scope and visibility and
//         help to organize large projects.
// Example: namespace Showcase, containing the clases and other types related to this project. The .NET Framework uses namespaces
//          to organize the several classes contained in it, like system.net or system.Math
namespace Showcase
{
    // C# 1.0: Classes are reference types defining data and behaviour. All classes derive from system.object
    // Example: class Program followed by its definition in the code block enclosed by brackets { }
    internal class Program
    {
        private static compensation compensationSample;
        private static compensation compensationSample2;
        private static void Main(string[] args)
        {
            compensationSample = new compensation(_baseSalary: 15000f, 1000f, 500f, 0f, TAX_TIERS.TIER2);
            compensationSample2.baseSalary = 18000f;
            Console.WriteLine("Welcome to the C# Showcase project");
            Console.WriteLine(compensationSample.baseSalary.ToString());
            Console.WriteLine(compensationSample2.baseSalary.ToString());
            Console.WriteLine(compensationSample2.expenses.ToString());

            Console.ReadKey();

        }
    }

    // C# 1.0: Structures are value types. They are copied on assignment. For example, built-in C# numeric types are built
    //         using structs like "float" as the "system.single" struct.
    // Example: struct compensation, followed by the data packed into the struct inside the { code block }
    internal struct compensation
    {
        public compensation(float _baseSalary, float _bonus, float _expenses, float _totalCompensation, TAX_TIERS _taxTier)
        {
            baseSalary = _baseSalary;
            bonus = _bonus;
            expenses = _expenses;
            totalCompensation = _totalCompensation;
            taxTier = _taxTier;
        }
        public float baseSalary;
        public float bonus;
        public float expenses;
        public float totalCompensation;
        public TAX_TIERS taxTier;
    }

    // C# 1.0 (Check this): Enums are value types. They are used to define meaningful names to integer constants.
    // Example: enu TAX_TIERS define several named tiers, like TAX_TIERS.TIER3, wich is backed up by an integer constant: 13.
    internal enum TAX_TIERS
    {
        TIER1 = 0,
        TIER2 = 5,
        TIER3 = 12,
        TIER4 = 17
    }
}