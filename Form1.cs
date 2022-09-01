using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TouhouPlaylistHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lines = File.ReadAllLines("videos.txt");
            authors = File.ReadAllLines("authors.txt").ToList();
            games = File.ReadAllLines("games.txt").ToList();
            characters = File.ReadAllLines("characters.txt").ToList();
            CharacterOutBox1.AutoCompleteCustomSource.AddRange(characters.ToArray());
            CharacterOutBox2.AutoCompleteCustomSource.AddRange(characters.ToArray());
            CharacterOutBox3.AutoCompleteCustomSource.AddRange(characters.ToArray());
            CharacterOutBox4.AutoCompleteCustomSource.AddRange(characters.ToArray());
            CharacterOutBox5.AutoCompleteCustomSource.AddRange(characters.ToArray());
            CharacterOutBox6.AutoCompleteCustomSource.AddRange(characters.ToArray());
            AuthorOutBox.AutoCompleteCustomSource.AddRange(authors.ToArray());
            CharacterBoxes = new List<TextBox>{ CharacterOutBox1, CharacterOutBox2, CharacterOutBox3, CharacterOutBox4, CharacterOutBox5, CharacterOutBox6 };
            bool spec = false;
            foreach (string game in games)
            {
                string ga = "";
                if (game == "==SPECIAL==")
                {
                    spec = true;
                    continue;
                }
                if (!spec)
                    game.Split(' ').ToList().ForEach(x => ga += x[0]);
                else
                    ga = game;
                GameOutBox.AutoCompleteCustomSource.Add(ga);
            }
            
            foreach (string line in File.ReadAllLines("themes.txt"))
            {
                string[] f = line.Split('=');
                string[] s = f[0].Split('-');
                themes.Add(new ThemeEntry(s[0].Trim(), s[1].Trim(), f[1].Trim()));
            }
        }

        string[] lines = new string[] { };
        bool f = true;
        int pos = -1;
        string lastAuthor = "";
        string lastVocal = "";
        string url = "";
        List<string> authors = new List<string>();
        List<string> games = new List<string>();
        List<string> characters = new List<string>();
        List<ThemeEntry> themes = new List<ThemeEntry>();
        List<TextBox> CharacterBoxes = new List<TextBox>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (TitleOutBox.Text != "" && IdOutBox.Text != "" && AuthorOutBox.Text != "" & CharacterOutBox1.Text != "")
            {

                if (!f)
                {
                    string characters = "";
                    foreach (TextBox t in CharacterBoxes)
                    {
                        if (t.Text != "")
                        {
                            characters += "$" + t.Text;
                        }
                    }
                    characters = characters.Substring(1);


                    File.AppendAllText("playlist.txt", $"{TitleOutBox.Text} | {IdOutBox.Text} | {AuthorOutBox.Text} | {characters} | {GameOutBox.Text}\n");
                }
                else
                {
                    f = false;
                }
                pos++;

                if (LoadNew.Checked)
                {
                    lines[pos] = lines[pos].Trim().Replace("\"title\": ", "");
                    TitleOutBox.Text = lines[pos];
                    TitleOutBox.Text = TitleOutBox.Text.Remove(TitleOutBox.Text.Length - 1, 1);
                    List<string> a = authors.Where(x => lines[pos].Contains(x)).ToList();
                    lastAuthor = AuthorOutBox.Text;
                    if (a.Any())
                    {
                        if (a.Any(x => x == "ZUN") && a.Count > 1)
                            AuthorOutBox.Text = a.Where(x => x != "ZUN").First();
                        else
                            AuthorOutBox.Text = a.First();
                        if(a.Count > 1)
                            TitleOutBox.Text = TitleOutBox.Text.Replace(a.First(), "");
                    }
                    else
                        AuthorOutBox.Text = "";
                    TitleBox.Text = lines[pos];
                    TitleOutBox.Text = RemoveBetween(TitleOutBox.Text, '【', '】').Replace("\"", "").Trim();
                    pos++;
                    DescriptionBox.Text = lines[pos].Replace("\\n", "\r\n").TrimStart();
                    if (AuthorOutBox.Text == "")
                    {
                        a = authors.Where(x => lines[pos].Contains(x)).ToList();
                        if (a.Any())
                            AuthorOutBox.Text = a.First();
                    }

                    List<string> c = characters.Where(x => lines[pos].Contains(x)).ToList();

                    foreach (TextBox t in CharacterBoxes)
                    {
                        t.Text = "";
                    }

                    if (c.Any())
                    {
                        int cha = 0;
                        foreach (string ch in c)
                        {
                            CharacterBoxes[cha].Text = ch;
                            if (cha == 5)
                                break;
                            else
                                cha++;
                        }
                    }




                    List<string> g = games.Where(x => lines[pos].Contains(x)).ToList();
                    if (g.Any())
                    {
                        string ga = "";
                        g.First().Split(' ').ToList().ForEach(x => ga += x[0]);
                        GameOutBox.Text = ga;
                    }
                    else
                    {
                        List<ThemeEntry> posgames = themes.Where(x => x.character == CharacterOutBox1.Text).ToList();
                        if (posgames.Any())
                            GameOutBox.Text = posgames.First().game;
                        else
                            GameOutBox.Text = "";
                    }


                    foreach (ThemeEntry te in themes)
                    {
                        if (DescriptionBox.Text.Contains(te.orig))
                        {
                            CharacterOutBox1.Text = te.character;
                            GameOutBox.Text = te.game;
                        }
                    }

                    pos++;
                    if (lines[pos].Contains("\"url\":"))
                    {
                        pos++;
                    }
                    IdOutBox.Text = lines[pos].Split(':')[1].Replace("\"", "").Trim();
                    label6.Text = "Pos: " + pos;
                }
                else
                {
                    lastAuthor = AuthorOutBox.Text;
                    TitleOutBox.Text = "";
                    AuthorOutBox.Text = "";
                    CharacterOutBox1.Text = "";
                    CharacterOutBox2.Text = "";
                    CharacterOutBox3.Text = "";
                    CharacterOutBox4.Text = "";
                    CharacterOutBox5.Text = "";
                    CharacterOutBox6.Text = "";
                    GameOutBox.Text = "";
                    IdOutBox.Text = "";
                }
            }
        }
        string RemoveBetween(string text, char startingpoint, char endpoint)
        {
            string newtext = "";
            bool rem = false;
            foreach(char c in text)
            {
                if (!rem)
                {
                    if (c == startingpoint)
                        rem = true;                  
                    else
                        newtext += c;
                }
                else
                {
                    if (c == endpoint)
                        rem = false;
                }
            }
            return newtext;
        }

        private void CharacterOutBox_TextChanged(object sender, EventArgs e)
        {
            if(CharacterOutBox1.Text == "non")
            {
                CharacterOutBox1.Text = "Non touhou";
                ActiveControl = null;
                GameOutBox.Text = "Non touhou";
            }
            else if (CharacterOutBox1.Text == "com")
            {
                CharacterOutBox1.Text = "Compilation";
                ActiveControl = null;
                GameOutBox.Text = "Compilation";
            }
            if(GameOutBox.Text == "" && CharacterOutBox1.Text.Length > 2)
            {
                List<ThemeEntry> posgam = themes.Where(x => x.character == CharacterOutBox1.Text).ToList();
                if (posgam.Any())
                    GameOutBox.Text = posgam.First().game;
            }

        }
        public class ThemeEntry
        {
            public string character = "";
            public string game = "";
            public string orig = "";
            public ThemeEntry(string cha, string gam, string or)
            {
                character = cha;
                game = gam;
                orig = or;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<ThemeEntry> posgam = themes.Where(x => x.character == CharacterOutBox1.Text && !CharacterOutBox1.Text.Contains("Stage")).ToList();
            if (posgam.Any())
                GameOutBox.Text = posgam.First().game;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AuthorOutBox.Text = lastAuthor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VocalOutBox.Text = lastVocal;
        }
    }
}
