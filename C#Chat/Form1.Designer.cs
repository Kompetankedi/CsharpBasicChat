namespace C_Chat
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Serverİptxt = new System.Windows.Forms.TextBox();
            this.ServerPorttxt = new System.Windows.Forms.TextBox();
            this.Clientİptxt = new System.Windows.Forms.TextBox();
            this.ClientPortTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ServerStart = new System.Windows.Forms.Button();
            this.ClientConnect = new System.Windows.Forms.Button();
            this.ChatScreen = new System.Windows.Forms.TextBox();
            this.MessageTXT = new System.Windows.Forms.TextBox();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServerStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ServerPorttxt);
            this.groupBox1.Controls.Add(this.Serverİptxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClientConnect);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ClientPortTxt);
            this.groupBox2.Controls.Add(this.Clientİptxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // Serverİptxt
            // 
            this.Serverİptxt.Location = new System.Drawing.Point(37, 44);
            this.Serverİptxt.Name = "Serverİptxt";
            this.Serverİptxt.Size = new System.Drawing.Size(164, 29);
            this.Serverİptxt.TabIndex = 1;
            // 
            // ServerPorttxt
            // 
            this.ServerPorttxt.Location = new System.Drawing.Point(381, 44);
            this.ServerPorttxt.Name = "ServerPorttxt";
            this.ServerPorttxt.Size = new System.Drawing.Size(164, 29);
            this.ServerPorttxt.TabIndex = 2;
            // 
            // Clientİptxt
            // 
            this.Clientİptxt.Location = new System.Drawing.Point(37, 45);
            this.Clientİptxt.Name = "Clientİptxt";
            this.Clientİptxt.Size = new System.Drawing.Size(164, 29);
            this.Clientİptxt.TabIndex = 4;
            // 
            // ClientPortTxt
            // 
            this.ClientPortTxt.Location = new System.Drawing.Point(381, 45);
            this.ClientPortTxt.Name = "ClientPortTxt";
            this.ClientPortTxt.Size = new System.Drawing.Size(164, 29);
            this.ClientPortTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "İp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "İp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // ServerStart
            // 
            this.ServerStart.Location = new System.Drawing.Point(551, 44);
            this.ServerStart.Name = "ServerStart";
            this.ServerStart.Size = new System.Drawing.Size(75, 29);
            this.ServerStart.TabIndex = 3;
            this.ServerStart.Text = "Başlat";
            this.ServerStart.UseVisualStyleBackColor = true;
            this.ServerStart.Click += new System.EventHandler(this.ServerStart_Click);
            // 
            // ClientConnect
            // 
            this.ClientConnect.Location = new System.Drawing.Point(551, 45);
            this.ClientConnect.Name = "ClientConnect";
            this.ClientConnect.Size = new System.Drawing.Size(75, 29);
            this.ClientConnect.TabIndex = 6;
            this.ClientConnect.Text = "Bağlan";
            this.ClientConnect.UseVisualStyleBackColor = true;
            this.ClientConnect.Click += new System.EventHandler(this.ClientConnect_Click);
            // 
            // ChatScreen
            // 
            this.ChatScreen.Location = new System.Drawing.Point(12, 213);
            this.ChatScreen.Multiline = true;
            this.ChatScreen.Name = "ChatScreen";
            this.ChatScreen.Size = new System.Drawing.Size(638, 238);
            this.ChatScreen.TabIndex = 123123;
            // 
            // MessageTXT
            // 
            this.MessageTXT.Location = new System.Drawing.Point(13, 487);
            this.MessageTXT.Multiline = true;
            this.MessageTXT.Name = "MessageTXT";
            this.MessageTXT.Size = new System.Drawing.Size(544, 76);
            this.MessageTXT.TabIndex = 7;
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(563, 489);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(75, 74);
            this.Sendbtn.TabIndex = 8;
            this.Sendbtn.Text = "Gönder";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AcceptButton = this.Sendbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(662, 575);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.MessageTXT);
            this.Controls.Add(this.ChatScreen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Chat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ServerStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerPorttxt;
        private System.Windows.Forms.TextBox Serverİptxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClientConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientPortTxt;
        private System.Windows.Forms.TextBox Clientİptxt;
        private System.Windows.Forms.TextBox ChatScreen;
        private System.Windows.Forms.TextBox MessageTXT;
        private System.Windows.Forms.Button Sendbtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

