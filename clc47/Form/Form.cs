using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace calc
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Common c = new Common();
        private Logic logic = new Logic();
        private T_displayDto dis = new T_displayDto();

        public Form()
        {
            InitializeComponent();
            DataGridView();
            ComBoxView();
            TxtBoxView();
            ChkBoxView();
            ChangeEv();
            result();
            this.Text = "とあるIFダメージ計算@ちゃんサバ";
            this.Icon = new System.Drawing.Icon(@"icon.ico");
        }

        private void Form_Load(object sender, EventArgs e) { }

        private string[] col1 = { "小", "中", "大", "特大", "超特" };
        private string[] col2 = { "クリあり", "クリなし", "攻撃", "防御", "推定防御(逆算)" };

        private void DataGridView()
        {
            dis.buflist = new List<T_bufDto>();
            dis.buflist = logic.LoadbufAll();
            dis.feslist = logic.Loadfes();

            DataGridView d = dataGridView_buf;
            d.ColumnCount = col1.Length;
            d.RowCount = dis.buflist.Count();
            for (int i = 0; i < d.ColumnCount; i++) d.Columns[i].Name = col1[i];
            for (int i = 0; i < d.RowCount; i++)
            {
                d.Rows[i].HeaderCell.Value = dis.buflist[i].name;
                string[] tmp = { "" + dis.buflist[i].cnts, "" + dis.buflist[i].cntm, "" + dis.buflist[i].cntl, "" + dis.buflist[i].cntxl, "" + dis.buflist[i].cntxxl };
                string[] tmp2 = { "" + dis.buflist[i].bufs, "" + dis.buflist[i].bufm, "" + dis.buflist[i].bufl, "" + dis.buflist[i].bufxl, "" + dis.buflist[i].bufxxl };
                for (int j = 0; j < d.ColumnCount; j++)
                {
                    d[j, i].Value = tmp[j];
                    d[j, i].ToolTipText = "倍率 "+tmp2[j];
                    if (String.IsNullOrEmpty(tmp2[j]) || tmp2[j].Equals("0"))
                    {
                        d[j, i].Style.BackColor = Color.LightGray;
                        d[j, i].ToolTipText = "未使用";
                    }
                }
            }
            d.DefaultCellStyle.NullValue = "0";
            d.TopLeftHeaderCell.Value = "個数";

            DataGridView d2 = dataGridView_res;
            d2.ColumnCount = col2.Length;
            d2.RowCount = dis.feslist.Count();
            for (int i = 0; i < d2.ColumnCount; i++) d2.Columns[i].Name = col2[i];
            for (int i = 0; i < d2.RowCount; i++) d2.Rows[i].HeaderCell.Value = dis.feslist[i].header;
            d2.DefaultCellStyle.NullValue = "0";
            d2.TopLeftHeaderCell.Value = "加護(中, 大)";
            if (d.GetClipboardContent() != null) Clipboard.SetDataObject(d.GetClipboardContent());
            if (d2.GetClipboardContent() != null) Clipboard.SetDataObject(d2.GetClipboardContent());
            InitGrid();
        }

        private void TxtBoxView()
        {
            var table = new Dictionary<string, Label>
            {
                { "SLV", label_slv },
                { "ATK_A", label_atkA },
                { "ATK_B", label_atkB },
                { "HP", label_hp },
                { "MAXHP", label_maxhp },
                { "ATKBONUS", label_atkBonus },
                { "CHRBONUS", label_chrBonus },
                { "DMG", label_antidmg }
            };
            var table2 = new Dictionary<string, TextBox>
            {
                { "SLV", textBox_slv },
                { "ATK_A", textBox_atkA },
                { "ATK_B", textBox_atkB },
                { "HP", textBox_hp },
                { "MAXHP", textBox_maxhp },
                { "ATKBONUS", textBox_atkBonus },
                { "CHRBONUS", textBox_chrBonus },
                { "DMG", textBox_antidmg }
            };

            dis.txt = logic.Loadtxtall();
            foreach (T_objectDto i in dis.txt)
            {
                switch (i.pk)
                {
                    case "DEF":
                        label_def.Text = i.name;
                        comboBox_def.Text = i.val.ToString();
                        break;
                    case "BUFNUM":
                        trackBar_n.Text = i.name;
                        dis.num = (int)i.val;
                        if (dis.num < 0) dis.num = 0;
                        if (dis.num > 10) dis.num = 10;
                        trackBar_n.Value = dis.num;
                        break;
                    default:
                        foreach (string key in table.Keys)
                        {
                            if (i.pk == key) table[key].Text = i.name;
                        }
                        foreach (string key in table2.Keys)
                        {
                            if (i.pk == key)
                            {
                                table2[key].Text = i.val.ToString();
                            }
                        }

                        break;
                }
            }
            InitTxt();
        }

        private void ComBoxView()
        {
            var table = new Dictionary<ComboBox, List<string>>
            {
                { comboBox_type, logic.Loadpulldown("COL") },
                { comboBox_super, logic.Loadpulldown("SUP") },
                { comboBox_bonus, logic.Loadpulldown("BON") },
                { comboBox_def, logic.Loadpulldown("DEF") },
                { comboBox_sp, logic.Loadsp1pull() },
                { comboBox_sp2, logic.Loadsp2pull() }
            };
            foreach(var key in table.Keys) key.DataSource = table[key];
            ComBoxView2();
        }
        private void ComBoxView2()
        {
            var table = new Dictionary<string, ComboBox>
            {
                { "COL", comboBox_type },
                { "SUP", comboBox_super },
                { "BONUS", comboBox_bonus },
                { "DEF", comboBox_def },
                { "SP1", comboBox_sp },
                { "SP2", comboBox_sp2 }
            };
            dis.idx = logic.Loadidxall();
            foreach (T_objectDto i in dis.idx)
            {
                foreach (string key in table.Keys)
                {
                    if (i.pk == key) table[key].SelectedIndex = logic.tryStr(i.val.ToString());
                }
            }

            List<String> item1 = logic.Loadsp1pull();
            List<String> item2 = logic.Loadsp2pull();

            comboBox_sp.MaxDropDownItems = item1.Count;
            comboBox_sp2.MaxDropDownItems = item2.Count;
            int maxSize = 0;
            int maxSize2 = 0;
            for (int i = 0; i < item1.Count; i++)
            {
                maxSize = Math.Max(maxSize, TextRenderer.MeasureText(item1[i], comboBox_sp.Font).Width);
            }
            for (int i = 0; i < item2.Count; i++)
            {
                maxSize2 = Math.Max(maxSize, TextRenderer.MeasureText(item2[i], comboBox_sp2.Font).Width);
            }
            comboBox_sp.DropDownWidth = maxSize + 20;
            comboBox_sp2.DropDownWidth = maxSize2 + 20;

            InitCom();
        }

        public void ChkBoxView()
        {
            var table = new Dictionary<string, CheckBox>
            {
                { "MATCH", checkBox_match },
                { "P1_PM", checkBox_pm },
                { "P1_PL", checkBox_pl },
                { "P1_FUKU", checkBox_fuku },
                { "P1_SHIEN", checkBox_shien },
                { "P2_VEC", checkBox_vec },
                { "P2_VECM", checkBox_vecm },
                { "P2_VECL", checkBox_vecl },
                { "P2_LNK", checkBox_lnk },
                { "P2_ANAS", checkBox_anas },
                { "P2_ANAM", checkBox_anam },
                { "BREAK", checkBox_break }
            };
            dis.chk = logic.Loadchkall();
            foreach (T_objectDto i in dis.chk)
            {
                switch (i.pk)
                {
                    case "FESM":
                        dis.fesm = i.val;
                        break;
                    case "FESL":
                        dis.fesl = i.val;
                        break;
                    default:
                        foreach (string key in table.Keys)
                        {
                            if (i.pk == key)
                            {
                                table[key].Text = i.name;
                                table[key].Checked = i.chk;
                                toolTip1.SetToolTip(table[key], "倍率 " + i.val);
                            }
                        }
                        break;
                }
                InitChk();
            }
        }

        private void InitTxt()
        {
            foreach (T_objectDto i in dis.txt)
            {
                switch (i.pk)
                {
                    case "SLV":
                        dis.slv = logic.tryStr(textBox_slv.Text);
                        i.val = logic.tryStr2(textBox_slv.Text);
                        break;
                    case "ATK_A":
                        dis.atkA = logic.tryStr(textBox_atkA.Text);
                        i.val = logic.tryStr2(textBox_atkA.Text);
                        break;
                    case "ATK_B":
                        dis.atkB = logic.tryStr(textBox_atkB.Text);
                        i.val = logic.tryStr2(textBox_atkB.Text);
                        break;
                    case "DEF":
                        dis.def = logic.tryStr(comboBox_def.Text);
                        i.val = logic.tryStr2(comboBox_def.Text);
                        break;
                    case "HP":
                        dis.hp = logic.tryStr(textBox_hp.Text);
                        i.val = logic.tryStr2(textBox_hp.Text);
                        break;
                    case "MAXHP":
                        dis.maxhp = logic.tryStr(textBox_maxhp.Text);
                        i.val = logic.tryStr2(textBox_maxhp.Text);
                        break;
                    case "ATKBONUS":
                        dis.atkBonus = logic.tryStr2(textBox_atkBonus.Text);
                        i.val = dis.atkBonus;
                        break;
                    case "CHRBONUS":
                        dis.chrBonus = logic.tryStr2(textBox_chrBonus.Text);
                        i.val = dis.chrBonus;
                        break;
                    case "DMG":
                        dis.realdmg = logic.tryStr2(textBox_antidmg.Text);
                        i.val = dis.realdmg;
                        break;
                    case "BUFNUM":
                        dis.num = trackBar_n.Value;
                        i.val = logic.tryStr2(dis.num.ToString());
                        toolTip1.SetToolTip(trackBar_n, i.val + "個");
                        break;
                    default:
                        break;
                }
            }
        }

        private void InitChk()
        {
            foreach (T_objectDto i in dis.chk)
            {
                switch (i.pk)
                {
                    case "MATCH":
                        dis.matchBuf = checkBox_match.Checked ? i.val: 1;
                        i.chk = checkBox_match.Checked;
                        break;
                    case "P1_PM":
                        dis.pm = checkBox_pm.Checked ? i.val: 0;
                        i.chk = checkBox_pm.Checked;
                        break;
                    case "P1_PL":
                        dis.pl = checkBox_pl.Checked ? i.val: 0;
                        i.chk = checkBox_pl.Checked;
                        break;
                    case "P1_FUKU":
                        dis.fuku = checkBox_fuku.Checked ? i.val: 0;
                        i.chk = checkBox_fuku.Checked;
                        break;
                    case "P1_SHIEN":
                        dis.shien = checkBox_shien.Checked ? i.val: 0;
                        i.chk = checkBox_shien.Checked;
                        break;
                    case "P2_VEC":
                        dis.vec = checkBox_vec.Checked ? i.val: 0;
                        i.chk = checkBox_vec.Checked;
                        break;
                    case "P2_VECM":
                        dis.vecm = checkBox_vecm.Checked ? i.val: 0;
                        i.chk = checkBox_vecm.Checked;
                        break;
                    case "P2_VECL":
                        dis.vecl = checkBox_vecl.Checked ? i.val: 0;
                        i.chk = checkBox_vecl.Checked;
                        break;
                    case "P2_LNK":
                        dis.lnk = checkBox_lnk.Checked ? i.val: 0;
                        i.chk = checkBox_lnk.Checked;
                        break;
                    case "P2_ANAS":
                        dis.anas = checkBox_anas.Checked ? i.val: 0;
                        i.chk = checkBox_anas.Checked;
                        break;
                    case "P2_ANAM":
                        dis.anam = checkBox_anam.Checked ? i.val: 0;
                        i.chk = checkBox_anam.Checked;
                        break;
                    case "BREAK":
                        dis.breakBuf = checkBox_break.Checked ? i.val : 1;
                        i.chk = checkBox_break.Checked;
                        break;
                    default:
                        break;
                }
            }
        }

        private void InitCom()
        {
            dis.colorBuf = logic.LoadpulldownVal("COL", comboBox_type.Text);
            dis.superBuf = logic.LoadpulldownVal("SUP", comboBox_super.Text);
            dis.partyBuf = logic.LoadpulldownVal("BON", comboBox_bonus.Text);
            dis.def = logic.tryStr(comboBox_def.Text);
            dis.sp1 = comboBox_sp.Text;
            dis.sp2 = comboBox_sp2.Text;
            var table = new Dictionary<string, ComboBox>
            {
                { "COL", comboBox_type },
                { "SUP", comboBox_super },
                { "BON", comboBox_bonus }
            };
            foreach (var key in table.Keys)
            {
                toolTip1.SetToolTip(table[key], "倍率 " + logic.LoadpulldownVal(key, table[key].Text));
            }
            toolTip1.SetToolTip(comboBox_sp, "倍率 " + logic.Loadsp1(comboBox_sp.Text).buf);
            toolTip1.SetToolTip(comboBox_sp2, "倍率 " + logic.Loadsp2(comboBox_sp2.Text).buf);
        }

        private void InitGrid()
        {
            DataGridView d = dataGridView_buf;
            d.AllowUserToAddRows = true;
            d.DefaultCellStyle.NullValue = "0";
            int count = 0;
            foreach (T_bufDto i in dis.buflist)
            {
                i.cnts = Cast(d[0, count].Value);
                i.cntm = Cast(d[1, count].Value);
                i.cntl = Cast(d[2, count].Value);
                i.cntxl = Cast(d[3, count].Value);
                i.cntxxl = Cast(d[4, count].Value);
                count++;
            }
            d.AllowUserToAddRows = false;
        }

        private static int Cast(object val)
        {
            if (val == null) return 0;
            return new Logic().tryStr(val.ToString());
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            InitTxt();
            result();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            InitChk();
            result();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitCom();
            result();
        }

        private void dataGridView_buf_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            InitGrid();
            result();
        }

        private void trackBar_n_Scroll(object sender, EventArgs e)
        {
            InitTxt();
            result();
        }

        private void ChangeEv()
        {
            CheckBox[] chk = new CheckBox[] {
                checkBox_match,
                checkBox_pm,
                checkBox_pl,
                checkBox_fuku,
                checkBox_shien,
                checkBox_vec,
                checkBox_vecm,
                checkBox_vecl,
                checkBox_lnk,
                checkBox_anas,
                checkBox_anam,
                checkBox_break
            };
            foreach (CheckBox i in chk) i.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);

            ComboBox[] com = new ComboBox[]
            {
                comboBox_type,
                comboBox_super,
                comboBox_bonus,
                comboBox_def,
                comboBox_sp,
                comboBox_sp2
            };
            foreach (ComboBox i in com) i.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);

            TextBox[] txt = new TextBox[]
            {
                textBox_slv,
                textBox_atkA,
                textBox_atkB,
                textBox_hp,
                textBox_maxhp,
                textBox_atkBonus,
                textBox_chrBonus,
                textBox_antidmg
            };
            foreach (TextBox i in txt) i.TextChanged += new System.EventHandler(this.textBox_TextChanged);

            comboBox_def.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            trackBar_n.Scroll += new System.EventHandler(this.trackBar_n_Scroll);
            dataGridView_buf.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_buf_CellValueChanged);
        }

        private void Button_ClickSav(object sender, EventArgs e)
        {
            var table = new Dictionary<string, ComboBox>
            {
                { "COL", comboBox_type },
                { "SUP", comboBox_super },
                { "BONUS", comboBox_bonus },
                { "DEF", comboBox_def },
                { "SP1", comboBox_sp },
                { "SP2", comboBox_sp2 }
            };
            dis.idx = logic.Loadidxall();
            foreach (T_objectDto i in dis.idx)
            {
                foreach (string key in table.Keys)
                {
                    if (i.pk == key) i.val = logic.tryStr2(table[key].SelectedIndex.ToString());
                }
            }
            logic.UpdateBuf(dis.buflist);
            logic.UpdateTxt(dis.txt);
            logic.UpdateChk(dis.chk);
            logic.UpdateIdx(dis.idx);
            MessageBox.Show("現在の状態を保存しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Button_ClickClear(object sender, EventArgs e)
        {
            ComBoxView2();
            TxtBoxView();
            ChkBoxView();
            //
            DataGridView d = dataGridView_buf;
            for (int i = 0; i < d.RowCount; i++)
            {
                for (int j = 0; j < d.ColumnCount; j++) d[j, i].Value = "0";
            }
            DataGridView d2 = dataGridView_res;
            for (int i = 0; i < d2.RowCount; i++)
            {
                for (int j = 0; j < d2.ColumnCount; j++) d2[j, i].Value = "0";
            }
            InitGrid();
        }
        private void Button_ClickOut(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"result.txt", false, Encoding.UTF8))
            {
                sw.WriteLine("計算結果");
                sw.WriteLine("加護(中, 大) :実値");
                DataGridView d = dataGridView_res;
                for (int j = 0; j < d.ColumnCount; j++)
                {
                    sw.WriteLine(col2[j]);
                    for (int i = 0; i < d.RowCount; i++)
                    {
                        sw.WriteLine(dis.feslist[i].header + " :" + d[j, i].Value);
                    }
                    sw.WriteLine("");
                }
            }
            System.Diagnostics.Process.Start("notepad.exe", @"result.txt");
        }

        private void result()
        {
            DataGridView d = dataGridView_res;
            d.AllowUserToAddRows = true;
            dis.feslist = c.resultLst(dis);
            int count = 0;
            foreach (T_resultDto i in dis.feslist)
            {
                string[] tmp = { i.output_dmgcri, i.output_dmg, i.output_atk, i.output_def, i.output_anti };
                for(int j = 0; j < tmp.Length; j++) d[j, count].Value = tmp[j];
                count++;
            }
            d.AllowUserToAddRows = false;
        }
    }
}
