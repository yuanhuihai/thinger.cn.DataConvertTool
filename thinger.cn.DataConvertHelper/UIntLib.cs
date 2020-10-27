using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// UInt转换类
    /// </summary>
    public class UIntLib
    {
        #region 字节数组中截取转成32位无符号整型
        /// <summary>
        /// 字节数组中截取转成32位无符号整型
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static uint GetUIntFromByteArray(byte[] source, int start=0, DataFormat type = DataFormat.ABCD)
        {
            byte[] b = ByteArrayLib.Get4ByteArray(source, start, type);
            return b == null ? 0 : BitConverter.ToUInt32(b, 0);
        }
        #endregion

        #region 将字节数组中截取转成32位无符号整型数组
        /// <summary>
        /// 将字节数组中截取转成32位无符号整型数组
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static uint[] GetUIntArrayFromByteArray(byte[] source, DataFormat type = DataFormat.ABCD)
        {
            uint[] values = new uint[source.Length / 4];

            for (int i = 0; i < source.Length / 4; i++)
            {
                values[i] = GetUIntFromByteArray(source, 4 * i, type);
            }

            return values;
        }
        #endregion

        #region 将字符串转转成32位无符号整型数组
        /// <summary>
        /// 将字符串转转成32位无符号整型数组
        /// </summary>
        /// <param name="val"></param>
        /// <param name="spilt"></param>
        /// <returns></returns>
        public static uint[] GetUIntArrayFromString(string val, char spilt = ' ')
        {
            val = val.Trim();
            List<uint> Result = new List<uint>();
            if (val.Contains(spilt))
            {
                string[] str = val.Split(new char[] { spilt }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in str)
                {
                    Result.Add(Convert.ToUInt32(item.Trim()));
                }
            }
            else
            {
                Result.Add(Convert.ToUInt32(val.Trim()));
            }

            return Result.ToArray();
        }
        #endregion



    }
}
