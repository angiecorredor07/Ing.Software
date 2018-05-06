namespace SoftwareArboles
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.link_Cerrar = new System.Windows.Forms.LinkLabel();
            this.picEvaluacion = new System.Windows.Forms.PictureBox();
            this.picPractica = new System.Windows.Forms.PictureBox();
            this.picAprendizaje = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEvaluacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPractica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAprendizaje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Software Aprendizaje de Arboles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // link_Cerrar
            // 
            this.link_Cerrar.AutoSize = true;
            this.link_Cerrar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Cerrar.LinkColor = System.Drawing.Color.Black;
            this.link_Cerrar.Location = new System.Drawing.Point(582, 9);
            this.link_Cerrar.Name = "link_Cerrar";
            this.link_Cerrar.Size = new System.Drawing.Size(23, 23);
            this.link_Cerrar.TabIndex = 4;
            this.link_Cerrar.TabStop = true;
            this.link_Cerrar.Text = "X";
            this.link_Cerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Cerrar_LinkClicked);
            // 
            // picEvaluacion
            // 
            this.picEvaluacion.BackColor = System.Drawing.Color.LightCoral;
            this.picEvaluacion.BackgroundImage = global::SoftwareArboles.Properties.Resources.evaluacion;
            this.picEvaluacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEvaluacion.Location = new System.Drawing.Point(422, 101);
            this.picEvaluacion.Name = "picEvaluacion";
            this.picEvaluacion.Size = new System.Drawing.Size(166, 247);
            this.picEvaluacion.TabIndex = 3;
            this.picEvaluacion.TabStop = false;
            this.picEvaluacion.Click += new System.EventHandler(this.picEvaluacion_Click);
            // 
            // picPractica
            // 
            this.picPractica.BackColor = System.Drawing.Color.Goldenrod;
            this.picPractica.BackgroundImage = global::SoftwareArboles.Properties.Resources.practica;
            this.picPractica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPractica.Location = new System.Drawing.Point(237, 101);
            this.picPractica.Name = "picPractica";
            this.picPractica.Size = new System.Drawing.Size(164, 247);
            this.picPractica.TabIndex = 2;
            this.picPractica.TabStop = false;
            this.picPractica.Click += new System.EventHandler(this.picPractica_Click);
            // 
            // picAprendizaje
            // 
            this.picAprendizaje.BackColor = System.Drawing.Color.MediumAquamarine;
            this.picAprendizaje.BackgroundImage = global::SoftwareArboles.Properties.Resources.aprendizaje11;
            this.picAprendizaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAprendizaje.Location = new System.Drawing.Point(48, 101);
            this.picAprendizaje.Name = "picAprendizaje";
            this.picAprendizaje.Size = new System.Drawing.Size(164, 247);
            this.picAprendizaje.TabIndex = 1;
            this.picAprendizaje.TabStop = false;
            this.picAprendizaje.Click += new System.EventHandler(this.picAprendizaje_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(630, 369);
            this.Controls.Add(this.link_Cerrar);
            this.Controls.Add(this.picEvaluacion);
            this.Controls.Add(this.picPractica);
            this.Controls.Add(this.picAprendizaje);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.picEvaluacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPractica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAprendizaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAprendizaje;
        private System.Windows.Forms.PictureBox picPractica;
        private System.Windows.Forms.PictureBox picEvaluacion;
        private System.Windows.Forms.LinkLabel link_Cerrar;
    }
}