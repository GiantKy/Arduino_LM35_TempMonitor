namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTenCom = new System.Windows.Forms.ComboBox();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.UART = new System.IO.Ports.SerialPort(this.components);
            this.btnNgatKetNoi = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCompact = new System.Windows.Forms.ToolStripMenuItem();
            this.miScroll = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Com";
            // 
            // cbxTenCom
            // 
            this.cbxTenCom.FormattingEnabled = true;
            this.cbxTenCom.Location = new System.Drawing.Point(96, 20);
            this.cbxTenCom.Name = "cbxTenCom";
            this.cbxTenCom.Size = new System.Drawing.Size(175, 27);
            this.cbxTenCom.TabIndex = 1;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKetNoi.Location = new System.Drawing.Point(31, 65);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(123, 39);
            this.btnKetNoi.TabIndex = 2;
            this.btnKetNoi.Text = "Kết Nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // UART
            // 
            this.UART.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.UART_DataReceived);
            // 
            // btnNgatKetNoi
            // 
            this.btnNgatKetNoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNgatKetNoi.Enabled = false;
            this.btnNgatKetNoi.Location = new System.Drawing.Point(160, 65);
            this.btnNgatKetNoi.Name = "btnNgatKetNoi";
            this.btnNgatKetNoi.Size = new System.Drawing.Size(123, 39);
            this.btnNgatKetNoi.TabIndex = 3;
            this.btnNgatKetNoi.Text = "Ngắt Kết Nối";
            this.btnNgatKetNoi.UseVisualStyleBackColor = true;
            this.btnNgatKetNoi.Click += new System.EventHandler(this.btnNgatKetNoi_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(290, 23);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(716, 378);
            this.zedGraphControl1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCompact,
            this.miScroll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 48);
            // 
            // miCompact
            // 
            this.miCompact.Name = "miCompact";
            this.miCompact.Size = new System.Drawing.Size(152, 22);
            this.miCompact.Text = "Compact";
            this.miCompact.Click += new System.EventHandler(this.miCompact_Click);
            // 
            // miScroll
            // 
            this.miScroll.Name = "miScroll";
            this.miScroll.Size = new System.Drawing.Size(152, 22);
            this.miScroll.Text = "Scroll";
            this.miScroll.Click += new System.EventHandler(this.miScroll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 414);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.btnNgatKetNoi);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.cbxTenCom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTenCom;
        private System.Windows.Forms.Button btnKetNoi;
        private System.IO.Ports.SerialPort UART;
        private System.Windows.Forms.Button btnNgatKetNoi;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miCompact;
        private System.Windows.Forms.ToolStripMenuItem miScroll;
    }
}

