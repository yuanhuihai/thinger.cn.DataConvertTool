using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// Float类型转换库
    /// </summary>
    public class FloatLib
    {
        #region 字节数组中截取转成浮点型
        /// <summary>
        /// 将字节数组中某4个字节转换成Float类型
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static float GetFloatFromByteArray(byte[] source, int start = 0, DataFormat type = DataFormat.ABCD)
        {
            byte[] b = ByteArrayLib.Get4ByteArray(source, start, type);
            return b == null ? 0.0f : BitConverter.ToSingle(b, 0);
        }
        #endregion

        #region 将字节数组中截取转成浮点型数组
        /// <summary>
        /// 将字节数组转换成Float数组
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static float[] GetFloatArrayFromByteArray(byte[] source, DataFormat type = DataFormat.ABCD)
        {
            float[] values = new float[source.Length / 4];

            for (int i = 0; i < source.Length / 4; i++)
            {
                values[i] = GetFloatFromByteArray(source, 4 * i, type);
            }

            return values;
        }
        #endregion

        #region 将字符串转换成浮点型数组
        /// <summary>
        /// 将Float字符串转换成单精度浮点型数组
        /// </summary>
        /// <param name="val">Float字符串</param>
        /// <param name="spilt">分隔符</param>
        /// <returns>单精度浮点型数组</returns>
        public static float[] GetFloatArrayFromString(string val, char spilt = ' ')
        {
            val = val.Trim();
            List<float> Result = new List<float>();
            if (val.Contains(spilt))
            {
                string[] str = val.Split(new char[] { spilt }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in str)
                {
                    Result.Add(Convert.ToSingle(item.Trim()));
                }
            }
            else
            {
                Result.Add(Convert.ToSingle(val.Trim()));
            }
            return Result.ToArray();
        }
        #endregion

     
    }
}
