/*
* Copyright (c) Carlos Mario.
* Please, read the document linceseinfo.doc, to find information about license
* of this code
*
*
*
*
*
*
*
*
* 
* Write me, I reply you.
* <carlos_programmer10@hotmail.com>
*/

namespace cmsoft.com.inputWindow
{
    partial class Input
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.pbxIcono = new System.Windows.Forms.PictureBox();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(71, 13);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(11, 13);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = ".";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtInput.Location = new System.Drawing.Point(34, 89);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(246, 20);
            this.txtInput.TabIndex = 3;
            // 
            // pbxIcono
            // 
            this.pbxIcono.Image = global::cmsoft.Properties.Resources.information;
            this.pbxIcono.Location = new System.Drawing.Point(23, 13);
            this.pbxIcono.Name = "pbxIcono";
            this.pbxIcono.Size = new System.Drawing.Size(34, 31);
            this.pbxIcono.TabIndex = 0;
            this.pbxIcono.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(115, 115);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 147);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pbxIcono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Input";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblMensaje;
        internal System.Windows.Forms.TextBox txtInput;
        internal System.Windows.Forms.PictureBox pbxIcono;
        private System.Windows.Forms.Button btnAccept;





    }
}