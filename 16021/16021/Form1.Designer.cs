namespace _16021
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopLabel = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.tootip_close = new System.Windows.Forms.ToolTip(this.components);
            this.menuIcon = new System.Windows.Forms.PictureBox();
            this.tootip_menu = new System.Windows.Forms.ToolTip(this.components);
            this.최소화 = new System.Windows.Forms.PictureBox();
            this.tooltip_minimize = new System.Windows.Forms.ToolTip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.title = new System.Windows.Forms.PictureBox();
            this.resultBox = new System.Windows.Forms.PictureBox();
            this.resultText = new System.Windows.Forms.Label();
            this.Arrow = new System.Windows.Forms.PictureBox();
            this.blackscreen = new System.Windows.Forms.PictureBox();
            this.hex_resultBox = new System.Windows.Forms.PictureBox();
            this.hex_resultText = new System.Windows.Forms.Label();
            this.ch_dec = new System.Windows.Forms.PictureBox();
            this.ch_hex = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TopLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.최소화)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hex_resultBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_dec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_hex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            this.SuspendLayout();
            // 
            // TopLabel
            // 
            this.TopLabel.Location = new System.Drawing.Point(0, 0);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(406, 46);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.TabStop = false;
            // 
            // Header
            // 
            this.Header.Location = new System.Drawing.Point(0, 35);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(406, 144);
            this.Header.TabIndex = 1;
            this.Header.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("closeButton.InitialImage")));
            this.closeButton.Location = new System.Drawing.Point(378, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 17);
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            // 
            // menuIcon
            // 
            this.menuIcon.Location = new System.Drawing.Point(12, 4);
            this.menuIcon.Name = "menuIcon";
            this.menuIcon.Size = new System.Drawing.Size(29, 24);
            this.menuIcon.TabIndex = 3;
            this.menuIcon.TabStop = false;
            // 
            // 최소화
            // 
            this.최소화.Location = new System.Drawing.Point(352, 13);
            this.최소화.Name = "최소화";
            this.최소화.Size = new System.Drawing.Size(20, 15);
            this.최소화.TabIndex = 4;
            this.최소화.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(62, 47);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(218, 132);
            this.title.TabIndex = 5;
            this.title.TabStop = false;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 209);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(393, 53);
            this.resultBox.TabIndex = 6;
            this.resultBox.TabStop = false;
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("나눔바른고딕 옛한글", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.resultText.Location = new System.Drawing.Point(335, 224);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(70, 22);
            this.resultText.TabIndex = 7;
            this.resultText.Text = "label1";
            // 
            // Arrow
            // 
            this.Arrow.Location = new System.Drawing.Point(176, 290);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(60, 91);
            this.Arrow.TabIndex = 8;
            this.Arrow.TabStop = false;
            // 
            // blackscreen
            // 
            this.blackscreen.Location = new System.Drawing.Point(176, 256);
            this.blackscreen.Name = "blackscreen";
            this.blackscreen.Size = new System.Drawing.Size(100, 50);
            this.blackscreen.TabIndex = 11;
            this.blackscreen.TabStop = false;
            // 
            // hex_resultBox
            // 
            this.hex_resultBox.Location = new System.Drawing.Point(12, 414);
            this.hex_resultBox.Name = "hex_resultBox";
            this.hex_resultBox.Size = new System.Drawing.Size(393, 53);
            this.hex_resultBox.TabIndex = 9;
            this.hex_resultBox.TabStop = false;
            // 
            // hex_resultText
            // 
            this.hex_resultText.AutoSize = true;
            this.hex_resultText.Font = new System.Drawing.Font("나눔바른고딕 옛한글", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hex_resultText.Location = new System.Drawing.Point(335, 432);
            this.hex_resultText.Name = "hex_resultText";
            this.hex_resultText.Size = new System.Drawing.Size(70, 22);
            this.hex_resultText.TabIndex = 10;
            this.hex_resultText.Text = "label1";
            // 
            // ch_dec
            // 
            this.ch_dec.Location = new System.Drawing.Point(32, 312);
            this.ch_dec.Name = "ch_dec";
            this.ch_dec.Size = new System.Drawing.Size(100, 50);
            this.ch_dec.TabIndex = 12;
            this.ch_dec.TabStop = false;
            // 
            // ch_hex
            // 
            this.ch_hex.Location = new System.Drawing.Point(292, 312);
            this.ch_hex.Name = "ch_hex";
            this.ch_hex.Size = new System.Drawing.Size(100, 50);
            this.ch_hex.TabIndex = 13;
            this.ch_hex.TabStop = false;
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(176, 312);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(100, 50);
            this.line.TabIndex = 14;
            this.line.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 707);
            this.Controls.Add(this.line);
            this.Controls.Add(this.ch_hex);
            this.Controls.Add(this.ch_dec);
            this.Controls.Add(this.blackscreen);
            this.Controls.Add(this.hex_resultText);
            this.Controls.Add(this.hex_resultBox);
            this.Controls.Add(this.Arrow);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.최소화);
            this.Controls.Add(this.menuIcon);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.TopLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.최소화)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hex_resultBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_dec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_hex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopLabel;
        private System.Windows.Forms.PictureBox Header;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.ToolTip tootip_close;
        private System.Windows.Forms.PictureBox menuIcon;
        private System.Windows.Forms.ToolTip tootip_menu;
        private System.Windows.Forms.PictureBox 최소화;
        private System.Windows.Forms.ToolTip tooltip_minimize;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.PictureBox resultBox;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.PictureBox Arrow;
        private System.Windows.Forms.PictureBox hex_resultBox;
        private System.Windows.Forms.PictureBox blackscreen;
        private System.Windows.Forms.Label hex_resultText;
        private System.Windows.Forms.PictureBox ch_hex;
        private System.Windows.Forms.PictureBox ch_dec;
        private System.Windows.Forms.PictureBox line;
    }
}

