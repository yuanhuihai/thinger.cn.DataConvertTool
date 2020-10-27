using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// Double类型转换库
    /// </summary>
    public class DoubleLib
    {

        #region 字节数组中截取转成双精度浮点型
        /// <summary>
        /// 将字节数组中某8个字节转换成Double类型
        /// </summary>
        /// <param name="source">字节数组</param>
        /// <param name="start">开始位置</param>
        /// <param name="type">字节顺序</param>
        /// <returns>Double类型数值</returns>
        public static double GetDoubleFromByteArray(byte[] source, int start = 0, DataFormat type = DataFormat.ABCD)
        {
            byte[] b = ByteArrayLib.Get8ByteArray(source, start, type);
            return b == null ? 0.0 : BitConverter.ToDouble(b, 0);
        }
        #endregion

        #region 将字节数组中截取转成双精度浮点型数组
        /// <summary>
        /// 将字节数组转换成Double数组
        /// </summary>
        /// <param name="source">字节数组</param>
        /// <param name="type">字节顺序</param>
        /// <returns>Double数组</returns>
        public static double[] GetDoubleArrayFromByteArray(byte[] source, DataFormat type = DataFormat.ABCD)
        {
            double[] values = new double[source.Length / 8];

            for (int i = 0; i < source.Length / 8; i++)
            {
                values[i] = GetDoubleFromByteArray(source, 8 * i, type);
            }

            return values;
        }
        #endregion

        #region 将字符串转转成双精度浮点型数组
        /// <summary>
        /// 将Double字符串转换成双精度浮点型数组
        /// </summary>
        /// <param name="val">Double字符串</param>
        /// <param name="spilt">Double字符串</param>
        /// <returns>双精度浮点型数组</returns>
        public static double[] GetDoubleArrayFromString(string val, char spilt = ' ')
        {
            val = val.Trim();

            List<double> Result = new List<double>();

            if (val.Contains(spilt))
            {
                string[] str = val.Split(new char[] { spilt }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in str)
                {
                    Result.Add(Convert.ToDouble(item.Trim()));
                }
            }
            else
            {
                Result.Add(Convert.ToDouble(val.Trim()));
            }

            return Result.ToArray();
        }
        #endregion

    }
}
