namespace projeto
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.PS = new System.Windows.Forms.Button();
            this.EQ = new System.Windows.Forms.Button();
            this.TQ = new System.Windows.Forms.Button();
            this.TT = new System.Windows.Forms.Button();
            this.HA = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.CRED = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PS
            // 
            this.PS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PS.Image = global::projeto.Properties.Resources.primeiros_socorros;
            this.PS.Location = new System.Drawing.Point(321, 202);
            this.PS.Name = "PS";
            this.PS.Size = new System.Drawing.Size(174, 118);
            this.PS.TabIndex = 0;
            this.PS.UseVisualStyleBackColor = true;
            this.PS.Click += new System.EventHandler(this.PS_Click);
            // 
            // EQ
            // 
            this.EQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EQ.Image = global::projeto.Properties.Resources.EVITE_QUEIMADURAS;
            this.EQ.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.EQ.Location = new System.Drawing.Point(530, 202);
            this.EQ.Name = "EQ";
            this.EQ.Size = new System.Drawing.Size(174, 118);
            this.EQ.TabIndex = 1;
            this.EQ.UseVisualStyleBackColor = true;
            this.EQ.Click += new System.EventHandler(this.EQ_Click);
            // 
            // TQ
            // 
            this.TQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TQ.Image = global::projeto.Properties.Resources.tq;
            this.TQ.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TQ.Location = new System.Drawing.Point(738, 202);
            this.TQ.Name = "TQ";
            this.TQ.Size = new System.Drawing.Size(174, 118);
            this.TQ.TabIndex = 2;
            this.TQ.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TQ.UseVisualStyleBackColor = true;
            this.TQ.Click += new System.EventHandler(this.TQ_Click);
            // 
            // TT
            // 
            this.TT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TT.Image = global::projeto.Properties.Resources.TT;
            this.TT.Location = new System.Drawing.Point(321, 349);
            this.TT.Name = "TT";
            this.TT.Size = new System.Drawing.Size(174, 118);
            this.TT.TabIndex = 3;
            this.TT.UseVisualStyleBackColor = true;
            this.TT.Click += new System.EventHandler(this.TT_Click);
            // 
            // HA
            // 
            this.HA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HA.Image = global::projeto.Properties.Resources.hospitais;
            this.HA.Location = new System.Drawing.Point(530, 349);
            this.HA.Name = "HA";
            this.HA.Size = new System.Drawing.Size(174, 118);
            this.HA.TabIndex = 4;
            this.HA.UseVisualStyleBackColor = true;
            this.HA.Click += new System.EventHandler(this.HA_Click);
            // 
            // button6
            // 
            this.button6.Image = global::projeto.Properties.Resources.saiba_mais;
            this.button6.Location = new System.Drawing.Point(738, 349);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 118);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CRED
            // 
            this.CRED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CRED.Image = global::projeto.Properties.Resources.Créditos;
            this.CRED.Location = new System.Drawing.Point(530, 488);
            this.CRED.Name = "CRED";
            this.CRED.Size = new System.Drawing.Size(174, 50);
            this.CRED.TabIndex = 6;
            this.CRED.UseVisualStyleBackColor = true;
            this.CRED.Click += new System.EventHandler(this.CRED_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Image = global::projeto.Properties.Resources.saiba_mais;
            this.linkLabel1.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(738, 349);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(174, 118);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = resources.GetString("linkLabel1.Text");
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(157)))), ((int)(((byte)(83)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(756, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::projeto.Properties.Resources.MENU;
            this.ClientSize = new System.Drawing.Size(1350, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.CRED);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.HA);
            this.Controls.Add(this.TT);
            this.Controls.Add(this.TQ);
            this.Controls.Add(this.EQ);
            this.Controls.Add(this.PS);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button PS;
        private Button EQ;
        private Button TQ;
        private Button TT;
        private Button HA;
        private Button button6;
        private Button CRED;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}