using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIC
{
    public class Image_Converter
    {
        //Mã hóa hình ảnh để lưu vào database 
        public byte[] getByteImage(PictureBox pb)
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                pb.Image.Save(stream, ImageFormat.Jpeg);
                return stream.ToArray();
            }
            catch
            {
                return null;
            }
        }

        public void loadImageFromDB_PictureBox(PictureBox pictureBox, byte[] img)
        {

            if (img != null)
            {
                MemoryStream ms = new MemoryStream(img);
                pictureBox.Image = Image.FromStream(ms);
            }
            else return;//
        }

        public Image loadImageFromDB(byte[] img)
        { 
            try
            {
                MemoryStream ms = new MemoryStream(img);
                return Image.FromStream(ms);
            }
            catch
            {
                return null;
            }
        }
        

    }
}
