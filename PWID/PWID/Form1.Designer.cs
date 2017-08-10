namespace PWID
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopLabel = new System.Windows.Forms.PictureBox();
            this.Body = new System.Windows.Forms.PictureBox();
            this.Mark = new System.Windows.Forms.PictureBox();
            this.toolTip_Mark = new System.Windows.Forms.ToolTip(this.components);
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.PWD = new System.Windows.Forms.PictureBox();
            this.PWD_Text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TopLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWD)).BeginInit();
            this.SuspendLayout();
            // 
            // TopLabel
            // 
            this.TopLabel.Location = new System.Drawing.Point(0, 1);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(431, 59);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.TabStop = false;
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(0, 66);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(431, 251);
            this.Body.TabIndex = 1;
            this.Body.TabStop = false;
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(12, 12);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(41, 35);
            this.Mark.TabIndex = 2;
            this.Mark.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(397, 10);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(34, 37);
            this.btn_close.TabIndex = 3;
            this.btn_close.TabStop = false;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Location = new System.Drawing.Point(344, 12);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(38, 39);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.TabStop = false;
            // 
            // PWD
            // 
            this.PWD.Location = new System.Drawing.Point(29, 53);
            this.PWD.Name = "PWD";
            this.PWD.Size = new System.Drawing.Size(382, 107);
            this.PWD.TabIndex = 5;
            this.PWD.TabStop = false;
            // 
            // PWD_Text
            // 
            this.PWD_Text.AutoSize = true;
            this.PWD_Text.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PWD_Text.Location = new System.Drawing.Point(127, 119);
            this.PWD_Text.Name = "PWD_Text";
            this.PWD_Text.Size = new System.Drawing.Size(68, 24);
            this.PWD_Text.TabIndex = 6;
            this.PWD_Text.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 197);
            this.Controls.Add(this.PWD_Text);
            this.Controls.Add(this.PWD);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.TopLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox TopLabel;
        public System.Windows.Forms.PictureBox Body;
        public System.Windows.Forms.PictureBox Mark;
        public System.Windows.Forms.ToolTip toolTip_Mark;
        public System.Windows.Forms.PictureBox btn_close;
        public System.Windows.Forms.PictureBox btn_minimize;
        public System.Windows.Forms.PictureBox PWD;
        public System.Windows.Forms.Label PWD_Text;
    }
}

