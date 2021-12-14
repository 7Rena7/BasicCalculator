using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDemo
{
    /// <summary>
    /// A type of operation the calculator can perform
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Adds two values together
        /// </summary>
        Add,
        
        /// <summary>
        /// Takes one value from another
        /// </summary>
        Minus,
        
        /// <summary>
        /// Divides one number by the other
        /// </summary>
        Divide,
        
        /// <summary>
        /// Multiplies a number by other
        /// </summary>
        Multiply
    }
}
