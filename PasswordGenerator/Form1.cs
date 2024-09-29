using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity;
using OfficeOpenXml;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private readonly UserManager<IdentityUser> _userManager;
        private List<UserResult> _results = new List<UserResult>();

        public Form1(UserManager<IdentityUser> userManager)
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            _userManager = userManager;
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    _results = await ProcessExcelFile(filePath);
                    dataGridViewResults.DataSource = _results;
                }
            }
        }

        private async Task<List<UserResult>> ProcessExcelFile(string filePath)
        {
            var results = new List<UserResult>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];

                int total = 0;
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    var username = worksheet.Cells[row, 1].Text;
                    var password = worksheet.Cells[row, 2].Text;

                    var hashedPassword = await HashPasswordAsync(password);
                    results.Add(new UserResult { Username = username, Password = password, HashedPassword = hashedPassword });

                    total++;
                }

                totalCount.Text = "Total Generated: " + total.ToString();
            }

            return results;
        }

        private async Task<string> HashPasswordAsync(string password)
        {
            var user = new IdentityUser(); // Dummy user for hashing
            var hashedPassword = _userManager.PasswordHasher.HashPassword(user, password);
            return hashedPassword;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save the Hashed Passwords File";
                saveFileDialog.FileName = "hashed_passwords.xlsx"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CreateExcelFile(saveFileDialog.FileName, _results);
                    MessageBox.Show("File downloaded successfully.");
                }
            }
        }


        private void CreateExcelFile(string filePath, List<UserResult> results)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Results");
                worksheet.Cells[1, 1].Value = "Username";
                worksheet.Cells[1, 2].Value = "Password";
                worksheet.Cells[1, 3].Value = "Hashed Password";

                for (int i = 0; i < results.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = results[i].Username;
                    worksheet.Cells[i + 2, 2].Value = results[i].Password;
                    worksheet.Cells[i + 2, 3].Value = results[i].HashedPassword;
                }

                package.SaveAs(new FileInfo(filePath));
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.opus-bd.com",
                UseShellExecute = true
            });
        }

        public class UserResult
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string HashedPassword { get; set; }
        }
    }
}
