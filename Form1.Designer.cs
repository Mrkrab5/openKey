namespace openKey
{
    partial class Form1
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
            label1 = new Label();
            entryMassenge = new TextBox();
            label2 = new Label();
            choiseEncrypt = new ComboBox();
            itogEncrypt = new Label();
            encrypt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(280, 24);
            label1.Name = "label1";
            label1.Size = new Size(243, 27);
            label1.TabIndex = 0;
            label1.Text = "Что надо зашифровать";
            // 
            // entryMassenge
            // 
            entryMassenge.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            entryMassenge.Location = new Point(12, 66);
            entryMassenge.Name = "entryMassenge";
            entryMassenge.Size = new Size(776, 35);
            entryMassenge.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(284, 124);
            label2.Name = "label2";
            label2.Size = new Size(225, 27);
            label2.TabIndex = 2;
            label2.Text = "Способ шифрования";
            // 
            // choiseEncrypt
            // 
            choiseEncrypt.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            choiseEncrypt.FormattingEnabled = true;
            choiseEncrypt.Items.AddRange(new object[] { "Алгоритм RSA", "На основе задачи об укладке ранца", "Шифрование Эль-Гамаля" });
            choiseEncrypt.Location = new Point(221, 165);
            choiseEncrypt.Name = "choiseEncrypt";
            choiseEncrypt.Size = new Size(346, 35);
            choiseEncrypt.TabIndex = 3;
            choiseEncrypt.SelectedIndexChanged += choiseEncrypt_SelectedIndexChanged;
            // 
            // itogEncrypt
            // 
            itogEncrypt.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            itogEncrypt.Location = new Point(12, 214);
            itogEncrypt.Name = "itogEncrypt";
            itogEncrypt.Size = new Size(776, 124);
            itogEncrypt.TabIndex = 4;
            // 
            // encrypt
            // 
            encrypt.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            encrypt.Location = new Point(312, 390);
            encrypt.Name = "encrypt";
            encrypt.Size = new Size(153, 48);
            encrypt.TabIndex = 5;
            encrypt.Text = "Шифровать";
            encrypt.UseVisualStyleBackColor = true;
            encrypt.Click += encrypt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(encrypt);
            Controls.Add(itogEncrypt);
            Controls.Add(choiseEncrypt);
            Controls.Add(label2);
            Controls.Add(entryMassenge);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox entryMassenge;
        private Label label2;
        private ComboBox choiseEncrypt;
        private Label itogEncrypt;
        private Button encrypt;
    }
}