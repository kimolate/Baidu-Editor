using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using MSWord = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;

namespace 百度经验编辑器.MainClass
{
   public class PublicClass
    {

       public static string tag=null ;
       public static string photopath=null;
        


        public void AutoChangePhoto(PictureBox pic)
        {
            string picturepath = photopath + tag+".png";
            Bitmap photo = new Bitmap(picturepath);
            pic.Image = (Image)photo;
            
            
        }
        public void GetWord(string strContent)
        {
            object path;//文件路径
           
            MSWord.Application wordApp;//Word应用程序变量
            MSWord.Document wordDoc;//Word文档变量
            path = "d:\\myWord.doc";//保存为Word2003文档
            // path = "d:\\myWord.doc";//保存为Word2007文档
            wordApp = new MSWord.ApplicationClass();//初始化
            if (File.Exists((string)path))
            {
                File.Delete((string)path);
            }
            Object Nothing = Missing.Value;
            wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);

            wordApp.Selection.ParagraphFormat.LineSpacing = 35f;//设置文档的行间距
            //写入普通文本
            wordApp.Selection.ParagraphFormat.FirstLineIndent = 30;//首行缩进的长度
            
            wordDoc.Paragraphs.Last.Range.Text = strContent;
            object format = MSWord.WdSaveFormat.wdFormatDocument;
            wordDoc.SaveAs(ref path, ref format, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
            wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
            wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);
           

        }
        public void FirstPhoto(string path, PictureBox pic)
        {
            Bitmap firstphoto = new Bitmap(path);
            pic.Image = (Image)firstphoto;
        }
            
       


    }
}
