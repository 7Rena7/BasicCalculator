using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDemo
{
    /// <summary>
    /// Holds information about a single caluclator operation
    /// </summary>
    public class Operation
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Operation()
        {
            //CReate empty strings instead of having null
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// The left side of the operation
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// The right side of the operation
        /// </summary>
        public string RightSide { get; set; }

        /// <summary>
        /// The type of operation to perform
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// The operation to be performed initially before this operation
        /// </summary>
        public Operation InnerOperation { get; set; }

        #endregion
    }
}
