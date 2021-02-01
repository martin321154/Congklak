using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Congklak2
{
    public partial class Form1 : Form
    {
        public struct VAL{
            public int round;
            public int player;
            public int[,] val;
            public int next_player;
            public string[,] pd;
            public int[,] rc;
        }
        struct INFO
        {
            public int num;
            public string brief;
        }

        //variants
        VAL current_val = new VAL();
        List<INFO> info = new List<INFO>();
        string[] playername = new string[2];
        List<VAL> game_record = new List<VAL>();
        int dots = 5;
        //const


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            current_val.val = new int[2, 7];
            current_val.rc = new int[2, 7];
            for (int i = 1; i < 7; i++)
            {
                current_val.val[0, i] = 0;
                current_val.val[1, i] = 0;
            }
            current_val.pd = new string[2, 7];
            bt_open();
            lb_playturn.Visible = false;

            FileInfo infoF = new FileInfo("D:\\study\\info.txt");
            StreamReader sr = infoF.OpenText();
            while (sr.Peek() >= 0)
            {
                string str = sr.ReadLine();
                string[] cnt = str.Split(" Dots:");
                INFO temp = new INFO();
                temp.num = Int32.Parse(cnt[0]);
                string[] cnt_ = cnt[1].Split("  -");
                temp.brief = cnt_[1];
                info.Add(temp);
            }
            sr.Close();
            lb_sn.Text = (info.Count + 1).ToString();
        }

        private void init_game()
        {
            game_record.Clear();
            playername[0] = tb_player1.Text;
            playername[1] = tb_player2.Text;
            current_val.round = 0;
            current_val.player = -1;
            current_val.next_player = 0;
            current_val.val = new int[2, 7];
            
            for(int i=1; i<7; i++)
            {
                current_val.val[0, i] = dots;
                current_val.pd[0, i] = "      ";
                current_val.val[1, i] = dots;
                current_val.pd[0, i] = "      ";
            }
            ls_add(current_val);
            tb_player1.Enabled = false;
            tb_player2.Enabled = false;

            for (int i = 0; i < 7; i++)
            {
                Label lb_a, lb_b;
                lb_a = (Label)this.Controls.Find("lb_a" + i.ToString(), true)[0];
                lb_b = (Label)this.Controls.Find("lb_b" + i.ToString(), true)[0];
                lb_a.Text = current_val.val[0, i].ToString("00");
                lb_b.Text = current_val.val[1, i].ToString("00");
            }

            bt_open();
            new_file(tb_bf.Text, tb_dt.Text);
        }

        private void bt_open()
        {
            bool bt_a_open = false;
            bool bt_b_open = false;

            if (current_val.next_player == 0)
            {
                lb_playturn.Visible = true;
                lb_playturn.Text = playername[0] + " Turn";
                bt_a_open = true;
                bt_b_open = false;
            }
            else if(current_val.next_player == 1)
            {
                lb_playturn.Visible = true;
                lb_playturn.Text = playername[1] + " Turn";
                bt_a_open = false;
                bt_b_open = true;
            }

            for (int i = 1; i < 7; i++)
            {
                Button bt_a, bt_b;
                bt_a = (Button)this.Controls.Find("bt_a" + i, true)[0];
                bt_b = (Button)this.Controls.Find("bt_b" + i, true)[0];
                bt_a.Enabled = bt_a_open;
                bt_b.Enabled = bt_b_open;

                if ((current_val.next_player == 0) && bt_a_open == true)
                {
                    if (current_val.val[0, i] == 0)
                    {
                        bt_a.Enabled = false;
                        current_val.rc[0, i] = 0;
                        bt_a.BackColor = Color.White;
                    }
                    else
                    {
                        int result = predict(i);
                        if (result < -2)
                        {
                            int temp = Math.Abs(result);
                            temp--;
                            temp /= 10;
                            bt_a.Text = "A" + i.ToString() + "(A:" + temp.ToString() + ")";
                            bt_a.BackColor = Color.PaleGreen;
                            current_val.pd[0,i] = "(A:" + temp.ToString("00") + ")";
                            current_val.rc[0, i] = temp * 10;
                        }
                        else
                        {
                            switch (result)
                            {
                                case -1:
                                    bt_a.Text = "A" + i.ToString() + "(WIN)";
                                    current_val.pd[0, i] = "(WIN) ";
                                    current_val.rc[0, i] = 1;
                                    bt_a.BackColor = Color.Gold;
                                    break;
                                case -2:
                                    bt_a.Text = "A" + i.ToString() + "(LOSE)";
                                    current_val.pd[0, i] = "(LOSE)";
                                    current_val.rc[0, i] = -1;
                                    bt_a.BackColor = Color.White;
                                    break;
                                default:
                                    bt_a.Text = "A" + i.ToString() + "(H:" + result.ToString() + ")";
                                    current_val.pd[0, i] = "(H:" + result.ToString("00") + ")";
                                    current_val.rc[0, i] = -result * 10;
                                    bt_a.BackColor = Color.PeachPuff;
                                    break;
                            }
                        }
                    }
                }
                else if((current_val.next_player == 1) && bt_b_open == true)
                {
                    if (current_val.val[1, i] == 0)
                    {
                        current_val.rc[1, i] = 0;
                        bt_b.Enabled = false;
                        bt_b.BackColor = Color.White;
                    }
                    else
                    {
                        int result = predict(i);
                        if (result < -2)
                        {
                            int temp = Math.Abs(result);
                            temp--;
                            temp /= 10;
                            bt_b.Text = "B" + i.ToString() + "(A:" + temp.ToString() + ")";
                            current_val.pd[1, i] = "(A:" + temp.ToString("00") + ")";
                            current_val.rc[1, i] = temp*10;
                            bt_b.BackColor = Color.PaleGreen;
                        }
                        else
                        {
                            switch (result)
                            {
                                case -1:
                                    bt_b.Text = "B" + i.ToString() + "(LOSE)";
                                    current_val.pd[1, i] = "(LOSE)";
                                    current_val.rc[1, i] = -1;
                                    bt_b.BackColor = Color.White;
                                    break;
                                case -2:
                                    bt_b.Text = "B" + i.ToString() + "(WIN)";
                                    current_val.pd[1, i] = "(WIN) ";
                                    current_val.rc[1, i] =1;
                                    bt_b.BackColor = Color.Gold;
                                    break;
                                default:
                                    bt_b.Text = "B" + i.ToString() + "(H:" + result.ToString() + ")";
                                    current_val.pd[1, i] = "(H:" + result.ToString("00") + ")";
                                    current_val.rc[1, i] = -result * 10;
                                    bt_b.BackColor = Color.PeachPuff;
                                    break;
                            }
                        }
                    }
                }
                if (current_val.pd[0, i] == null)
                {
                    current_val.pd[0, i] = "      ";
                }
                if (current_val.pd[1, i] == null)
                {
                    current_val.pd[1, i] = "      ";
                }

                int player = current_val.player;
                string[] index = new string[2];
                index[0] = "bt_a";
                index[1] = "bt_b";

                
            }
        }

        private int predict(int select_hole)
        {
            VAL pre = new VAL();
            pre.val = new int[2, 7];
            pre.next_player = current_val.next_player;
            pre.player = current_val.player;
            pre.round = current_val.round;
            for(int i=0; i<7; i++)
            {
                pre.val[0, i] = current_val.val[0, i];
                pre.val[1, i] = current_val.val[1, i];
            }

            pre.round++;
            pre.player = pre.next_player;
            pre.next_player = (pre.player + 1) % 2;

            int inhand = pre.val[pre.player, select_hole];
            int[] current_hole = new int[2];

            current_hole[0] = pre.player;
            current_hole[1] = select_hole;

            pre.val[current_hole[0], current_hole[1]] = 0;

            while (inhand > 0)
            {
                current_hole[1]--;
                if (current_hole[1] <= 0)
                {
                    if (current_hole[0] != pre.player)
                    {
                        current_hole[0] = (current_hole[0] + 1) % 2;
                        current_hole[1] = 6;
                    }
                    else if (current_hole[1] < 0)
                    {
                        current_hole[0] = (current_hole[0] + 1) % 2;
                        current_hole[1] = 6;
                    }
                }
                inhand--;
                pre.val[current_hole[0], current_hole[1]]++;
                if (inhand == 0 && pre.val[current_hole[0], current_hole[1]] > 1)
                {
                    if (current_hole[1] != 0)
                    {
                        inhand = pre.val[current_hole[0], current_hole[1]];
                        pre.val[current_hole[0], current_hole[1]] = 0;
                    }
                }
            }

            if (current_hole[0] == pre.player)//grab
            {
                if (current_hole[1] == 0)
                {
                    pre.next_player = pre.player;
                }
                else if (pre.val[(current_hole[0] + 1) % 2, 7 - current_hole[1]] != 0)
                {
                    pre.val[current_hole[0], 0] +=
                        pre.val[(current_hole[0] + 1) % 2, 7 - current_hole[1]];
                    pre.val[current_hole[0], 0]++;
                    pre.val[(current_hole[0] + 1) % 2, 7 - current_hole[1]] = 0;
                    pre.val[current_hole[0], current_hole[1]] = 0;
                }
            }

            int sum = 0;
            for (int i = 1; i < 7; i++)
            {
                sum += pre.val[pre.next_player, i];
            }
            if (sum == 0)
            {
                pre.next_player = (pre.next_player + 1) % 2;
            }

            int _sum = pre.val[0, 0] + pre.val[1, 0];
            int _differ = pre.val[0, 0] - pre.val[1, 0];
            if (Math.Abs(_differ) > (12 * dots - _sum))
            {
                pre.next_player = -1;
                lb_playturn.Visible = true;
                if (_differ > 0)
                {
                    return -1;
                }
                else
                {
                    return -2;
                }
            }
            if (pre.next_player != pre.player)
            {
                return pre.val[pre.player, 0];
            }
            else
            {
                return -pre.val[pre.player, 0] * 10 - 1;
            }
        }

        private void go_step(int select_hole)
        {
            current_val.round++;
            current_val.player = current_val.next_player;
            current_val.next_player = (current_val.player + 1) % 2;

            int inhand = current_val.val[current_val.player, select_hole];
            int[] current_hole = new int[2];

            current_hole[0] = current_val.player;
            current_hole[1] = select_hole;

            current_val.val[current_hole[0], current_hole[1]] = 0;

            while (inhand > 0)
            {
                current_hole[1]--;
                if (current_hole[1] <= 0)
                {
                    if (current_hole[0] != current_val.player)
                    {
                        current_hole[0] = (current_hole[0] + 1) % 2;
                        current_hole[1] = 6;
                    }
                    else if(current_hole[1]<0)
                    {
                        current_hole[0] = (current_hole[0] + 1) % 2;
                        current_hole[1] = 6;
                    }
                }
                inhand--;
                current_val.val[current_hole[0], current_hole[1]]++;
                if(inhand==0 && current_val.val[current_hole[0], current_hole[1]] > 1)
                {
                    if (current_hole[1] != 0)
                    {
                        inhand = current_val.val[current_hole[0], current_hole[1]];
                        current_val.val[current_hole[0], current_hole[1]] = 0;
                    }
                }
            }

            if (current_hole[0] == current_val.player)//grab
            {
                if (current_hole[1] == 0)
                {
                    current_val.next_player = current_val.player;
                }
                else if(current_val.val[(current_hole[0] + 1) % 2, 7 - current_hole[1]]!=0)
                {
                    current_val.val[current_hole[0], 0] +=
                        current_val.val[(current_hole[0] + 1) % 2, 7 - current_hole[1]];
                    current_val.val[current_hole[0], 0]++;
                    current_val.val[(current_hole[0] + 1) % 2, 7 - current_hole[1]] = 0;
                    current_val.val[current_hole[0], current_hole[1]] = 0;
                }
            }
            

            for (int i = 0; i < 7; i++)
            {
                Label lb_a, lb_b;
                lb_a = (Label)this.Controls.Find("lb_a" + i.ToString(), true)[0];
                lb_b = (Label)this.Controls.Find("lb_b" + i.ToString(), true)[0];
                lb_a.Text = current_val.val[0, i].ToString("00");
                lb_b.Text = current_val.val[1, i].ToString("00");
            }

            int sum=0;
            for(int i=1;i<7; i++)
            {
                sum += current_val.val[current_val.next_player, i];
            }
            if (sum == 0)
            {
                current_val.next_player = (current_val.next_player + 1) % 2;
            }

            int _sum = current_val.val[0, 0] + current_val.val[1, 0];
            int _differ = current_val.val[0, 0] - current_val.val[1, 0];
            bool over = false;
            if (Math.Abs(_differ) > (12 * dots - _sum))
            {
                current_val.next_player = -1;
                lb_playturn.Visible = true;
                if (_differ > 0)
                {
                    lb_playturn.Text = playername[0]+" Win";
                }
                else
                {
                    lb_playturn.Text = playername[1] + " Win";
                }
                current_val.next_player = -1;
                over = true;
                no_dots.Value++;
            }

            bt_open();
            ls_add(current_val);
        }

        private void new_file(string bf, string dt)
        {
            FileInfo newfile = new FileInfo("D:\\study\\Data" + lb_sn.Text + ".txt");
            StreamWriter sw = newfile.CreateText();
            sw.WriteLine(dt);
            sw.WriteLine("           |    B6    |    B5    |    B4    |    B3    |    B2    |    B1    |    B0    |");
            sw.WriteLine("|    A0    |    A1    |    A2    |    A3    |    A4    |    A5    |    A6    |");
            sw.WriteLine();
            sw.Flush();
            sw.Close();

            INFO temp = new INFO();
            temp.num = info.Count + 1;
            temp.brief = bf;
            info.Add(temp);

            FileInfo infoF = new FileInfo("D:\\study\\info.txt");
            StreamWriter sw_info = infoF.AppendText();
            sw_info.WriteLine(lb_sn.Text + " Dots:" + dots.ToString() + "  -" + bf);
            sw_info.Flush();
            sw_info.Close();
            lb_sn.Text = (info.Count + 1).ToString();
        }

        private void record(VAL inp)
        {
            FileInfo data_f = new FileInfo("D:\\study\\Data" + info.Count + ".txt");
            StreamWriter sw = data_f.AppendText();
            string str = "Round: "+inp.round.ToString("000") + "            |";
            for (int j = 6; j >0; j--)
            {
                str = str + " "+inp.val[1, j].ToString("00") + inp.pd[1,j] + " |";
            }
            str = str + "    " + inp.val[1, 0].ToString("00") + "    |";
            sw.WriteLine(str);

            str = "player: " + inp.player.ToString("0") + "  |    "+ inp.val[0, 0].ToString("00")+ "    |";
            for (int j = 1; j <7; j++)
            {
                str = str + " " + inp.val[0, j].ToString("00") + inp.pd[1, j] + " |";
            }
            sw.WriteLine(str);
            sw.WriteLine();

            
        }

        private void post_record(VAL inp, int py)
        {
            FileInfo data_f = new FileInfo("D:\\study\\Data" + info.Count + ".txt");
            StreamWriter sw = data_f.AppendText();
            string str;
            if (py == 0)
            {
                str = "           |";
                for (int i = 6; i > 0; i--)
                {
                    str = str + " " + inp.val[1, i].ToString("00") + "       |";
                }
                str = str + "    " + inp.val[1, 0].ToString("00") + "    |";
                sw.WriteLine(str);

                str = "|    " + inp.val[0, 0].ToString("00") + "    |";
                for (int i = 1; i < 7; i++)
                {
                    str = str + " " + inp.val[0, i].ToString("00") + "       |";
                }
                sw.WriteLine(str);
            }
            else
            {
                str = "           |";
                for (int i = 6; i > 0; i--)
                {
                    str = str + " " + inp.val[1, i].ToString("00") + "       |";
                }
                str = str + "    " + inp.val[1, 0].ToString("00") + "    |";
                sw.WriteLine(str);

                str = "|    " + inp.val[0, 0].ToString("00") + "    |";
                for (int i = 1; i < 7; i++)
                {
                    str = str + " " + inp.val[0, i].ToString("00") + "       |";
                }
                sw.WriteLine(str);
            }
            sw.WriteLine();
            sw.WriteLine();
            sw.Flush();
            sw.Close();
        }

        private void pre_record(VAL inp, int py,int select)
        {
            FileInfo data_f = new FileInfo("D:\\study\\Data" + info.Count + ".txt");
            StreamWriter sw = data_f.AppendText();
            string str;
            if (py == 0)
            {
                str = "           |";
                for (int i = 6; i > 0; i--)
                {
                    str = str + " " + inp.val[1, i].ToString("00") + "       |";
                }
                str = str + "    " + inp.val[1, 0].ToString("00") + "    |";
                sw.WriteLine(str);

                str = "|    " + inp.val[0, 0].ToString("00") + "    |";
                for (int i = 1; i < 7; i++)
                {
                    if (select == i)
                        str = str + "*";
                    else
                        str = str + " ";
                    str = str  + inp.val[0, i].ToString("00") + inp.pd[0, i] + " |";
                }
                sw.WriteLine(str);
            }
            else
            {
                str = "           |";
                for (int i = 6; i > 0; i--)
                {
                    if (select == i)
                        str = str + "*";
                    else
                        str = str + " ";
                    str = str + inp.val[1, i].ToString("00") + inp.pd[1, i] + " |";
                }
                str = str + "    " + inp.val[1, 0].ToString("00") + "    |";
                sw.WriteLine(str);

                str = "|    " + inp.val[0, 0].ToString("00") + "    |";
                for (int i = 1; i < 7; i++)
                {
                    str = str + " " + inp.val[0, i].ToString("00") +"       |";
                }
                sw.WriteLine(str);
            }
            sw.WriteLine(">>");
            sw.Flush();
            sw.Close();
        }

        private void title(int rd,int py)
        {
            FileInfo data_f = new FileInfo("D:\\study\\Data" + info.Count + ".txt");
            StreamWriter sw = data_f.AppendText();
            string str = "Round: " + rd.ToString("000") + " Palyer:" + py.ToString("0") ;
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
        }

        private void bt_a1_Click(object sender, EventArgs e)
        {
            title(current_val.round + 1, 0);
            pre_record(current_val, 0, 1);
            go_step(1);
            post_record(current_val, 0);
        }

        private void bt_a2_Click(object sender, EventArgs e)
        {
            title(current_val.round + 1, 0);
            pre_record(current_val, 0, 2);
            go_step(2);
            post_record(current_val, 0);
        }

        private void bt_a3_Click(object sender, EventArgs e)
        {
            title(current_val.round + 1, 0);
            pre_record(current_val, 0, 3);
            go_step(3);
            post_record(current_val, 0);
        }

        private void bt_a4_Click(object sender, EventArgs e)
        {
            title(current_val.round + 1, 0);
            pre_record(current_val, 0, 4);
            go_step(4);
            post_record(current_val, 0);
        }

        private void bt_a5_Click(object sender, EventArgs e)
        {
            title(current_val.round + 1, 0);
            pre_record(current_val, 0, 5);
            go_step(5);
            post_record(current_val, 0);
        }

        private void bt_a6_Click(object sender, EventArgs e)
        {
            title(current_val.round + 1, 0);
            pre_record(current_val, 0, 6);
            go_step(6);
            post_record(current_val, 0);
        }

        private void bt_b1_Click(object sender, EventArgs e)
        {
            title(current_val.round + 1, 1);
            pre_record(current_val, 1, 1);
            go_step(1);
            post_record(current_val, 1);
        }

        private void bt_b2_Click(object sender, EventArgs e)
        {
            title(current_val.round + 1, 1);
            pre_record(current_val, 1, 2);
            go_step(2);
            post_record(current_val, 1);
        }

        private void bt_b3_Click(object sender, EventArgs e)
        {
            title(current_val.round + 1, 1);
            pre_record(current_val, 1, 3);
            go_step(3);
            post_record(current_val, 1);
        }

        private void bt_b4_Click(object sender, EventArgs e)
        {
            title(current_val.round + 1, 1);
            pre_record(current_val, 1, 4);
            go_step(4);
            post_record(current_val, 1);
        }

        private void bt_b5_Click(object sender, EventArgs e)
        {
            title(current_val.round + 1, 1);
            pre_record(current_val, 1, 5);
            go_step(5);
            post_record(current_val, 1);
        }

        private void bt_b6_Click(object sender, EventArgs e)
        {
            title(current_val.round + 1, 1);
            pre_record(current_val, 1, 6);
            go_step(6);
            post_record(current_val, 1);
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            if (dots <= 0)
            {
                MessageBox.Show("Dots Can't equal 0!", "Warning");
            }
            else
            {
                dots = (int)no_dots.Value;
                init_game();
            }
        }

        private void ls_add(VAL inp)
        {
            VAL temp = new VAL();
            temp.next_player = inp.next_player;
            temp.player = inp.player;
            temp.round = inp.round;

            temp.pd = new string[2, 7];
            temp.val = new int[2, 7];
            for(int i=0; i<7; i++)
            {
                temp.pd[0, i] = inp.pd[0, i];
                temp.pd[1, i] = inp.pd[1, i];
                temp.val[0, i] = inp.val[0, i];
                temp.val[1, i] = inp.val[1, i];
            }
            game_record.Add(temp);
        }

        private void cb_again_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_again.Checked == true)
            {
                cb_Home.Checked = false;
            }
            else
            {
                cb_Home.Checked = true;
            }
        }

        private void cb_Home_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Home.Checked == true)
            {
                cb_again.Checked = false;
            }
            else
            {
                cb_again.Checked = true;
            }
        }
    }
}
