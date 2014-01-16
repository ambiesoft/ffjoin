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
            this.lvMain = new System.Windows.Forms.ListView();
            this.chFile = new System.Windows.Forms.ColumnHeader();
            this.chLastAccess = new System.Windows.Forms.ColumnHeader();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.spRoot = new System.Windows.Forms.SplitContainer();
            this.spRoot.Panel1.SuspendLayout();
            this.spRoot.Panel2.SuspendLayout();
            this.spRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMain
            // 
            this.lvMain.AllowDrop = true;
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFile,
            this.chLastAccess});
            this.lvMain.FullRowSelect = true;
            this.lvMain.HideSelection = false;
            this.lvMain.Location = new System.Drawing.Point(3, 3);
            this.lvMain.MultiSelect = false;
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(485, 306);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvMain_DragDrop);
            this.lvMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvMain_ColumnClick);
            this.lvMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvMain_DragEnter);
            this.lvMain.DragLeave += new System.EventHandler(this.lvMain_DragLeave);
            this.lvMain.DragOver += new System.Windows.Forms.DragEventHandler(this.lvMain_DragOver);
            // 
            // chFile
            // 
            this.chFile.Text = "File";
            this.chFile.Width = 366;
            // 
            // chLastAccess
            // 
            this.chLastAccess.Text = "Date";
            this.chLastAccess.Width = 112;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(3, 3);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(485, 23);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "&Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(494, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(494, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // spRoot
            // 
            this.spRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spRoot.Location = new System.Drawing.Point(0, 0);
            this.spRoot.Name = "spRoot";
            this.spRoot.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spRoot.Panel1
            // 
            this.spRoot.Panel1.Controls.Add(this.lvMain);
            this.spRoot.Panel1.Controls.Add(this.btnClear);
            // 
            // spRoot.Panel2
            // 
            this.spRoot.Panel2.Controls.Add(this.btnJoin);
            this.spRoot.Panel2.Controls.Add(this.btnOK);
            this.spRoot.Size = new System.Drawing.Size(581, 358);
            this.spRoot.SplitterDistance = 312;
            this.spRoot.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 358);
            this.Controls.Add(this.spRoot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "ffjoin";
            this.spRoot.Panel1.ResumeLayout(false);
            this.spRoot.Panel2.ResumeLayout(false);
            this.spRoot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ColumnHeader chFile;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.ColumnHeader chLastAccess;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.SplitContainer spRoot;
    }
}

