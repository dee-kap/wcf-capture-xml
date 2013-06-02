namespace CaptureXML.Client
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
            this.buttonSayHello = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSayHello
            // 
            this.buttonSayHello.Location = new System.Drawing.Point(252, 75);
            this.buttonSayHello.Name = "buttonSayHello";
            this.buttonSayHello.Size = new System.Drawing.Size(113, 23);
            this.buttonSayHello.TabIndex = 0;
            this.buttonSayHello.Text = "Say Hello";
            this.buttonSayHello.UseVisualStyleBackColor = true;
            this.buttonSayHello.Click += new System.EventHandler(this.buttonSayHello_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(234, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(151, 28);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(35, 13);
            this.labelResponse.TabIndex = 2;
            this.labelResponse.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 264);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSayHello);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Service Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSayHello;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelResponse;
    }
}

