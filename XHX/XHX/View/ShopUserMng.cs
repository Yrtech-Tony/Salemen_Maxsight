using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XHX.Common;
using XHX.DTO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;
//using XHX.WebService;

namespace XHX.View
{
    public partial class ShopUserMng : BaseForm
    {
        XtraGridDataHandler<ShopUserInfoDto> dataHandler = null;
        LocalService local = new LocalService();
        public ShopUserMng()
        {
            InitializeComponent();
            dataHandler = new XtraGridDataHandler<ShopUserInfoDto>(grvShop);
            OnLoadView();
        }
        public void OnLoadView()
        {
            //为查询条件中Cbo绑定
            BindComBox.BindProject(cboProjects);
            BindPosition();
            BindAuth();

        }
        public void InitializeView()
        {
            cboProjects.SelectedIndex = 0;
            grcShop.DataSource = null;
            btnShopCode.Text = "";
            txtShopName.Text = "";
        }
        public void BindAuth()
        {
            DataSet ds = local.AuthSearch();
            List<AuthDto> list = new List<AuthDto>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    AuthDto subjectType = new AuthDto();
                    subjectType.AuthCode = Convert.ToString(ds.Tables[0].Rows[i]["AuthCode"]);
                    subjectType.AuthName = Convert.ToString(ds.Tables[0].Rows[i]["AuthName"]);
                    list.Add(subjectType);
                }
            }
            CommonHandler.BindComboBoxItems<AuthDto>(cboAuth, list, "AuthName", "AuthCode");
        }
        public void BindPosition()
        {
            DataSet ds = local.PositionSearch(0, "");
            List<PositionDto> list = new List<PositionDto>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    PositionDto subjectType = new PositionDto();
                    subjectType.PositionCode = Convert.ToString(ds.Tables[0].Rows[i]["PositionCode"]);
                    subjectType.PositionName = Convert.ToString(ds.Tables[0].Rows[i]["PositionName"]);
                    list.Add(subjectType);
                }
            }
            CommonHandler.BindComboBoxItems<PositionDto>(cboPosition, list, "PositionName", "PositionCode");
        }
        public override List<ButtonType> CreateButton()
        {
            List<ButtonType> list = new List<ButtonType>();
            list.Add(ButtonType.InitButton);
            list.Add(ButtonType.SearchButton);
            list.Add(ButtonType.AddRowButton);
            list.Add(ButtonType.DeleteRowButton);
            list.Add(ButtonType.SaveButton);
            list.Add(ButtonType.ExcelDownButton);
            return list;
        }
        public override void AddRowButtonClick()
        {
            if (string.IsNullOrEmpty(btnShopCode.Text))
            {
                CommonHandler.ShowMessage(MessageType.Information, "请选择经销商");
                return;
            }
            ShopUserInfoDto shop = new ShopUserInfoDto();
            shop.ProjectCode = CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString();
            shop.ShopCode = btnShopCode.Text;
            shop.ShopName = txtShopName.Text;
            dataHandler.AddRow(shop);
        }
        public override void InitButtonClick()
        {
            base.InitButtonClick();

            InitializeView();
        }
        public override void SearchButtonClick()
        {
            SearchLossRateMst();
        }
        public override void SaveButtonClick()
        {
            if (CommonHandler.ShowMessage(MessageType.Confirm, "是否保存?") == DialogResult.Yes
                || CommonHandler.ShowMessage(MessageType.Confirm, "是否保存?") == DialogResult.OK)
            {
                List<ShopUserInfoDto> list = dataHandler.DataList as List<ShopUserInfoDto>;
                foreach (ShopUserInfoDto user in list)
                {
                    local.ShopUserInfoSave(user.ProjectCode, user.ShopCode, user.UserName, user.PinYinName, user.PostionCode, user.AuthCode,
                        this.UserInfoDto.UserID, DateTime.Now, user.PicNameList);
                }
                SearchButtonClick();

                CommonHandler.ShowMessage(MessageType.Information, "保存完毕");
            }
        }
        public override void ExcelDownButtonClick()
        {
            if (grcShop.DataSource != null)
                CommonHandler.ExcelExport(grvShop);
        }
        public bool CopyDir(string srcPath, string aimPath)
        {
            try
            {
                // 检查目标目录是否以目录分割字符结束如果不是则添加之
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                    aimPath += Path.DirectorySeparatorChar;

                // 判断目标目录是否存在如果不存在则新建之
                if (!Directory.Exists(aimPath))
                    Directory.CreateDirectory(aimPath);

                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法

                string[] fileList = Directory.GetFileSystemEntries(srcPath);


                // 遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    if (Directory.Exists(file))
                    {
                        CopyDir(file, aimPath + Path.GetFileName(file));
                    }
                    // 否则直接Copy文件
                    else
                    {
                        File.Copy(file, aimPath + Path.GetFileName(file), true);
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        } 
        private void SearchLossRateMst()
        {
            List<ShopUserInfoDto> areaList = new List<ShopUserInfoDto>();
            DataSet ds = local.ShopUserInfoSearch(CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString(),
                btnShopCode.Text.Trim());
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ShopUserInfoDto area = new ShopUserInfoDto();
                    area.ProjectCode = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCode"]);
                    area.ShopCode = Convert.ToString(ds.Tables[0].Rows[i]["ShopCode"]);
                    area.ShopName = Convert.ToString(ds.Tables[0].Rows[i]["ShopName"]);
                    area.UserName = Convert.ToString(ds.Tables[0].Rows[i]["UserName"]);
                    area.PinYinName = Convert.ToString(ds.Tables[0].Rows[i]["PinYinName"]);
                    area.PostionCode = Convert.ToString(ds.Tables[0].Rows[i]["PositionCode"]);
                    area.AuthCode = Convert.ToString(ds.Tables[0].Rows[i]["AuthCode"]);
                    area.InUserId = Convert.ToString(ds.Tables[0].Rows[i]["InUserId"]);
                    area.InDateTime = Convert.ToDateTime(ds.Tables[0].Rows[i]["InDateTime"]);
                    area.PicNameList = Convert.ToString(ds.Tables[0].Rows[i]["PicNameList"]);
                    area.AreaName = Convert.ToString(ds.Tables[0].Rows[i]["AreaName"]);
                    areaList.Add(area);
                }
            }
            grcShop.DataSource = areaList;

        }
        private void btnShopCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Shop_Popup pop = new Shop_Popup(CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString(), "", "", false);
            pop.ShowDialog();
            ShopDto dto = pop.Shopdto;
            if (dto != null)
            {
                btnShopCode.Text = dto.ShopCode;
                txtShopName.Text = dto.ShopName;
            }
        }

        private void grvShop_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            ShopUserInfoDto shop = grvShop.GetRow(grvShop.FocusedRowHandle) as ShopUserInfoDto;
            if (e.Column == gcAreaName ||
                e.Column == gcShopCode
                || e.Column == gcShopName
                || e.Column == gridColumn4
                || e.Column == gridColumn6)
            {
                e.Appearance.BackColor = CommonHandler.GetReadOnlyColor();
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void grvShop_ShowingEditor(object sender, CancelEventArgs e)
        {

        }

        private void btnViewPic_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ShopUserInfoDto shop = grvShop.GetRow(grvShop.FocusedRowHandle) as ShopUserInfoDto;
            AllPictureShow2 all = new AllPictureShow2(AppDomain.CurrentDomain.BaseDirectory + "UploadImage" + "\\" + shop.ProjectCode + shop.ShopName + "\\" + "考试人员类型登记",
                (shop.PicNameList != null ? shop.PicNameList : "").Split(';'), shop.ShopName);
            all.Show();
        }

        private void grcShop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) != null)
            {
                e.Effect = DragDropEffects.Copy;
            }

        }
       
        private void grcShop_DragDrop(object sender, DragEventArgs e)
        {
            GridHitInfo bdhi = grvShop.CalcHitInfo(new Point(e.X, e.Y));
            bdhi = grvShop.CalcHitInfo(grcShop.PointToClient(new System.Drawing.Point(e.X, e.Y)));
            if (bdhi.InRow)
            {
                int rowHandle = bdhi.RowHandle;
                ShopUserInfoDto shopuser = grvShop.GetRow(rowHandle) as ShopUserInfoDto;
                if (shopuser.UserName == null)
                {
                    CommonHandler.ShowMessage(MessageType.Information, "请先输入姓名");
                    return;
                }
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "UploadImage" + "\\"+shopuser.ProjectCode+shopuser.ShopName+"\\"
                    + "考试人员登记"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "UploadImage" + "\\" + shopuser.ProjectCode + shopuser.ShopName + "\\"
                        + "考试人员登记");
                }
                String[] fileNames = (String[])e.Data.GetData(DataFormats.FileDrop);
                File.Copy(fileNames[0], AppDomain.CurrentDomain.BaseDirectory + "UploadImage" + "\\" + shopuser.ProjectCode + shopuser.ShopName + "\\"
                    + "考试人员登记" + "\\" + shopuser.UserName+".jpg");
                string fileNamesString = String.Empty;
                string fileName = string.Empty;

                for (int i = 0; i < fileNames.Length; i++)
                {
                    fileNamesString += fileNames[i];
                    fileName += shopuser.UserName;
                    if (i != fileNames.Length - 1)
                    {
                        fileName += ";";
                        fileNamesString += ";";
                    }
                }
                grvShop.SetRowCellValue(rowHandle, gcPicNameList, fileName);

                //    LossResultDto uploaddto = grvLoss.GetRow(rowHandle) as LossResultDto;
                //    uploaddto.FileName = fileName;
                //    grvLoss.SetRowCellValue(rowHandle, "PicName", uploaddto.FileName);
                //    string[] filenameList = fileName.Split(';');
                //    for (int i = 0; i < filenameList.Length; i++)
                //    {
                //        //if (uploaddto.FilePath.Contains(':') && uploaddto.FilePath.Contains('\\'))
                //        //{
                //        //uploaddto.FileName = txtShopName.Text + "_" + txtSubjectCode.Text + "_" + grvLoss.FocusedRowHandle.ToString();

                //        CommonHandler.CompressionPic(CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString(), this.UserInfoDto.UserID, fileNames[i], filenameList[i], CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString() + txtShopName.Text);
                //        string appDomainPath = string.Empty;
                //        appDomainPath = service.getImagePath(ProjectCode_Golbal, this.UserInfoDto.UserID);

                //        if (string.IsNullOrEmpty(appDomainPath))
                //        {
                //            appDomainPath = AppDomain.CurrentDomain.BaseDirectory;
                //        }
                //        string filePath = appDomainPath + @"\" + @"UploadImage\" + CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString() + txtShopName.Text + @"\" + filenameList[i] + ".jpg";
                //        byte[] image = null;
                //        if (File.Exists(filePath))
                //        {
                //            FileStream fs = new FileStream(filePath, FileMode.Open);
                //            int streamLength = (int)fs.Length;
                //            image = new byte[streamLength];
                //            fs.Read(image, 0, streamLength);
                //            fs.Close();
                //        }
                //        else
                //        {
                //            image = new byte[0];
                //        }
                //        service.SaveAnswerDtl2Streampic(base.UserInfoDto.UserID,
                //            image, CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString() + txtShopName.Text,
                //            filenameList[i], "", "", SubjectCode_Golbal);
                //        //}

                //        //GetFileAndPic();
            }
            CommonHandler.ShowMessage(MessageType.Information, "图片上传成功！");
        }


    }

}

