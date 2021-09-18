using Geveo.Modules.Robot.Base.Common;
using Geveo.Modules.Robot.Core.Services;
using Geveo.Modules.Robot.DTOs.TestData;
using Geveo.Utilities.Exception.ViewModels.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geveo.Modules.Robot.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RobotController : ControllerBase
    {
        #region Private Declarations

        private readonly IRobotService _robotService;
        private readonly ILogger<RobotController> _logger;
        //private readonly IMapper _mapper;
        //private readonly IAuthorizationAttributesService _authSvc;

        #endregion

        #region Constructor

        /// <summary>
        /// Credit Common - Controller
        /// </summary>
        /// <param name="robotService">Business Lead Management service DI</param>
        /// <param name="logger"></param>
        public RobotController(IRobotService robotService, ILogger<RobotController> logger)
        {
            _robotService = robotService;
            _logger = logger;
        }
        #endregion

        #region Task
        /// <summary>
        /// Test Api - Async
        /// </summary>
        /// <param></param>
        /// <returns>TestResponse</returns>
        [HttpGet(Name = "TestApiAsync")]
        public async Task<TestResponse> TestApiAsync()
        {
            TestResponse testResponse = new TestResponse();
            try
            {
                testResponse.Message = await _robotService.TestApiAsync();
                testResponse.IsSuccess = true;
            }
            catch (Exception ex)
            {
                throw new GeveoException(ex, testResponse);
            }
            return testResponse;
        }

        /// <summary>
        /// Get Test Data - Async
        /// </summary>
        /// <param name="param"></param>
        /// <returns>TestDataResponse</returns>
        [HttpGet("{param}", Name = "GetTestDataAsync")]
        public async Task<TestDataResponse> GetTestDataAsync(string param)
        {
            TestDataResponse testDataResponse = new TestDataResponse();
            try
            {
                testDataResponse.TestVM = await _robotService.GetTestDataAsync(param);
                testDataResponse.IsSuccess = true;
            }
            catch (Exception ex)
            {
                throw new GeveoException(ex, testDataResponse);
            }
            return testDataResponse;
        }
        #endregion
    }
}
