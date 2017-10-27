using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIC.DM_MatHang
{
    public class HandleMatHang
    {
        //public void SuaClick(DataSet ds, TreeView tv, string tableName, string key, string colImageName)
        //{
        //    //get hình
        //    byte[] img = null;
        //    try
        //    {
        //        foreach (DataRow row in ds.Tables["LoaiMatHang"].Rows)
        //        {
        //            if (row["MaLoaiMH"].ToString() == tv.SelectedNode.Name)
        //                img = (byte[])row["HinhAnh"];
        //        }
        //    }
        //    catch
        //    {
        //        //chưa set hình
        //    }
        //    Image_Converter toImage = new Image_Converter();
        //}

        public void loadTreeView(TreeView treeView, DataSet ds, string tableName, string ma, string ten, string colImgName, ImageList imageList)
        {
            treeView.Nodes.Clear();
            
            foreach (DataRow row in ds.Tables[tableName].Rows)
            {
                try
                {
                    Image_Converter image = new Image_Converter();

                    //gán tên mã cho image và load img lên từ DB
                    imageList.Images.Add(row[ma].ToString(), image.loadImageFromDB((byte[])row[colImgName]));

                    //mã, tên, tên ảnh trong imageList
                    treeView.Nodes.Add(row[ma].ToString(), row[ten].ToString(), row[ma].ToString(), row[ma].ToString());

                }
                catch
                {
                    //Lỗi do chưa đặt ảnh cho danh mục => đặt ảnh mặt định cho nó ở imageList - Index = 0
                    treeView.Nodes.Add(row[ma].ToString(), row[ten].ToString(), 0, 0);
                }
            }
        }

       

    }
}
