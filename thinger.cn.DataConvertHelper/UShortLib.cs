using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// UShort转换类
    /// </summary>
    public class UShortLib
    {
        #region 字节数组中截取转成16位无符号整型

        /// <summary>
        /// 字节数组中截取转成16位无符号整型
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ushort GetUShortFromByteArray(byte[] source, int start=0, DataFormat type = DataFormat.ABCD)
        {
            return BitConverter.ToUInt16(ByteArrayLib.Get2ByteArray(source, start, type), 0);
        }
        #endregion

        #region 将字节数组中截取转成16位无符号整型数组

        /// <summary>
        /// 将字节数组中截取转成16位无符号整型数组
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ushort[] GetUShortArrayFromByteArray(byte[] source, DataFormat type = DataFormat.ABCD)
        {
            ushort[] result = new ushort[source.Length / 2];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = GetUShortFromByteArray(source, i * 2, type);
            }
            return result;
        }
        #endregion

        #region 将字符串转转成16位无符号整型数组

        /// <summary>
        /// 将字符串转转成16位无符号整型数组
        /// </summary>
        /// <param name="val"></param>
        /// <param name="spilt"></param>
        /// <returns></returns>
        public static ushort[] GetUShortArrayFromString(string val, char spilt = ' ')
        {
            val = val.Trim();
            List<ushort> Result = new List<ushort>();
            if (val.Contains(spilt))
            {
                string[] str = val.Split(new char[] { spilt }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in str)
                {
                    Result.Add(Convert.ToUInt16(item.Trim()));
                }
            }
            else
            {
                Result.Add(Convert.ToUInt16(val.Trim()));
            }

            return Result.ToArray();
        }
        #endregion

        #region 将无符号整型某个位赋值

        /// <summary>
        /// 设置UShort中的某个位
        /// </summary>
        /// <param name="value"></param>
        /// <param name="bit"></param>
        /// <param name="val"></param>
        /// <param name="dataFormat"></param>
        /// <returns></returns>
        public static ushort SetbitValueFromUShort(ushort value, int bit, bool val, DataFormat dataFormat = DataFormat.ABCD)
        {
            byte[] bt = ByteArrayLib.GetByteArrayFromUShort(value, dataFormat);

            if (bit >= 0 && bit <= 7)
            {
                bt[1] = ByteLib.SetbitValue(bt[1], bit, val);
            }
            else
            {
                bt[0] = ByteLib.SetbitValue(bt[0], bit - 8, val);
            }
            return GetUShortFromByteArray(bt, 0, dataFormat);
        }


        #endregion


        /// <summary>
        /// 设置2个字节的数组中的某个位
        /// </summary>
        /// <param name="bt"></param>
        /// <param name="bit"></param>
        /// <param name="val"></param>
        /// <param name="dataFormat"></param>
        /// <returns></returns>

        public static ushort SetbitValueFrom2ByteArray(byte[] bt, int bit, bool val, DataFormat dataFormat = DataFormat.ABCD)
        {
            if (bit >= 0 && bit <= 7)
            {
                bt[1] = ByteLib.SetbitValue(bt[1], bit, val);
            }
            else
            {
                bt[0] = ByteLib.SetbitValue(bt[0], bit - 8, val);
            }
            return GetUShortFromByteArray(bt, 0, dataFormat);
        }
    }
}
