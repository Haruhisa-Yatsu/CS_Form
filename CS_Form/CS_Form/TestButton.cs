﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace CS_Form
{
    class TestButton : Button
    {


        /// <summary>
        /// ボタンをクリックした際にラベルを更新したいため、
        /// Form1への参照を保管しておく
        /// </summary>
        Form1 _form1;

        /// <summary>
        /// コンストラクタ
        /// クラスを生成したときに呼び出される
        /// </summary>
        public TestButton(Form1 form1, string str , int x, int y, int width, int height)
        {

            // Form1のインスタンスを保管
            _form1 = form1;

            // ClickイベントにOnClick関数を登録
            // ボタンをクリックした時に登録した関数を実行します。
            Click += OnClick;

            // ボタン内に文字を表示させる
            Text = str;

            // ボタンの生成場所を指定
            Location = new Point(x, y);

            //　ボタンの大きさを指定
            Size = new Size(width, height);
        }

        /// <summary>
        /// ボタンをクリックした際の処理を記述する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="s"></param>
        public void OnClick(object sender, EventArgs s)
        {
            string t = _form1.ButtonLabelReplacement(Text);

            Text = t;

            _form1.LabelTextUpdate(Text);
        }
    }
}
