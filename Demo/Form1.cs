using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lv_NhanVien.View = View.Details;
            lv_NhanVien.GridLines = true;
            lv_NhanVien.FullRowSelect = true;

            lv_NhanVien.Columns.Add("Họ tên", 150);
            lv_NhanVien.Columns.Add("Ngày sinh", 100);
            lv_NhanVien.Columns.Add("Số điện thoại", 100);
            lv_NhanVien.Columns.Add("Địa chỉ", 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] thongtin = new string[4];

            thongtin[0] = txt_name.Text;
            thongtin[1] = dtp_Ngaysinh.Text;
            thongtin[2] = txt_sdt.Text;
            thongtin[3] = txt_dc.Text;

            ListViewItem itm = new ListViewItem(thongtin);
            lv_NhanVien.Items.Add(itm);
        }
        
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_NhanVien.Items.Count; i++)
            {
                if (lv_NhanVien.Items[i].Checked)
                {
                    lv_NhanVien.Items[i].Remove();
                    i--;
                }
            }
        }
        bool sua = true;
        private void bt_Sua_Click(object sender, EventArgs e)
        {
            if (!sua)
            {
                sua = true;
                if (lv_NhanVien.SelectedItems.Count > 0)
                {
                    txt_name.Text = lv_NhanVien.SelectedItems[0].SubItems[0].Text;
                    dtp_Ngaysinh.Text = lv_NhanVien.SelectedItems[0].SubItems[1].Text;
                    txt_sdt.Text = lv_NhanVien.SelectedItems[0].SubItems[2].Text;
                    txt_dc.Text = lv_NhanVien.SelectedItems[0].SubItems[3].Text;
                }
            }
            else
            {
                sua = false;
                lv_NhanVien.SelectedItems[0].SubItems[0].Text = txt_name.Text;
                lv_NhanVien.SelectedItems[0].SubItems[1].Text = dtp_Ngaysinh.Text;
                lv_NhanVien.SelectedItems[0].SubItems[2].Text = txt_sdt.Text;
                lv_NhanVien.SelectedItems[0].SubItems[3].Text = txt_dc.Text;
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
