
namespace PreventZzz
{
    partial class NotifyIconWrapper
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconWrapper));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Monitor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Sleep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "PreventZzz";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Monitor,
            this.toolStripMenuItem_Sleep,
            this.toolStripSeparator1,
            this.toolStripMenuItem_About,
            this.toolStripSeparator2,
            this.toolStripMenuItem_Quit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 104);
            // 
            // toolStripMenuItem_Monitor
            // 
            this.toolStripMenuItem_Monitor.CheckOnClick = true;
            this.toolStripMenuItem_Monitor.Name = "toolStripMenuItem_Monitor";
            this.toolStripMenuItem_Monitor.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem_Monitor.Text = "Don\'t power off monitor.";
            // 
            // toolStripMenuItem_Sleep
            // 
            this.toolStripMenuItem_Sleep.CheckOnClick = true;
            this.toolStripMenuItem_Sleep.Name = "toolStripMenuItem_Sleep";
            this.toolStripMenuItem_Sleep.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem_Sleep.Text = "Don\'t sleep.";
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            this.toolStripMenuItem_About.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem_About.Text = "About";
            // 
            // toolStripMenuItem_Quit
            // 
            this.toolStripMenuItem_Quit.Name = "toolStripMenuItem_Quit";
            this.toolStripMenuItem_Quit.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem_Quit.Text = "Quit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            this.contextMenuStrip1.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Monitor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Sleep;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Quit;
    }
}
