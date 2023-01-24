using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateFolder
{
    public partial class FormMain : Form
    {
        public int ListIndexValue = 0;
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void btnFS_Click(object sender, EventArgs e)
        {
           FBDialog.ShowDialog();
            txtFS.Text = FBDialog.SelectedPath;

        }

        private void btnTFS_Click(object sender, EventArgs e)
        {
            FBDialog.ShowDialog();
            txtTFS.Text = FBDialog.SelectedPath;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            
            FolderNameGet(txtFS.Text);

            

        }
        private void FolderNameGet(string directoryPath)
        {
            try
            {
                if (directoryPath != "" && txtTFS.Text!="")
                {
                    //Verilen yol'daki klasörleri alıp,diziye atıyoruz.
                    string[] directories = Directory.GetDirectories(directoryPath);


                    if (directories.Count() > 0)
                    {
                        //tüm klasör dönüyoruz.
                        foreach (string folder in directories)
                        {
                            //DirectoryInfo ile klasörün bilgilerini çekiyoruz.
                            DirectoryInfo dirInfoDirectory = new DirectoryInfo(folder);
                            if (dirInfoDirectory.Name[0] != '$' && dirInfoDirectory.Name != "System Volume Information" && dirInfoDirectory.Name !="Documents and Settings" && dirInfoDirectory.Name != "OneDriveTemp" && dirInfoDirectory.Name != "ProgramData" && dirInfoDirectory.Name != "Recovery")
                            {
                                lstBox.Items.Add(dirInfoDirectory.Name);


                            }
                        }
                        MessageBox.Show("Dosya adları listeye başarıyla eklenmiştir. Dosya adlarını kontrol ederek ekleme, güncelleme ve silme işlemlerini yapabilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen dizinleri seçiniz.","Dizin Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CreateFolder(string path, List<string> FolderNames,string targetParentFolderName)
        {
            if (!Directory.Exists(path + targetParentFolderName))
            {
                DirectoryInfo d1 = Directory.CreateDirectory(path + targetParentFolderName);
                List<string> klasorler = FolderNames;
                foreach (string folderName in klasorler)
                {
                    Directory.CreateDirectory(path + targetParentFolderName+ "\\" + folderName);
                    
                }
                MessageBox.Show($"{path}{targetParentFolderName} dizinine klasörleriniz başarıyla eklenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result=MessageBox.Show("Hedeflenen dizinde aynı isimde klasör mevcut. Üstüne yazılsın mı?", "HATA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Directory.Delete(path + targetParentFolderName,true);
                    DirectoryInfo d1 = Directory.CreateDirectory(path + targetParentFolderName);
                    List<string> klasorler = FolderNames;
                    foreach (string folderName in klasorler)
                    {
                        Directory.CreateDirectory(path + targetParentFolderName);

                    }
                    MessageBox.Show($"{path}{targetParentFolderName} dizinine klasörleriniz başarıyla eklenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            List<string> klasorAdlari = new List<string>();
            foreach (var item in lstBox.Items)
            {
                klasorAdlari.Add(item.ToString());
            }
            
                CreateFolder(txtTFS.Text, klasorAdlari, folderName.Text);
            

        }

        private void folderName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(folderName.Text))
            {
                btnCreateFolder.Enabled = true;
            }
            else
            {
                btnCreateFolder.Enabled = false;
            }
            
        }

        private void txtFS_TextChanged(object sender, EventArgs e)
        {
            if (txtFS.Text.Count() > 0)
            {
                btnGet.Enabled = true;
            }
            else
            {
                btnGet.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstBox.Items[ListIndexValue].ToString() != selectName.Text)
            {
                //MessageBox.Show($"{ListIndexValue} - {selectName.Text}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstBox.Items[ListIndexValue] =selectName.Text;
                ClearSelectName();
                MessageBox.Show($"Güncelleme işlemi başarıyla yapılmıştır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        void ClearSelectName()
        {
            selectName.Text= string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(selectName.Text) && ListIndexValue!=-1)
            {
                lstBox.Items.RemoveAt(ListIndexValue);
                MessageBox.Show($"Silme işlemi başarıyla gerçekleşmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSelectName();
            }
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBox.SelectedIndex>=0)
            {
                ListIndexValue = lstBox.SelectedIndex;
                selectedName();

            }
            
           
            
            

        }
        private void selectedName()
        {
                selectName.Text = lstBox.Items[ListIndexValue].ToString();
                //MessageBox.Show($"{ListIndexValue} - Index", "Seçilen Değer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (inputName.Text.Trim().Count()>0 && !lstBox.Items.Contains(inputName.Text))
            {

                lstBox.Items.Add(inputName.Text.Trim());//kontrol eklemen lazım if sorgusuna
                MessageBox.Show($"Dosya adı listeye başarıyla eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                inputName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show($"Dosya adları aynı olamaz. Boş dosya adı geçersizdir.","Dosya Adı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void selectName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(selectName.Text))
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void lstClear_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show($"Listedeki bütün adlar silinecek. Emin misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lstBox.Items.Clear();
            }
            
        }

        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/atasoyonur/FolderCreateApp");
        }
    }
}
