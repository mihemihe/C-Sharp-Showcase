// C# Showcase project
// Clear and concise examples for C# features up to C# 8.0 (September 2019)
// Project target: .Net Framework 4.7.2 (September 2019)
// Recommended tools to follow the examples:
//      * dnSpy: To browse the core libraries and IL
//      * Visual Studio 2019: Visual Studio community is free.
//      * https://referencesource.microsoft.com/ : The .Net Framework source code. Version 4.8 (September 2019)
// This is an example of a single-line comment
/* This is an example of
   a comment block.
*/

namespace Showcase
{
    // C# 1.0: Classes are reference types defining data and behaviour. All classes derive from system.object
    // Example: class Program followed by its definition in the code block enclosed by brackets { }
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    // C# 1.0: Structures are value types. They are copied on assignment. For example, built-in C# numeric types are built
    //         using structs like "float" as the "system.single" struct.
    // Example: struct compensation, followed by the data packed into the struct. 
    internal struct compensation
    {
        private float baseSalary;
        private float bonus;
        private float expenses;
        private float totalCompensation;
        private TAX_TIERS taxTier;
    }

    internal enum TAX_TIERS
    {
        TIER1 = 0,
        TIER2 = 5,
        TIER3 = 12,
        TIER4 = 17
    }
}