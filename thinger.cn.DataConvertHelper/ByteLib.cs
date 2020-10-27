using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// 单个字节转换库
    /// </summary>
    public class ByteLib
    {

        #region 截取某个字节
        /// <summary>
        /// 从字节数组中截取某个字节
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static byte GetByteFromByteArray(byte[] source, int start)
        {
            byte[] b = ByteArrayLib.GetByteArray(source, start, 1);

            return b == null ? (byte)0 : b[0];
        }
        #endregion

        #region 将字节中某个位赋值
        /// <summary>
        /// 将字节中的某个位赋值
        /// </summary>
        /// <param name="value">原始字节</param>
        /// <param name="bit">位</param>
        /// <param name="val">写入数值</param>
        /// <returns>返回字节</returns>
        public static byte SetbitValue(byte value, int bit, bool val)
        {
            return val ? (byte)(value | (byte)Math.Pow(2, bit)) : (byte)(value & (byte)~(byte)Math.Pow(2, bit));
        }
        #endregion

    }
}
