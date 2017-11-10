namespace PrototipoSeguridad
{
    partial class AsigUsuarioPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsigUsuarioPerfil));
            this.Dgv_perfil = new System.Windows.Forms.DataGridView();
            this.Cmb_usuario = new System.Windows.Forms.ComboBox();
            this.Cmb_id = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_edit = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_removerTodo = new System.Windows.Forms.Button();
            this.Btn_remover = new System.Windows.Forms.Button();
            this.Btn_agregarTodo = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Dgv_asignacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_perfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_perfil
            // 
            this.Dgv_perfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_perfil.Location = new System.Drawing.Point(45, 145);
            this.Dgv_perfil.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_perfil.Name = "Dgv_perfil";
            this.Dgv_perfil.Size = new System.Drawing.Size(318, 315);
            this.Dgv_perfil.TabIndex = 13;
            this.Dgv_perfil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_perfil_CellClick);
            this.Dgv_perfil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_perfil_CellContentClick);
            // 
            // Cmb_usuario
            // 
            this.Cmb_usuario.FormattingEnabled = true;
            this.Cmb_usuario.Location = new System.Drawing.Point(327, 45);
            this.Cmb_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_usuario.Name = "Cmb_usuario";
            this.Cmb_usuario.Size = new System.Drawing.Size(341, 24);
            this.Cmb_usuario.TabIndex = 12;
            // 
            // Cmb_id
            // 
            this.Cmb_id.FormattingEnabled = true;
            this.Cmb_id.Location = new System.Drawing.Point(99, 45);
            this.Cmb_id.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_id.Name = "Cmb_id";
            this.Cmb_id.Size = new System.Drawing.Size(107, 24);
            this.Cmb_id.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Usuario";
            // 
            // Btn_edit
            // 
            this.Btn_edit.FlatAppearance.BorderSize = 0;
            this.Btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_edit.Image")));
            this.Btn_edit.Location = new System.Drawing.Point(464, 449);
            this.Btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_edit.Name = "Btn_edit";
            this.Btn_edit.Size = new System.Drawing.Size(87, 80);
            this.Btn_edit.TabIndex = 30;
            this.Btn_edit.UseVisualStyleBackColor = true;
            this.Btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.FlatAppearance.BorderSize = 0;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.Location = new System.Drawing.Point(609, 458);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(85, 71);
            this.Btn_borrar.TabIndex = 29;
            this.Btn_borrar.UseVisualStyleBackColor = true;
            // 
            // Btn_removerTodo
            // 
            this.Btn_removerTodo.BackgroundImage = global::PrototipoSeguridad.Properties.Resources._22264625_1723360751031984_1344209642_n;
            this.Btn_removerTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_removerTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_removerTodo.Location = new System.Drawing.Point(467, 391);
            this.Btn_removerTodo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_removerTodo.Name = "Btn_removerTodo";
            this.Btn_removerTodo.Size = new System.Drawing.Size(67, 53);
            this.Btn_removerTodo.TabIndex = 28;
            this.Btn_removerTodo.UseVisualStyleBackColor = true;
            this.Btn_removerTodo.Click += new System.EventHandler(this.Btn_removerTodo_Click);
            // 
            // Btn_remover
            // 
            this.Btn_remover.BackgroundImage = global::PrototipoSeguridad.Properties.Resources._22264596_1723360747698651_173196365_n;
            this.Btn_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_remover.Location = new System.Drawing.Point(467, 325);
            this.Btn_remover.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_remover.Name = "Btn_remover";
            this.Btn_remover.Size = new System.Drawing.Size(67, 41);
            this.Btn_remover.TabIndex = 27;
            this.Btn_remover.UseVisualStyleBackColor = true;
            this.Btn_remover.Click += new System.EventHandler(this.Btn_remover_Click);
            // 
            // Btn_agregarTodo
            // 
            this.Btn_agregarTodo.BackgroundImage = global::PrototipoSeguridad.Properties.Resources._22264602_1723360754365317_1757528147_n;
            this.Btn_agregarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_agregarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_agregarTodo.Location = new System.Drawing.Point(467, 204);
            this.Btn_agregarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_agregarTodo.Name = "Btn_agregarTodo";
            this.Btn_agregarTodo.Size = new System.Drawing.Size(67, 53);
            this.Btn_agregarTodo.TabIndex = 26;
            this.Btn_agregarTodo.UseVisualStyleBackColor = true;
            this.Btn_agregarTodo.Click += new System.EventHandler(this.Btn_agregarTodo_Click);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackgroundImage = global::PrototipoSeguridad.Properties.Resources._22236267_1723360744365318_2094413666_n;
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_agregar.Location = new System.Drawing.Point(467, 155);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(67, 41);
            this.Btn_agregar.TabIndex = 25;
            this.Btn_agregar.UseVisualStyleBackColor = true;
            // 
            // Dgv_asignacion
            // 
            this.Dgv_asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignacion.Location = new System.Drawing.Point(659, 135);
            this.Dgv_asignacion.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_asignacion.Name = "Dgv_asignacion";
            this.Dgv_asignacion.Size = new System.Drawing.Size(318, 315);
            this.Dgv_asignacion.TabIndex = 31;
            // 
            // AsigUsuarioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 538);
            this.Controls.Add(this.Dgv_asignacion);
            this.Controls.Add(this.Btn_edit);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_removerTodo);
            this.Controls.Add(this.Btn_remover);
            this.Controls.Add(this.Btn_agregarTodo);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_perfil);
            this.Controls.Add(this.Cmb_usuario);
            this.Controls.Add(this.Cmb_id);
            this.Name = "AsigUsuarioPerfil";
            this.Text = "AsigUsuarioPerfil";
            this.Load += new System.EventHandler(this.AsigUsuarioPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_perfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_perfil;
        private System.Windows.Forms.ComboBox Cmb_usuario;
        private System.Windows.Forms.ComboBox Cmb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_edit;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_removerTodo;
        private System.Windows.Forms.Button Btn_remover;
        private System.Windows.Forms.Button Btn_agregarTodo;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.DataGridView Dgv_asignacion;
    }
}