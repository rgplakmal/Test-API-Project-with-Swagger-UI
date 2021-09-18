using FluentValidation.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using FluentValidation;

namespace Geveo.Modules.Robot
{
    /// <summary>
    /// Abstract model to represent base response   
    /// </summary>    
    public abstract class BaseResponse
    {
        #region Public Properties -----------------------------------------------------------------
        /// <summary>
        /// Message
        /// </summary>

        public string Message { get; set; }

        /// <summary>
        /// Message details
        /// </summary>
        public string MessageDetails { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public ResponseStatus Status { get; set; }

        /// <summary>
        /// List of validation errors
        /// </summary>
        public IList<ValidationFailure> ValidationErrors { get; set; }

        /// <summary>
        /// Last accessed date and time
        /// </summary>
        public DateTime LastAccessedDateTime { get; set; }

        /// <summary>
        /// Success flag
        /// </summary>
        public bool IsSuccess { get; set; }

        #endregion Public Properties
    }

}