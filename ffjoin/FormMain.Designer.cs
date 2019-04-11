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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.cmList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromTheListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSetffmpeg = new System.Windows.Forms.Button();
            this.btnJoinDifferent = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnJoinDifferentH265 = new System.Windows.Forms.Button();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.slMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.slDuration = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvMain = new ListViewCustomReorder.ListViewEx();
            this.cmList.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmList
            // 
            this.cmList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromTheListToolStripMenuItem});
            this.cmList.Name = "cmList";
            resources.ApplyResources(this.cmList, "cmList");
            // 
            // removeFromTheListToolStripMenuItem
            // 
            this.removeFromTheListToolStripMenuItem.Name = "removeFromTheListToolStripMenuItem";
            resources.ApplyResources(this.removeFromTheListToolStripMenuItem, "removeFromTheListToolStripMenuItem");
            this.removeFromTheListToolStripMenuItem.Click += new System.EventHandler(this.removeFromTheListToolStripMenuItem_Click);
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
            // btnJoinDifferentH265
            // 
            resources.ApplyResources(this.btnJoinDifferentH265, "btnJoinDifferentH265");
            this.btnJoinDifferentH265.Name = "btnJoinDifferentH265";
            this.btnJoinDifferentH265.UseVisualStyleBackColor = true;
            this.btnJoinDifferentH265.Click += new System.EventHandler(this.btnJoinDifferentH265_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slMain,
            this.slDuration});
            resources.ApplyResources(this.ssMain, "ssMain");
            this.ssMain.Name = "ssMain";
            // 
            // slMain
            // 
            this.slMain.Name = "slMain";
            resources.ApplyResources(this.slMain, "slMain");
            this.slMain.Spring = true;
            // 
            // slDuration
            // 
            this.slDuration.Name = "slDuration";
            resources.ApplyResources(this.slDuration, "slDuration");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvMain);
            this.panel1.Controls.Add(this.btnJoin);
            this.panel1.Controls.Add(this.btnJoinDifferent);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnJoinDifferentH265);
            this.panel1.Controls.Add(this.btnSetffmpeg);
            this.panel1.Controls.Add(this.btnClear);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lvMain
            // 
            this.lvMain.AllowDrop = true;
            resources.ApplyResources(this.lvMain, "lvMain");
            this.lvMain.ContextMenuStrip = this.cmList;
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
            // FormMain
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssMain);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.cmList.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListViewCustomReorder.ListViewEx lvMain;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnJoinDifferent;
        private System.Windows.Forms.Button btnSetffmpeg;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ContextMenuStrip cmList;
        private System.Windows.Forms.ToolStripMenuItem removeFromTheListToolStripMenuItem;
        private System.Windows.Forms.Button btnJoinDifferentH265;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel slMain;
        private System.Windows.Forms.ToolStripStatusLabel slDuration;
        private System.Windows.Forms.Panel panel1;
    }
}

