using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgramСopying
{
    public partial class Form1 : Form
    {
        string fileWhereFromCopYway = "";
        string fileWhereCopYway = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void CopyFile_Click(object sender, EventArgs e)
        {
            fileWhereFromCopYway = WhereFromCopyFile.Text; // проверяем существования файла для копирования
            bool value = System.IO.File.Exists(fileWhereFromCopYway);
            if (value == false)
            {
                Console.WriteLine("Ошибка Файла не существуе");
            }
            fileWhereCopYway = WhereCopyFile.Text; // проверяем существования каталога для копирования
            bool valuecopy = System.IO.Directory.Exists(fileWhereCopYway);
            if (value == false)
            {
                Console.WriteLine("Ошибка Католога не существует");
            }


        }

        private void WhereFromCopyFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void WhereCopyFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
