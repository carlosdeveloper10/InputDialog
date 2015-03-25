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
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cmsoft.com.inputWindow
{

    /// <summary>
    /// Windows with a petition
    /// </summary>
    public class InputDialog
    {
        /// <summary>
        /// The windows will has only the accept button.
        /// </summary>
        public static readonly int ACCEPT_BUTTON = 0;

        /// <summary>
        /// The windows will has accept and cancel buttons
        /// </summary>
        public static readonly int ACCEPT_CANCEL_BUTON = 1;

        /// <summary>
        /// The type message will be none
        /// </summary>
        public static readonly int NONE_MESSAGE = 0;

        /// <summary>
        /// The type message will be message error
        /// </summary>
        public static readonly int ERROR_MESSAGE = 1;

        /// <summary>
        /// Entero para mensaje tipo pregunta
        /// </summary>
        public static readonly int QUESTION_MESSAGE = 2;

        /// <summary>
        /// Entero para mensaje tipo advertencia
        /// </summary>
        public static readonly int WARNING_MESSAGE = 3;

        /// <summary>
        /// Entero para mensaje tipo informacion
        /// </summary>
        public static readonly int INFOMARTION_MESSAGE = 4;

        /// <summary>
        /// Class version
        /// </summary>
        public static readonly string VERSION = "v1.0.0.1";


        /// <summary>
        /// Shows a input dialog with a standard window and a message, and returns the text
        /// typed 
        /// </summary>
        /// <param name="message">Message for show</param>
        /// <returns>
        ///  The text typed
        /// </returns>
        public static string Show(string message)
        {
            validateParameters(message, "The parameter [message] cannot be null");

            Input frmFormulario = new Input();
            frmFormulario.lblMensaje.Text = message;
            frmFormulario.Adjust();

            if (frmFormulario.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return frmFormulario.txtInput.Text;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Shows a input dialog with a standard window, a message 
        /// and a the window's title, and returns the text typed 
        /// </summary>
        /// <param name="message">Message for show</param>
        /// <param name="title">window's title</param>
        /// <returns>
        /// The text typed
        /// </returns>
        public static string Show(string message, string title)
        {
            validateParameters(message, "The parameter [message] cannot be null");
            validateParameters(message, "The parameter [title] cannot be null");

            Input frmFormulario = new Input();
            frmFormulario.lblMensaje.Text = message;
            frmFormulario.Text = title;
            frmFormulario.Adjust();

            if (frmFormulario.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return frmFormulario.txtInput.Text; 
            }
            else
            {
                return "";
            }

            
        }

        /// <summary>
        /// Shows a input dialog with a standard window, a message 
        /// and a the window's title, the buttons to show, and returns the text typed 
        /// </summary>
        /// <param name="message">Message for show</param>
        /// <param name="title">window's title</param
        /// <param name="buttonType">The buttons for show</param>
        /// <returns>
        /// The text typed
        /// </returns>
        public static string Show(string message, string title, int buttonType)
        {
            validateParameters(message, "The parameter [message] cannot be null");
            validateParameters(message, "The parameter [title] cannot be null");
            validateParameters(buttonType, 1, 0, "The parameter [buttonType] is out index. The index is [0 to 1]");

            Input frmFormulario = new Input();
            frmFormulario.lblMensaje.Text = message;
            frmFormulario.Text = title;
            frmFormulario.Adjust();
            if (buttonType == InputDialog.ACCEPT_CANCEL_BUTON)
            {
                frmFormulario.cancelButton();
            }

            if (frmFormulario.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return frmFormulario.txtInput.Text;
            }
            else if ((frmFormulario.ShowDialog() == System.Windows.Forms.DialogResult.Cancel))
            {
                return "";
            }
            else
            {
                return "";
            }
        }


        /// <summary>
        /// Shows a input dialog with a standard window, a message 
        /// and a the window's title, the buttons to show, the buttons to show, 
        /// and returns the text typed 
        /// </summary>
        /// <param name="message">Message for show</param>
        /// <param name="title">window's title</param
        /// <param name="buttonType">The buttons for show</param>
        /// <param name="messageType">Tyoe of image on the window</param>
        /// <returns>una cadena de texto introducida por el usuario</returns>
        public static string Show(string message, string title, int buttonType, 
            int messageType)
        {
            validateParameters(message, "The parameter [message] cannot be null");
            validateParameters(message, "The parameter [title] cannot be null");
            validateParameters(buttonType, 1, 0, "The parameter [buttonType] is out index. The index is [0 to 1]");
            validateParameters(buttonType, 4, 0, "The parameter [messageType] is out index. The index is [0 to 4]");

            Input frmFormulario = new Input();
            frmFormulario.lblMensaje.Text = message;
            frmFormulario.Text = title;
            if (buttonType == InputDialog.ACCEPT_CANCEL_BUTON)
            {
                frmFormulario.cancelButton();
            }
            frmFormulario.Adjust();

            switch (messageType)
            {
                case 0:
                    frmFormulario.pbxIcono.Image = null;
                    break;
                case 1:
                    frmFormulario.pbxIcono.Image = global::cmsoft.Properties.Resources.cross;
                    break;
                case 2:
                    frmFormulario.pbxIcono.Image = global::cmsoft.Properties.Resources.question;
                    break;
                case 3:
                    frmFormulario.pbxIcono.Image = global::cmsoft.Properties.Resources.error;
                    break;
                case 4:
                    frmFormulario.pbxIcono.Image = global::cmsoft.Properties.Resources.information;
                    break;
            }

            if (frmFormulario.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return frmFormulario.txtInput.Text;
            }
            else if ((frmFormulario.ShowDialog() == System.Windows.Forms.DialogResult.Cancel))
            {
                return "";
            }
            else
            {
                return "";
            }
        }

        //validates the parameters
        private static void validateParameters(int integer, int top, int min, string info)
        {
            if (integer > top || integer < min)
            {
                throw new InputDialogException(info);
            }
        }

        private static void validateParameters(string msg, string info)
        {
            if (msg == null)
            {
                throw new InputDialogException(info);
            }
        }
    }
}
