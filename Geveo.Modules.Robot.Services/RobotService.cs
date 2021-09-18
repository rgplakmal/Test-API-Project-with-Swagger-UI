using Geveo.Modules.Robot.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Geveo.Modules.Robot.ViewModels;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Geveo.Modules.Robot.Services
{
    public class RobotService : IRobotService
    {
        #region Private Declarations
        private readonly ILogger<RobotService> _logger;
        #endregion Private Declarations 

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">RobotService</param>
        public RobotService(ILogger<RobotService> logger)
        {
            _logger = logger;
        }

        #endregion Constructor

        #region Public Methods - Services
        /// <summary>
        /// Test Api - Async
        /// </summary>
        /// <param></param>
        /// <returns>string</returns>
        public async Task<string> TestApiAsync()
        {
            return "Welcome! Successfully Access";
        }

        /// <summary>
        /// Get Test Data - Async
        /// </summary>
        /// <param name="param">param</param>
        /// <returns>TestVM</returns>
        public async Task<TestVM> GetTestDataAsync(string param)
        {
            TestVM testVM = new TestVM();

            testVM.BankName = "Sampath";
            testVM.BranchName = "Colombo";

            return testVM;
        }

        #endregion Public Methods - Services
    }
}
