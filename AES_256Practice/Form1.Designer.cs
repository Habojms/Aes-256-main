namespace AES_256Practice
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPlane = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResEn = new System.Windows.Forms.TextBox();
            this.txtSixteen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSeven = new System.Windows.Forms.TextBox();
            this.btGen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbResPlane = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEn = new System.Windows.Forms.TextBox();
            this.btngeneral = new System.Windows.Forms.Button();
            this.btncomparar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbPlane
            // 
            this.tbPlane.Location = new System.Drawing.Point(76, 228);
            this.tbPlane.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlane.Multiline = true;
            this.tbPlane.Name = "tbPlane";
            this.tbPlane.Size = new System.Drawing.Size(352, 224);
            this.tbPlane.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto Plano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto Encriptado";
            // 
            // tbResEn
            // 
            this.tbResEn.Location = new System.Drawing.Point(573, 228);
            this.tbResEn.Margin = new System.Windows.Forms.Padding(4);
            this.tbResEn.Multiline = true;
            this.tbResEn.Name = "tbResEn";
            this.tbResEn.ReadOnly = true;
            this.tbResEn.Size = new System.Drawing.Size(352, 224);
            this.tbResEn.TabIndex = 2;
            // 
            // txtSixteen
            // 
            this.txtSixteen.Location = new System.Drawing.Point(77, 92);
            this.txtSixteen.Margin = new System.Windows.Forms.Padding(4);
            this.txtSixteen.Name = "txtSixteen";
            this.txtSixteen.Size = new System.Drawing.Size(351, 22);
            this.txtSixteen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Llave IV -16 caracteres";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Llave -32 caracteres";
            // 
            // txtSeven
            // 
            this.txtSeven.Location = new System.Drawing.Point(588, 92);
            this.txtSeven.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeven.Name = "txtSeven";
            this.txtSeven.Size = new System.Drawing.Size(337, 22);
            this.txtSeven.TabIndex = 6;
            // 
            // btGen
            // 
            this.btGen.Location = new System.Drawing.Point(451, 156);
            this.btGen.Margin = new System.Windows.Forms.Padding(4);
            this.btGen.Name = "btGen";
            this.btGen.Size = new System.Drawing.Size(100, 28);
            this.btGen.TabIndex = 8;
            this.btGen.Text = "Generar";
            this.btGen.UseVisualStyleBackColor = true;
            this.btGen.Click += new System.EventHandler(this.btGen_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 484);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Encriptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 788);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Desencriptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 512);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Texto Encriptado";
            // 
            // tbResPlane
            // 
            this.tbResPlane.Location = new System.Drawing.Point(573, 532);
            this.tbResPlane.Margin = new System.Windows.Forms.Padding(4);
            this.tbResPlane.Multiline = true;
            this.tbResPlane.Name = "tbResPlane";
            this.tbResPlane.ReadOnly = true;
            this.tbResPlane.Size = new System.Drawing.Size(352, 224);
            this.tbResPlane.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 512);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Texto Plano";
            // 
            // tbEn
            // 
            this.tbEn.Location = new System.Drawing.Point(76, 532);
            this.tbEn.Margin = new System.Windows.Forms.Padding(4);
            this.tbEn.Multiline = true;
            this.tbEn.Name = "tbEn";
            this.tbEn.Size = new System.Drawing.Size(352, 224);
            this.tbEn.TabIndex = 10;
            // 
            // btngeneral
            // 
            this.btngeneral.Location = new System.Drawing.Point(995, 181);
            this.btngeneral.Name = "btngeneral";
            this.btngeneral.Size = new System.Drawing.Size(121, 27);
            this.btngeneral.TabIndex = 15;
            this.btngeneral.Text = "Genral archivo";
            this.btngeneral.UseVisualStyleBackColor = true;
            this.btngeneral.Click += new System.EventHandler(this.btngeneral_Click);
            // 
            // btncomparar
            // 
            this.btncomparar.Location = new System.Drawing.Point(995, 475);
            this.btncomparar.Name = "btncomparar";
            this.btncomparar.Size = new System.Drawing.Size(120, 28);
            this.btncomparar.TabIndex = 16;
            this.btncomparar.Text = "Comparacion";
            this.btncomparar.UseVisualStyleBackColor = true;
            this.btncomparar.Click += new System.EventHandler(this.btncomparar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 841);
            this.Controls.Add(this.btncomparar);
            this.Controls.Add(this.btngeneral);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbResPlane);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btGen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSeven);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSixteen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbResEn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPlane);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "AES-256";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResEn;
        private System.Windows.Forms.TextBox txtSixteen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSeven;
        private System.Windows.Forms.Button btGen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbResPlane;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEn;
        private System.Windows.Forms.Button btngeneral;
        private System.Windows.Forms.Button btncomparar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

