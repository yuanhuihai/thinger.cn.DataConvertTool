using System;
using System.Collections.Generic;
using System.Text;

namespace thinger.cn.DataConvertHelper
{
    /// <summary>
    /// 字节集合类
    /// </summary>
    public class ByteArray
    {

        #region 初始化

        private List<byte> list = new List<byte>();

        #endregion

        #region 获取字节数组

        /// <summary>
        /// 属性，返回字节数组
        /// </summary>
        public byte[] array
        {
            get { return list.ToArray(); }
        }
        #endregion

        #region 相关方法
        /// <summary>
        /// 清空字节数组
        /// </summary>
        public void Clear()
        {
            list = new List<byte>();
        }

        /// <summary>
        /// 添加一个字节
        /// </summary>
        /// <param name="item">字节</param>
        public void Add(byte item)
        {
            list.Add(item);
        }

        /// <summary>
        /// 添加一个字节数组
        /// </summary>
        /// <param name="items">字节数组</param>
        public void Add(byte[] items)
        {
            list.AddRange(items);
        }

        /// <summary>
        /// 添加一个ByteArray对象
        /// </summary>
        /// <param name="byteArray">ByteArray对象</param>
        public void Add(ByteArray byteArray)
        {
            list.AddRange(byteArray.array);
        }

        #endregion

    }
}
