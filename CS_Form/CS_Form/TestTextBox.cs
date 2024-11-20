using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    class TestTextBox : TextBox
    {
        /// <summary>
        /// コンストラクタ
        /// クラスを生成したときに呼び出される
        /// </summary>
        public TestTextBox(string str, int x, int y,
            int width, int height)
        {
            // ラベル内に文字を表示させる
            Text = str;

            // ボタンの生成場所を指定
            Location = new Point(x, y);

            //　ボタンの大きさを指定
            Size = new Size(width, height);
        }

        /// <summary>
        /// 指定されたテキストで更新し
        /// もともとのテキストを返す関数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string TextReplacement(string str)
        {
            string temp = Text;

            Text = str;

            return temp;
        }


    }
}
