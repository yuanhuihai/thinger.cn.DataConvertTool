using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.cn.DataConvertHelper
{



    /// <summary>
    /// 操作结果的类，只带有成功标志和错误信息 -> The class that operates the result, with only success flags and error messages
    /// </summary>
    /// <remarks>
    /// 当 <see cref="IsSuccess"/> 为 True 时，忽略 <see cref="Message"/> 及 <see cref="ErrorCode"/> 的值
    /// </remarks>
    public class XktResult
    {
        #region Constructor

        /// <summary>
        /// 实例化一个默认的结果对象
        /// </summary>
        public XktResult()
        {
        }

        /// <summary>
        /// 使用指定的消息实例化一个默认的结果对象
        /// </summary>
        /// <param name="msg">错误消息</param>
        public XktResult(string msg)
        {
            this.Message = msg;
        }

        /// <summary>
        /// 使用错误代码，消息文本来实例化对象
        /// </summary>
        /// <param name="err">错误代码</param>
        /// <param name="msg">错误消息</param>
        public XktResult(int err, string msg)
        {
            this.ErrorCode = err;
            this.Message = msg;
        }

        #endregion

        /// <summary>
        /// 指示本次访问是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 具体的错误描述
        /// </summary>
        public string Message { get; set; } = "Unknown";

        /// <summary>
        /// 具体的错误代码
        /// </summary>
        public int ErrorCode { get; set; } = 10000;



        /// <summary>
        /// 从另一个结果类中拷贝错误信息
        /// </summary>
        /// <typeparam name="TResult">支持结果类及派生类</typeparam>
        /// <param name="result">结果类及派生类的对象</param>
        public void CopyErrorFromOther<TResult>(TResult result) where TResult : XktResult
        {
            if (result != null)
            {
                ErrorCode = result.ErrorCode;
                Message = result.Message;
            }

        }

        #region Static Method


        /// <summary>
        /// 创建并返回一个失败的结果对象
        /// </summary>
        /// <returns>失败的结果对象</returns>
        public static XktResult CreateFailedResult()
        {
            return new XktResult()
            {
                IsSuccess = false,
                ErrorCode = 10000,
                Message = "Unknown",
            };
        }


        /// <summary>
        /// 创建并返回一个失败的结果对象，该对象复制另一个结果对象的错误信息
        /// </summary>
        /// <typeparam name="T">目标数据类型</typeparam>
        /// <param name="result">之前的结果对象</param>
        /// <returns>带默认泛型对象的失败结果类</returns>
        public static XktResult<T> CreateFailedResult<T>(XktResult result)
        {
            return new XktResult<T>()
            {
                ErrorCode = result.ErrorCode,
                Message = result.Message,
            };
        }

        /// <summary>
        /// 创建并返回一个失败的结果对象，该对象复制另一个结果对象的错误信息
        /// </summary>
        /// <typeparam name="T1">目标数据类型一</typeparam>
        /// <typeparam name="T2">目标数据类型二</typeparam>
        /// <param name="result">之前的结果对象</param>
        /// <returns>带默认泛型对象的失败结果类</returns>
        public static XktResult<T1, T2> CreateFailedResult<T1, T2>(XktResult result)
        {
            return new XktResult<T1, T2>()
            {
                ErrorCode = result.ErrorCode,
                Message = result.Message,
            };
        }


        /// <summary>
        /// 创建并返回一个失败的结果对象，该对象复制另一个结果对象的错误信息
        /// </summary>
        /// <typeparam name="T1">目标数据类型一</typeparam>
        /// <typeparam name="T2">目标数据类型二</typeparam>
        /// <typeparam name="T3">目标数据类型三</typeparam>
        /// <param name="result">之前的结果对象</param>
        /// <returns>带默认泛型对象的失败结果类</returns>
        public static XktResult<T1, T2, T3> CreateFailedResult<T1, T2, T3>(XktResult result)
        {
            return new XktResult<T1, T2, T3>()
            {
                ErrorCode = result.ErrorCode,
                Message = result.Message,
            };
        }


        /// <summary>
        /// 创建并返回一个失败的结果对象，该对象复制另一个结果对象的错误信息
        /// </summary>
        /// <typeparam name="T1">目标数据类型一</typeparam>
        /// <typeparam name="T2">目标数据类型二</typeparam>
        /// <typeparam name="T3">目标数据类型三</typeparam>
        /// <typeparam name="T4">目标数据类型四</typeparam>
        /// <param name="result">之前的结果对象</param>
        /// <returns>带默认泛型对象的失败结果类</returns>
        public static XktResult<T1, T2, T3, T4> CreateFailedResult<T1, T2, T3, T4>(XktResult result)
        {
            return new XktResult<T1, T2, T3, T4>()
            {
                ErrorCode = result.ErrorCode,
                Message = result.Message,
            };
        }


        /// <summary>
        /// 创建并返回一个失败的结果对象，该对象复制另一个结果对象的错误信息
        /// </summary>
        /// <typeparam name="T1">目标数据类型一</typeparam>
        /// <typeparam name="T2">目标数据类型二</typeparam>
        /// <typeparam name="T3">目标数据类型三</typeparam>
        /// <typeparam name="T4">目标数据类型四</typeparam>
        /// <typeparam name="T5">目标数据类型五</typeparam>
        /// <param name="result">之前的结果对象</param>
        /// <returns>带默认泛型对象的失败结果类</returns>
        public static XktResult<T1, T2, T3, T4, T5> CreateFailedResult<T1, T2, T3, T4, T5>(XktResult result)
        {
            return new XktResult<T1, T2, T3, T4, T5>()
            {
                ErrorCode = result.ErrorCode,
                Message = result.Message,
            };
        }



        /// <summary>
        /// 创建并返回一个成功的结果对象
        /// </summary>
        /// <returns>结果对象</returns>
        public static XktResult CreateSuccessResult()
        {
            return new XktResult()
            {
                IsSuccess = true,
                ErrorCode = 0,
                Message = "Success",
            };
        }

        /// <summary>
        /// 创建并返回一个成功的结果对象，并带有一个参数对象
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="value">类型的值对象</param>
        /// <returns>结果对象</returns>
        public static XktResult<T> CreateSuccessResult<T>(T value)
        {
            return new XktResult<T>()
            {
                IsSuccess = true,
                ErrorCode = 0,
                Message = "Success",
                Content = value
            };
        }


        /// <summary>
        /// 创建并返回一个成功的结果对象，并带有两个参数对象
        /// </summary>
        /// <typeparam name="T1">第一个参数类型</typeparam>
        /// <typeparam name="T2">第二个参数类型</typeparam>
        /// <param name="value1">类型一对象</param>
        /// <param name="value2">类型二对象</param>
        /// <returns>结果对象</returns>
        public static XktResult<T1, T2> CreateSuccessResult<T1, T2>(T1 value1, T2 value2)
        {
            return new XktResult<T1, T2>()
            {
                IsSuccess = true,
                ErrorCode = 0,
                Message = "Success",
                Content1 = value1,
                Content2 = value2,
            };
        }


        /// <summary>
        /// 创建并返回一个成功的结果对象，并带有三个参数对象
        /// </summary>
        /// <typeparam name="T1">第一个参数类型</typeparam>
        /// <typeparam name="T2">第二个参数类型</typeparam>
        /// <typeparam name="T3">第三个参数类型</typeparam>
        /// <param name="value1">类型一对象</param>
        /// <param name="value2">类型二对象</param>
        /// <param name="value3">类型三对象</param>
        /// <returns>结果对象</returns>
        public static XktResult<T1, T2, T3> CreateSuccessResult<T1, T2, T3>(T1 value1, T2 value2, T3 value3)
        {
            return new XktResult<T1, T2, T3>()
            {
                IsSuccess = true,
                ErrorCode = 0,
                Message = "Success",
                Content1 = value1,
                Content2 = value2,
                Content3 = value3,
            };
        }

        /// <summary>
        /// 创建并返回一个成功的结果对象，并带有四个参数对象
        /// </summary>
        /// <typeparam name="T1">第一个参数类型</typeparam>
        /// <typeparam name="T2">第二个参数类型</typeparam>
        /// <typeparam name="T3">第三个参数类型</typeparam>
        /// <typeparam name="T4">第四个参数类型</typeparam>
        /// <param name="value1">类型一对象</param>
        /// <param name="value2">类型二对象</param>
        /// <param name="value3">类型三对象</param>
        /// <param name="value4">类型四对象</param>
        /// <returns>结果对象</returns>
        public static XktResult<T1, T2, T3, T4> CreateSuccessResult<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4)
        {
            return new XktResult<T1, T2, T3, T4>()
            {
                IsSuccess = true,
                ErrorCode = 0,
                Message = "Success",
                Content1 = value1,
                Content2 = value2,
                Content3 = value3,
                Content4 = value4,
            };
        }


        /// <summary>
        /// 创建并返回一个成功的结果对象，并带有五个参数对象
        /// </summary>
        /// <typeparam name="T1">第一个参数类型</typeparam>
        /// <typeparam name="T2">第二个参数类型</typeparam>
        /// <typeparam name="T3">第三个参数类型</typeparam>
        /// <typeparam name="T4">第四个参数类型</typeparam>
        /// <typeparam name="T5">第五个参数类型</typeparam>
        /// <param name="value1">类型一对象</param>
        /// <param name="value2">类型二对象</param>
        /// <param name="value3">类型三对象</param>
        /// <param name="value4">类型四对象</param>
        /// <param name="value5">类型五对象</param>
        /// <returns>结果对象</returns>
        public static XktResult<T1, T2, T3, T4, T5> CreateSuccessResult<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5)
        {
            return new XktResult<T1, T2, T3, T4, T5>()
            {
                IsSuccess = true,
                ErrorCode = 0,
                Message = "Success",
                Content1 = value1,
                Content2 = value2,
                Content3 = value3,
                Content4 = value4,
                Content5 = value5,
            };
        }

        #endregion

    }

    /// <summary>
    /// 操作结果的泛型类，允许带一个用户自定义的泛型对象，推荐使用这个类
    /// </summary>
    /// <typeparam name="T">泛型类</typeparam>
    public class XktResult<T> : XktResult
    {
        #region Constructor

        /// <summary>
        /// 实例化一个默认的结果对象
        /// </summary>
        public XktResult() : base()
        {
        }

        /// <summary>
        /// 使用指定的消息实例化一个默认的结果对象
        /// </summary>
        /// <param name="msg">错误消息</param>
        public XktResult(string msg) : base(msg)
        {

        }

        /// <summary>
        /// 使用错误代码，消息文本来实例化对象
        /// </summary>
        /// <param name="err">错误代码</param>
        /// <param name="msg">错误消息</param>
        public XktResult(int err, string msg) : base(err, msg)
        {

        }

        #endregion

        /// <summary>
        /// 用户自定义的泛型数据
        /// </summary>
        public T Content { get; set; }
    }

    /// <summary>
    /// 操作结果的泛型类，允许带两个用户自定义的泛型对象，推荐使用这个类
    /// </summary>
    /// <typeparam name="T1">泛型类</typeparam>
    /// <typeparam name="T2">泛型类</typeparam>
    public class XktResult<T1, T2> : XktResult
    {
        #region Constructor

        /// <summary>
        /// 实例化一个默认的结果对象
        /// </summary>
        public XktResult() : base()
        {
        }

        /// <summary>
        /// 使用指定的消息实例化一个默认的结果对象
        /// </summary>
        /// <param name="msg">错误消息</param>
        public XktResult(string msg) : base(msg)
        {

        }

        /// <summary>
        /// 使用错误代码，消息文本来实例化对象
        /// </summary>
        /// <param name="err">错误代码</param>
        /// <param name="msg">错误消息</param>
        public XktResult(int err, string msg) : base(err, msg)
        {

        }

        #endregion

        /// <summary>
        /// 用户自定义的泛型数据1
        /// </summary>
        public T1 Content1 { get; set; }

        /// <summary>
        /// 用户自定义的泛型数据2
        /// </summary>
        public T2 Content2 { get; set; }
    }

    /// <summary>
    /// 操作结果的泛型类，允许带三个用户自定义的泛型对象，推荐使用这个类
    /// </summary>
    /// <typeparam name="T1">泛型类</typeparam>
    /// <typeparam name="T2">泛型类</typeparam>
    /// <typeparam name="T3">泛型类</typeparam>
    public class XktResult<T1, T2, T3> : XktResult
    {
        #region Constructor

        /// <summary>
        /// 实例化一个默认的结果对象
        /// </summary>
        public XktResult() : base()
        {
        }

        /// <summary>
        /// 使用指定的消息实例化一个默认的结果对象
        /// </summary>
        /// <param name="msg">错误消息</param>
        public XktResult(string msg) : base(msg)
        {

        }

        /// <summary>
        /// 使用错误代码，消息文本来实例化对象
        /// </summary>
        /// <param name="err">错误代码</param>
        /// <param name="msg">错误消息</param>
        public XktResult(int err, string msg) : base(err, msg)
        {

        }

        #endregion

        /// <summary>
        /// 用户自定义的泛型数据1
        /// </summary>
        public T1 Content1 { get; set; }

        /// <summary>
        /// 用户自定义的泛型数据2
        /// </summary>
        public T2 Content2 { get; set; }

        /// <summary>
        /// 用户自定义的泛型数据3
        /// </summary>
        public T3 Content3 { get; set; }
    }

    /// <summary>
    /// 操作结果的泛型类，允许带四个用户自定义的泛型对象，推荐使用这个类
    /// </summary>
    /// <typeparam name="T1">泛型类</typeparam>
    /// <typeparam name="T2">泛型类</typeparam>
    /// <typeparam name="T3">泛型类</typeparam>
    /// <typeparam name="T4">泛型类</typeparam>
    public class XktResult<T1, T2, T3, T4> : XktResult
    {
        #region Constructor

        /// <summary>
        /// 实例化一个默认的结果对象
        /// </summary>
        public XktResult() : base()
        {
        }

        /// <summary>
        /// 使用指定的消息实例化一个默认的结果对象
        /// </summary>
        /// <param name="msg">错误消息</param>
        public XktResult(string msg) : base(msg)
        {

        }

        /// <summary>
        /// 使用错误代码，消息文本来实例化对象
        /// </summary>
        /// <param name="err">错误代码</param>
        /// <param name="msg">错误消息</param>
        public XktResult(int err, string msg) : base(err, msg)
        {

        }

        #endregion

        /// <summary>
        /// 用户自定义的泛型数据1
        /// </summary>
        public T1 Content1 { get; set; }

        /// <summary>
        /// 用户自定义的泛型数据2
        /// </summary>
        public T2 Content2 { get; set; }

        /// <summary>
        /// 用户自定义的泛型数据3
        /// </summary>
        public T3 Content3 { get; set; }

        /// <summary>
        /// 用户自定义的泛型数据4
        /// </summary>
        public T4 Content4 { get; set; }
    }

    /// <summary>
    /// 操作结果的泛型类，允许带五个用户自定义的泛型对象，推荐使用这个类
    /// </summary>
    /// <typeparam name="T1">泛型类</typeparam>
    /// <typeparam name="T2">泛型类</typeparam>
    /// <typeparam name="T3">泛型类</typeparam>
    /// <typeparam name="T4">泛型类</typeparam>
    /// <typeparam name="T5">泛型类</typeparam>
    public class XktResult<T1, T2, T3, T4, T5> : XktResult
    {
        #region Constructor

        /// <summary>
        /// 实例化一个默认的结果对象
        /// </summary>
        public XktResult() : base()
        {
        }

        /// <summary>
        /// 使用指定的消息实例化一个默认的结果对象
        /// </summary>
        /// <param name="msg">错误消息</param>
        public XktResult(string msg) : base(msg)
        {

        }

        /// <summary>
        /// 使用错误代码，消息文本来实例化对象
        /// </summary>
        /// <param name="err">错误代码</param>
        /// <param name="msg">错误消息</param>
        public XktResult(int err, string msg) : base(err, msg)
        {

        }

        #endregion

        /// <summary>
        /// 用户自定义的泛型数据1
        /// </summary>
        public T1 Content1 { get; set; }

        /// <summary>
        /// 用户自定义的泛型数据2
        /// </summary>
        public T2 Content2 { get; set; }

        /// <summary>
        /// 用户自定义的泛型数据3
        /// </summary>
        public T3 Content3 { get; set; }

        /// <summary>
        /// 用户自定义的泛型数据4
        /// </summary>
        public T4 Content4 { get; set; }

        /// <summary>
        /// 用户自定义的泛型数据5
        /// </summary>
        public T5 Content5 { get; set; }

    }
}
