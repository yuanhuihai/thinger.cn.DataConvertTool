using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// Short转换类
    /// </summary>
    public class ShortLib
    {
        #region 字节数组中截取转成16位整型
        /// <summary>
        /// 字节数组中截取转成16位整型
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="dataFormat"></param>
        /// <returns></returns>
        public static short GetShortFromByteArray(byte[] source, int start = 0, DataFormat dataFormat = DataFormat.ABCD)
        {
            return BitConverter.ToInt16(ByteArrayLib.Get2ByteArray(source, start, dataFormat), 0);
        }
        #endregion

        #region 将字节数组中截取转成16位整型数组
        /// <summary>
        /// 将字节数组中截取转成16位整型数组
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static short[] GetShortArrayFromByteArray(byte[] source, DataFormat type = DataFormat.ABCD)
        {
            short[] result = new short[source.Length / 2];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = GetShortFromByteArray(source, i * 2, type);
            }
            return result;
        }
        #endregion

        #region 将字符串转转成16位整型数组
        /// <summary>
        /// 将字符串转转成16位整型数组
        /// </summary>
        /// <param name="val"></param>
        /// <param name="spilt"></param>
        /// <returns></returns>
        public static short[] GetShortArrayFromString(string val,char spilt=' ')
        {
            val = val.Trim();

            List<short> Result = new List<short>();

            if (val.Contains(spilt))
            {
                string[] str = val.Split(new char[] { spilt }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in str)
                {
                    Result.Add(Convert.ToInt16(item.Trim()));
                }
            }
            else
            {
                Result.Add(Convert.ToInt16(val.Trim()));
            }

            return Result.ToArray();
        }
        #endregion

        #region 设置16位整型或字节数组某个位
        /// <summary>
        /// 设置16位整型某个位
        /// </summary>
        /// <param name="value"></param>
        /// <param name="bit"></param>
        /// <param name="val"></param>
        /// <param name="dataFormat"></param>
        /// <returns></returns>
        public static short SetbitValueFromShort(short value, int bit, bool val, DataFormat dataFormat = DataFormat.ABCD)
        {
            byte[] bt = ByteArrayLib.GetByteArrayFromShort(value, dataFormat);

            if (bit >= 0 && bit <= 7)
            {
                bt[1] = ByteLib.SetbitValue(bt[1], bit, val);
            }
            else
            {
                bt[0] = ByteLib.SetbitValue(bt[0], bit - 8, val);
            }
            return GetShortFromByteArray(bt, 0, dataFormat);
        }

        /// <summary>
        /// 设置字节数组某个位
        /// </summary>
        /// <param name="bt"></param>
        /// <param name="bit"></param>
        /// <param name="val"></param>
        /// <param name="dataFormat"></param>
        /// <returns></returns>
        public static short SetbitValueFrom2ByteArray(byte[] bt, int bit, bool val, DataFormat dataFormat = DataFormat.ABCD)
        {
            if (bit >= 0 && bit <= 7)
            {
                bt[1] = ByteLib.SetbitValue(bt[1], bit, val);
            }
            else
            {
                bt[0] = ByteLib.SetbitValue(bt[0], bit - 8, val);
            }
            return GetShortFromByteArray(bt, 0, dataFormat);
        }

        #endregion

   

    }
}
