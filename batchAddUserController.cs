using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace CS325_broadSword_flowerProject
{
    class batchAddUserController
    {
        public batchAddUserController()
        {
            //No Constructor
        }

        internal void constructGUI()
        {
            batchAddUsersGui batchGui = new batchAddUsersGui(this);
            batchGui.ShowDialog();
        }

        internal List<User> loadDataFromFile(string filepath)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            int rCnt;
            int rw = 0;
            int cl = 0;
            int index = 0;

            List<User> batchUsers = new List<User>();

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(filepath, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;

            rw = range.Rows.Count;
            cl = range.Columns.Count;
            for (rCnt = 1; rCnt <= rw; rCnt++)
            {
                batchUsers.Add(new User());
                batchUsers[index].setFirst((range.Cells[rCnt, 1] as Excel.Range).Value);
                batchUsers[index].setLast((range.Cells[rCnt, 2] as Excel.Range).Value);
                batchUsers[index].setUserName((range.Cells[rCnt, 3] as Excel.Range).Value);
                batchUsers[index].setPass((range.Cells[rCnt, 4] as Excel.Range).Value);
                batchUsers[index].setLevel((int)(range.Cells[rCnt, 5] as Excel.Range).Value);
                index++;
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            return batchUsers;
        }

        internal bool batchAddUsersToDatabase(List<User> users)
        {
            return DatabaseManager.batchAddUsers(users);
        }
    }
}
