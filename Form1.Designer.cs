namespace iwm_HtmlMsgBox
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
			this.components = new System.ComponentModel.Container();
			this.BtnYes = new System.Windows.Forms.Button();
			this.BtnNo = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.CbAccept = new System.Windows.Forms.CheckBox();
			this.TbUrl = new System.Windows.Forms.TextBox();
			this.CmsNull = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.BtnGoStartPage = new System.Windows.Forms.Button();
			this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// BtnYes
			// 
			this.BtnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnYes.BackColor = System.Drawing.SystemColors.ControlLight;
			this.BtnYes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.BtnYes.FlatAppearance.BorderSize = 0;
			this.BtnYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
			this.BtnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.BtnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.BtnYes.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnYes.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnYes.Location = new System.Drawing.Point(163, 408);
			this.BtnYes.Margin = new System.Windows.Forms.Padding(0);
			this.BtnYes.Name = "BtnYes";
			this.BtnYes.Size = new System.Drawing.Size(70, 24);
			this.BtnYes.TabIndex = 2;
			this.BtnYes.Text = "はい";
			this.BtnYes.UseVisualStyleBackColor = true;
			this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
			// 
			// BtnNo
			// 
			this.BtnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnNo.BackColor = System.Drawing.SystemColors.ControlLight;
			this.BtnNo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.BtnNo.FlatAppearance.BorderSize = 0;
			this.BtnNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
			this.BtnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.BtnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.BtnNo.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnNo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnNo.Location = new System.Drawing.Point(235, 408);
			this.BtnNo.Margin = new System.Windows.Forms.Padding(0);
			this.BtnNo.Name = "BtnNo";
			this.BtnNo.Size = new System.Drawing.Size(70, 24);
			this.BtnNo.TabIndex = 3;
			this.BtnNo.Text = "いいえ";
			this.BtnNo.UseVisualStyleBackColor = true;
			this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.BtnCancel.FlatAppearance.BorderSize = 0;
			this.BtnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
			this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.BtnCancel.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnCancel.Location = new System.Drawing.Point(307, 408);
			this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(70, 24);
			this.BtnCancel.TabIndex = 4;
			this.BtnCancel.Text = "閉じる";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// CbAccept
			// 
			this.CbAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CbAccept.AutoSize = true;
			this.CbAccept.BackColor = System.Drawing.SystemColors.Control;
			this.CbAccept.Checked = true;
			this.CbAccept.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CbAccept.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CbAccept.Location = new System.Drawing.Point(10, 380);
			this.CbAccept.Margin = new System.Windows.Forms.Padding(0);
			this.CbAccept.Name = "CbAccept";
			this.CbAccept.Size = new System.Drawing.Size(157, 17);
			this.CbAccept.TabIndex = 1;
			this.CbAccept.Text = "上記内容を承諾します。";
			this.CbAccept.UseVisualStyleBackColor = true;
			this.CbAccept.CheckedChanged += new System.EventHandler(this.CbAccept_CheckedChanged);
			// 
			// TbUrl
			// 
			this.TbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TbUrl.BackColor = System.Drawing.Color.WhiteSmoke;
			this.TbUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TbUrl.ContextMenuStrip = this.CmsNull;
			this.TbUrl.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbUrl.ForeColor = System.Drawing.Color.Black;
			this.TbUrl.Location = new System.Drawing.Point(30, 6);
			this.TbUrl.Margin = new System.Windows.Forms.Padding(0);
			this.TbUrl.Name = "TbUrl";
			this.TbUrl.ReadOnly = true;
			this.TbUrl.Size = new System.Drawing.Size(349, 12);
			this.TbUrl.TabIndex = 0;
			this.TbUrl.TabStop = false;
			this.TbUrl.Text = "URL";
			this.TbUrl.WordWrap = false;
			// 
			// CmsNull
			// 
			this.CmsNull.Name = "CmsNull";
			this.CmsNull.Size = new System.Drawing.Size(61, 4);
			// 
			// BtnGoStartPage
			// 
			this.BtnGoStartPage.BackColor = System.Drawing.Color.LightCyan;
			this.BtnGoStartPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnGoStartPage.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnGoStartPage.ForeColor = System.Drawing.Color.Black;
			this.BtnGoStartPage.Location = new System.Drawing.Point(1, 1);
			this.BtnGoStartPage.Margin = new System.Windows.Forms.Padding(0);
			this.BtnGoStartPage.Name = "BtnGoStartPage";
			this.BtnGoStartPage.Size = new System.Drawing.Size(25, 22);
			this.BtnGoStartPage.TabIndex = 0;
			this.BtnGoStartPage.TabStop = false;
			this.BtnGoStartPage.Text = "<<";
			this.BtnGoStartPage.UseVisualStyleBackColor = false;
			this.BtnGoStartPage.Click += new System.EventHandler(this.BtnGoStartPage_Click);
			// 
			// WebBrowser1
			// 
			this.WebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.WebBrowser1.ContextMenuStrip = this.CmsNull;
			this.WebBrowser1.Location = new System.Drawing.Point(1, 25);
			this.WebBrowser1.Margin = new System.Windows.Forms.Padding(0);
			this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.WebBrowser1.Name = "WebBrowser1";
			this.WebBrowser1.Size = new System.Drawing.Size(380, 350);
			this.WebBrowser1.TabIndex = 5;
			this.WebBrowser1.TabStop = false;
			this.WebBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBrowser1_Navigated);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(384, 441);
			this.Controls.Add(this.TbUrl);
			this.Controls.Add(this.BtnGoStartPage);
			this.Controls.Add(this.WebBrowser1);
			this.Controls.Add(this.BtnYes);
			this.Controls.Add(this.BtnNo);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.CbAccept);
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(250, 160);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button BtnYes;
		private System.Windows.Forms.Button BtnNo;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.CheckBox CbAccept;
		private System.Windows.Forms.TextBox TbUrl;
		private System.Windows.Forms.Button BtnGoStartPage;
		private System.Windows.Forms.WebBrowser WebBrowser1;
		private System.Windows.Forms.ContextMenuStrip CmsNull;
	}
}

