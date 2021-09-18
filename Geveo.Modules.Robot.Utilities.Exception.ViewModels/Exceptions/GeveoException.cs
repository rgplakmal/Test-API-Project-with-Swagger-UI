using Geveo.Modules.Robot.Base.Common;

namespace Geveo.Utilities.Exception.ViewModels.Exceptions
{
    public class GeveoException : System.Exception
    {

        public GeveoException(System.Exception innerException, BaseResponse response)
            : base("", innerException)
        {
            Response = response;
        }

        public BaseResponse Response { get; set; }
    }
}