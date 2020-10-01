using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSys
{
    class Utility
    {

        public static void formatEventGrid(DataGridView dg)
        {
            dg.Columns["Title"].Width = 80;
            dg.Columns["Title"].DefaultCellStyle.Format = "00";
            dg.Columns["Title"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["Description"].Width = 150;
            dg.Columns["Description"].DefaultCellStyle.Format = "000";
            dg.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["Time"].Width = 50;
            dg.Columns["Time"].DefaultCellStyle.Format = "000";
            dg.Columns["Time"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["EventDate"].Width = 90;
            dg.Columns["EventDate"].DefaultCellStyle.Format = "000";
            dg.Columns["EventDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dg.Columns["Price"].Width = 50;
            dg.Columns["Price"].DefaultCellStyle.Format = "N2";
            dg.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }



    }
}
