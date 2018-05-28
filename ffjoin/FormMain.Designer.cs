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
            resources.ApplyResources(this.lvMain, "lvMain");
            this.lvMain.FullRowSelect = true;
            this.lvMain.HideSelection = false;
            this.lvMain.LineAfter = -1;
            this.lvMain.LineBefore = -1;
            this.lvMain.MultiSelect = false;
            this.lvMain.Name = "lvMain";
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
            resources.ApplyResources(this.btnJoin, "btnJoin");
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSetffmpeg
            // 
            resources.ApplyResources(this.btnSetffmpeg, "btnSetffmpeg");
            this.btnSetffmpeg.Name = "btnSetffmpeg";
            this.btnSetffmpeg.UseVisualStyleBackColor = true;
            this.btnSetffmpeg.Click += new System.EventHandler(this.btnSetffmpeg_Click);
            // 
            // txtAllduration
            // 
            resources.ApplyResources(this.txtAllduration, "txtAllduration");
            this.txtAllduration.Name = "txtAllduration";
            this.txtAllduration.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnJoinDifferent
            // 
            resources.ApplyResources(this.btnJoinDifferent, "btnJoinDifferent");
            this.btnJoinDifferent.Name = "btnJoinDifferent";
            this.btnJoinDifferent.UseVisualStyleBackColor = true;
            this.btnJoinDifferent.Click += new System.EventHandler(this.btnJoinDifferent_Click);
            // 
            // btnAbout
            // 
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnJoinDifferent);
            this.Controls.Add(this.btnSetffmpeg);
            this.Controls.Add(this.txtAllduration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lvMain);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
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

