using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quan_ly_ban_hang_sieu_thi
{
    public partial class ucChuongTrinhKM : UserControl
    {
        public ucChuongTrinhKM()
        {
            InitializeComponent();
        }



        private void btnThemLoaiKM_Click(object sender, EventArgs e)
        {
            newForm LoaiKM = new newForm("frmLoaiKM", "LOẠI KHUYẾN MÃI");
            ucLoaiHinhKM newLHKM= new ucLoaiHinhKM();
            LoaiKM.taoForm(newLHKM);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }





    }
}
