using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// 数值转换类
    /// </summary>
    public class MigrationLib
    {
        private static string ByteMax = byte.MaxValue.ToString();
        private static string ByteMin = byte.MinValue.ToString();

        private static string ShortMax = short.MaxValue.ToString();
        private static string ShortMin = ushort.MinValue.ToString();

        private static string UShortMax = ushort.MaxValue.ToString();
        private static string UShortMin = ushort.MinValue.ToString();

        private static string IntMax = int.MaxValue.ToString();
        private static string IntMin = int.MinValue.ToString();

        private static string UIntMax = uint.MaxValue.ToString();
        private static string UIntMin = uint.MinValue.ToString();

        private static string GetErrorMsg(DataType type)
        {
            string result = string.Empty;

            switch (type)
            {
                case DataType.Byte:
                    result = "设置范围：" + ByteMin + "-" + ByteMax;
                    break;
                case DataType.Short:
                    result = "设置范围：" + ShortMin + "-" + ShortMax;
                    break;
                case DataType.UShort:
                    result = "设置范围：" + UShortMin + "-" + UShortMax;
                    break;
                case DataType.Int:
                    result = "设置范围：" + IntMin + "-" + IntMax;
                    break;
                case DataType.UInt:
                    result = "设置范围：" + UIntMin + "-" + UIntMax;
                    break;
                default:
                    result = "设置范围超限";
                    break;
            }
            return result;
        }

        public static object GetMigrationValue(object value, string scale, string offset)
        {
            if (scale == "1" && offset == "0")
            {
                return value;
            }
            else
            {
                string type = value.GetType().Name;
                switch (type.ToLower())
                {
                    case "byte":
                    case "int16":
                    case "uint16":
                    case "int32":
                    case "uint32":
                    case "single":
                        return Convert.ToSingle((Convert.ToSingle(value) * Convert.ToSingle(scale) + Convert.ToSingle(offset)).ToString("N4"));
                    case "int64":
                    case "uint64":
                    case "double":
                        return Convert.ToDouble((Convert.ToDouble(value) * Convert.ToDouble(scale) + Convert.ToDouble(offset)).ToString("N4"));
                    default:
                        return value;
                }
            }
        }

        public static XktResult<string> SetMigrationValue(string set, DataType type, string scale, string offset)
        {
            XktResult<string> result = new XktResult<string>();
            if (scale == "1" && offset == "0")
            {
                try
                {
                    switch (type)
                    {
                        case DataType.Byte:
                            result.Content = Convert.ToByte(set).ToString();
                            break;
                        case DataType.Short:
                            result.Content = Convert.ToInt16(set).ToString();
                            break;
                        case DataType.UShort:
                            result.Content = Convert.ToUInt16(set).ToString();
                            break;
                        case DataType.Int:
                            result.Content = Convert.ToInt32(set).ToString();
                            break;
                        case DataType.UInt:
                            result.Content = Convert.ToUInt32(set).ToString();
                            break;
                        case DataType.Long:
                            result.Content = Convert.ToInt64(set).ToString();
                            break;
                        case DataType.ULong:
                            result.Content = Convert.ToUInt64(set).ToString();
                            break;
                        case DataType.Float:
                            result.Content = Convert.ToSingle(set).ToString();
                            break;
                        case DataType.Double:
                            result.Content = Convert.ToDouble(set).ToString();
                            break;
                        default:
                            result.Content = set;
                            break;
                    }
                    result.IsSuccess = true;
                    return result;
                }
                catch (Exception)
                {
                    result.IsSuccess = false;
                    result.Message = "转换出错，" + GetErrorMsg(type);
                    return result;
                }
            }
            else
            {
                try
                {
                    switch (type)
                    {
                        case DataType.Byte:
                            result.Content = Convert.ToByte((Convert.ToSingle(set) - Convert.ToSingle(offset)) / Convert.ToSingle(scale)).ToString();
                            break;
                        case DataType.Short:
                            result.Content = Convert.ToInt16((Convert.ToSingle(set) - Convert.ToSingle(offset)) / Convert.ToSingle(scale)).ToString();
                            break;
                        case DataType.UShort:
                            result.Content = Convert.ToUInt16((Convert.ToSingle(set) - Convert.ToSingle(offset)) / Convert.ToSingle(scale)).ToString();
                            break;
                        case DataType.Int:
                            result.Content = Convert.ToInt32((Convert.ToSingle(set) - Convert.ToSingle(offset)) / Convert.ToSingle(scale)).ToString();
                            break;
                        case DataType.UInt:
                            result.Content = Convert.ToUInt32((Convert.ToSingle(set) - Convert.ToSingle(offset)) / Convert.ToSingle(scale)).ToString();
                            break;
                        case DataType.Long:
                            result.Content = Convert.ToInt64((Convert.ToDouble(set) - Convert.ToDouble(offset)) / Convert.ToDouble(scale)).ToString();
                            break;
                        case DataType.ULong:
                            result.Content = Convert.ToUInt64((Convert.ToDouble(set) - Convert.ToDouble(offset)) / Convert.ToDouble(scale)).ToString();
                            break;
                        case DataType.Float:
                            result.Content = Convert.ToSingle((Convert.ToSingle(set) - Convert.ToSingle(offset)) / Convert.ToSingle(scale)).ToString();
                            break;
                        case DataType.Double:
                            result.Content = Convert.ToDouble((Convert.ToDouble(set) - Convert.ToDouble(offset)) / Convert.ToDouble(scale)).ToString();
                            break;
                        default:
                            result.Content = set;
                            break;
                    }
                    result.IsSuccess = true;
                    return result;
                }
                catch (Exception)
                {
                    result.IsSuccess = false;
                    result.Message = "转换出错，" + GetErrorMsg(type);
                    return result;
                }
            }
        }

    }
}

