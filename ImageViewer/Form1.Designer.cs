namespace ImageViewer
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
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(13, 13);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(256, 144);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 0;
            this.picImg.TabStop = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(13, 164);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(97, 49);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "이전";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(172, 163);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 49);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblNum
            // 
            this.lblNum.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNum.Location = new System.Drawing.Point(117, 164);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(49, 48);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "/";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 225);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.picImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "사진첩";
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblNum;
    }
}

