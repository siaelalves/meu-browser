namespace BRW
{
    partial class BRW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BRW));
            this.mn = new System.Windows.Forms.MenuStrip();
            this.cmdIn = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdVl = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdAv = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdParar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdRec = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMecPs = new System.Windows.Forms.ToolStripComboBox();
            this.txtURL = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.st = new System.Windows.Forms.StatusStrip();
            this.lblSit = new System.Windows.Forms.ToolStripStatusLabel();
            this.web = new System.Windows.Forms.WebBrowser();
            this.ctmn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdCp = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCl = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdctVl = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdcdAv = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdctRec = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSp1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdSp2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdSv = new System.Windows.Forms.ToolStripMenuItem();
            this.mn.SuspendLayout();
            this.st.SuspendLayout();
            this.ctmn.SuspendLayout();
            this.SuspendLayout();
            // 
            // mn
            // 
            this.mn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdIn,
            this.cmdVl,
            this.cmdAv,
            this.cmdParar,
            this.cmdRec,
            this.txtMecPs,
            this.txtURL,
            this.toolStripTextBox1});
            this.mn.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mn.Location = new System.Drawing.Point(0, 0);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(732, 62);
            this.mn.TabIndex = 0;
            this.mn.Text = "menu";
            // 
            // cmdIn
            // 
            this.cmdIn.Name = "cmdIn";
            this.cmdIn.Size = new System.Drawing.Size(48, 19);
            this.cmdIn.Text = "&Início";
            this.cmdIn.Click += new System.EventHandler(this.cmdIn_Click);
            // 
            // cmdVl
            // 
            this.cmdVl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdVl.Image = global::BRW.Properties.Resources.Voltar;
            this.cmdVl.Name = "cmdVl";
            this.cmdVl.Size = new System.Drawing.Size(28, 20);
            this.cmdVl.Text = "&Voltar";
            this.cmdVl.Click += new System.EventHandler(this.cmdVl_Click);
            // 
            // cmdAv
            // 
            this.cmdAv.Name = "cmdAv";
            this.cmdAv.Size = new System.Drawing.Size(62, 19);
            this.cmdAv.Text = "&Avançar";
            this.cmdAv.Click += new System.EventHandler(this.cmdAv_Click);
            // 
            // cmdParar
            // 
            this.cmdParar.Name = "cmdParar";
            this.cmdParar.Size = new System.Drawing.Size(46, 19);
            this.cmdParar.Text = "&Parar";
            this.cmdParar.Click += new System.EventHandler(this.cmdParar_Click);
            // 
            // cmdRec
            // 
            this.cmdRec.Name = "cmdRec";
            this.cmdRec.Size = new System.Drawing.Size(75, 19);
            this.cmdRec.Text = "&Recarregar";
            this.cmdRec.Click += new System.EventHandler(this.cmdRec_Click);
            // 
            // txtMecPs
            // 
            this.txtMecPs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMecPs.Name = "txtMecPs";
            this.txtMecPs.Size = new System.Drawing.Size(300, 29);
            this.txtMecPs.SelectedIndexChanged += new System.EventHandler(this.txtMecPs_SelectedIndexChanged);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(645, 29);
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(12, 4);
            // 
            // st
            // 
            this.st.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.st.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSit});
            this.st.Location = new System.Drawing.Point(0, 354);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(732, 22);
            this.st.TabIndex = 1;
            this.st.Text = "status";
            // 
            // lblSit
            // 
            this.lblSit.Name = "lblSit";
            this.lblSit.Size = new System.Drawing.Size(0, 17);
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(419, 62);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(313, 292);
            this.web.TabIndex = 2;
            this.web.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_DocumentCompleted);
            this.web.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.web_Navigated);
            this.web.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.web_Navigating);
            // 
            // ctmn
            // 
            this.ctmn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdCp,
            this.cmdCl,
            this.cmdSp1,
            this.cmdctVl,
            this.cmdcdAv,
            this.cmdctRec,
            this.cmdSp2,
            this.cmdSv});
            this.ctmn.Name = "ctmn";
            this.ctmn.Size = new System.Drawing.Size(145, 148);
            this.ctmn.Text = "Menu de contexto";
            // 
            // cmdCp
            // 
            this.cmdCp.Name = "cmdCp";
            this.cmdCp.Size = new System.Drawing.Size(144, 22);
            this.cmdCp.Text = "&Copiar";
            // 
            // cmdCl
            // 
            this.cmdCl.Name = "cmdCl";
            this.cmdCl.Size = new System.Drawing.Size(144, 22);
            this.cmdCl.Text = "Co&lar";
            // 
            // cmdctVl
            // 
            this.cmdctVl.Name = "cmdctVl";
            this.cmdctVl.Size = new System.Drawing.Size(144, 22);
            this.cmdctVl.Text = "&Voltar";
            // 
            // cmdcdAv
            // 
            this.cmdcdAv.Name = "cmdcdAv";
            this.cmdcdAv.Size = new System.Drawing.Size(144, 22);
            this.cmdcdAv.Text = "&Avançar";
            // 
            // cmdctRec
            // 
            this.cmdctRec.Name = "cmdctRec";
            this.cmdctRec.Size = new System.Drawing.Size(144, 22);
            this.cmdctRec.Text = "&Recarregar";
            // 
            // cmdSp1
            // 
            this.cmdSp1.Name = "cmdSp1";
            this.cmdSp1.Size = new System.Drawing.Size(141, 6);
            // 
            // cmdSp2
            // 
            this.cmdSp2.Name = "cmdSp2";
            this.cmdSp2.Size = new System.Drawing.Size(141, 6);
            // 
            // cmdSv
            // 
            this.cmdSv.Name = "cmdSv";
            this.cmdSv.Size = new System.Drawing.Size(144, 22);
            this.cmdSv.Text = "&Salvar página";
            // 
            // BRW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 376);
            this.Controls.Add(this.web);
            this.Controls.Add(this.st);
            this.Controls.Add(this.mn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mn;
            this.Name = "BRW";
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.BRW_Load);
            this.SizeChanged += new System.EventHandler(this.BRW_SizeChanged);
            this.mn.ResumeLayout(false);
            this.mn.PerformLayout();
            this.st.ResumeLayout(false);
            this.st.PerformLayout();
            this.ctmn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mn;
        private System.Windows.Forms.ToolStripTextBox txtURL;
        private System.Windows.Forms.StatusStrip st;
        private System.Windows.Forms.ToolStripStatusLabel lblSit;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.ToolStripComboBox txtMecPs;
        private System.Windows.Forms.ToolStripMenuItem cmdVl;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem cmdAv;
        private System.Windows.Forms.ToolStripMenuItem cmdIn;
        private System.Windows.Forms.ToolStripMenuItem cmdRec;
        private System.Windows.Forms.ToolStripMenuItem cmdParar;
        private System.Windows.Forms.ContextMenuStrip ctmn;
        private System.Windows.Forms.ToolStripMenuItem cmdCp;
        private System.Windows.Forms.ToolStripMenuItem cmdCl;
        private System.Windows.Forms.ToolStripSeparator cmdSp1;
        private System.Windows.Forms.ToolStripMenuItem cmdctVl;
        private System.Windows.Forms.ToolStripMenuItem cmdcdAv;
        private System.Windows.Forms.ToolStripMenuItem cmdctRec;
        private System.Windows.Forms.ToolStripSeparator cmdSp2;
        private System.Windows.Forms.ToolStripMenuItem cmdSv;
    }
}

