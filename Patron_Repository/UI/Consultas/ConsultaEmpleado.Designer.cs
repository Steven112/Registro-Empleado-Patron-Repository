namespace Patron_Repository.UI.Consultas
{
    partial class ConsultaEmpleado
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
            this.Criterio1label = new System.Windows.Forms.Label();
            this.Filtroqlabel = new System.Windows.Forms.Label();
            this.Hastaalabel = new System.Windows.Forms.Label();
            this.EstDesdelabel = new System.Windows.Forms.Label();
            this.MydataGridView = new System.Windows.Forms.DataGridView();
            this.EstCriteriotextBox = new System.Windows.Forms.TextBox();
            this.ESTfiltro = new System.Windows.Forms.ComboBox();
            this.HastadataTimer = new System.Windows.Forms.DateTimePicker();
            this.DesdeTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EstBuscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Criterio1label
            // 
            this.Criterio1label.AutoSize = true;
            this.Criterio1label.Location = new System.Drawing.Point(552, 10);
            this.Criterio1label.Name = "Criterio1label";
            this.Criterio1label.Size = new System.Drawing.Size(39, 13);
            this.Criterio1label.TabIndex = 18;
            this.Criterio1label.Text = "Criterio";
            // 
            // Filtroqlabel
            // 
            this.Filtroqlabel.AutoSize = true;
            this.Filtroqlabel.Location = new System.Drawing.Point(423, 10);
            this.Filtroqlabel.Name = "Filtroqlabel";
            this.Filtroqlabel.Size = new System.Drawing.Size(29, 13);
            this.Filtroqlabel.TabIndex = 17;
            this.Filtroqlabel.Text = "Filtro";
            // 
            // Hastaalabel
            // 
            this.Hastaalabel.AutoSize = true;
            this.Hastaalabel.Location = new System.Drawing.Point(217, 10);
            this.Hastaalabel.Name = "Hastaalabel";
            this.Hastaalabel.Size = new System.Drawing.Size(35, 13);
            this.Hastaalabel.TabIndex = 16;
            this.Hastaalabel.Text = "Hasta";
            // 
            // EstDesdelabel
            // 
            this.EstDesdelabel.AutoSize = true;
            this.EstDesdelabel.Location = new System.Drawing.Point(11, 10);
            this.EstDesdelabel.Name = "EstDesdelabel";
            this.EstDesdelabel.Size = new System.Drawing.Size(38, 13);
            this.EstDesdelabel.TabIndex = 15;
            this.EstDesdelabel.Text = "Desde";
            // 
            // MydataGridView
            // 
            this.MydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MydataGridView.Location = new System.Drawing.Point(14, 63);
            this.MydataGridView.Name = "MydataGridView";
            this.MydataGridView.Size = new System.Drawing.Size(776, 377);
            this.MydataGridView.TabIndex = 14;
            // 
            // EstCriteriotextBox
            // 
            this.EstCriteriotextBox.Location = new System.Drawing.Point(555, 34);
            this.EstCriteriotextBox.Name = "EstCriteriotextBox";
            this.EstCriteriotextBox.Size = new System.Drawing.Size(152, 20);
            this.EstCriteriotextBox.TabIndex = 13;
            // 
            // ESTfiltro
            // 
            this.ESTfiltro.FormattingEnabled = true;
            this.ESTfiltro.Items.AddRange(new object[] {
            "Todo",
            "ID",
            "Matricula",
            "Nombre"});
            this.ESTfiltro.Location = new System.Drawing.Point(426, 34);
            this.ESTfiltro.Name = "ESTfiltro";
            this.ESTfiltro.Size = new System.Drawing.Size(122, 21);
            this.ESTfiltro.TabIndex = 12;
            // 
            // HastadataTimer
            // 
            this.HastadataTimer.Location = new System.Drawing.Point(220, 33);
            this.HastadataTimer.Name = "HastadataTimer";
            this.HastadataTimer.Size = new System.Drawing.Size(200, 20);
            this.HastadataTimer.TabIndex = 11;
            // 
            // DesdeTimePicker1
            // 
            this.DesdeTimePicker1.Location = new System.Drawing.Point(14, 33);
            this.DesdeTimePicker1.Name = "DesdeTimePicker1";
            this.DesdeTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.DesdeTimePicker1.TabIndex = 10;
            // 
            // EstBuscarbutton
            // 
            this.EstBuscarbutton.Image = global::Patron_Repository.Properties.Resources.icons8_borrar_búsqueda_241;
            this.EstBuscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EstBuscarbutton.Location = new System.Drawing.Point(713, 33);
            this.EstBuscarbutton.Name = "EstBuscarbutton";
            this.EstBuscarbutton.Size = new System.Drawing.Size(77, 23);
            this.EstBuscarbutton.TabIndex = 19;
            this.EstBuscarbutton.Text = "Buscar";
            this.EstBuscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EstBuscarbutton.UseVisualStyleBackColor = true;
            this.EstBuscarbutton.Click += new System.EventHandler(this.EstBuscarbutton_Click);
            // 
            // ConsultaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EstBuscarbutton);
            this.Controls.Add(this.Criterio1label);
            this.Controls.Add(this.Filtroqlabel);
            this.Controls.Add(this.Hastaalabel);
            this.Controls.Add(this.EstDesdelabel);
            this.Controls.Add(this.MydataGridView);
            this.Controls.Add(this.EstCriteriotextBox);
            this.Controls.Add(this.ESTfiltro);
            this.Controls.Add(this.HastadataTimer);
            this.Controls.Add(this.DesdeTimePicker1);
            this.Name = "ConsultaEmpleado";
            this.Text = "ConsultaEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EstBuscarbutton;
        private System.Windows.Forms.Label Criterio1label;
        private System.Windows.Forms.Label Filtroqlabel;
        private System.Windows.Forms.Label Hastaalabel;
        private System.Windows.Forms.Label EstDesdelabel;
        private System.Windows.Forms.DataGridView MydataGridView;
        private System.Windows.Forms.TextBox EstCriteriotextBox;
        private System.Windows.Forms.ComboBox ESTfiltro;
        private System.Windows.Forms.DateTimePicker HastadataTimer;
        private System.Windows.Forms.DateTimePicker DesdeTimePicker1;
    }
}