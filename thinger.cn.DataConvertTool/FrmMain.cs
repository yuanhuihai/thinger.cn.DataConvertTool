using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.cn.DataConvertHelper;

namespace thinger.cn.DataConvertTool
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private const string ErrorTips = "不支持的数据类型转换";

        private void chk_ConvertEnable_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_Scale.ReadOnly = this.txt_Offset.ReadOnly = !this.chk_ConvertEnable.Checked;
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            if (this.chk_ConvertEnable.Checked)
            {
                if (this.chk_Get.Checked)
                {
                    try
                    {
                        this.txt_Result.Text = MigrationLib.GetMigrationValue(GetSrcValueByType(this.txt_Source.Text.Trim(), GetSrcDataType()), this.txt_Scale.Text, this.txt_Offset.Text).ToString();

                    }
                    catch (Exception ex)
                    {

                        this.txt_Result.Text = "转换出错：" + ex.Message;
                    }

                }
                else
                {
                    var res = MigrationLib.SetMigrationValue(this.txt_Source.Text.Trim(), GetDesDataType(), this.txt_Scale.Text, this.txt_Offset.Text);
                    if (res.IsSuccess)
                    {
                        this.txt_Result.Text = res.Content.ToString();
                    }
                    else
                    {
                        this.txt_Result.Text = res.Message;
                    }
                }
            }

            else
            {
                switch (GetSrcDataType())
                {
                    case DataType.Bool:

                        switch (GetDesDataType())
                        {
                            case DataType.Bool:
                                this.txt_Result.Text = this.txt_Source.Text;
                                break;
                            default:
                                this.txt_Result.Text = ErrorTips;
                                break;
                        }

                        break;
                    case DataType.Byte:
                        switch (GetDesDataType())
                        {
                            case DataType.Bool:
                                this.txt_Result.Text = StringLib.GetStringFromBitArray(BitLib.GetBitArrayFromByte(Convert.ToByte(this.txt_Source.Text), this.chk_Reverse.Checked));

                                break;
                            case DataType.Byte:
                                this.txt_Result.Text = this.txt_Source.Text;
                                break;
                            case DataType.Short:
                                break;
                            case DataType.UShort:
                                break;
                            case DataType.Int:
                                break;
                            case DataType.UInt:
                                break;
                            case DataType.Float:
                                break;
                            case DataType.Double:
                                break;
                            case DataType.Long:
                                break;
                            case DataType.ULong:
                                break;
                            case DataType.String:
                                break;
                            case DataType.ByteArray:
                                break;
                            case DataType.HexString:
                                break;
                            default:
                                break;
                        }
                        break;
                    case DataType.Short:
                        break;
                    case DataType.UShort:
                        break;
                    case DataType.Int:
                        break;
                    case DataType.UInt:
                        break;
                    case DataType.Float:
                        break;
                    case DataType.Double:
                        break;
                    case DataType.Long:
                        break;
                    case DataType.ULong:
                        break;
                    case DataType.String:
                        break;
                    case DataType.ByteArray:
                        break;
                    case DataType.HexString:
                        break;
                    default:
                        break;
                }

            }
        }


        private object GetSrcValueByType(string value, DataType type)
        {
            object result = null;
            switch (type)
            {
                case DataType.Bool:
                    result = value == "1" || value.ToLower() == "true";
                    break;
                case DataType.Byte:
                    result = Convert.ToByte(value);
                    break;
                case DataType.Short:
                    result = Convert.ToInt16(value);
                    break;
                case DataType.UShort:
                    result = Convert.ToUInt16(value);
                    break;
                case DataType.Int:
                    result = Convert.ToInt32(value);
                    break;
                case DataType.UInt:
                    result = Convert.ToUInt32(value);
                    break;
                case DataType.Float:
                    result = Convert.ToSingle(value);
                    break;
                case DataType.Double:
                    result = Convert.ToDouble(value);
                    break;
                case DataType.Long:
                    result = Convert.ToInt64(value);
                    break;
                case DataType.ULong:
                    result = Convert.ToUInt64(value);
                    break;
                case DataType.String:
                    result = value;
                    break;
                case DataType.ByteArray:
                    result = value;
                    break;
                case DataType.HexString:
                    result = value;
                    break;
                default:
                    result = value;
                    break;
            }
            return result;
        }


        private DataType GetSrcDataType()
        {
            foreach (var item in this.panel_Src.Controls)
            {
                if (item is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        switch (rb.Text.ToLower())
                        {
                            case "bit": return DataType.Bool;
                            case "byte": return DataType.Byte;
                            case "short": return DataType.Short;
                            case "ushort": return DataType.UShort;
                            case "int": return DataType.Int;
                            case "uint": return DataType.UInt;
                            case "float": return DataType.Float;
                            case "long": return DataType.Long;
                            case "ulong": return DataType.ULong;
                            case "double": return DataType.Double;
                            case "ascii": return DataType.String;
                            case "hex": return DataType.HexString;
                            default: return DataType.String;
                        }
                    }

                }
            }

            return DataType.String;

        }

        private DataType GetDesDataType()
        {
            foreach (var item in this.panel_Des.Controls)
            {
                if (item is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        switch (rb.Text.ToLower())
                        {
                            case "bit": return DataType.Bool;
                            case "byte": return DataType.Byte;
                            case "short": return DataType.Short;
                            case "ushort": return DataType.UShort;
                            case "int": return DataType.Int;
                            case "uint": return DataType.UInt;
                            case "float": return DataType.Float;
                            case "long": return DataType.Long;
                            case "ulong": return DataType.ULong;
                            case "double": return DataType.Double;
                            case "ascii": return DataType.String;
                            case "hex": return DataType.HexString;
                            default: return DataType.String;
                        }
                    }

                }
            }

            return DataType.String;
        }

        private DataFormat GetDataFormat()
        {
            foreach (var item in this.panel_DataFormat.Controls)
            {
                if (item is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        switch (rb.Text.ToLower())
                        {
                            case "abcd": return DataFormat.ABCD;
                            case "badc": return DataFormat.BADC;
                            case "cdab": return DataFormat.CDAB;
                            case "dcba": return DataFormat.DCBA;
                            default: return DataFormat.ABCD;
                        }
                    }

                }
            }
            return DataFormat.ABCD;
        }
    }
}
