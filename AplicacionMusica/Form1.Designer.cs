namespace AplicacionMusica
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
            this.radioBtnId = new System.Windows.Forms.RadioButton();
            this.radioBtnNombre = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.desplegableAlbum = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtnId
            // 
            this.radioBtnId.AutoSize = true;
            this.radioBtnId.Location = new System.Drawing.Point(52, 41);
            this.radioBtnId.Name = "radioBtnId";
            this.radioBtnId.Size = new System.Drawing.Size(46, 28);
            this.radioBtnId.TabIndex = 1;
            this.radioBtnId.TabStop = true;
            this.radioBtnId.Text = "Id";
            this.radioBtnId.UseVisualStyleBackColor = true;
            this.radioBtnId.CheckedChanged += new System.EventHandler(this.radioBtnId_CheckedChanged);
            // 
            // radioBtnNombre
            // 
            this.radioBtnNombre.AutoSize = true;
            this.radioBtnNombre.Location = new System.Drawing.Point(52, 89);
            this.radioBtnNombre.Name = "radioBtnNombre";
            this.radioBtnNombre.Size = new System.Drawing.Size(100, 28);
            this.radioBtnNombre.TabIndex = 2;
            this.radioBtnNombre.TabStop = true;
            this.radioBtnNombre.Text = "Nombre";
            this.radioBtnNombre.UseVisualStyleBackColor = true;
            this.radioBtnNombre.CheckedChanged += new System.EventHandler(this.radioBtnNombre_CheckedChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(476, 60);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(93, 37);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Buscar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(205, 41);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(228, 28);
            this.txtBoxId.TabIndex = 4;
            this.txtBoxId.TextChanged += new System.EventHandler(this.txtBoxId_TextChanged);
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(205, 89);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(228, 28);
            this.txtBoxNombre.TabIndex = 5;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.txtBoxNombre_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxNombre);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.radioBtnId);
            this.groupBox1.Controls.Add(this.txtBoxId);
            this.groupBox1.Controls.Add(this.radioBtnNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 137);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca un artista:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Artista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione album:";
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(67, 279);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.RowTemplate.Height = 24;
            this.dataGridViewInfo.Size = new System.Drawing.Size(697, 184);
            this.dataGridViewInfo.TabIndex = 9;
            // 
            // desplegableAlbum
            // 
            this.desplegableAlbum.FormattingEnabled = true;
            this.desplegableAlbum.Location = new System.Drawing.Point(257, 214);
            this.desplegableAlbum.Name = "desplegableAlbum";
            this.desplegableAlbum.Size = new System.Drawing.Size(396, 24);
            this.desplegableAlbum.TabIndex = 10;
            this.desplegableAlbum.SelectedValueChanged += new System.EventHandler(this.desplegableAlbum_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.desplegableAlbum);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioBtnId;
        private System.Windows.Forms.RadioButton radioBtnNombre;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.ComboBox desplegableAlbum;
    }
}

