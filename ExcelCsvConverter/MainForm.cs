using ExcelCsvConverter.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelCsvConverter
{
    public partial class MainForm : Form
    {
        private ConfigurationModel _config = new ConfigurationModel(); 
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainPropertyGrid.SelectedObject = Serializer.DeSerializemodel();
            LoadFiles();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure exiting app?","Exit confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                Serializer.Serialize(_config);
                Application.Exit();
            }

        }
        private void LoadFiles()
        {
            fileListView.SmallImageList = SmallImageList;
            string path = @"c:\data";
            foreach (var item in System.IO.Directory.GetFiles(path))
            {
                ListViewItem newItem = new ListViewItem();
                newItem.ImageIndex = 0;
                newItem.Text = item;


                fileListView.Items.Add(item);
            }




        }

        private void MainPropertyGrid_Enter(object sender, EventArgs e)
        {
            
        }

        private void MainPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            _config.FolderProperty = e.ChangedItem.Value.ToString();

            Serializer.Serialize(_config);
        }
    }
}
