using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// 字符串转换类
    /// </summary>
    public class StringLib
    {
        #region 将字节数组转换成字符串
        /// <summary>
        /// 将字节数组转换成字符串
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string GetStringFromByteArrayByBitConvert(byte[] source, int start, int count)
        {
            return BitConverter.ToString(source, start, count);
        }
        #endregion

        #region 将字节数组转换成带编码格式字符串
        /// <summary>
        /// 将字节数组转换成带编码格式字符串
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="count"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string GetStringFromByteArray(byte[] source, int start, int count, Encoding encoding)
        {
            return encoding.GetString(ByteArrayLib.GetByteArray(source, start, count));
        }
        /// <summary>
        /// 将字节数组转换成带编码格式字符串
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string GetStringFromByteArray(byte[] source, int start, int count)
        {
            return Encoding.ASCII.GetString(ByteArrayLib.GetByteArray(source, start, count));
        }

        #endregion

        #region 将字节数组转换成带16进制字符串
        /// <summary>
        /// 将字节数组转换成带16进制字符串
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="count"></param>
        /// <param name="segment"></param>
        /// <returns></returns>
        public static string GetHexStringFromByteArray(byte[] source, int start, int count,char segment=' ')
        {
            byte[] b = ByteArrayLib.GetByteArray(source, start, count);

            StringBuilder sb = new StringBuilder();

            if (b.Length > 0)
            {
                foreach (var item in b)
                {
                    if (segment == 0) sb.Append(string.Format("{0:X2}", item));
                    else sb.Append(string.Format("{0:X2}{1}", item, segment));
                }
            }
            if (segment != 0 && sb.Length > 1 && sb[sb.Length - 1] == segment)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 将字节数组转换成带16进制字符串
        /// </summary>
        /// <param name="source"></param>
        /// <param name="segment"></param>
        /// <returns></returns>
        public static string GetHexStringFromByteArray(byte[] source, char segment = ' ')
        {
            return GetHexStringFromByteArray(source, 0, source.Length, segment);
        }


        #endregion

        #region  将字节数组转换成西门子字符串
        /// <summary>
        /// 将字节数组转换成西门子字符串
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GetSiemensStringFromByteArray(byte[] source, int start,int length)
        {
            byte[] b = ByteArrayLib.GetByteArray(source, start, length+2);

            int valid = b[1];
            if (valid > 0)
            {
                return Encoding.GetEncoding("GBK").GetString(ByteArrayLib.GetByteArray(b, 2, valid));
            }
            else
            {
                return "empty";
            }
        }
        #endregion

        /// <summary>
        /// 布尔数组转换成字符串
        /// </summary>
        /// <param name="source"></param>
        /// <param name="IsTrueFormat"></param>
        /// <param name="segment"></param>
        /// <returns></returns>
        public static string GetStringFromBitArray(bool[] source, bool IsTrueFormat = true, char segment = ' ')
        {
            return GetStringFromBitArray(source, 0, source.Length, IsTrueFormat, segment);
        }


        /// <summary>
        /// 布尔数组转换成字符串
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="count"></param>
        /// <param name="IsTrueFormat"></param>
        /// <param name="segment"></param>
        /// <returns></returns>
        public static string GetStringFromBitArray(bool[] source, int start, int count, bool IsTrueFormat = true, char segment = ' ')
        {
            bool[] b = BitLib.GetBitArray(source, start, count);
            StringBuilder sb = new StringBuilder();
            if (b.Length > 0)
            {
                foreach (bool item in b)
                {
                    if (segment == '\0')
                    {
                        if (IsTrueFormat)
                        {
                            sb.Append(item.ToString());
                        }
                        else
                        {
                            sb.Append(item ? "1" : "0");
                        }
                    }
                    else if (IsTrueFormat)
                    {
                        sb.Append(item.ToString() + segment.ToString());
                    }
                    else
                    {
                        sb.Append(item ? "1" : ("0" + segment.ToString()));
                    }
                }
            }
            if (((segment != '\0') && (sb.Length > 1)) && (sb[sb.Length - 1] == segment))
            {
                sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 各种类型数组转换成字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="segment"></param>
        /// <returns></returns>
        public static string GetStringFromValueArray<T>(T[] source, char segment = ' ')
        {
            StringBuilder sb = new StringBuilder();
            if (source.Length > 0)
            {
                foreach (T item in source)
                {
                    if (segment == '\0')
                    {
                        sb.Append(item.ToString());
                    }
                    else
                    {
                        sb.Append(item.ToString() + segment.ToString());
                    }
                }
            }
            if (((segment != '\0') && (sb.Length > 1)) && (sb[sb.Length - 1] == segment))
            {
                sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString();
        }

    }
}
