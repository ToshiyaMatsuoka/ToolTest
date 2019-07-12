namespace ToolTest.Views
{
    partial class Menu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.btnPlayer = new System.Windows.Forms.Button();
            this.BtnEnemy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayer
            // 
            this.btnPlayer.Location = new System.Drawing.Point(208, 206);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(91, 38);
            this.btnPlayer.TabIndex = 0;
            this.btnPlayer.Text = "プレイヤー";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.BtnPlayer_Click);
            // 
            // BtnEnemy
            // 
            this.BtnEnemy.Location = new System.Drawing.Point(446, 206);
            this.BtnEnemy.Name = "BtnEnemy";
            this.BtnEnemy.Size = new System.Drawing.Size(90, 38);
            this.BtnEnemy.TabIndex = 1;
            this.BtnEnemy.Text = "エネミー";
            this.BtnEnemy.UseVisualStyleBackColor = true;
            this.BtnEnemy.Click += new System.EventHandler(this.BtnEnemy_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEnemy);
            this.Controls.Add(this.btnPlayer);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button BtnEnemy;
    }
}

