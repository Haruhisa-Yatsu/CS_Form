using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// ラベルの文字列を更新するために
        /// 参照を保管しておく
        /// </summary>
        TestLabel _testLabel;

        TestTextBox _textBox;

        public Form1()
        {
            // コンポーネントの初期化
            InitializeComponent();

            string[] strs =
            {
                "あか",
                "あお",
                "きいろ",
                "みどり",
                "くろ",
                "しろ",
                "ちゃいろ",
                "ピンク",
                "むらさき",
                "きみどり"
            };


            //　テストボタンを10個作成する
            for (int i = 0; i < 10; i++)
            {
                // ボタンの表示処理
                TestButton testButton = new TestButton(this, strs[i],(i % 5) * 100, (i / 5) * 100, 100, 100);
                
                // ボタンの追加
                Controls.Add(testButton);
            }

            // ラベルの作成
            _testLabel = new TestLabel("らべるです。", 10,250,500,50);
            
            // ラベルの追加
            Controls.Add(_testLabel);


            // テキストボックスの作成
            _textBox = new TestTextBox(
                "てきすとぼっくすです",10,300,500,100);

            Controls.Add(_textBox);

            //Label label = new Label();
            //label.Location = new Point(30,400);
            //label.Text = "らべるです。";
            //Controls.Add(label);
        }

        /// <summary>
        /// ラベルの文字を更新する
        /// </summary>
        /// <param name="str"></param>
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }


        public string ButtonLabelReplacement(string str)
        {
            string s = _textBox.TextReplacement(str);


            return s;
        }



    }
}
