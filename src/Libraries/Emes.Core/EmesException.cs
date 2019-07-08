using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Emes.Core
{
    /// <summary>
    /// 表示在应用程序执行期间发生的错误
    /// </summary>
    [Serializable]
    public class EmesException : Exception
    {
        /// <summary>
        /// 初始化异常类的新实例。
        /// </summary>
        public EmesException()
        {
        }

        /// <summary>
        /// 用指定的错误消息初始化异常类的新实例。
        /// </summary>
        /// <param name="message">描述错误的消息。</param>
        public EmesException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// 用指定的错误消息初始化异常类的新实例。
        /// </summary>
        /// <param name="messageFormat">异常消息格式。</param>
        /// <param name="args">异常消息参数。</param>
        public EmesException(string messageFormat, params object[] args)
            : base(string.Format(messageFormat, args))
        {
        }

        /// <summary>
        ///用序列化的数据初始化异常类的新实例。
        /// </summary>
        /// <param name="info">序列化的序列化信息，关于抛出异常的序列化对象数据。</param>
        /// <param name="context">包含关于源或目的地的上下文信息的StreamingContext。</param>
        protected EmesException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// 用指定的错误消息初始化异常类的新实例，并引用内部异常，这是该异常的原因。
        /// </summary>
        /// <param name="message">错误消息解释了异常的原因。</param>
        /// <param name="innerException">唯一的例外是当前异常的原因，或者如果没有指定内部异常，则是null引用。</param>
        public EmesException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
