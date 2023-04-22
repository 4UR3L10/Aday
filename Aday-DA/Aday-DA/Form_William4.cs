using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aday_DA
{
    public partial class Form_William4 : Form
    {
        private Form _parentForm;
        public Form_William4(Form parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void bt_close_Adding_Event_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_save_Event_Click(object sender, EventArgs e)
        {

        }
        /*
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Re-enable other forms
            if (_parentForm != null)
            {
                foreach (Form form in _parentForm.MdiChildren)
                {
                    if (form != this)
                    {
                        form.Enabled = true;
                    }
                }
            }
        }


        

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //MessageBox.Show("Here I am ");
            // Disable other forms
            if (_parentForm != null)
            {
                foreach (Form form in _parentForm.MdiChildren)
                {
                    if (form != this)
                    {
                        form.Enabled = false;
                    }
                }
            }
        }*/
    }
}
