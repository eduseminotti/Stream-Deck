
namespace Stream_Deck
{
    partial class StreamDeck
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_APAREIAGE = new System.Windows.Forms.Button();
            this.BTN_swoosh = new System.Windows.Forms.Button();
            this.BTN_AIAI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_APAREIAGE
            // 
            this.BTN_APAREIAGE.Location = new System.Drawing.Point(37, 59);
            this.BTN_APAREIAGE.Name = "BTN_APAREIAGE";
            this.BTN_APAREIAGE.Size = new System.Drawing.Size(75, 23);
            this.BTN_APAREIAGE.TabIndex = 0;
            this.BTN_APAREIAGE.Text = "Apareiage";
            this.BTN_APAREIAGE.UseVisualStyleBackColor = true;
            this.BTN_APAREIAGE.Click += new System.EventHandler(this.BTN_APAREIAGE_Click);
            // 
            // BTN_swoosh
            // 
            this.BTN_swoosh.Location = new System.Drawing.Point(146, 59);
            this.BTN_swoosh.Name = "BTN_swoosh";
            this.BTN_swoosh.Size = new System.Drawing.Size(75, 23);
            this.BTN_swoosh.TabIndex = 1;
            this.BTN_swoosh.Text = "swoosh";
            this.BTN_swoosh.UseVisualStyleBackColor = true;
            this.BTN_swoosh.Click += new System.EventHandler(this.BTN_swoosh_Click);
            // 
            // BTN_AIAI
            // 
            this.BTN_AIAI.Location = new System.Drawing.Point(252, 59);
            this.BTN_AIAI.Name = "BTN_AIAI";
            this.BTN_AIAI.Size = new System.Drawing.Size(75, 23);
            this.BTN_AIAI.TabIndex = 2;
            this.BTN_AIAI.Text = "AIAI";
            this.BTN_AIAI.UseVisualStyleBackColor = true;
            this.BTN_AIAI.Click += new System.EventHandler(this.BTN_AIAI_Click);
            // 
            // StreamDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 773);
            this.Controls.Add(this.BTN_AIAI);
            this.Controls.Add(this.BTN_swoosh);
            this.Controls.Add(this.BTN_APAREIAGE);
            this.Name = "StreamDeck";
            this.Text = "Stream Deck";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_APAREIAGE;
        private System.Windows.Forms.Button BTN_swoosh;
        private System.Windows.Forms.Button BTN_AIAI;
    }
}

