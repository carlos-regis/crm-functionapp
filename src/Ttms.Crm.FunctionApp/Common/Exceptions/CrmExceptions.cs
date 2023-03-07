using System;

namespace Ttms.Crm.FunctionApp.Common.Exceptions
{
    public static class CrmExceptions
    {
        /// <summary>
        /// A function to manage exceptions thrown by the app
        /// </summary>
        /// <param name="exception">The exception thrown</param>
        public static void HandleException(Exception exception)
        {
            if (exception.InnerException != null)
            {
                HandleException(exception.InnerException);
            }
            else
            {
                throw exception;
            }
        }
    }
}
