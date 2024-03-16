namespace pdfV
{
    partial class frm_reutilizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reutilizacion));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.pdfReader = new AxAcroPDFLib.AxAcroPDF();
            this.btnOpenPdf = new System.Windows.Forms.Button();
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.wbBrowser = new AxSHDocVw.AxWebBrowser();
            this.windowsMedia = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pdfReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.Location = new System.Drawing.Point(42, 513);
            this.btnOpenVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(147, 28);
            this.btnOpenVideo.TabIndex = 0;
            this.btnOpenVideo.Text = "Watch a video";
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            this.btnOpenVideo.Click += new System.EventHandler(this.button1_Click);
            // 
            // pdfReader
            // 
            this.pdfReader.Enabled = true;
            this.pdfReader.Location = new System.Drawing.Point(749, 12);
            this.pdfReader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pdfReader.Name = "pdfReader";
            this.pdfReader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfReader.OcxState")));
            this.pdfReader.Size = new System.Drawing.Size(305, 312);
            this.pdfReader.TabIndex = 3;
            // 
            // btnOpenPdf
            // 
            this.btnOpenPdf.Location = new System.Drawing.Point(881, 513);
            this.btnOpenPdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenPdf.Name = "btnOpenPdf";
            this.btnOpenPdf.Size = new System.Drawing.Size(100, 28);
            this.btnOpenPdf.TabIndex = 4;
            this.btnOpenPdf.Text = "Open pdf";
            this.btnOpenPdf.UseVisualStyleBackColor = true;
            this.btnOpenPdf.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Location = new System.Drawing.Point(445, 513);
            this.btnOpenBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(100, 28);
            this.btnOpenBrowser.TabIndex = 5;
            this.btnOpenBrowser.Text = "URL";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Enabled = true;
            this.wbBrowser.Location = new System.Drawing.Point(298, 13);
            this.wbBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.wbBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wbBrowser.OcxState")));
            this.wbBrowser.Size = new System.Drawing.Size(399, 325);
            this.wbBrowser.TabIndex = 2;
            // 
            // windowsMedia
            // 
            this.windowsMedia.Enabled = true;
            this.windowsMedia.Location = new System.Drawing.Point(12, 12);
            this.windowsMedia.Margin = new System.Windows.Forms.Padding(4);
            this.windowsMedia.Name = "windowsMedia";
            this.windowsMedia.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMedia.OcxState")));
            this.windowsMedia.Size = new System.Drawing.Size(251, 390);
            this.windowsMedia.TabIndex = 1;
            // 
            // frm_reutilizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnOpenBrowser);
            this.Controls.Add(this.btnOpenPdf);
            this.Controls.Add(this.pdfReader);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.windowsMedia);
            this.Controls.Add(this.btnOpenVideo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_reutilizacion";
            this.Text = "Reutilizacion Componentes";
            ((System.ComponentModel.ISupportInitialize)(this.pdfReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMedia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenVideo;
        private AxWMPLib.AxWindowsMediaPlayer windowsMedia;
        private AxAcroPDFLib.AxAcroPDF pdfReader;
        private AxSHDocVw.AxWebBrowser wbBrowser;
        private System.Windows.Forms.Button btnOpenPdf;
        private System.Windows.Forms.Button btnOpenBrowser;
    }
}

