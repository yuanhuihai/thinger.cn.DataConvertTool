using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// ULong转换类
    /// </summary>
    public class ULongLib
    {
        #region 字节数组中截取转成64位整型
        /// <summary>
        /// 字节数组中截取转成64位整型
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ulong GetULongFromByteArray(byte[] source, int start=0, DataFormat type = DataFormat.ABCD)
        {
            byte[] b = ByteArrayLib.Get8ByteArray(source, start, type);
            return b == null ? 0 : BitConverter.ToUInt64(b, 0);
        }
        #endregion

        #region 将字节数组中截取转成64位整型数组
        /// <summary>
        /// 将字节数组中截取转成64位整型数组
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ulong[] GetULongArrayFromByteArray(byte[] source, DataFormat type = DataFormat.ABCD)
        {
            ulong[] values = new ulong[source.Length / 8];

            for (int i = 0; i < source.Length / 8; i++)
            {
                values[i] = GetULongFromByteArray(source, 8 * i, type);
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
        public static ulong[] GetULongArrayFromString(string val,char spilt=' ' )
        {
            val = val.Trim();

            List<ulong> Result = new List<ulong>();

            if (val.Contains(spilt))
            {
            string[] str = val.Split(new char[] { spilt }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in str)
                {
                    Result.Add(Convert.ToUInt64(item.Trim()));
                }
            }
            else
            {
                Result.Add(Convert.ToUInt64(val.Trim()));
            }

            return Result.ToArray();
        }
        #endregion



    }
}
