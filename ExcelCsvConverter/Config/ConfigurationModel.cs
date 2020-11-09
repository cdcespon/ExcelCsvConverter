using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace ExcelCsvConverter.Config
{
    class ConfigurationModel
    {
      private string mFolderProperty { get; set; }
        [Category("Browser")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public string FolderProperty
        {
            get
            {
                return mFolderProperty;
            }
            set
            {
                mFolderProperty = value;
            }
        }
    }
}

