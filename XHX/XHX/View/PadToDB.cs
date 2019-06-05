using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using XHX.Common;
using System.Data.Common;
using XHX.DTO;
using DbAccess;

namespace XHX.View
{
    public partial class PadToDB : BaseForm
    {
        //public static localhost.Service service = new localhost.Service();
        LocalService local = new LocalService();
        string ProjectCode_Golbal = "";
        string ShopCode_Golbal = "";

        public PadToDB()
        {
            InitializeComponent();
            XHX.Common.BindComBox.BindProject(cboProjects);
        }

        public override List<XHX.BaseForm.ButtonType> CreateButton()
        {
            List<XHX.BaseForm.ButtonType> list = new List<XHX.BaseForm.ButtonType>();
            return list;
        }

        

        #region UploadData

        private void btnDataPath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                btnDataPath.Text = fbd.SelectedPath;
            }
        }

        private void btnUploadData_Click(object sender, EventArgs e)
        {
            #region ������֤
           
            if (btnDataPath.Text == "")
            {
                CommonHandler.ShowMessage(MessageType.Information, "��ѡ��\"����·��\"");
                btnDataPath.Focus();
                return;
            }

            ProjectCode_Golbal = CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString();

            DirectoryInfo dataDir = new DirectoryInfo(btnDataPath.Text);
            FileInfo[] filesInfo = dataDir.GetFiles();

            bool isExistDBFile = false;
            foreach (FileInfo fileInfo in filesInfo)
            {
                if (fileInfo.Name == "writeable.db")
                {
                    isExistDBFile = true;
                    SqliteHelper.SetConnectionString("Data Source=" + fileInfo.FullName, "");
                }
            }
            if (!isExistDBFile)
            {
                CommonHandler.ShowMessage(MessageType.Information, "·���в��������ݿ��ļ�'writeable.db'");
                return;
            }
            #endregion

            #region �ϴ�����
            {
                List<String> dataList = SqliteHelper.Search("SELECT ProjectCode,ShopCode,UserName,PinYinName,UserPosition,Authenticate,InUserId,InDateTime,PicNameList from ShopUserMng WHERE ProjectCode='" + ProjectCode_Golbal + "'");
                local.ShopUserInfoUpload(dataList);
            }
            #endregion

            #region �ϴ�ͼƬ�ļ�
            {
                DirectoryInfo[] dirInfos = dataDir.GetDirectories();
                foreach (DirectoryInfo dirInfo in dirInfos)
                {
                    if (dirInfo.Name.Contains(ProjectCode_Golbal))
                    {
                        FileInfo[] fileList = dirInfo.GetFiles("Thumbs.db");
                        if (fileList != null && fileList.Length != 0)
                        {
                            foreach (FileInfo file in fileList)
                            {
                                if (file.Name == "Thumbs.db")
                                {
                                    file.Delete();
                                    break;
                                }
                            }
                        }
                    }
                }
                CopyDir(btnDataPath.Text, AppDomain.CurrentDomain.BaseDirectory + "\\" + "UploadImage");
                CommonHandler.ShowMessage(MessageType.Information, "�ϴ����");
                
            }
            #endregion
        }
        #endregion
        public bool CopyDir(string srcPath, string aimPath)
        {
            try
            {
                // ���Ŀ��Ŀ¼�Ƿ���Ŀ¼�ָ��ַ�����������������֮
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                    aimPath += Path.DirectorySeparatorChar;

                // �ж�Ŀ��Ŀ¼�Ƿ����������������½�֮
                if (!Directory.Exists(aimPath))
                    Directory.CreateDirectory(aimPath);

                // �õ�ԴĿ¼���ļ��б��������ǰ����ļ��Լ�Ŀ¼·����һ������
                // �����ָ��copyĿ���ļ�������ļ���������Ŀ¼��ʹ������ķ���

                string[] fileList = Directory.GetFileSystemEntries(srcPath);


                // �������е��ļ���Ŀ¼
                foreach (string file in fileList)
                {
                    // �ȵ���Ŀ¼��������������Ŀ¼�͵ݹ�Copy��Ŀ¼������ļ�
                    if (Directory.Exists(file))
                    {
                        CopyDir(file, aimPath + Path.GetFileName(file));
                    }
                    // ����ֱ��Copy�ļ�
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
        #region DownloadData

        private void tbnSQLitePath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbnSQLitePath.Text = fbd.SelectedPath;
            }
        }

        private void btnDownloadData_Click(object sender, EventArgs e)
        {

            if (tbnSQLitePath.Text == "")
            {
                CommonHandler.ShowMessage(MessageType.Information, "��ѡ��\"����·��\"");
                tbnSQLitePath.Focus();
                return;
            }

            string sqlConnString = GetSqlServerConnectionString("123.57.229.128", "XinHuaXin_pad", "sa", "mxT1@mfb");
            string sqlitePath = Path.Combine(tbnSQLitePath.Text.Trim(), "readonly.db");
            this.Cursor = Cursors.WaitCursor;
            SqlConversionHandler handler = new SqlConversionHandler(delegate(bool done,
                bool success, int percent, string msg)
            {
                Invoke(new MethodInvoker(delegate()
                {
                    pbrProgress.Value = percent;

                    if (done)
                    {
                        this.Cursor = Cursors.Default;

                        if (success)
                        {
                            File.Copy(sqlitePath, Path.Combine(Path.GetDirectoryName(sqlitePath), "writeable.db"), true);
                            CommonHandler.ShowMessage(MessageType.Information, "���سɹ�");
                            pbrProgress.Value = 0;
                        }
                        else
                        {
                            CommonHandler.ShowMessage(MessageType.Information, "����ʧ��\r\n" + msg);
                            pbrProgress.Value = 0;
                        }
                    }
                }));
            });
            SqlTableSelectionHandler selectionHandler = new SqlTableSelectionHandler(delegate(List<TableSchema> schema)
            {
                return schema;
            });

            FailedViewDefinitionHandler viewFailureHandler = new FailedViewDefinitionHandler(delegate(ViewSchema vs)
            {
                return null;
            });

            string password = null;
            SqlServerToSQLite.ConvertSqlServerToSQLiteDatabase(sqlConnString, sqlitePath, password, handler,
                selectionHandler, viewFailureHandler, false, false);
        }

        private static string GetSqlServerConnectionString(string address, string db, string user, string pass)
        {
            string res = @"Data Source=" + address.Trim() +
                ";Initial Catalog=" + db.Trim() + ";User ID=" + user.Trim() + ";Password=" + pass.Trim();
            return res;
        }

        #endregion

        #region UpdateData

        private void tbnSQLitePathForUpdate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbnSQLitePathForUpdate.Text = fbd.SelectedPath;
            }
        }

        private void btnDownloadDataForUpdate_Click(object sender, EventArgs e)
        {
            if (tbnSQLitePathForUpdate.Text == "")
            {
                CommonHandler.ShowMessage(MessageType.Information, "��ѡ��\"����·��\"");
                tbnSQLitePathForUpdate.Focus();
                return;
            }

            string sqlConnString = GetSqlServerConnectionString(".", "XinHuaXin_ShopUser", "DSAT", "DSAT");
            string sqlitePath = Path.Combine(tbnSQLitePathForUpdate.Text.Trim(), "readonly.db");
            this.Cursor = Cursors.WaitCursor;
            SqlConversionHandler handler = new SqlConversionHandler(delegate(bool done,
                bool success, int percent, string msg)
            {
                Invoke(new MethodInvoker(delegate()
                {
                    pbrProgressForUpdate.Value = percent;

                    if (done)
                    {
                        this.Cursor = Cursors.Default;

                        if (success)
                        {
                            CommonHandler.ShowMessage(MessageType.Information, "���سɹ�");
                            pbrProgressForUpdate.Value = 0;
                        }
                        else
                        {
                            CommonHandler.ShowMessage(MessageType.Information, "����ʧ��\r\n" + msg);
                            pbrProgressForUpdate.Value = 0;
                        }
                    }
                }));
            });
            SqlTableSelectionHandler selectionHandler = new SqlTableSelectionHandler(delegate(List<TableSchema> schema)
            {
                return schema;
            });

            FailedViewDefinitionHandler viewFailureHandler = new FailedViewDefinitionHandler(delegate(ViewSchema vs)
            {
                return null;
            });

            string password = null;
            SqlServerToSQLite.ConvertSqlServerToSQLiteDatabase(sqlConnString, sqlitePath, password, handler,
                selectionHandler, viewFailureHandler, false, false);
        }

        #endregion

    }
}