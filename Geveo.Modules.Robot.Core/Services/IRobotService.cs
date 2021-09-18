using Geveo.Modules.Robot.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Geveo.Modules.Robot.Core.Services
{
    public interface IRobotService
    {
        #region Task
        /// <summary>
        /// Test Api - Async
        /// </summary>
        /// <param></param>
        /// <returns>string</returns>
        Task<string> TestApiAsync();

        /// <summary>
        /// Get Test Data - Async
        /// </summary>
        /// <param name="param">param</param>
        /// <returns>TestVM</returns>
        Task<TestVM> GetTestDataAsync(string param);
        #endregion
    }
}
