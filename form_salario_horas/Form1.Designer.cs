namespace form_salario_horas
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
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pago_por_hora = new System.Windows.Forms.TextBox();
            this.txt_afp = new System.Windows.Forms.TextBox();
            this.txt_sfs = new System.Windows.Forms.TextBox();
            this.txt_isr = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_horas_trabajadas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sueldo_anual = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_sueldo_bruto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_total_des = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(495, 136);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(126, 47);
            this.btn_Calcular.TabIndex = 0;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(495, 235);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(126, 42);
            this.btn_Limpiar.TabIndex = 1;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(495, 332);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(126, 41);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculo del salario por hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "pago por hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "AFP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "SFS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "ISR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Status";
            // 
            // txt_pago_por_hora
            // 
            this.txt_pago_por_hora.Location = new System.Drawing.Point(260, 118);
            this.txt_pago_por_hora.Name = "txt_pago_por_hora";
            this.txt_pago_por_hora.Size = new System.Drawing.Size(138, 22);
            this.txt_pago_por_hora.TabIndex = 9;
            // 
            // txt_afp
            // 
            this.txt_afp.Location = new System.Drawing.Point(260, 276);
            this.txt_afp.Name = "txt_afp";
            this.txt_afp.Size = new System.Drawing.Size(138, 22);
            this.txt_afp.TabIndex = 10;
            // 
            // txt_sfs
            // 
            this.txt_sfs.Location = new System.Drawing.Point(260, 327);
            this.txt_sfs.Name = "txt_sfs";
            this.txt_sfs.Size = new System.Drawing.Size(138, 22);
            this.txt_sfs.TabIndex = 11;
            // 
            // txt_isr
            // 
            this.txt_isr.Location = new System.Drawing.Point(260, 380);
            this.txt_isr.Name = "txt_isr";
            this.txt_isr.Size = new System.Drawing.Size(138, 22);
            this.txt_isr.TabIndex = 12;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(260, 513);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(138, 22);
            this.txt_status.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Horas trabajadas";
            // 
            // txt_horas_trabajadas
            // 
            this.txt_horas_trabajadas.Location = new System.Drawing.Point(260, 172);
            this.txt_horas_trabajadas.Name = "txt_horas_trabajadas";
            this.txt_horas_trabajadas.Size = new System.Drawing.Size(138, 22);
            this.txt_horas_trabajadas.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sueldo neto";
            // 
            // txt_sueldo_anual
            // 
            this.txt_sueldo_anual.Location = new System.Drawing.Point(260, 470);
            this.txt_sueldo_anual.Name = "txt_sueldo_anual";
            this.txt_sueldo_anual.Size = new System.Drawing.Size(138, 22);
            this.txt_sueldo_anual.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sueldo bruto";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_sueldo_bruto
            // 
            this.txt_sueldo_bruto.Location = new System.Drawing.Point(260, 219);
            this.txt_sueldo_bruto.Name = "txt_sueldo_bruto";
            this.txt_sueldo_bruto.Size = new System.Drawing.Size(138, 22);
            this.txt_sueldo_bruto.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total descuento";
            // 
            // txt_total_des
            // 
            this.txt_total_des.Location = new System.Drawing.Point(260, 430);
            this.txt_total_des.Name = "txt_total_des";
            this.txt_total_des.Size = new System.Drawing.Size(138, 22);
            this.txt_total_des.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.txt_total_des);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_sueldo_bruto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_sueldo_anual);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_horas_trabajadas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_isr);
            this.Controls.Add(this.txt_sfs);
            this.Controls.Add(this.txt_afp);
            this.Controls.Add(this.txt_pago_por_hora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pago_por_hora;
        private System.Windows.Forms.TextBox txt_afp;
        private System.Windows.Forms.TextBox txt_sfs;
        private System.Windows.Forms.TextBox txt_isr;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_horas_trabajadas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sueldo_anual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_sueldo_bruto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_total_des;
    }
}

