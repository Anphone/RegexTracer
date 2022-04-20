using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexTracer
{
    public partial class FrmRegexTracer : Form
    {
        public FrmRegexTracer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtPattern.Text = @"^[a-zA-Z0-9](((?![._\-+'():;<>\][\\@]{2}).)*)[a-zA-Z0-9!#$%&*/=?^`{|}~]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9]*[._\-+'():;<>\][\\@]?[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?[0-9a-z]$";
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            bool result = Regex.IsMatch(txtInput.Text.Trim(), txtPattern.Text.Trim());
            txtResult.Text = result ? "True" : "False";
        }
    }
}
