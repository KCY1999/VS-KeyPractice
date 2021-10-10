using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace 期末作業
{
    public partial class Form1 : Form
    {
        Random rd = new Random();                //亂數
        PictureBox[] pic = new PictureBox[5];//五張圖的陣列
        int[] bb = new int[5];                           //圖內文字之陣列
        int[] point = new int[5];                      //排行玩家得分紀錄上限的陣列
        string[] user = new string[5];             //排行玩家上限的陣列
        int index, hippo=0,score = 0, space = 10, time = 60, GG = 0, pp = 0;
        //圖片參數,人,分數,圖移動格數,時間,遊戲開始的初使值,換場景之值

        public Form1()
        {
            InitializeComponent();
            read();//讀檔,先前玩家的紀錄
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("遊戲開始前請看'關於'內的遊戲說明");
            axWindowsMediaPlayer1.URL = "音樂檔\\戰鬥BGM.mp3"; //背景音樂
            pic[0] = pictureBox1;
            pic[1] = pictureBox2;
            pic[2] = pictureBox3;
            pic[3] = pictureBox4;
            pic[4] = pictureBox5;
            dis();
            AP();
        }

        private void timer1_Tick(object sender, EventArgs e)//timer1使圖片重複落下
        {
            for (int i = 0; i < 5; i++)//使用for迴圈,產生亂數圖後使其掉落
            {
                if (pic[i].Top + pic[i].Height >= 415)
                {
                    pic[i].Top = rd.Next(60, 125);
                    index = i;  //避免圖片重複
                    rdP();
                    score -= 5;
                    label4.Text = score.ToString();
                }
                pic[i].Top += space;
                gameover();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)//timer2時間倒數60 sec
        {
            time--;
            label2.Text = time.ToString();
            if (time == 0)  //判斷時間歸零後所要執行的動作
            {
                開始ToolStripMenuItem.Enabled = false;
                tef();
                point[hippo] = score;  //第x人所得之分數
                MessageBox.Show("遊戲結束 " + " 獲得分數:" + score.ToString());
                Re();
                dis();
                if(hippo<4)
                hippo += 1; //小於4人時每次紀錄加1人
                write();  //將分數寫入記事本
            }
        }

        private void timer3_Tick(object sender, EventArgs e)//timer3闖關模式內變換場景與速率的各項判斷式
        {
            if (score >= 200 && score < 500 && pp != 1)
            {
                BackgroundImage = Image.FromFile(("古圖\\" + "pokemon3" + ".png"));
                timer1.Interval = 550;
                pp = 1;  //避免反覆換圖造成的閃爍
            }
            if (score >= 500 && score < 900 && pp != 2)
            {
                BackgroundImage = Image.FromFile(("古圖\\" + "pokemon5" + ".png"));
                timer1.Interval = 300;
                pp = 2;
            }
            if (score >= 900 && pp != 3)
            {
                BackgroundImage = Image.FromFile(("古圖\\" + "pokemon1" + ".png"));
                timer1.Interval = 90;
                pp = 3;
            }
            while (score > 2000)
            {
                Re();
                tef();
                dis();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)//按下按鍵後開始判斷
        {
            if (GG == 0)//避免剛進入遊戲不小心按到按鍵便結束遊戲的防呆措施
            {
                return;
            }
            int x;
            x = e.KeyChar;
            for (int i = 0; i < 5; i++)
            {
                if (bb[i] == x)
                {
                    axWindowsMediaPlayer2.URL = "音樂檔\\音效.wav";
                    score += 10;
                    pic[i].Top = rd.Next(33, 127); //答對後亂數換圖
                    index = i;//避免換到重複之圖片
                    rdP();
                    label4.Text = score.ToString();
                    return;
                }
            }
            if (bb[0] != x && bb[1] != x && bb[2] != x && bb[3] != x && bb[4] != x)//答錯時扣分
            {
                score -= 5;
                label4.Text = score.ToString();
            }
            gameover();
        }

        private void 開始ToolStripMenuItem_Click(object sender, EventArgs e)//主要為暫停後用以繼續之功能
        {
            start();
            簡單ToolStripMenuItem.Enabled = false;
            中等ToolStripMenuItem.Enabled = false;
            困難ToolStripMenuItem.Enabled = false;
            地獄ToolStripMenuItem.Enabled = false;
            闖關模式ToolStripMenuItem.Enabled = false;
        }
        private void 暫停ToolStripMenuItem_Click(object sender, EventArgs e)//停止動作
        {
            GG = 0;
            tef();
            dis();
        }
        private void 重新挑戰ToolStripMenuItem_Click(object sender, EventArgs e)//每次結束或失敗皆須按下此鍵
        {
            BackgroundImage = Image.FromFile(("古圖\\" + "pokemon" + ".jpg"));
            dis();
            Re();
            開始ToolStripMenuItem.Enabled = true;
            暫停ToolStripMenuItem.Enabled = true;
            簡單ToolStripMenuItem.Enabled = true;
            中等ToolStripMenuItem.Enabled = true;
            困難ToolStripMenuItem.Enabled = true;
            地獄ToolStripMenuItem.Enabled = true;
            闖關模式ToolStripMenuItem.Enabled = true;
        }
        private void 結束ToolStripMenuItem1_Click(object sender, EventArgs e)//離開
        {
            Environment.Exit(0);
        }
        private void 簡單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(("古圖\\" + "pokemon2" + ".png"));
            mf();
            timer1.Interval = 700;
            start();
            cf();
        }
        private void 中等ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(("古圖\\" + "pokemon3" + ".png"));
            mf();
            timer1.Interval = 500;
            start();
            cf();
        }
        private void 困難ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(("古圖\\" + "pokemon4" + ".jpg"));
            mf();
            timer1.Interval = 300;
            start();
            cf();
        }
        private void 地獄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(("古圖\\" + "pokemon5" + ".png"));
            mf();
            timer1.Interval = 150;
            start();
            cf();
        }
        private void 闖關模式ToolStripMenuItem_Click(object sender, EventArgs e)//闖關模式,不斷加速以及變換場景
        {
            MessageBox.Show("闖關模式內一但開始便不能暫停，每當分數達到一定標準便會加速，試著破關吧!!!!!");
            BackgroundImage = Image.FromFile(("古圖\\" + "pokemon2" + ".png"));
            mf();
            start();
            timer1.Interval = 800;
            timer3.Enabled = true;
            time = 150;
            開始ToolStripMenuItem.Enabled = false;
            暫停ToolStripMenuItem.Enabled = false;
            cf();
        }
        private void 排行榜ToolStripMenuItem_Click(object sender, EventArgs e)//紀錄並顯示玩家分數
        {
            sort();
            string st = "";//顯示玩家分數
            int a = hippo;
            if (a < 4)      //避免人數未達時排行多顯示一人
                a = a - 1;
            for (int i = 0; i <= a; i++)
            {
                st += user[i] + "的成績為" + point[i].ToString() + "分" + "\r\n";
            }
            MessageBox.Show(st);
        }
        private void 背景音樂ToolStripMenuItem_Click(object sender, EventArgs e)//音效開
        {
            axWindowsMediaPlayer1.settings.volume = 60;
        }
        private void 點擊音樂ToolStripMenuItem_Click(object sender, EventArgs e)//音效開
        {
            axWindowsMediaPlayer2.settings.volume = 60;
        }
        private void 全部音效ToolStripMenuItem_Click(object sender, EventArgs e)//音效開
        {
            axWindowsMediaPlayer1.settings.volume = 60;
            axWindowsMediaPlayer2.settings.volume = 60;
        }
        private void 背景音樂ToolStripMenuItem1_Click(object sender, EventArgs e)//音效關
        {
            axWindowsMediaPlayer1.settings.volume = 0;
        }
        private void 點擊音樂ToolStripMenuItem1_Click(object sender, EventArgs e)//音效關
        {
            axWindowsMediaPlayer2.settings.volume = 0;
        }
        private void 全部音效ToolStripMenuItem1_Click(object sender, EventArgs e)//音效關
        {
            axWindowsMediaPlayer1.settings.volume = 0;
            axWindowsMediaPlayer2.settings.volume = 0;
        }
        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e) //遊戲說明 必看
        {
            MessageBox.Show("這是個打字練習遊戲，進入遊戲後可直接點選'開始'進行遊戲，" +
                                            "不過不納入排行。選擇'模式'內的各種難度，得分才會納入排行。" +
                                            "按下暫停後須再次按下'開始'才會繼續，每次遊戲結束後都需再次按下'重新挑戰'，" +
                                            "按下重新挑戰即可重新選擇難度。");
        } 
        /*===================================自訂function===================================*/
        void rdP()//遊戲開始後,圖片亂數
        {
            int x;
            x = rd.Next(33, 127);
            pic[index].Image = Image.FromFile("古圖\\" + x.ToString() + ".png");
            bb[index] = x;//設圖片內之值為x
            for (int i = 0; i < 5; i++)
            {
                while (x == bb[i] && index != i)//判斷圖片是否重複
                {
                    x = rd.Next(33, 127);
                    pic[index].Image = Image.FromFile("古圖\\" + x.ToString() + ".png");
                    bb[index] = x;
                    i = 0;
                }
            }
        }
        void AP()//開始遊戲時,圖片亂數
        {
            int x;
            for (int i = 0; i < 5; i++)
            {
                x = rd.Next(33, 127);
                pic[i].Image = Image.FromFile("古圖\\" + x.ToString() + ".png");
                bb[i] = x;
                for (int j = 0; j < i; j++)//避免圖片重複
                {
                    while (bb[i] == bb[j])
                    {
                        x = rd.Next(33, 127);
                        pic[i].Image = Image.FromFile("古圖\\" + x.ToString() + ".png");
                        bb[i] = x;
                        j = 0;
                    }
                }
            }
        }
        void Re()//遊戲回到初始狀態
        {
            GG = 0;
            AP();
            tef();
            timer1.Interval = 800;
            time = 60;
            score = 0;
            label2.Text = time.ToString();
            label4.Text = score.ToString();
            pictureBox1.Top = rd.Next(60, 125);
            pictureBox2.Top = rd.Next(60, 125);
            pictureBox3.Top = rd.Next(60, 125);
            pictureBox4.Top = rd.Next(60, 125);
            pictureBox5.Top = rd.Next(60, 125);
        }
        void tef()//時間暫停
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }
        void dis()//圖片消失
        {
            pic[0].Visible = false;
            pic[1].Visible = false;
            pic[2].Visible = false;
            pic[3].Visible = false;
            pic[4].Visible = false;
        }
        void gameover()//分數低於0時,遊戲結束
        {
            if (score < 0)
            {
                tef();
                MessageBox.Show("挑戰失敗，你好爛");
                Re();
                dis();
                開始ToolStripMenuItem.Enabled = false;
            }
        }
        void start()//遊戲開始,物件啟用
        {
            GG = 1;
            timer1.Enabled = true;
            timer2.Enabled = true;
            pic[0].Visible = true;
            pic[1].Visible = true;
            pic[2].Visible = true;
            pic[3].Visible = true;
            pic[4].Visible = true;
        }
        void cf()//停用按鍵
        {
            簡單ToolStripMenuItem.Enabled = false;
            中等ToolStripMenuItem.Enabled = false;
            困難ToolStripMenuItem.Enabled = false;
            地獄ToolStripMenuItem.Enabled = false;
            闖關模式ToolStripMenuItem.Enabled = false;
        }
        void mf()//輸入玩家姓名
        {
            user[hippo] = Interaction.InputBox("輸入名稱", "輸入名稱", "名稱", -1, -1);
        }
        void sort()//氣泡排序(傳址),依分數高到低
        {
            int tmp;
            string tmpp = "";
            for (int i = hippo; i > 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (point[i] > point[j])
                    {
                        tmp = point[i];
                        point[i] = point[j];
                        point[j] = tmp;
                        tmpp = user[i];//玩家名稱需跟對應分數一併移動
                        user[i] = user[j];
                        user[j] = tmpp;
                    }
                }
            }
        }
        void read()//讀檔
        {
            StreamReader sr;
            try
            {
                sr = new StreamReader("排行榜.txt");//讀取記事本的資料
            }
            catch
            {
                MessageBox.Show("無法讀取檔案");
                return;
            }
            try
            {
                hippo = Convert.ToInt32(sr.ReadLine());
            }
            catch
            {
                hippo = 0;
            }
            for (int i = 0; i <= hippo; i++)
            {
                user[i] = sr.ReadLine();
                point[i] = Convert.ToInt32(sr.ReadLine());
            }
            sr.Close();
        }
        void write()//寫入
        {
            StreamWriter wr;
            wr = new StreamWriter("排行榜.txt");//寫入排行資訊到記事本內
            wr.WriteLine(hippo.ToString());
            for (int i = 0; i <= hippo; i++)
            {
                wr.WriteLine(user[i]);
                wr.WriteLine(point[i].ToString());
            }
            wr.Flush();
            wr.Close();
        }   
    }
}