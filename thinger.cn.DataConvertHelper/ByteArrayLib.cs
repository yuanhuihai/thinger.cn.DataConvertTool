using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// 字节数组转换库
    /// </summary>
    public class ByteArrayLib
    {

        #region 自定义截取字节数组
        /// <summary>
        /// 自定义截取字节数组
        /// </summary>
        /// <param name="source">字节数组</param>
        /// <param name="start">开始字节</param>
        /// <param name="length">截取长度</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArray(byte[] source, int start, int length)
        {
            byte[] Res = new byte[length];
            if (source != null && start >= 0 && length > 0 && source.Length >= (start + length))
            {
                Array.Copy(source, start, Res, 0, length);
                return Res;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region 自定义截取2个字节
        /// <summary>
        /// 从字节数组中截取2个字节
        /// </summary>
        /// <param name="source">字节数组</param>
        /// <param name="start">开始索引</param>
        /// <param name="type">字节顺序，默认为ABCD</param>
        /// <returns>字节数组</returns>
        public static byte[] Get2ByteArray(byte[] source, int start, DataFormat type = DataFormat.ABCD)
        {
            byte[] Res = new byte[2];

            byte[] ResTemp = GetByteArray(source, start, 2);

            if (ResTemp == null) return null;

            switch (type)
            {
                case DataFormat.ABCD:
                case DataFormat.CDAB:
                    Res[0] = ResTemp[1];
                    Res[1] = ResTemp[0];
                    break;
                case DataFormat.BADC:
                case DataFormat.DCBA:
                    Res = ResTemp;
                    break;
            }
            return Res;
        }
        #endregion

        #region 自定义截取4个字节
        /// <summary>
        /// 从字节数组中截取4个字节
        /// </summary>
        /// <param name="source">字节数组</param>
        /// <param name="start">开始索引</param>
        /// <param name="type">字节顺序，默认为ABCD</param>
        /// <returns>字节数组</returns>
        public static byte[] Get4ByteArray(byte[] source, int start, DataFormat type = DataFormat.ABCD)
        {
            byte[] Res = new byte[4];

            byte[] ResTemp = GetByteArray(source, start, 4);

            if (ResTemp == null) return null;

            switch (type)
            {
                case DataFormat.ABCD:
                    Res[0] = ResTemp[3];
                    Res[1] = ResTemp[2];
                    Res[2] = ResTemp[1];
                    Res[3] = ResTemp[0];
                    break;
                case DataFormat.CDAB:
                    Res[0] = ResTemp[1];
                    Res[1] = ResTemp[0];
                    Res[2] = ResTemp[3];
                    Res[3] = ResTemp[2];
                    break;
                case DataFormat.BADC:
                    Res[0] = ResTemp[2];
                    Res[1] = ResTemp[3];
                    Res[2] = ResTemp[0];
                    Res[3] = ResTemp[1];
                    break;
                case DataFormat.DCBA:
                    Res = ResTemp;
                    break;
            }
            return Res;

        }
        #endregion

        #region 自定义截取8个字节
        /// <summary>
        /// 从字节数组中截取8个字节
        /// </summary>
        /// <param name="source">字节数组</param>
        /// <param name="start">开始索引</param>
        /// <param name="type">字节顺序，默认为ABCD</param>
        /// <returns>字节数组</returns>
        public static byte[] Get8ByteArray(byte[] source, int start, DataFormat type = DataFormat.ABCD)
        {
            byte[] Res = new byte[8];

            byte[] ResTemp = GetByteArray(source, start, 8);

            if (ResTemp == null) return null;

            switch (type)
            {
                case DataFormat.ABCD:
                    Res[0] = ResTemp[7];
                    Res[1] = ResTemp[6];
                    Res[2] = ResTemp[5];
                    Res[3] = ResTemp[4];
                    Res[4] = ResTemp[3];
                    Res[5] = ResTemp[2];
                    Res[6] = ResTemp[1];
                    Res[7] = ResTemp[0];
                    break;
                case DataFormat.CDAB:
                    Res[0] = ResTemp[1];
                    Res[1] = ResTemp[0];
                    Res[2] = ResTemp[3];
                    Res[3] = ResTemp[2];
                    Res[4] = ResTemp[5];
                    Res[5] = ResTemp[4];
                    Res[6] = ResTemp[7];
                    Res[7] = ResTemp[6];
                    break;
                case DataFormat.BADC:
                    Res[0] = ResTemp[6];
                    Res[1] = ResTemp[7];
                    Res[2] = ResTemp[4];
                    Res[3] = ResTemp[5];
                    Res[4] = ResTemp[2];
                    Res[5] = ResTemp[3];
                    Res[6] = ResTemp[0];
                    Res[7] = ResTemp[1];
                    break;
                case DataFormat.DCBA:
                    Res = ResTemp;
                    break;
            }
            return Res;
        }
        #endregion

        #region 比较两个字节数组是否相等
        /// <summary>
        /// 比较两个字节数组是否完全相同
        /// </summary>
        /// <param name="b1">字节数组1</param>
        /// <param name="b2">字节数组2</param>
        /// <returns>是否相同</returns>
        public static bool ByteArrayEquals(byte[] b1, byte[] b2)
        {
            if (b1 == null || b2 == null) return false;
            if (b1.Length != b2.Length) return false;
            for (int i = 0; i < b1.Length; i++)
            {
                if (b1[i] != b2[i])
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 将单个字节转换成字节数组
        /// <summary>
        /// 将单个字节转换成字节数组
        /// </summary>
        /// <param name="value">单个字节</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromByte(byte value)
        {
            return new byte[] { value };
        }
        #endregion

        #region 将Short及UShort类型转换成字节数组
        /// <summary>
        /// 将Short类型数值转换成字节数组
        /// </summary>
        /// <param name="SetValue">Short类型数值</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromShort(short SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            byte[] ResTemp = BitConverter.GetBytes(SetValue);
            byte[] Res = new byte[2];

            switch (dataFormat)
            {
                case DataFormat.ABCD:
                case DataFormat.CDAB:
                    Res[0] = ResTemp[1];
                    Res[1] = ResTemp[0];
                    break;
                case DataFormat.BADC:
                case DataFormat.DCBA:
                    Res = ResTemp;
                    break;
                default:
                    break;
            }
            return Res;
        }

        /// <summary>
        /// 将UShort类型数值转换成字节数组
        /// </summary>
        /// <param name="SetValue">UShort类型数值</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromUShort(ushort SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            byte[] ResTemp = BitConverter.GetBytes(SetValue);
            byte[] Res = new byte[2];

            switch (dataFormat)
            {
                case DataFormat.ABCD:
                case DataFormat.CDAB:
                    Res[0] = ResTemp[1];
                    Res[1] = ResTemp[0];
                    break;
                case DataFormat.BADC:
                case DataFormat.DCBA:
                    Res = ResTemp;
                    break;
                default:
                    break;
            }
            return Res;
        }

        #endregion

        #region 将Short及UShort数组转换成字节数组
        /// <summary>
        /// 将Short数组转换成字节数组
        /// </summary>
        /// <param name="SetValue">Short数组</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromShortArray(short[] SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            ByteArray array = new ByteArray();

            foreach (var item in SetValue)
            {
                array.Add(GetByteArrayFromShort(item, dataFormat));
            }
            return array.array;
        }

        /// <summary>
        /// 将UShort数组转换成字节数组
        /// </summary>
        /// <param name="SetValue">UShort数组</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromUShortArray(ushort[] SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            ByteArray array = new ByteArray();

            foreach (var item in SetValue)
            {
                array.Add(GetByteArrayFromUShort(item, dataFormat));
            }
            return array.array;
        }
        #endregion

        #region 将Int及UInt及Float及Double类型转换成字节数组
        /// <summary>
        /// 将Int类型数值转换成字节数组
        /// </summary>
        /// <param name="SetValue">Int类型数值</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromInt(int SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            byte[] ResTemp = BitConverter.GetBytes(SetValue);

            byte[] Res = new byte[4];

            switch (dataFormat)
            {
                case DataFormat.ABCD:
                    Res[0] = ResTemp[3];
                    Res[1] = ResTemp[2];
                    Res[2] = ResTemp[1];
                    Res[3] = ResTemp[0];
                    break;
                case DataFormat.CDAB:
                    Res[0] = ResTemp[1];
                    Res[1] = ResTemp[0];
                    Res[2] = ResTemp[3];
                    Res[3] = ResTemp[2];
                    break;
                case DataFormat.BADC:
                    Res[0] = ResTemp[2];
                    Res[1] = ResTemp[3];
                    Res[2] = ResTemp[0];
                    Res[3] = ResTemp[1];
                    break;
                case DataFormat.DCBA:
                    Res = ResTemp;
                    break;
            }
            return Res;
        }
        /// <summary>
        /// 将UInt类型数值转换成字节数组
        /// </summary>
        /// <param name="SetValue">UInt类型数值</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromUInt(uint SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            byte[] ResTemp = BitConverter.GetBytes(SetValue);

            byte[] Res = new byte[4];

            switch (dataFormat)
            {
                case DataFormat.ABCD:
                    Res[0] = ResTemp[3];
                    Res[1] = ResTemp[2];
                    Res[2] = ResTemp[1];
                    Res[3] = ResTemp[0];
                    break;
                case DataFormat.CDAB:
                    Res[0] = ResTemp[1];
                    Res[1] = ResTemp[0];
                    Res[2] = ResTemp[3];
                    Res[3] = ResTemp[2];
                    break;
                case DataFormat.BADC:
                    Res[0] = ResTemp[2];
                    Res[1] = ResTemp[3];
                    Res[2] = ResTemp[0];
                    Res[3] = ResTemp[1];
                    break;
                case DataFormat.DCBA:
                    Res = ResTemp;
                    break;
            }
            return Res;
        }

        /// <summary>
        /// 将Float数值转换成字节数组
        /// </summary>
        /// <param name="SetValue">Float类型数值</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromFloat(float SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            byte[] ResTemp = BitConverter.GetBytes(SetValue);

            byte[] Res = new byte[4];

            switch (dataFormat)
            {
                case DataFormat.ABCD:
                    Res[0] = ResTemp[3];
                    Res[1] = ResTemp[2];
                    Res[2] = ResTemp[1];
                    Res[3] = ResTemp[0];
                    break;
                case DataFormat.CDAB:
                    Res[0] = ResTemp[1];
                    Res[1] = ResTemp[0];
                    Res[2] = ResTemp[3];
                    Res[3] = ResTemp[2];
                    break;
                case DataFormat.BADC:
                    Res[0] = ResTemp[2];
                    Res[1] = ResTemp[3];
                    Res[2] = ResTemp[0];
                    Res[3] = ResTemp[1];
                    break;
                case DataFormat.DCBA:
                    Res = ResTemp;
                    break;
            }
            return Res;
        }
        /// <summary>
        /// 将Double类型数值转换成字节数组
        /// </summary>
        /// <param name="SetValue">Double类型数值</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromDouble(double SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            byte[] ResTemp = BitConverter.GetBytes(SetValue);

            byte[] Res = new byte[8];

            switch (dataFormat)
            {
                case DataFormat.ABCD:
                    Res[0] = ResTemp[7];
                    Res[1] = ResTemp[6];
                    Res[2] = ResTemp[5];
                    Res[3] = ResTemp[4];
                    Res[4] = ResTemp[3];
                    Res[5] = ResTemp[2];
                    Res[6] = ResTemp[1];
                    Res[7] = ResTemp[0];
                    break;
                case DataFormat.CDAB:
                    Res[0] = ResTemp[1];
                    Res[1] = ResTemp[0];
                    Res[2] = ResTemp[3];
                    Res[3] = ResTemp[2];
                    Res[4] = ResTemp[5];
                    Res[5] = ResTemp[4];
                    Res[6] = ResTemp[7];
                    Res[7] = ResTemp[6];
                    break;
                case DataFormat.BADC:
                    Res[0] = ResTemp[6];
                    Res[1] = ResTemp[7];
                    Res[2] = ResTemp[4];
                    Res[3] = ResTemp[5];
                    Res[4] = ResTemp[2];
                    Res[5] = ResTemp[3];
                    Res[6] = ResTemp[0];
                    Res[7] = ResTemp[1];
                    break;
                case DataFormat.DCBA:
                    Res = ResTemp;
                    break;
            }
            return Res;
        }

        #endregion

        #region 将Int及UInt及Float及Double数组转换成字节数组
        /// <summary>
        /// 将Int类型数组转换成字节数组
        /// </summary>
        /// <param name="SetValue">Int类型数组</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromIntArray(int[] SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            ByteArray array = new ByteArray();

            foreach (var item in SetValue)
            {
                array.Add(GetByteArrayFromInt(item, dataFormat));
            }
            return array.array;
        }
        /// <summary>
        /// 将UInt类型数组转换成字节数组
        /// </summary>
        /// <param name="SetValue">UInt类型数组</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromUIntArray(uint[] SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            ByteArray array = new ByteArray();

            foreach (var item in SetValue)
            {
                array.Add(GetByteArrayFromUInt(item, dataFormat));
            }
            return array.array;
        }

        /// <summary>
        /// 将Float类型数组转成字节数组
        /// </summary>
        /// <param name="SetValue">Float类型数组</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromFloatArray(float[] SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            ByteArray array = new ByteArray();

            foreach (var item in SetValue)
            {
                array.Add(GetByteArrayFromFloat(item, dataFormat));
            }
            return array.array;
        }

        /// <summary>
        /// 将Double类型数组转成字节数组
        /// </summary>
        /// <param name="SetValue">Double类型数组</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromDoubleArray(double[] SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            ByteArray array = new ByteArray();

            foreach (var item in SetValue)
            {
                array.Add(GetByteArrayFromDouble(item, dataFormat));
            }
            return array.array;
        }

        #endregion

        #region 将Long及ULong类型转换成字节数组

        /// <summary>
        /// 将Long类型数值转换成字节数组
        /// </summary>
        /// <param name="SetValue">Long类型数值</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromLong(long SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            byte[] ResTemp = BitConverter.GetBytes(SetValue);

            byte[] Res = new byte[8];

            switch (dataFormat)
            {
                case DataFormat.ABCD:
                    Res[0] = ResTemp[7];
                    Res[1] = ResTemp[6];
                    Res[2] = ResTemp[5];
                    Res[3] = ResTemp[4];
                    Res[4] = ResTemp[3];
                    Res[5] = ResTemp[2];
                    Res[6] = ResTemp[1];
                    Res[7] = ResTemp[0];
                    break;
                case DataFormat.CDAB:
                    Res[0] = ResTemp[1];
                    Res[1] = ResTemp[0];
                    Res[2] = ResTemp[3];
                    Res[3] = ResTemp[2];
                    Res[4] = ResTemp[5];
                    Res[5] = ResTemp[4];
                    Res[6] = ResTemp[7];
                    Res[7] = ResTemp[6];
                    break;
                case DataFormat.BADC:
                    Res[0] = ResTemp[6];
                    Res[1] = ResTemp[7];
                    Res[2] = ResTemp[4];
                    Res[3] = ResTemp[5];
                    Res[4] = ResTemp[2];
                    Res[5] = ResTemp[3];
                    Res[6] = ResTemp[0];
                    Res[7] = ResTemp[1];
                    break;
                case DataFormat.DCBA:
                    Res = ResTemp;
                    break;
            }
            return Res;
        }

        /// <summary>
        /// 将ULong类型数值转换成字节数组
        /// </summary>
        /// <param name="SetValue">ULong类型数值</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromULong(ulong SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            byte[] ResTemp = BitConverter.GetBytes(SetValue);

            byte[] Res = new byte[8];

            switch (dataFormat)
            {
                case DataFormat.ABCD:
                    Res[0] = ResTemp[7];
                    Res[1] = ResTemp[6];
                    Res[2] = ResTemp[5];
                    Res[3] = ResTemp[4];
                    Res[4] = ResTemp[3];
                    Res[5] = ResTemp[2];
                    Res[6] = ResTemp[1];
                    Res[7] = ResTemp[0];
                    break;
                case DataFormat.CDAB:
                    Res[0] = ResTemp[1];
                    Res[1] = ResTemp[0];
                    Res[2] = ResTemp[3];
                    Res[3] = ResTemp[2];
                    Res[4] = ResTemp[5];
                    Res[5] = ResTemp[4];
                    Res[6] = ResTemp[7];
                    Res[7] = ResTemp[6];
                    break;
                case DataFormat.BADC:
                    Res[0] = ResTemp[6];
                    Res[1] = ResTemp[7];
                    Res[2] = ResTemp[4];
                    Res[3] = ResTemp[5];
                    Res[4] = ResTemp[2];
                    Res[5] = ResTemp[3];
                    Res[6] = ResTemp[0];
                    Res[7] = ResTemp[1];
                    break;
                case DataFormat.DCBA:
                    Res = ResTemp;
                    break;
            }
            return Res;
        }

        #endregion

        #region 将Long及ULong数组转换成字节数组
        /// <summary>
        /// 将Long类型数组转换成字节数组
        /// </summary>
        /// <param name="SetValue">Long类型数组</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromLongArray(long[] SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            ByteArray array = new ByteArray();

            foreach (var item in SetValue)
            {
                array.Add(GetByteArrayFromDouble(item, dataFormat));
            }
            return array.array;
        }

        /// <summary>
        /// 将ULong类型数组转换成字节数组
        /// </summary>
        /// <param name="SetValue">ULong类型数组</param>
        /// <param name="dataFormat">字节顺序</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromULongArray(ulong[] SetValue, DataFormat dataFormat = DataFormat.ABCD)
        {
            ByteArray array = new ByteArray();

            foreach (var item in SetValue)
            {
                array.Add(GetByteArrayFromDouble(item, dataFormat));
            }
            return array.array;
        }

        #endregion

        #region 将字符串转换成字节数组
        /// <summary>
        /// 将指定编码格式的字符串转换成字节数组
        /// </summary>
        /// <param name="SetValue">字符串</param>
        /// <param name="encoding">编码格式</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromString(string SetValue, Encoding encoding)
        {
            return encoding.GetBytes(SetValue);
        }
        #endregion

        #region 将16进制字符串转换成字节数组
        /// <summary>
        /// 将16进制字符串按照空格分隔成字节数组
        /// </summary>
        /// <param name="val">16进制字符串</param>
        /// <param name="spilt">分隔符</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromHexString(string val, char spilt = ' ')
        {
            val = val.Trim();//去除空格

            List<byte> Result = new List<byte>();

            try
            {
                if (val.Contains(spilt))
                {
                    string[] str = val.Split(new char[] { spilt }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var item in str)
                    {
                        Result.Add(Convert.ToByte(item.Trim(), 16));
                    }
                }
                else
                {
                    Result.Add(Convert.ToByte(val.Trim(), 16));
                }
                return Result.ToArray();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 将16进制字符串不用分隔符转换成字节数组（每2个字符为1个字节）
        /// </summary>
        /// <param name="val">16进制字符串</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromHexStringWithoutSpilt(string val)
        {

            List<byte> Result = new List<byte>();

            if (val.Length % 2 != 0) return null;

            try
            {
                for (int i = 0; i < val.Length; i += 2)
                {
                    string temp = val.Substring(i, 2);

                    Result.Add(Convert.ToByte(temp, 16));
                }
                return Result.ToArray();
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region 将布尔数组转换成字节数组
        /// <summary>
        /// 将布尔数组转换成字节数组
        /// </summary>
        /// <param name="val">布尔数组</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromBoolArray(bool[] val)
        {
            if (val == null && val.Length == 0) return null;

            byte[] result = new byte[val.Length % 8 != 0 ? val.Length / 8 + 1 : val.Length / 8];

            //遍历每个字节
            for (int i = 0; i < result.Length; i++)
            {
                int total = val.Length < 8 * (i + 1) ? val.Length - 8 * i : 8;

                //遍历当前字节的每个位赋值
                for (int j = 0; j < total; j++)
                {
                    result[i] = ByteLib.SetbitValue(result[i], j, val[8 * i + j]);
                }
            }
            return result;
        }
        #endregion

        #region 将西门子字符串转换成字节数组
        /// <summary>
        /// 将西门子字符串转换成字节数组
        /// </summary>
        /// <param name="SetValue">西门子字符串</param>
        /// <returns>字节数组</returns>
        public static byte[] GetByteArrayFromSiemensString(string SetValue)
        {
            byte[] b = GetByteArrayFromString(SetValue, Encoding.GetEncoding("GBK"));
            byte[] array = new byte[b.Length + 2];
            array[1] = (byte)(b.Length);
            Array.Copy(b, 0, array, 2, b.Length);

            return array;
        }
        #endregion

        #region 字节数组转换成ASCII字节数组
        /// <summary>
        /// 将字节数组转换成ASCII字节数组
        /// </summary>
        /// <param name="inBytes">字节数组</param>
        /// <returns>ASCII字节数组</returns>
        public static byte[] GetAsciiBytesFromByteArray(byte[] inBytes)
        {
            return Encoding.ASCII.GetBytes(StringLib.GetHexStringFromByteArray(inBytes, (char)0));
        }

        #endregion

        #region 合并字节数组
        /// <summary>
        /// 将2个字节数组进行合并
        /// </summary>
        /// <param name="bytes1">字节数组1</param>
        /// <param name="bytes2">字节数组2</param>
        /// <returns>字节数组</returns>
        public static byte[] CombineTwoByteArray(byte[] bytes1, byte[] bytes2)
        {
            if (bytes1 == null && bytes2 == null) return null;
            if (bytes1 == null) return bytes2;
            if (bytes2 == null) return bytes1;

            byte[] buffer = new byte[bytes1.Length + bytes2.Length];
            bytes1.CopyTo(buffer, 0);
            bytes2.CopyTo(buffer, bytes1.Length);
            return buffer;
        }
        /// <summary>
        /// 将3个字节数组进行合并
        /// </summary>
        /// <param name="bytes1">字节数组1</param>
        /// <param name="bytes2">字节数组2</param>
        /// <param name="bytes3">字节数组3</param>
        /// <returns></returns>
        public static byte[] CombineThreeByteArray(byte[] bytes1, byte[] bytes2, byte[] bytes3)
        {
            return CombineTwoByteArray(CombineTwoByteArray(bytes1, bytes2), bytes3);
        }

        #endregion

        #region ASCII字节数组转换成字节数组
        /// <summary>
        /// 将ASCII字节数组转换成字节数组
        /// </summary>
        /// <param name="inBytes">ASCII字节数组</param>
        /// <returns>字节数组</returns>
        public static byte[] GetBytesArrayFromASCIIByteArray(byte[] inBytes)
        {
            return GetByteArrayFromHexStringWithoutSpilt(Encoding.ASCII.GetString(inBytes));
        }

        #endregion

        #region 字节数组转换
        /// <summary>
        /// 字节数组转换
        /// </summary>
        /// <param name="src"></param>
        /// <param name="value"></param>
        /// <param name="start"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static byte[] SetByteArray(byte[] src, object value, int start, int offset)
        {
            string name = value.GetType().Name;
            byte[] b = null;
            switch (name.ToLower())
            {
                case "boolean":
                    Array.Copy(GetByteArrayFromByte(ByteLib.SetbitValue(src[start], offset, Convert.ToBoolean(value))), 0, src, start, 1);
                    break;
                case "byte":
                    Array.Copy(GetByteArrayFromByte(Convert.ToByte(value)), 0, src, start, 1);
                    break;
                case "int16":
                    Array.Copy(GetByteArrayFromShort(Convert.ToInt16(value)), 0, src, start, 2);
                    break;
                case "uint16":
                    Array.Copy(GetByteArrayFromUShort(Convert.ToUInt16(value)), 0, src, start, 2);
                    break;
                case "int32":
                    Array.Copy(GetByteArrayFromInt(Convert.ToInt32(value)), 0, src, start, 4);
                    break;
                case "uint32":
                    Array.Copy(GetByteArrayFromUInt(Convert.ToUInt32(value)), 0, src, start, 4);
                    break;
                case "single":
                    Array.Copy(GetByteArrayFromFloat(Convert.ToSingle(value)), 0, src, start, 4);
                    break;
                case "double":
                    Array.Copy(GetByteArrayFromDouble(Convert.ToDouble(value)), 0, src, start, 8);
                    break;
                case "int64":
                    Array.Copy(GetByteArrayFromLong(Convert.ToInt64(value)), 0, src, start, 8);
                    break;
                case "uint64":
                    Array.Copy(GetByteArrayFromULong(Convert.ToUInt64(value)), 0, src, start, 8);
                    break;
                case "byte[]":
                    b = GetByteArrayFromHexString(value.ToString());
                    Array.Copy(b, 0, src, start, b.Length);
                    break;
                case "int16[]":
                    b = GetByteArrayFromShortArray(ShortLib.GetShortArrayFromString(value.ToString()));
                    Array.Copy(b, 0, src, start, b.Length);
                    break;
                case "uint16[]":
                    b = GetByteArrayFromUShortArray(UShortLib.GetUShortArrayFromString(value.ToString()));
                    Array.Copy(b, 0, src, start, b.Length);
                    break;
                case "int32[]":
                    b = GetByteArrayFromIntArray(IntLib.GetIntArrayFromString(value.ToString()));
                    Array.Copy(b, 0, src, start, b.Length);
                    break;
                case "uint32[]":
                    b = GetByteArrayFromUIntArray(UIntLib.GetUIntArrayFromString(value.ToString()));
                    Array.Copy(b, 0, src, start, b.Length);
                    break;
                case "single[]":
                    b = GetByteArrayFromFloatArray(FloatLib.GetFloatArrayFromString(value.ToString()));
                    Array.Copy(b, 0, src, start, b.Length);
                    break;
                case "double[]":
                    b = GetByteArrayFromDoubleArray(DoubleLib.GetDoubleArrayFromString(value.ToString()));
                    Array.Copy(b, 0, src, start, b.Length);
                    break;
                case "int64[]":
                    b = GetByteArrayFromLongArray(LongLib.GetLongArrayFromString(value.ToString()));
                    Array.Copy(b, 0, src, start, b.Length);
                    break;
                case "uint64[]":
                    b = GetByteArrayFromULongArray(ULongLib.GetULongArrayFromString(value.ToString()));
                    Array.Copy(b, 0, src, start, b.Length);
                    break;
                default:
                    break;
            }

            return src;

        }

        #endregion

    }
}
