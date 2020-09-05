using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MouseKeyboardLibrary;

namespace AppSpy
{
    public partial class Form1 : Form
    {
        MouseHook mouseHook = new MouseHook();
        KeyboardHook keyboardHook = new KeyboardHook();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mouseHook.MouseMove += new MouseEventHandler(mouseHook_MouseMove);
            mouseHook.MouseDown += new MouseEventHandler(mouseHook_MouseDown);
            mouseHook.MouseUp += new MouseEventHandler(mouseHook_MouseUp);
            mouseHook.MouseWheel += new MouseEventHandler(mouseHook_MouseWheel);

            keyboardHook.KeyDown += new KeyEventHandler(keyboardHook_KeyDown);
            keyboardHook.KeyUp += new KeyEventHandler(keyboardHook_KeyUp);
            keyboardHook.KeyPress += new KeyPressEventHandler(keyboardHook_KeyPress);

            mouseHook.Start();
            keyboardHook.Start();

            SetXYLabel(MouseSimulator.X, MouseSimulator.Y);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        void keyboardHook_KeyPress(object sender, KeyPressEventArgs e)
        {

            AddKeyboardEvent(
                "KeyPress",
                "",
                e.KeyChar.ToString(),
                "",
                "",
                ""
                );

        }

        void keyboardHook_KeyUp(object sender, KeyEventArgs e)
        {

            AddKeyboardEvent(
                "KeyUp",
                e.KeyCode.ToString(),
                "",
                e.Shift.ToString(),
                e.Alt.ToString(),
                e.Control.ToString()
                );

        }

        void keyboardHook_KeyDown(object sender, KeyEventArgs e)
        {


            AddKeyboardEvent(
                "KeyDown",
                e.KeyCode.ToString(),
                "",
                e.Shift.ToString(),
                e.Alt.ToString(),
                e.Control.ToString()
                );

        }

        void mouseHook_MouseWheel(object sender, MouseEventArgs e)
        {

            AddMouseEvent(
                "MouseWheel",
                "",
                "",
                "",
                e.Delta.ToString()
                );

        }

        void mouseHook_MouseUp(object sender, MouseEventArgs e)
        {


            AddMouseEvent(
                "MouseUp",
                e.Button.ToString(),
                e.X.ToString(),
                e.Y.ToString(),
                ""
                );

        }

        void mouseHook_MouseDown(object sender, MouseEventArgs e)
        {


            AddMouseEvent(
                "MouseDown",
                e.Button.ToString(),
                e.X.ToString(),
                e.Y.ToString(),
                ""
                );

        }

        void mouseHook_MouseMove(object sender, MouseEventArgs e)
        {

            SetXYLabel(e.X, e.Y);

        }

        void SetXYLabel(int x, int y)
        {

            //curXYLabel.Text = String.Format("Current Mouse Point: X={0}, y={1}", x, y);

        }

        void AddMouseEvent(string eventType, string button, string x, string y, string delta)
        {


        }

        void AddKeyboardEvent(string eventType, string keyCode, string keyChar, string shift, string alt, string control)
         {


        }
    }
}
