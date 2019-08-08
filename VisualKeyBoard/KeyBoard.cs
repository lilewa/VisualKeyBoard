using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualKeyBoard
{
    public partial class KeyBoard : Form
    {
         public Control TextBox;
         PopupWindowHelperMessageFilter filter;
        public KeyBoard()
        {
            InitializeComponent();
            TopMost = true;
        }

        void ButtonNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send(((Button)sender).Text);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Enter}");
            this.Visible = false;
           

        }

        protected override CreateParams CreateParams
        {
            get
            {   // (int)Flags.WindowStyles.WS_THICKFRAME | 
                CreateParams ret = base.CreateParams;
                ret.Style =(int)Flags.WindowStyles.WS_CHILD;
                ret.ExStyle |= (int)Flags.WindowStyles.WS_EX_NOACTIVATE | (int)Flags.WindowStyles.WS_EX_TOOLWINDOW;
                ret.X = this.Location.X;
                ret.Y = this.Location.Y;
                return ret;
            }
        }

        private void KeyBoard_Load(object sender, EventArgs e)
        {
            filter = new PopupWindowHelperMessageFilter(this, TextBox);

        }

        private void KeyBoard_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
               
                Application.AddMessageFilter(filter);
            }
            else
            {
                Application.RemoveMessageFilter(filter);
            }
        }

        
    }
}
