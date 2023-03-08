using System;

namespace Ttms.Crm.FunctionApp.Common
{
    public class OperationResult
    {
        protected OperationResult()
        {
            this.Success = true;
        }

        protected OperationResult(string message)
        {
            this.Success = false;
            this.FailureMessage = message;
        }

        protected OperationResult(Exception exception)
        {
            this.Success = false;
            this.Exception = exception;
        }

        public bool Success { get; protected set; }
        public string FailureMessage { get; protected set; }
        public Exception Exception { get; protected set; }

        public static OperationResult SuccessResult()
        {
            return new OperationResult();
        }

        public static OperationResult FailureResult(string message)
        {
            return new OperationResult(message);
        }

        public static OperationResult ExceptionResult(Exception exception)
        {
            return new OperationResult(exception);
        }
    }
}
