namespace ffjoin
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナ変数です。
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

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lvMain = new ListViewCustomReorder.ListViewEx();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSetffmpeg = new System.Windows.Forms.Button();
            this.txtAllduration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJoinDifferent = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMain
            // 
            this.lvMain.AllowDrop = true;
            this.lvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMain.FullRowSelect = true;
            this.lvMain.HideSelection = false;
            this.lvMain.LineAfter = -1;
            this.lvMain.LineBefore = -1;
            this.lvMain.Location = new System.Drawing.Point(12, 13);
            this.lvMain.MultiSelect = false;
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(633, 334);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvMain_ColumnClick);
            this.lvMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvMain_DragDrop);
            this.lvMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvMain_DragEnter);
            this.lvMain.DragOver += new System.Windows.Forms.DragEventHandler(this.lvMain_DragOver);
            this.lvMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvMain_MouseDown);
            this.lvMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvMain_MouseMove);
            this.lvMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvMain_MouseUp);
            // 
            // btnJoin
            // 
            this.btnJoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnJoin.Location = new System.Drawing.Point(12, 353);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(313, 25);
            this.btnJoin.TabIndex = 6;
            this.btnJoin.Text = "&Join Normal";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(654, 353);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 25);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "&Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(651, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 25);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSetffmpeg
            // 
            this.btnSetffmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetffmpeg.Location = new System.Drawing.Point(651, 219);
            this.btnSetffmpeg.Name = "btnSetffmpeg";
            this.btnSetffmpeg.Size = new System.Drawing.Size(92, 25);
            this.btnSetffmpeg.TabIndex = 2;
            this.btnSetffmpeg.Text = "set &ffmpeg";
            this.btnSetffmpeg.UseVisualStyleBackColor = true;
            this.btnSetffmpeg.Click += new System.EventHandler(this.btnSetffmpeg_Click);
            // 
            // txtAllduration
            // 
            this.txtAllduration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAllduration.Location = new System.Drawing.Point(651, 277);
            this.txtAllduration.Name = "txtAllduration";
            this.txtAllduration.ReadOnly = true;
            this.txtAllduration.Size = new System.Drawing.Size(92, 20);
            this.txtAllduration.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "&duration";
            // 
            // btnJoinDifferent
            // 
            this.btnJoinDifferent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJoinDifferent.Location = new System.Drawing.Point(332, 353);
            this.btnJoinDifferent.Name = "btnJoinDifferent";
            this.btnJoinDifferent.Size = new System.Drawing.Size(313, 25);
            this.btnJoinDifferent.TabIndex = 7;
            this.btnJoinDifferent.Text = "&Join Different Codec";
            this.btnJoinDifferent.UseVisualStyleBackColor = true;
            this.btnJoinDifferent.Click += new System.EventHandler(this.btnJoinDifferent_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(651, 310);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(92, 25);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 390);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnJoinDifferent);
            this.Controls.Add(this.btnSetffmpeg);
            this.Controls.Add(this.txtAllduration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lvMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(762, 423);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ffjoin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListViewCustomReorder.ListViewEx lvMain;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAllduration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJoinDifferent;
        private System.Windows.Forms.Button btnSetffmpeg;
        private System.Windows.Forms.Button btnAbout;
    }
}

