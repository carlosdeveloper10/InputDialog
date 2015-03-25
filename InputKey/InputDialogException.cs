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

namespace cmsoft.com.inputWindow
{
    /// <summary>
    /// This exception thrown when occurred some problem with InputDialog class
    /// </summary>
    public class InputDialogException : Exception
    {
        public InputDialogException()
            : base()
        {
        }

        public InputDialogException(string message)
            : base(message)
        {
        }
    }
}
