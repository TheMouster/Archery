using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassifiedDevelopment.Archery
{
    public partial class frmArcheryFileCreator : Form
    {
        private ArchiveScript archiveScript = new ArchiveScript();

        public frmArcheryFileCreator()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgFolderSource.ShowDialog();
            if (result == DialogResult.OK)
            {
                archiveScript.Source = dlgFolderSource.SelectedPath;
                txtSource.Text = archiveScript.Source;
            }

            CheckPathsAndEnableSaveButton();
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgFolderDestination.ShowDialog();

            if (result == DialogResult.OK)
            {
                archiveScript.Destination = dlgFolderDestination.SelectedPath;
                txtDestination.Text = archiveScript.Destination;
            }

            CheckPathsAndEnableSaveButton();
        }

        private void CheckPathsAndEnableSaveButton()
        {
            Boolean sourceIsBlank = String.IsNullOrEmpty(archiveScript.Source);
            Boolean destinationIsBlank = String.IsNullOrEmpty(archiveScript.Destination);
            Boolean sourceMatchesDestination = (archiveScript.Source == archiveScript.Destination);

            if (!sourceIsBlank && !destinationIsBlank && !sourceMatchesDestination)
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO: Acquire save path
            //TODO: Serialise the archiveScript
        }
    }
}
