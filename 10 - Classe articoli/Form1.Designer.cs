namespace _10___Classe_articoli
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.codice_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prezzo_box = new System.Windows.Forms.TextBox();
            this.descrizione_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aggiungi_btn = new System.Windows.Forms.Button();
            this.articoli = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tipo_cmbox = new System.Windows.Forms.ComboBox();
            this.si_check = new System.Windows.Forms.CheckBox();
            this.no_check = new System.Windows.Forms.CheckBox();
            this.scontrino_btn = new System.Windows.Forms.Button();
            this.TimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codice_box
            // 
            this.codice_box.Location = new System.Drawing.Point(138, 91);
            this.codice_box.Name = "codice_box";
            this.codice_box.Size = new System.Drawing.Size(100, 20);
            this.codice_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CODICE";
            // 
            // prezzo_box
            // 
            this.prezzo_box.Location = new System.Drawing.Point(138, 143);
            this.prezzo_box.Name = "prezzo_box";
            this.prezzo_box.Size = new System.Drawing.Size(100, 20);
            this.prezzo_box.TabIndex = 2;
            // 
            // descrizione_box
            // 
            this.descrizione_box.Location = new System.Drawing.Point(138, 117);
            this.descrizione_box.Name = "descrizione_box";
            this.descrizione_box.Size = new System.Drawing.Size(100, 20);
            this.descrizione_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PREZZO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESCRIZIONE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // aggiungi_btn
            // 
            this.aggiungi_btn.Location = new System.Drawing.Point(407, 156);
            this.aggiungi_btn.Name = "aggiungi_btn";
            this.aggiungi_btn.Size = new System.Drawing.Size(97, 58);
            this.aggiungi_btn.TabIndex = 7;
            this.aggiungi_btn.Text = "AGGIUNGI";
            this.aggiungi_btn.UseVisualStyleBackColor = true;
            this.aggiungi_btn.Click += new System.EventHandler(this.aggiungi_btn_Click);
            // 
            // articoli
            // 
            this.articoli.FormattingEnabled = true;
            this.articoli.Location = new System.Drawing.Point(55, 235);
            this.articoli.Name = "articoli";
            this.articoli.Size = new System.Drawing.Size(473, 173);
            this.articoli.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "TIPO ARTICOLO";
            // 
            // tipo_cmbox
            // 
            this.tipo_cmbox.FormattingEnabled = true;
            this.tipo_cmbox.Items.AddRange(new object[] {
            "ALIMENTARE",
            "NON ALIMENTARE",
            "FRESCO"});
            this.tipo_cmbox.Location = new System.Drawing.Point(301, 90);
            this.tipo_cmbox.Name = "tipo_cmbox";
            this.tipo_cmbox.Size = new System.Drawing.Size(121, 21);
            this.tipo_cmbox.TabIndex = 18;
            // 
            // si_check
            // 
            this.si_check.AutoSize = true;
            this.si_check.Location = new System.Drawing.Point(522, 94);
            this.si_check.Name = "si_check";
            this.si_check.Size = new System.Drawing.Size(35, 17);
            this.si_check.TabIndex = 19;
            this.si_check.Text = "Sì";
            this.si_check.UseVisualStyleBackColor = true;
            // 
            // no_check
            // 
            this.no_check.AutoSize = true;
            this.no_check.Location = new System.Drawing.Point(522, 116);
            this.no_check.Name = "no_check";
            this.no_check.Size = new System.Drawing.Size(40, 17);
            this.no_check.TabIndex = 20;
            this.no_check.Text = "No";
            this.no_check.UseVisualStyleBackColor = true;
            // 
            // scontrino_btn
            // 
            this.scontrino_btn.Location = new System.Drawing.Point(571, 282);
            this.scontrino_btn.Name = "scontrino_btn";
            this.scontrino_btn.Size = new System.Drawing.Size(81, 56);
            this.scontrino_btn.TabIndex = 21;
            this.scontrino_btn.Text = "MOSTRA SCONTRINO";
            this.scontrino_btn.UseVisualStyleBackColor = true;
            this.scontrino_btn.Click += new System.EventHandler(this.scontrino_btn_Click);
            // 
            // TimePicker_date
            // 
            this.TimePicker_date.Location = new System.Drawing.Point(138, 185);
            this.TimePicker_date.Name = "TimePicker_date";
            this.TimePicker_date.Size = new System.Drawing.Size(200, 20);
            this.TimePicker_date.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "SCADENZA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "RICICLABILE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimePicker_date);
            this.Controls.Add(this.scontrino_btn);
            this.Controls.Add(this.no_check);
            this.Controls.Add(this.si_check);
            this.Controls.Add(this.tipo_cmbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.articoli);
            this.Controls.Add(this.aggiungi_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descrizione_box);
            this.Controls.Add(this.prezzo_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codice_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codice_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prezzo_box;
        private System.Windows.Forms.TextBox descrizione_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aggiungi_btn;
        private System.Windows.Forms.ListBox articoli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tipo_cmbox;
        private System.Windows.Forms.CheckBox si_check;
        private System.Windows.Forms.CheckBox no_check;
        private System.Windows.Forms.Button scontrino_btn;
        private System.Windows.Forms.DateTimePicker TimePicker_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

