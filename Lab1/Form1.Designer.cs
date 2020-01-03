namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.open_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.zamknijCOM_btn = new System.Windows.Forms.Button();
            this.portyCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fec_btn = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.phy_btn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.b_psk_btn = new System.Windows.Forms.RadioButton();
            this.q_psk_btn = new System.Windows.Forms.RadioButton();
            this.psk_8_btn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nadaj_asci = new System.Windows.Forms.RichTextBox();
            this.nadaj_hex = new System.Windows.Forms.RichTextBox();
            this.odbior = new System.Windows.Forms.RichTextBox();
            this.modulacja_box = new System.Windows.Forms.GroupBox();
            this.dl_btn = new System.Windows.Forms.RadioButton();
            this.polaczenie_box = new System.Windows.Forms.GroupBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.ascii_text = new System.Windows.Forms.Label();
            this.hex_text = new System.Windows.Forms.Label();
            this.odbior_text = new System.Windows.Forms.Label();
            this.wyslij_btn = new System.Windows.Forms.Button();
            this.modulacja_box.SuspendLayout();
            this.polaczenie_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_btn
            // 
            this.open_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.open_btn.Location = new System.Drawing.Point(2, 300);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(152, 77);
            this.open_btn.TabIndex = 0;
            this.open_btn.Text = "Otwórz COM";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.otworzCom_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reset_btn.Location = new System.Drawing.Point(319, 300);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(152, 77);
            this.reset_btn.TabIndex = 1;
            this.reset_btn.Text = "Zresetuj";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // zamknijCOM_btn
            // 
            this.zamknijCOM_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zamknijCOM_btn.Location = new System.Drawing.Point(160, 300);
            this.zamknijCOM_btn.Name = "zamknijCOM_btn";
            this.zamknijCOM_btn.Size = new System.Drawing.Size(152, 77);
            this.zamknijCOM_btn.TabIndex = 2;
            this.zamknijCOM_btn.Text = "Zamknij COM";
            this.zamknijCOM_btn.UseVisualStyleBackColor = true;
            this.zamknijCOM_btn.Click += new System.EventHandler(this.zamknijCOM_btn_Click);
            // 
            // portyCOM
            // 
            this.portyCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portyCOM.FormattingEnabled = true;
            this.portyCOM.Location = new System.Drawing.Point(176, 10);
            this.portyCOM.Name = "portyCOM";
            this.portyCOM.Size = new System.Drawing.Size(295, 33);
            this.portyCOM.TabIndex = 4;
            this.portyCOM.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dostępne porty";
            // 
            // fec_btn
            // 
            this.fec_btn.AutoSize = true;
            this.fec_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fec_btn.Location = new System.Drawing.Point(396, 176);
            this.fec_btn.Name = "fec_btn";
            this.fec_btn.Size = new System.Drawing.Size(73, 29);
            this.fec_btn.TabIndex = 6;
            this.fec_btn.Text = "FEC";
            this.fec_btn.UseVisualStyleBackColor = true;
            this.fec_btn.CheckedChanged += new System.EventHandler(this.fec_btn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Typ połączenia";
            // 
            // phy_btn
            // 
            this.phy_btn.AutoSize = true;
            this.phy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phy_btn.Location = new System.Drawing.Point(177, 8);
            this.phy_btn.Name = "phy_btn";
            this.phy_btn.Size = new System.Drawing.Size(74, 29);
            this.phy_btn.TabIndex = 9;
            this.phy_btn.TabStop = true;
            this.phy_btn.Text = "PHY";
            this.phy_btn.UseVisualStyleBackColor = true;
            this.phy_btn.CheckedChanged += new System.EventHandler(this.phy_btn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Modulacja";
            // 
            // b_psk_btn
            // 
            this.b_psk_btn.AutoSize = true;
            this.b_psk_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_psk_btn.Location = new System.Drawing.Point(23, 11);
            this.b_psk_btn.Name = "b_psk_btn";
            this.b_psk_btn.Size = new System.Drawing.Size(93, 29);
            this.b_psk_btn.TabIndex = 11;
            this.b_psk_btn.TabStop = true;
            this.b_psk_btn.Text = "B-PSK";
            this.b_psk_btn.UseVisualStyleBackColor = true;
            this.b_psk_btn.CheckedChanged += new System.EventHandler(this.b_psk_btn_CheckedChanged);
            // 
            // q_psk_btn
            // 
            this.q_psk_btn.AutoSize = true;
            this.q_psk_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.q_psk_btn.Location = new System.Drawing.Point(125, 11);
            this.q_psk_btn.Name = "q_psk_btn";
            this.q_psk_btn.Size = new System.Drawing.Size(95, 29);
            this.q_psk_btn.TabIndex = 12;
            this.q_psk_btn.TabStop = true;
            this.q_psk_btn.Text = "Q-PSK";
            this.q_psk_btn.UseVisualStyleBackColor = true;
            this.q_psk_btn.CheckedChanged += new System.EventHandler(this.q_psk_btn_CheckedChanged);
            // 
            // psk_8_btn
            // 
            this.psk_8_btn.AutoSize = true;
            this.psk_8_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.psk_8_btn.Location = new System.Drawing.Point(225, 9);
            this.psk_8_btn.Name = "psk_8_btn";
            this.psk_8_btn.Size = new System.Drawing.Size(91, 29);
            this.psk_8_btn.TabIndex = 13;
            this.psk_8_btn.TabStop = true;
            this.psk_8_btn.Text = "8-PSK";
            this.psk_8_btn.UseVisualStyleBackColor = true;
            this.psk_8_btn.CheckedChanged += new System.EventHandler(this.psk_8_btn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Korekcja błędów z wyprzedzeniem";
            // 
            // nadaj_asci
            // 
            this.nadaj_asci.Location = new System.Drawing.Point(499, 19);
            this.nadaj_asci.Name = "nadaj_asci";
            this.nadaj_asci.Size = new System.Drawing.Size(289, 132);
            this.nadaj_asci.TabIndex = 15;
            this.nadaj_asci.Text = "";
            this.nadaj_asci.TextChanged += new System.EventHandler(this.nadaj_asci_TextChanged);
            // 
            // nadaj_hex
            // 
            this.nadaj_hex.Location = new System.Drawing.Point(499, 177);
            this.nadaj_hex.Name = "nadaj_hex";
            this.nadaj_hex.Size = new System.Drawing.Size(289, 117);
            this.nadaj_hex.TabIndex = 16;
            this.nadaj_hex.Text = "";
            // 
            // odbior
            // 
            this.odbior.Location = new System.Drawing.Point(12, 223);
            this.odbior.Name = "odbior";
            this.odbior.Size = new System.Drawing.Size(466, 71);
            this.odbior.TabIndex = 18;
            this.odbior.Text = "";
            // 
            // modulacja_box
            // 
            this.modulacja_box.Controls.Add(this.psk_8_btn);
            this.modulacja_box.Controls.Add(this.q_psk_btn);
            this.modulacja_box.Controls.Add(this.b_psk_btn);
            this.modulacja_box.Location = new System.Drawing.Point(153, 111);
            this.modulacja_box.Name = "modulacja_box";
            this.modulacja_box.Size = new System.Drawing.Size(317, 59);
            this.modulacja_box.TabIndex = 19;
            this.modulacja_box.TabStop = false;
            // 
            // dl_btn
            // 
            this.dl_btn.AutoSize = true;
            this.dl_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dl_btn.Location = new System.Drawing.Point(63, 8);
            this.dl_btn.Name = "dl_btn";
            this.dl_btn.Size = new System.Drawing.Size(57, 29);
            this.dl_btn.TabIndex = 7;
            this.dl_btn.TabStop = true;
            this.dl_btn.Text = "DL";
            this.dl_btn.UseVisualStyleBackColor = true;
            this.dl_btn.CheckedChanged += new System.EventHandler(this.dl_btn_CheckedChanged);
            // 
            // polaczenie_box
            // 
            this.polaczenie_box.Controls.Add(this.dl_btn);
            this.polaczenie_box.Controls.Add(this.phy_btn);
            this.polaczenie_box.Location = new System.Drawing.Point(176, 52);
            this.polaczenie_box.Name = "polaczenie_box";
            this.polaczenie_box.Size = new System.Drawing.Size(293, 53);
            this.polaczenie_box.TabIndex = 20;
            this.polaczenie_box.TabStop = false;
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear_btn.Location = new System.Drawing.Point(477, 300);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(152, 77);
            this.clear_btn.TabIndex = 21;
            this.clear_btn.Text = "Wyczyść";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.wyczysc_btn_Click);
            // 
            // ascii_text
            // 
            this.ascii_text.AutoSize = true;
            this.ascii_text.Location = new System.Drawing.Point(496, 3);
            this.ascii_text.Name = "ascii_text";
            this.ascii_text.Size = new System.Drawing.Size(34, 13);
            this.ascii_text.TabIndex = 22;
            this.ascii_text.Text = "ASCII";
            // 
            // hex_text
            // 
            this.hex_text.AutoSize = true;
            this.hex_text.Location = new System.Drawing.Point(496, 161);
            this.hex_text.Name = "hex_text";
            this.hex_text.Size = new System.Drawing.Size(83, 13);
            this.hex_text.TabIndex = 23;
            this.hex_text.Text = "HEXADECIMAL";
            // 
            // odbior_text
            // 
            this.odbior_text.AutoSize = true;
            this.odbior_text.Location = new System.Drawing.Point(14, 207);
            this.odbior_text.Name = "odbior_text";
            this.odbior_text.Size = new System.Drawing.Size(49, 13);
            this.odbior_text.TabIndex = 24;
            this.odbior_text.Text = "ODBIÓR";
            // 
            // wyslij_btn
            // 
            this.wyslij_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyslij_btn.Location = new System.Drawing.Point(635, 300);
            this.wyslij_btn.Name = "wyslij_btn";
            this.wyslij_btn.Size = new System.Drawing.Size(152, 77);
            this.wyslij_btn.TabIndex = 25;
            this.wyslij_btn.Text = "Wyślij";
            this.wyslij_btn.UseVisualStyleBackColor = true;
            this.wyslij_btn.Click += new System.EventHandler(this.wyslij_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wyslij_btn);
            this.Controls.Add(this.odbior_text);
            this.Controls.Add(this.hex_text);
            this.Controls.Add(this.ascii_text);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.modulacja_box);
            this.Controls.Add(this.odbior);
            this.Controls.Add(this.nadaj_hex);
            this.Controls.Add(this.nadaj_asci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fec_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portyCOM);
            this.Controls.Add(this.zamknijCOM_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.polaczenie_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.modulacja_box.ResumeLayout(false);
            this.modulacja_box.PerformLayout();
            this.polaczenie_box.ResumeLayout(false);
            this.polaczenie_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button zamknijCOM_btn;
        private System.Windows.Forms.ComboBox portyCOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox fec_btn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton phy_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton b_psk_btn;
        private System.Windows.Forms.RadioButton q_psk_btn;
        private System.Windows.Forms.RadioButton psk_8_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox nadaj_asci;
        private System.Windows.Forms.RichTextBox nadaj_hex;
        private System.Windows.Forms.RichTextBox odbior;
        private System.Windows.Forms.GroupBox modulacja_box;
        private System.Windows.Forms.RadioButton dl_btn;
        private System.Windows.Forms.GroupBox polaczenie_box;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button wyslij_btn;
        private System.Windows.Forms.Label ascii_text;
        private System.Windows.Forms.Label hex_text;
        private System.Windows.Forms.Label odbior_text;

    }
}

