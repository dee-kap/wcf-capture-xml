namespace CaptureXML.Host
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStartService = new System.Windows.Forms.Button();
            this.tabControlCapture = new System.Windows.Forms.TabControl();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.webBrowserRequest = new System.Windows.Forms.WebBrowser();
            this.tabPageResponse = new System.Windows.Forms.TabPage();
            this.webBrowserResponse = new System.Windows.Forms.WebBrowser();
            this.tabControlCapture.SuspendLayout();
            this.tabPageRequest.SuspendLayout();
            this.tabPageResponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartService
            // 
            this.buttonStartService.Location = new System.Drawing.Point(12, 12);
            this.buttonStartService.Name = "buttonStartService";
            this.buttonStartService.Size = new System.Drawing.Size(172, 23);
            this.buttonStartService.TabIndex = 0;
            this.buttonStartService.Text = "Start Service";
            this.buttonStartService.UseVisualStyleBackColor = true;
            this.buttonStartService.Click += new System.EventHandler(this.buttonStartService_Click);
            // 
            // tabControlCapture
            // 
            this.tabControlCapture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCapture.Controls.Add(this.tabPageRequest);
            this.tabControlCapture.Controls.Add(this.tabPageResponse);
            this.tabControlCapture.Location = new System.Drawing.Point(4, 50);
            this.tabControlCapture.Name = "tabControlCapture";
            this.tabControlCapture.SelectedIndex = 0;
            this.tabControlCapture.Size = new System.Drawing.Size(517, 451);
            this.tabControlCapture.TabIndex = 1;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Controls.Add(this.webBrowserRequest);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequest.Size = new System.Drawing.Size(509, 425);
            this.tabPageRequest.TabIndex = 0;
            this.tabPageRequest.Text = "Request";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // webBrowserRequest
            // 
            this.webBrowserRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserRequest.Location = new System.Drawing.Point(3, 3);
            this.webBrowserRequest.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserRequest.Name = "webBrowserRequest";
            this.webBrowserRequest.Size = new System.Drawing.Size(503, 419);
            this.webBrowserRequest.TabIndex = 0;
            // 
            // tabPageResponse
            // 
            this.tabPageResponse.Controls.Add(this.webBrowserResponse);
            this.tabPageResponse.Location = new System.Drawing.Point(4, 22);
            this.tabPageResponse.Name = "tabPageResponse";
            this.tabPageResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResponse.Size = new System.Drawing.Size(509, 425);
            this.tabPageResponse.TabIndex = 1;
            this.tabPageResponse.Text = "Response";
            this.tabPageResponse.UseVisualStyleBackColor = true;
            // 
            // webBrowserResponse
            // 
            this.webBrowserResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserResponse.Location = new System.Drawing.Point(3, 3);
            this.webBrowserResponse.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserResponse.Name = "webBrowserResponse";
            this.webBrowserResponse.Size = new System.Drawing.Size(503, 419);
            this.webBrowserResponse.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 504);
            this.Controls.Add(this.tabControlCapture);
            this.Controls.Add(this.buttonStartService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Service Host";
            this.tabControlCapture.ResumeLayout(false);
            this.tabPageRequest.ResumeLayout(false);
            this.tabPageResponse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartService;
        private System.Windows.Forms.TabControl tabControlCapture;
        private System.Windows.Forms.TabPage tabPageRequest;
        private System.Windows.Forms.TabPage tabPageResponse;
        private System.Windows.Forms.WebBrowser webBrowserRequest;
        private System.Windows.Forms.WebBrowser webBrowserResponse;
    }
}

