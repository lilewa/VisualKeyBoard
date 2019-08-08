using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace VisualKeyBoard
{
    public class KeyBoardTextBox : TextBox
    {
        KeyBoard keyBoard;

         int keyBoardWidth ;
         int keyBoardHeight;
     

        public KeyBoardTextBox()
        {
            this.Click += new EventHandler(TexBoxWKeyBoard_Click);
            this.Enter += new EventHandler(TexBoxWKeyBoard_Enter);
            this.Leave += new EventHandler(TexBoxWKeyBoard_Leave);
            
        }

        void TexBoxWKeyBoard_Leave(object sender, EventArgs e)
        {
            if (keyBoard != null)
            {
                //keyBoard.Close();
                //keyBoard = null;
                keyBoard.Visible = false;
            }
        }

        //void HK_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    //keyBoard.Dispose();
        //    //keyBoard = null;
        //    if (keyBoard != null)
        //    { 
        //        keyBoard.Visible = false;
        //    }
        //}

        void TexBoxWKeyBoard_Enter(object sender, EventArgs e)
        {
            if (keyBoard == null)
            {
                keyBoard = new KeyBoard();
                keyBoard.TextBox = this;
                keyBoardWidth = keyBoard.Size.Width;
                keyBoardHeight = keyBoard.Size.Height;
                

            }

            int rightWidth = this.Parent.ClientSize.Width -  this.Location.X;
           int  bottomHeight = this.Parent.ClientSize.Height - this.Height - this.Location.Y;

           int keyBoardY = this.Bottom;
           if (bottomHeight < keyBoardHeight)
           {
               keyBoardY = this.Location.Y - keyBoardHeight;
           }
           int keyBoardX = this.Left;
           if (rightWidth < keyBoardWidth)
           {
               keyBoardX = this.Location.X - keyBoardWidth+this.Width;
           }
           keyBoard.Location = this.Parent.PointToScreen(new Point(keyBoardX, keyBoardY));

            keyBoard.Show();

        }

        void TexBoxWKeyBoard_Click(object sender, EventArgs e)
        {
            TexBoxWKeyBoard_Enter(sender, e);
        }

    }
}
