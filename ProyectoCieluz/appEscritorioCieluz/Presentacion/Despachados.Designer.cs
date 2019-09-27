namespace appEscritorioCieluz
{
    partial class Despachados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDespachados = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEnviarCL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtTipoPago = new System.Windows.Forms.TextBox();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespachados)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvDespachados);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 539);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // dgvDespachados
            // 
            this.dgvDespachados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvDespachados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespachados.Location = new System.Drawing.Point(45, 46);
            this.dgvDespachados.Name = "dgvDespachados";
            this.dgvDespachados.ReadOnly = true;
            this.dgvDespachados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespachados.Size = new System.Drawing.Size(596, 465);
            this.dgvDespachados.TabIndex = 3;
            this.dgvDespachados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDespachados_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.txtEstado);
            this.panel3.Controls.Add(this.txtIdProducto);
            this.panel3.Controls.Add(this.txtIdCliente);
            this.panel3.Controls.Add(this.txtTipoPago);
            this.panel3.Controls.Add(this.txtPrecioTotal);
            this.panel3.Controls.Add(this.txtTalla);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.pbxImagen);
            this.panel3.Controls.Add(this.lblIdProducto);
            this.panel3.Controls.Add(this.lblIdCliente);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btnEnviarCL);
            this.panel3.Location = new System.Drawing.Point(648, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 465);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(59, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Enviar a Entregados:";
            // 
            // btnEnviarCL
            // 
            this.btnEnviarCL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCL.Location = new System.Drawing.Point(245, 422);
            this.btnEnviarCL.Name = "btnEnviarCL";
            this.btnEnviarCL.Size = new System.Drawing.Size(98, 32);
            this.btnEnviarCL.TabIndex = 18;
            this.btnEnviarCL.Text = "Enviar";
            this.btnEnviarCL.UseVisualStyleBackColor = true;
            this.btnEnviarCL.Click += new System.EventHandler(this.btnEnviarCL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado Despachados";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(237, 325);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 94;
            this.txtEstado.Text = "Entregados";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(237, 387);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 93;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(237, 351);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 92;
            // 
            // txtTipoPago
            // 
            this.txtTipoPago.Location = new System.Drawing.Point(237, 291);
            this.txtTipoPago.Name = "txtTipoPago";
            this.txtTipoPago.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPago.TabIndex = 91;
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Location = new System.Drawing.Point(237, 256);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioTotal.TabIndex = 90;
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(237, 230);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(100, 20);
            this.txtTalla.TabIndex = 89;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(237, 200);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 88;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(22, 13);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(131, 114);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxImagen.TabIndex = 87;
            this.pbxImagen.TabStop = false;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.ForeColor = System.Drawing.Color.White;
            this.lblIdProducto.Location = new System.Drawing.Point(96, 386);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(98, 21);
            this.lblIdProducto.TabIndex = 86;
            this.lblIdProducto.Text = "IdProducto";
            this.lblIdProducto.Visible = false;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.ForeColor = System.Drawing.Color.White;
            this.lblIdCliente.Location = new System.Drawing.Point(96, 352);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(82, 21);
            this.lblIdCliente.TabIndex = 85;
            this.lblIdCliente.Text = "IdCliente";
            this.lblIdCliente.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(103, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 84;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 83;
            this.label2.Text = "Tipo Pago:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(96, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 82;
            this.label11.Text = "Precio Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(103, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 21);
            this.label10.TabIndex = 81;
            this.label10.Text = "Talla:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(98, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 80;
            this.label9.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(146, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 22);
            this.label8.TabIndex = 79;
            this.label8.Text = "Datos Pedido";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(14, 431);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(39, 20);
            this.txtId.TabIndex = 95;
            // 
            // Despachados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 541);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Despachados";
            this.Text = "Despachados";
            this.Load += new System.EventHandler(this.Despachados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespachados)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEnviarCL;
        private System.Windows.Forms.DataGridView dgvDespachados;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtTipoPago;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
    }
}