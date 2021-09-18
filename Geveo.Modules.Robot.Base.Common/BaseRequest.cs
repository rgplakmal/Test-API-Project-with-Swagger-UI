using System;

namespace Geveo.Modules.Robot.Base.Common
{
    /// <summary>
    /// Abstract model to represent base request
    /// </summary>
    public abstract class BaseRequest
    {
        #region Public Properties -----------------------------------------------------------------

        /// <summary>
        /// Last accessed date and time
        /// </summary>
        public DateTime LastAccessedDateTime { get; set; }

        #endregion
    }
}
