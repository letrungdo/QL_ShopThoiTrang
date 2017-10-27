using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LOGIC
{
    public class OpenFileDialogImage
    {
        public Image getHinh(OpenFileDialog openFileDialog)
        {
            openFileDialog.Filter = "JPG File (*.JPG)|*.JPG|GIF File (*.GIF)|*.GIF|PNG File (*.PNG)|*.PNG";
            openFileDialog.Title = "Chọn ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imgloc = string.Empty;//Đường dẫn hình ảnh
                imgloc = openFileDialog.FileName;
                //pictureBox_avatar.ImageLocation = file;
                if (string.IsNullOrEmpty(imgloc))
                    return null;
                return Image.FromFile(imgloc);
                
            }
            return null;
        }
    }
}
