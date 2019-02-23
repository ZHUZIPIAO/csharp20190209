namespace 윈폼예제2_1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.comFont = new System.Windows.Forms.ComboBox();
            this.ddd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSports = new System.Windows.Forms.Label();
            this.rdoTkd = new System.Windows.Forms.RadioButton();
            this.rdoBaskeball = new System.Windows.Forms.RadioButton();
            this.rdoBaseBall = new System.Windows.Forms.RadioButton();
            this.rdoSoccer = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.chkItalic);
            this.groupBox1.Controls.Add(this.chkBold);
            this.groupBox1.Controls.Add(this.comFont);
            this.groupBox1.Controls.Add(this.ddd);
            this.groupBox1.Location = new System.Drawing.Point(61, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "폰트설정";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(24, 106);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(433, 21);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "오라클자바커뮤니티";
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(454, 40);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(72, 16);
            this.chkItalic.TabIndex = 3;
            this.chkItalic.Text = "이탤릭체";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(302, 39);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(48, 16);
            this.chkBold.TabIndex = 2;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // comFont
            // 
            this.comFont.FormattingEnabled = true;
            this.comFont.Location = new System.Drawing.Point(120, 37);
            this.comFont.Name = "comFont";
            this.comFont.Size = new System.Drawing.Size(121, 20);
            this.comFont.TabIndex = 1;
            this.comFont.SelectedIndexChanged += new System.EventHandler(this.comFont_SelectedIndexChanged);
            // 
            // ddd
            // 
            this.ddd.AutoSize = true;
            this.ddd.Location = new System.Drawing.Point(22, 37);
            this.ddd.Name = "ddd";
            this.ddd.Size = new System.Drawing.Size(29, 12);
            this.ddd.TabIndex = 0;
            this.ddd.Text = "폰트";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSports);
            this.groupBox2.Controls.Add(this.rdoTkd);
            this.groupBox2.Controls.Add(this.rdoBaskeball);
            this.groupBox2.Controls.Add(this.rdoBaseBall);
            this.groupBox2.Controls.Add(this.rdoSoccer);
            this.groupBox2.Location = new System.Drawing.Point(61, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "좋아하는스포츠하나만";
            // 
            // lblSports
            // 
            this.lblSports.AutoSize = true;
            this.lblSports.Location = new System.Drawing.Point(37, 96);
            this.lblSports.Name = "lblSports";
            this.lblSports.Size = new System.Drawing.Size(141, 12);
            this.lblSports.TabIndex = 4;
            this.lblSports.Text = "선택한스포츠가없습니다.";
            // 
            // rdoTkd
            // 
            this.rdoTkd.AutoSize = true;
            this.rdoTkd.Location = new System.Drawing.Point(489, 40);
            this.rdoTkd.Name = "rdoTkd";
            this.rdoTkd.Size = new System.Drawing.Size(63, 16);
            this.rdoTkd.TabIndex = 3;
            this.rdoTkd.TabStop = true;
            this.rdoTkd.Text = "태권도;";
            this.rdoTkd.UseVisualStyleBackColor = true;
            this.rdoTkd.CheckedChanged += new System.EventHandler(this.rdoTkd_CheckedChanged);
            // 
            // rdoBaskeball
            // 
            this.rdoBaskeball.AutoSize = true;
            this.rdoBaskeball.Location = new System.Drawing.Point(327, 41);
            this.rdoBaskeball.Name = "rdoBaskeball";
            this.rdoBaskeball.Size = new System.Drawing.Size(47, 16);
            this.rdoBaskeball.TabIndex = 2;
            this.rdoBaskeball.TabStop = true;
            this.rdoBaskeball.Text = "농구";
            this.rdoBaskeball.UseVisualStyleBackColor = true;
            this.rdoBaskeball.CheckedChanged += new System.EventHandler(this.rdoBasketball_CheckedChanged);
            // 
            // rdoBaseBall
            // 
            this.rdoBaseBall.AutoSize = true;
            this.rdoBaseBall.Location = new System.Drawing.Point(186, 42);
            this.rdoBaseBall.Name = "rdoBaseBall";
            this.rdoBaseBall.Size = new System.Drawing.Size(47, 16);
            this.rdoBaseBall.TabIndex = 1;
            this.rdoBaseBall.TabStop = true;
            this.rdoBaseBall.Text = "야구";
            this.rdoBaseBall.UseVisualStyleBackColor = true;
            this.rdoBaseBall.CheckedChanged += new System.EventHandler(this.rdoBaseball_CheckedChanged);
            // 
            // rdoSoccer
            // 
            this.rdoSoccer.AutoSize = true;
            this.rdoSoccer.Location = new System.Drawing.Point(39, 42);
            this.rdoSoccer.Name = "rdoSoccer";
            this.rdoSoccer.Size = new System.Drawing.Size(47, 16);
            this.rdoSoccer.TabIndex = 0;
            this.rdoSoccer.TabStop = true;
            this.rdoSoccer.Text = "축구";
            this.rdoSoccer.UseVisualStyleBackColor = true;
            this.rdoSoccer.CheckedChanged += new System.EventHandler(this.rdoSoccer_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Checkbox,RadioButton,ComboBox,TextBox예제";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox comFont;
        private System.Windows.Forms.Label ddd;
        private System.Windows.Forms.Label lblSports;
        private System.Windows.Forms.RadioButton rdoTkd;
        private System.Windows.Forms.RadioButton rdoBaskeball;
        private System.Windows.Forms.RadioButton rdoBaseBall;
        private System.Windows.Forms.RadioButton rdoSoccer;
    }
}

