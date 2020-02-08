using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Caffeinated {
    // Base class for all forms. See stackvoerflow for reasons:
    // http://stackoverflow.com/questions/297701/default-font-for-windows-forms-application/4076183#4076183
    public class BaseForm : Form {
        public BaseForm() {
            // Provides design-time support for the default font on Visa/Win7.
            // Falls back to something decent if system lacks the font.
            this.Font = SystemFonts.MessageBoxFont;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }
    }
}
