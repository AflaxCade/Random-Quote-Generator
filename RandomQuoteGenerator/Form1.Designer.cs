namespace RandomQuoteGenerator
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
            this.pnlCard = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnGetQuote = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.circle = new Guna.UI2.WinForms.Guna2Shapes();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnAudio = new System.Windows.Forms.PictureBox();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.BorderRadius = 20;
            this.pnlCard.Controls.Add(this.btnAudio);
            this.pnlCard.Controls.Add(this.lblAuthor);
            this.pnlCard.Controls.Add(this.lblQuote);
            this.pnlCard.Controls.Add(this.lblHeader);
            this.pnlCard.Controls.Add(this.btnGetQuote);
            this.pnlCard.Controls.Add(this.guna2Separator1);
            this.pnlCard.Controls.Add(this.circle);
            this.pnlCard.Location = new System.Drawing.Point(248, 106);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(763, 452);
            this.pnlCard.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.White;
            this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAuthor.Location = new System.Drawing.Point(398, 311);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAuthor.Size = new System.Drawing.Size(288, 31);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Winston Churchill";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQuote
            // 
            this.lblQuote.BackColor = System.Drawing.Color.White;
            this.lblQuote.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(76, 74);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(610, 228);
            this.lblQuote.TabIndex = 3;
            this.lblQuote.Text = "Continuous effort - not strength or intelligence - is the key to unlocking our po" +
    "tential.";
            this.lblQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Bord Demo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(162, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(380, 38);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Quote of the day";
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.AutoRoundedCorners = true;
            this.btnGetQuote.BackColor = System.Drawing.Color.Transparent;
            this.btnGetQuote.BorderRadius = 28;
            this.btnGetQuote.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGetQuote.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGetQuote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGetQuote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGetQuote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnGetQuote.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnGetQuote.ForeColor = System.Drawing.Color.White;
            this.btnGetQuote.Location = new System.Drawing.Point(486, 369);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(199, 59);
            this.btnGetQuote.TabIndex = 0;
            this.btnGetQuote.Text = "Generate Quote";
            this.btnGetQuote.UseTransparentBackground = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.Silver;
            this.guna2Separator1.Location = new System.Drawing.Point(79, 347);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(606, 10);
            this.guna2Separator1.TabIndex = 0;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.Transparent;
            this.circle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.circle.FillColor = System.Drawing.Color.Transparent;
            this.circle.Location = new System.Drawing.Point(81, 371);
            this.circle.Name = "circle";
            this.circle.PolygonSkip = 1;
            this.circle.Rotate = 0F;
            this.circle.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.circle.Size = new System.Drawing.Size(56, 56);
            this.circle.TabIndex = 7;
            this.circle.Text = "guna2Shapes1";
            this.circle.UseTransparentBackground = true;
            this.circle.Zoom = 100;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 664);
            this.panel1.TabIndex = 2;
            // 
            // MessageDialog
            // 
            this.MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageDialog.Caption = "Error";
            this.MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.MessageDialog.Parent = this;
            this.MessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageDialog.Text = null;
            // 
            // btnAudio
            // 
            this.btnAudio.BackColor = System.Drawing.Color.White;
            this.btnAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAudio.Image = global::RandomQuoteGenerator.Properties.Resources.audio;
            this.btnAudio.Location = new System.Drawing.Point(91, 380);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(35, 35);
            this.btnAudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAudio.TabIndex = 6;
            this.btnAudio.TabStop = false;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Quote Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAudio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlCard;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnGetQuote;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblAuthor;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog;
        private System.Windows.Forms.PictureBox btnAudio;
        private Guna.UI2.WinForms.Guna2Shapes circle;
    }
}

