using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kashka.Presentation_Layer.Forms
{
    public partial class List : Form
    {
        public object SelectedListItem { get; private set; }

        public List()
        {
            InitializeComponent();
        }

        public void SetItemList<T>(List<T> itemList) where T : class
        {
            lstItems.DisplayMember = "Name";
            lstItems.DataSource = itemList;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem != null)
            {
                SelectedListItem = lstItems.SelectedItem;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }
    }
}
