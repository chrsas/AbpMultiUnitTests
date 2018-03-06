using System;
using System.Runtime.Serialization;
using Abp.Logging;
using Abp.UI;

namespace Sdt.Common
{
    /// <inheritdoc />
    /// <summary>
    /// 用这个能抛出400的异常
    /// </summary>
    public class SdtFriendlyException : UserFriendlyException
    {
        protected SdtFriendlyException()
        {
        }

        /// <inheritdoc />
        /// <param name="message"></param>
        public SdtFriendlyException(string message) : base(message)
        {
        }

        public SdtFriendlyException(SerializationInfo serializationInfo, StreamingContext context) : base(
            serializationInfo, context)
        {
        }

        public SdtFriendlyException(string message, LogSeverity severity) : base(message, severity)
        {
        }

        public SdtFriendlyException(int code, string message) : base(code, message)
        {
        }

        public SdtFriendlyException(string message, string details) : base(message, details)
        {
        }

        public SdtFriendlyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public SdtFriendlyException(int code, string message, string details) : base(code, message, details)
        {
        }

        public SdtFriendlyException(string message, string details, Exception innerException) : base(message, details,
            innerException)
        {
        }

    }
}
