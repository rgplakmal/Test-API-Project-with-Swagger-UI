using Geveo.Modules.Robot.Base.Common;
using Geveo.Modules.Robot.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geveo.Modules.Robot.DTOs.TestData
{

    public class TestDataResponse : BaseResponse
    {
        public TestVM TestVM { get; set; }
    }
}
