namespace Programa
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
            richTextBox1 = new RichTextBox();
            buttonRefresh = new Button();
            textBoxID = new TextBox();
            textBoxNombre = new TextBox();
            textBoxEquipo = new TextBox();
            textBoxPuntos = new TextBox();
            buttonAgregar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonModificar = new Button();
            textBoxModId = new TextBox();
            textBoxModNom = new TextBox();
            textBoxModEqpo = new TextBox();
            textBoxModPts = new TextBox();
            textBoxEliminar = new TextBox();
            buttonEliminar = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(221, 371);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(68, 389);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(111, 49);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(48, 44);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "ID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 2;
            textBoxID.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(48, 78);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 3;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxEquipo
            // 
            textBoxEquipo.Location = new Point(48, 112);
            textBoxEquipo.Name = "textBoxEquipo";
            textBoxEquipo.PlaceholderText = "Equipo";
            textBoxEquipo.Size = new Size(100, 23);
            textBoxEquipo.TabIndex = 4;
            textBoxEquipo.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPuntos
            // 
            textBoxPuntos.Location = new Point(48, 146);
            textBoxPuntos.Name = "textBoxPuntos";
            textBoxPuntos.PlaceholderText = "Puntos";
            textBoxPuntos.Size = new Size(100, 23);
            textBoxPuntos.TabIndex = 5;
            textBoxPuntos.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(59, 180);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(textBoxID);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(textBoxEquipo);
            panel1.Controls.Add(textBoxPuntos);
            panel1.Location = new Point(326, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 253);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(buttonModificar);
            panel2.Controls.Add(textBoxModId);
            panel2.Controls.Add(textBoxModNom);
            panel2.Controls.Add(textBoxModEqpo);
            panel2.Controls.Add(textBoxModPts);
            panel2.Location = new Point(559, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 253);
            panel2.TabIndex = 8;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(59, 179);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 6;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textBoxModId
            // 
            textBoxModId.Location = new Point(48, 43);
            textBoxModId.Name = "textBoxModId";
            textBoxModId.PlaceholderText = "ID";
            textBoxModId.Size = new Size(100, 23);
            textBoxModId.TabIndex = 2;
            textBoxModId.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxModNom
            // 
            textBoxModNom.Location = new Point(48, 78);
            textBoxModNom.Name = "textBoxModNom";
            textBoxModNom.PlaceholderText = "Nombre";
            textBoxModNom.Size = new Size(100, 23);
            textBoxModNom.TabIndex = 3;
            textBoxModNom.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxModEqpo
            // 
            textBoxModEqpo.Location = new Point(48, 111);
            textBoxModEqpo.Name = "textBoxModEqpo";
            textBoxModEqpo.PlaceholderText = "Equipo";
            textBoxModEqpo.Size = new Size(100, 23);
            textBoxModEqpo.TabIndex = 4;
            textBoxModEqpo.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxModPts
            // 
            textBoxModPts.Location = new Point(48, 146);
            textBoxModPts.Name = "textBoxModPts";
            textBoxModPts.PlaceholderText = "Puntos";
            textBoxModPts.Size = new Size(100, 23);
            textBoxModPts.TabIndex = 5;
            textBoxModPts.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxEliminar
            // 
            textBoxEliminar.Location = new Point(10, 10);
            textBoxEliminar.Name = "textBoxEliminar";
            textBoxEliminar.PlaceholderText = "ID";
            textBoxEliminar.Size = new Size(100, 23);
            textBoxEliminar.TabIndex = 7;
            textBoxEliminar.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(133, 10);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 7;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(buttonEliminar);
            panel3.Controls.Add(textBoxEliminar);
            panel3.Location = new Point(420, 341);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 42);
            panel3.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(buttonRefresh);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button buttonRefresh;
        private TextBox textBoxID;
        private TextBox textBoxNombre;
        private TextBox textBoxEquipo;
        private TextBox textBoxPuntos;
        private Button buttonAgregar;
        private Panel panel1;
        private Panel panel2;
        private Button buttonModificar;
        private TextBox textBoxModId;
        private TextBox textBoxModNom;
        private TextBox textBoxModEqpo;
        private TextBox textBoxModPts;
        private TextBox textBoxEliminar;
        private Button buttonEliminar;
        private Panel panel3;
    }
}
