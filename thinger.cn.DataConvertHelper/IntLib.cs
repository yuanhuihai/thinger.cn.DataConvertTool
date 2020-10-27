using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// Int类型转换库
    /// </summary>
    public class IntLib
    {
        #region 字节数组中截取转成32位整型
        /// <summary>
        /// 字节数组中截取转成32位整型
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static int GetIntFromByteArray(byte[] source, int start = 0, DataFormat type = DataFormat.ABCD)
        {
            byte[] b = ByteArrayLib.Get4ByteArray(source, start, type);
            return b==null?0: BitConverter.ToInt32(b, 0);
        }

        #endregion

        #region 将字节数组中截取转成32位整型数组
        /// <summary>
        /// 将字节数组中截取转成32位整型数组
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static int[] GetIntArrayFromByteArray(byte[] source, DataFormat type = DataFormat.ABCD)
        {
            int[] values = new int[source.Length / 4];

            for (int i = 0; i < source.Length / 4; i++)
            {
                values[i] = GetIntFromByteArray(source, 4 * i, type);
            }

            return values;
        }
        #endregion

        #region 将字符串转转成32位整型数组
        /// <summary>
        /// 将字符串转转成32位整型数组
        /// </summary>
        /// <param name="val"></param>
        /// <param name="spilt"></param>
        /// <returns></returns>
        public static int[] GetIntArrayFromString(string val,char spilt=' ')
        {
            val = val.Trim();
            List<int> Result = new List<int>();
            if (val.Contains(spilt))
            {
                string[] str = val.Split(new char[] { spilt }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in str)
                {
                    Result.Add(Convert.ToInt32(item.Trim()));
                }
            }
            else
            {
                Result.Add(Convert.ToInt32(val.Trim()));
            }

            return Result.ToArray();
        }
        #endregion

    }
}
