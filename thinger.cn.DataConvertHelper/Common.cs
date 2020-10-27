using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.cn.DataConvertHelper
{
    public enum DataType
    {
        Bool,
        Byte,
        Short,
        UShort,
        Int,
        UInt,
        Float,
        Double,
        Long,
        ULong,
        String,
        ByteArray,
        HexString
    }


    public enum DataFormat
    {
        /// <summary>
        /// 按照顺序排序
        /// </summary>
        ABCD = 0,
        /// <summary>
        /// 按照单字反转
        /// </summary>
        BADC = 1,
        /// <summary>
        /// 按照双字反转
        /// </summary>
        CDAB = 2,
        /// <summary>
        /// 按照倒序排序
        /// </summary>
        DCBA = 3,
    }
}
