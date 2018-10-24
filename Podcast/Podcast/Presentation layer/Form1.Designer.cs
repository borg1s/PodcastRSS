namespace Podcast
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
            this.comBoxKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.comBoxUppdateringsfrekvens = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvKategorier = new System.Windows.Forms.ListView();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.lvPodcasts = new System.Windows.Forms.ListView();
            this.lvPodcastAvsnitt = new System.Windows.Forms.ListView();
            this.btnTaBortPodcast = new System.Windows.Forms.Button();
            this.btnSparaPodcast = new System.Windows.Forms.Button();
            this.btnNyPodcast = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comBoxKategori
            // 
            this.comBoxKategori.FormattingEnabled = true;
            this.comBoxKategori.Location = new System.Drawing.Point(446, 223);
            this.comBoxKategori.Name = "comBoxKategori";
            this.comBoxKategori.Size = new System.Drawing.Size(121, 21);
            this.comBoxKategori.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(13, 223);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(300, 20);
            this.txtURL.TabIndex = 3;
            // 
            // comBoxUppdateringsfrekvens
            // 
            this.comBoxUppdateringsfrekvens.FormattingEnabled = true;
            this.comBoxUppdateringsfrekvens.Location = new System.Drawing.Point(319, 223);
            this.comBoxUppdateringsfrekvens.Name = "comBoxUppdateringsfrekvens";
            this.comBoxUppdateringsfrekvens.Size = new System.Drawing.Size(121, 21);
            this.comBoxUppdateringsfrekvens.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uppdateringsfrekvens:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategorier:";
            // 
            // lvKategorier
            // 
            this.lvKategorier.Location = new System.Drawing.Point(603, 28);
            this.lvKategorier.Name = "lvKategorier";
            this.lvKategorier.Size = new System.Drawing.Size(237, 170);
            this.lvKategorier.TabIndex = 8;
            this.lvKategorier.UseCompatibleStateImageBehavior = false;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(603, 207);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(237, 20);
            this.txtKategori.TabIndex = 10;
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(603, 233);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(75, 23);
            this.btnNyKategori.TabIndex = 11;
            this.btnNyKategori.Text = "Ny...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(684, 233);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(75, 23);
            this.btnSparaKategori.TabIndex = 12;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(765, 233);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(75, 23);
            this.btnTaBortKategori.TabIndex = 13;
            this.btnTaBortKategori.Text = "Ta bort...";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // lvPodcasts
            // 
            this.lvPodcasts.Location = new System.Drawing.Point(13, 13);
            this.lvPodcasts.Name = "lvPodcasts";
            this.lvPodcasts.Size = new System.Drawing.Size(554, 185);
            this.lvPodcasts.TabIndex = 14;
            this.lvPodcasts.UseCompatibleStateImageBehavior = false;
            // 
            // lvPodcastAvsnitt
            // 
            this.lvPodcastAvsnitt.Location = new System.Drawing.Point(13, 279);
            this.lvPodcastAvsnitt.Name = "lvPodcastAvsnitt";
            this.lvPodcastAvsnitt.Size = new System.Drawing.Size(554, 207);
            this.lvPodcastAvsnitt.TabIndex = 15;
            this.lvPodcastAvsnitt.UseCompatibleStateImageBehavior = false;
            // 
            // btnTaBortPodcast
            // 
            this.btnTaBortPodcast.Location = new System.Drawing.Point(492, 250);
            this.btnTaBortPodcast.Name = "btnTaBortPodcast";
            this.btnTaBortPodcast.Size = new System.Drawing.Size(75, 23);
            this.btnTaBortPodcast.TabIndex = 16;
            this.btnTaBortPodcast.Text = "Ta bort...";
            this.btnTaBortPodcast.UseVisualStyleBackColor = true;
            // 
            // btnSparaPodcast
            // 
            this.btnSparaPodcast.Location = new System.Drawing.Point(411, 250);
            this.btnSparaPodcast.Name = "btnSparaPodcast";
            this.btnSparaPodcast.Size = new System.Drawing.Size(75, 23);
            this.btnSparaPodcast.TabIndex = 17;
            this.btnSparaPodcast.Text = "Spara";
            this.btnSparaPodcast.UseVisualStyleBackColor = true;
            // 
            // btnNyPodcast
            // 
            this.btnNyPodcast.Location = new System.Drawing.Point(330, 250);
            this.btnNyPodcast.Name = "btnNyPodcast";
            this.btnNyPodcast.Size = new System.Drawing.Size(75, 23);
            this.btnNyPodcast.TabIndex = 18;
            this.btnNyPodcast.Text = "Ny...";
            this.btnNyPodcast.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(583, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 470);
            this.label5.TabIndex = 19;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Location = new System.Drawing.Point(603, 279);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(237, 207);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(583, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 2);
            this.label6.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 498);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNyPodcast);
            this.Controls.Add(this.btnSparaPodcast);
            this.Controls.Add(this.btnTaBortPodcast);
            this.Controls.Add(this.lvPodcastAvsnitt);
            this.Controls.Add(this.lvPodcasts);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.lvKategorier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comBoxUppdateringsfrekvens);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBoxKategori);
            this.Name = "Form1";
            this.Text = "Podcasts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comBoxKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ComboBox comBoxUppdateringsfrekvens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvKategorier;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Button btnNyKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.ListView lvPodcasts;
        private System.Windows.Forms.ListView lvPodcastAvsnitt;
        private System.Windows.Forms.Button btnTaBortPodcast;
        private System.Windows.Forms.Button btnSparaPodcast;
        private System.Windows.Forms.Button btnNyPodcast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label6;
    }
}

