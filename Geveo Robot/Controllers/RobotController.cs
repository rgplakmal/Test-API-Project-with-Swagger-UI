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

        //private readonly ICreditApprovalService _creditApprovalService;
        private readonly ILogger<RobotController> _logger;
        //private readonly IMapper _mapper;
        //private readonly IAuthorizationAttributesService _authSvc;

        #endregion

        #region Constructor

        ///// <summary>
        ///// Credit Common - Controller
        ///// </summary>
        ///// <param name="creditApprovalService">Business Lead Management service DI</param>
        ///// <param name="logger"></param>
        ///// <param name="mapper"></param>
        ///// <param name="authSvc">IAuthorizationAttributesService</param>
        //public CreditApprovalController(ICreditApprovalService creditApprovalService, ILogger<CreditApprovalController> logger, IMapper mapper, IAuthorizationAttributesService authSvc)
        //{
        //    _creditApprovalService = creditApprovalService;
        //    _logger = logger;
        //    _mapper = mapper;
        //    _authSvc = authSvc;
        //}
        #endregion

        #region Task
        /// <summary>
        /// Get Aplication Creation Approval Data By Credit Account Lead Reference No - Async
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [HttpGet("{param}", Name = "GetAplicationDataAsync")]
        public async Task<TestDataResponse> GetAplicationDataAsync(string param)
        {
            TestDataResponse testDataResponse = new TestDataResponse();
            try
            {
                //var userId = _authSvc.UserId;
                //var agentId = _authSvc.AgentId;
                testDataResponse.Number = 10;
                //testDataResponse.ApplicationCreationApprovalData = await _creditApprovalService.GetAplicationCreationApprovalDataByCreditAccountLeadReferenceNoAsync(creditAccountLeadReferenceNo, currentTab, userId, agentId);
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
