﻿namespace GpsGetter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblLon = new System.Windows.Forms.Label();
            this.txbLon = new System.Windows.Forms.TextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.txbLat = new System.Windows.Forms.TextBox();
            this.txbAccuracy = new System.Windows.Forms.TextBox();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(33, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "位置情報取得開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLon.Location = new System.Drawing.Point(27, 55);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(57, 36);
            this.lblLon.TabIndex = 1;
            this.lblLon.Text = "Lon";
            // 
            // txbLon
            // 
            this.txbLon.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbLon.Location = new System.Drawing.Point(139, 55);
            this.txbLon.Name = "txbLon";
            this.txbLon.Size = new System.Drawing.Size(123, 31);
            this.txbLon.TabIndex = 2;
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLat.Location = new System.Drawing.Point(27, 118);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(51, 36);
            this.lblLat.TabIndex = 3;
            this.lblLat.Text = "Lat";
            // 
            // txbLat
            // 
            this.txbLat.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbLat.Location = new System.Drawing.Point(139, 123);
            this.txbLat.Name = "txbLat";
            this.txbLat.Size = new System.Drawing.Size(123, 31);
            this.txbLat.TabIndex = 4;
            // 
            // txbAccuracy
            // 
            this.txbAccuracy.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbAccuracy.Location = new System.Drawing.Point(139, 175);
            this.txbAccuracy.Name = "txbAccuracy";
            this.txbAccuracy.Size = new System.Drawing.Size(123, 31);
            this.txbAccuracy.TabIndex = 5;
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAccuracy.Location = new System.Drawing.Point(27, 170);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(63, 36);
            this.lblAccuracy.TabIndex = 6;
            this.lblAccuracy.Text = "精度";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 336);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.txbAccuracy);
            this.Controls.Add(this.txbLat);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.txbLon);
            this.Controls.Add(this.lblLon);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.TextBox txbLon;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.TextBox txbLat;
        private System.Windows.Forms.TextBox txbAccuracy;
        private System.Windows.Forms.Label lblAccuracy;
    }
}

