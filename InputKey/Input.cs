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
* Write me, I'll reply you.
* <carlos_programmer10@hotmail.com>
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cmsoft.com.inputWindow
{
    internal partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adjusts the objects on window.
        /// </summary>
        public void Adjust()
        {
            if (this.lblMensaje.Width > this.Width - 40)
            {
                this.Width = this.lblMensaje.Width + 110;
            }

            if (this.lblMensaje.Height > 65)
            {
                this.Height = this.lblMensaje.Height + 110;
            }
        }

        /// <summary>
        /// Action of button cancel.
        /// </summary>
        public void cancelButton()
        {

            System.Windows.Forms.Button btnCancelar = new System.Windows.Forms.Button();

            btnCancelar.Text = "Cancelar";
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.Location = new System.Drawing.Point(65, 115);
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.Location = new System.Drawing.Point(161, 115);
            btnCancelar.UseVisualStyleBackColor = true;
            this.Controls.Add(btnCancelar);

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
