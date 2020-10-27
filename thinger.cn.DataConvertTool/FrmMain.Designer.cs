namespace thinger.cn.DataConvertTool
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Source = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.chk_Reverse = new System.Windows.Forms.CheckBox();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.panel_Src = new System.Windows.Forms.Panel();
            this.panel_Des = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton28 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_ConvertEnable = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Scale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Offset = new System.Windows.Forms.TextBox();
            this.panel_DataFormat = new System.Windows.Forms.Panel();
            this.chk_Get = new System.Windows.Forms.CheckBox();
            this.panel_Src.SuspendLayout();
            this.panel_Des.SuspendLayout();
            this.panel_DataFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "待转换数据：";
            // 
            // txt_Source
            // 
            this.txt_Source.Location = new System.Drawing.Point(118, 23);
            this.txt_Source.Multiline = true;
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.Size = new System.Drawing.Size(466, 135);
            this.txt_Source.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "待转换类型：";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bit";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Byte";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(164, 9);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(63, 24);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Short";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(242, 9);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(73, 24);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.Text = "UShort";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(333, 9);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(45, 24);
            this.radioButton6.TabIndex = 8;
            this.radioButton6.Text = "Int";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(164, 49);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(60, 24);
            this.radioButton7.TabIndex = 9;
            this.radioButton7.Text = "Float";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(85, 49);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(71, 24);
            this.radioButton8.TabIndex = 11;
            this.radioButton8.Text = "ULong";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(13, 49);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(61, 24);
            this.radioButton9.TabIndex = 10;
            this.radioButton9.Text = "Long";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(242, 49);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(77, 24);
            this.radioButton10.TabIndex = 12;
            this.radioButton10.Text = "Double";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "转换类型：";
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(396, 9);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(55, 24);
            this.radioButton16.TabIndex = 18;
            this.radioButton16.Text = "UInt";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "字节顺序：";
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Checked = true;
            this.radioButton21.Location = new System.Drawing.Point(13, 7);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(66, 24);
            this.radioButton21.TabIndex = 25;
            this.radioButton21.TabStop = true;
            this.radioButton21.Text = "ABCD";
            this.radioButton21.UseVisualStyleBackColor = true;
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.Location = new System.Drawing.Point(165, 7);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(66, 24);
            this.radioButton22.TabIndex = 26;
            this.radioButton22.Text = "CDAB";
            this.radioButton22.UseVisualStyleBackColor = true;
            // 
            // radioButton23
            // 
            this.radioButton23.AutoSize = true;
            this.radioButton23.Location = new System.Drawing.Point(89, 7);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(66, 24);
            this.radioButton23.TabIndex = 27;
            this.radioButton23.Text = "BACD";
            this.radioButton23.UseVisualStyleBackColor = true;
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.Location = new System.Drawing.Point(242, 8);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(66, 24);
            this.radioButton24.TabIndex = 28;
            this.radioButton24.Text = "DCBA";
            this.radioButton24.UseVisualStyleBackColor = true;
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(114, 478);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(466, 135);
            this.txt_Result.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "转换结果：";
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(121, 429);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(98, 32);
            this.btn_Convert.TabIndex = 31;
            this.btn_Convert.Text = "点击转换";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // chk_Reverse
            // 
            this.chk_Reverse.AutoSize = true;
            this.chk_Reverse.Location = new System.Drawing.Point(466, 342);
            this.chk_Reverse.Name = "chk_Reverse";
            this.chk_Reverse.Size = new System.Drawing.Size(101, 24);
            this.chk_Reverse.TabIndex = 33;
            this.chk_Reverse.Text = "Bit Reverse";
            this.chk_Reverse.UseVisualStyleBackColor = true;
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.Location = new System.Drawing.Point(333, 49);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(53, 24);
            this.radioButton25.TabIndex = 34;
            this.radioButton25.Text = "Hex";
            this.radioButton25.UseVisualStyleBackColor = true;
            // 
            // radioButton26
            // 
            this.radioButton26.AutoSize = true;
            this.radioButton26.Location = new System.Drawing.Point(396, 49);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(62, 24);
            this.radioButton26.TabIndex = 35;
            this.radioButton26.Text = "ASCII";
            this.radioButton26.UseVisualStyleBackColor = true;
            // 
            // panel_Src
            // 
            this.panel_Src.Controls.Add(this.radioButton26);
            this.panel_Src.Controls.Add(this.radioButton1);
            this.panel_Src.Controls.Add(this.radioButton25);
            this.panel_Src.Controls.Add(this.radioButton16);
            this.panel_Src.Controls.Add(this.radioButton10);
            this.panel_Src.Controls.Add(this.radioButton8);
            this.panel_Src.Controls.Add(this.radioButton9);
            this.panel_Src.Controls.Add(this.radioButton7);
            this.panel_Src.Controls.Add(this.radioButton6);
            this.panel_Src.Controls.Add(this.radioButton2);
            this.panel_Src.Controls.Add(this.radioButton4);
            this.panel_Src.Controls.Add(this.radioButton3);
            this.panel_Src.Location = new System.Drawing.Point(121, 164);
            this.panel_Src.Name = "panel_Src";
            this.panel_Src.Size = new System.Drawing.Size(466, 82);
            this.panel_Src.TabIndex = 38;
            // 
            // panel_Des
            // 
            this.panel_Des.Controls.Add(this.radioButton5);
            this.panel_Des.Controls.Add(this.radioButton11);
            this.panel_Des.Controls.Add(this.radioButton12);
            this.panel_Des.Controls.Add(this.radioButton13);
            this.panel_Des.Controls.Add(this.radioButton14);
            this.panel_Des.Controls.Add(this.radioButton15);
            this.panel_Des.Controls.Add(this.radioButton17);
            this.panel_Des.Controls.Add(this.radioButton18);
            this.panel_Des.Controls.Add(this.radioButton19);
            this.panel_Des.Controls.Add(this.radioButton20);
            this.panel_Des.Controls.Add(this.radioButton27);
            this.panel_Des.Controls.Add(this.radioButton28);
            this.panel_Des.Location = new System.Drawing.Point(121, 247);
            this.panel_Des.Name = "panel_Des";
            this.panel_Des.Size = new System.Drawing.Size(466, 82);
            this.panel_Des.TabIndex = 39;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(396, 49);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(62, 24);
            this.radioButton5.TabIndex = 35;
            this.radioButton5.Text = "ASCII";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Checked = true;
            this.radioButton11.Location = new System.Drawing.Point(13, 9);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(45, 24);
            this.radioButton11.TabIndex = 3;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Bit";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(333, 49);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(53, 24);
            this.radioButton12.TabIndex = 34;
            this.radioButton12.Text = "Hex";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(396, 9);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(55, 24);
            this.radioButton13.TabIndex = 18;
            this.radioButton13.Text = "UInt";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(242, 49);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(77, 24);
            this.radioButton14.TabIndex = 12;
            this.radioButton14.Text = "Double";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(85, 49);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(71, 24);
            this.radioButton15.TabIndex = 11;
            this.radioButton15.Text = "ULong";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(13, 49);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(61, 24);
            this.radioButton17.TabIndex = 10;
            this.radioButton17.Text = "Long";
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(164, 49);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(60, 24);
            this.radioButton18.TabIndex = 9;
            this.radioButton18.Text = "Float";
            this.radioButton18.UseVisualStyleBackColor = true;
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new System.Drawing.Point(333, 9);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(45, 24);
            this.radioButton19.TabIndex = 8;
            this.radioButton19.Text = "Int";
            this.radioButton19.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(85, 9);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(56, 24);
            this.radioButton20.TabIndex = 4;
            this.radioButton20.Text = "Byte";
            this.radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton27
            // 
            this.radioButton27.AutoSize = true;
            this.radioButton27.Location = new System.Drawing.Point(242, 9);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(73, 24);
            this.radioButton27.TabIndex = 6;
            this.radioButton27.Text = "UShort";
            this.radioButton27.UseVisualStyleBackColor = true;
            // 
            // radioButton28
            // 
            this.radioButton28.AutoSize = true;
            this.radioButton28.Location = new System.Drawing.Point(164, 9);
            this.radioButton28.Name = "radioButton28";
            this.radioButton28.Size = new System.Drawing.Size(63, 24);
            this.radioButton28.TabIndex = 5;
            this.radioButton28.Text = "Short";
            this.radioButton28.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "线性转换：";
            // 
            // chk_ConvertEnable
            // 
            this.chk_ConvertEnable.AutoSize = true;
            this.chk_ConvertEnable.Location = new System.Drawing.Point(134, 388);
            this.chk_ConvertEnable.Name = "chk_ConvertEnable";
            this.chk_ConvertEnable.Size = new System.Drawing.Size(74, 24);
            this.chk_ConvertEnable.TabIndex = 41;
            this.chk_ConvertEnable.Text = "Enable";
            this.chk_ConvertEnable.UseVisualStyleBackColor = true;
            this.chk_ConvertEnable.CheckedChanged += new System.EventHandler(this.chk_ConvertEnable_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Scale：";
            // 
            // txt_Scale
            // 
            this.txt_Scale.Location = new System.Drawing.Point(363, 386);
            this.txt_Scale.Name = "txt_Scale";
            this.txt_Scale.ReadOnly = true;
            this.txt_Scale.Size = new System.Drawing.Size(65, 25);
            this.txt_Scale.TabIndex = 42;
            this.txt_Scale.Text = "1";
            this.txt_Scale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Offset：";
            // 
            // txt_Offset
            // 
            this.txt_Offset.Location = new System.Drawing.Point(504, 386);
            this.txt_Offset.Name = "txt_Offset";
            this.txt_Offset.ReadOnly = true;
            this.txt_Offset.Size = new System.Drawing.Size(68, 25);
            this.txt_Offset.TabIndex = 42;
            this.txt_Offset.Text = "0";
            this.txt_Offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_DataFormat
            // 
            this.panel_DataFormat.Controls.Add(this.radioButton24);
            this.panel_DataFormat.Controls.Add(this.radioButton21);
            this.panel_DataFormat.Controls.Add(this.radioButton22);
            this.panel_DataFormat.Controls.Add(this.radioButton23);
            this.panel_DataFormat.Location = new System.Drawing.Point(121, 333);
            this.panel_DataFormat.Name = "panel_DataFormat";
            this.panel_DataFormat.Size = new System.Drawing.Size(315, 39);
            this.panel_DataFormat.TabIndex = 43;
            // 
            // chk_Get
            // 
            this.chk_Get.AutoSize = true;
            this.chk_Get.Checked = true;
            this.chk_Get.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Get.Location = new System.Drawing.Point(220, 388);
            this.chk_Get.Name = "chk_Get";
            this.chk_Get.Size = new System.Drawing.Size(78, 24);
            this.chk_Get.TabIndex = 44;
            this.chk_Get.Text = "Get/Set";
            this.chk_Get.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 633);
            this.Controls.Add(this.chk_Get);
            this.Controls.Add(this.txt_Offset);
            this.Controls.Add(this.txt_Scale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chk_ConvertEnable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_Des);
            this.Controls.Add(this.chk_Reverse);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Source);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Src);
            this.Controls.Add(this.panel_DataFormat);
            this.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据类型转换工具V1.0";
            this.panel_Src.ResumeLayout(false);
            this.panel_Src.PerformLayout();
            this.panel_Des.ResumeLayout(false);
            this.panel_Des.PerformLayout();
            this.panel_DataFormat.ResumeLayout(false);
            this.panel_DataFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Source;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.RadioButton radioButton23;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.CheckBox chk_Reverse;
        private System.Windows.Forms.RadioButton radioButton25;
        private System.Windows.Forms.RadioButton radioButton26;
        private System.Windows.Forms.Panel panel_Src;
        private System.Windows.Forms.Panel panel_Des;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton27;
        private System.Windows.Forms.RadioButton radioButton28;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_ConvertEnable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Scale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Offset;
        private System.Windows.Forms.Panel panel_DataFormat;
        private System.Windows.Forms.CheckBox chk_Get;
    }
}

