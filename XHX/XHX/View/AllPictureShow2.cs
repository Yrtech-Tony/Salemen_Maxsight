using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XHX;
using System.IO;
using XHX.Common;

namespace XHX.View
{
    public partial class AllPictureShow2 : DevExpress.XtraEditors.XtraForm
    {
        localhost.Service service = new XHX.localhost.Service();

        public AllPictureShow2()
        {
            InitializeComponent();

            this.Shown += new EventHandler(AllPictureShow2_Shown);
        }

        void AllPictureShow2_Shown(object sender, EventArgs e)
        {
            this.kpImageViewer1.FitToScreen();
        }

        public AllPictureShow2(string filePath, string[] fileName, string shopName)
            : this()
        {
            this.LookAndFeel.SetSkinStyle(CommonHandler.Skin_Name);
            List<Image> pictures = new List<Image>();

            //MessageBox.Show(filePath);

            for (int i = 0; i < fileName.Length; i++)
            {
                //MessageBox.Show(fileName[i]);
                //Image image  =new byte[0] ;
                if (File.Exists(filePath + "\\" + fileName[i].Replace(".jpg","") + ".jpg"))
                {
                    Image image = Image.FromFile(filePath + "\\" + fileName[i]+".jpg");
                    pictures.Add(image);
                }
               
            }

            if (pictures.Count != 0)
            {
                this.kpImageViewer1.ImageList = pictures;
            }

        }


    }
}
