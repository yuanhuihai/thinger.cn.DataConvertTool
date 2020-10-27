using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// Long转换类
    /// </summary>
    public class LongLib
    {
        #region 字节数组中截取转成64位整型
        /// <summary>
        /// 字节数组中截取转成64位整型
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static long GetLongFromByteArray(byte[] source, int start=0, DataFormat type = DataFormat.ABCD)
        {
            byte[] b = ByteArrayLib.Get8ByteArray(source, start, type);
            return b == null ? 0 : BitConverter.ToInt64(b, 0);
        }
        #endregion

        #region 将字节数组中截取转成64位整型数组
        /// <summary>
        /// 将字节数组中截取转成64位整型数组
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static long[] GetLongArrayFromByteArray(byte[] source, DataFormat type = DataFormat.ABCD)
        {
            long[] values = new long[source.Length / 8];

            for (int i = 0; i < source.Length / 8; i++)
            {
                values[i] = GetLongFromByteArray(source, 8 * i, type);
            }

            return values;
        }
        #endregion

        #region 将字符串转转成64位整型数组
        /// <summary>
        /// 将字符串转转成64位整型数组
        /// </summary>
        /// <param name="val"></param>
        /// <param name="spilt"></param>
        /// <returns></returns>
        public static long[] GetLongArrayFromString(string val, char spilt = ' ')
        {
            val = val.Trim();

            List<long> Result = new List<long>();

            if (val.Contains(spilt))
            {
                string[] str = val.Split(new char[] { spilt }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in str)
                {
                    Result.Add(Convert.ToInt64(item.Trim()));
                }
            }
            else
            {
                Result.Add(Convert.ToInt64(val.Trim()));
            }

            return Result.ToArray();
        }
        #endregion



    }
}
