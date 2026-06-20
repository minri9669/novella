using project.DialogMnager.бурмаджа_.dialogue;
using project.EndingManager.EndingUsee;
using project.MiniGame3.HelpClass;
using project.MiniGame3.Skip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class MainFormGame : Form
    {
        private SkipDialogs skipd = new SkipDialogs();
        private BaseText bt = new BaseText();
        private List<DialogueLine> currentDialogList;
        private int currentDialogIndex = 0;
        private bool isDialogPlaying = false;
        private bool isWaitingForEnter = false;
        private string currentFullText = "";
        private int currentSprites = -1;
        private int currentBackground = -1;

        private List<Image> SpritesImages;
        private List<Image> BackgroundImages;

        EndingUse eu = new EndingUse();
        public MainFormGame()
        {
            InitializeComponent();
            LoadImagesToList();
            panel1.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            panel1.BackColor = Color.FromArgb(128, 0, 0, 0);
            label1.BackColor = Color.FromArgb(128, 0, 0, 0);

            panel1.Visible = true;
            label1.Visible = true;
            pictureBox2.Visible = true;
            panel2.Visible = false;

            skipd.OnTextUpdated += (text) =>
            {
                if (label2.InvokeRequired)
                    label2.Invoke(new Action(() => label2.Text = text));
                else
                    label2.Text = text;
            };

            skipd.OnTypingComplete += () =>
            {
                isWaitingForEnter = true;

            };

            timer1.Start();
            this.KeyDown += MainFormGame_KeyDown;
            this.Shown += MainFormGame_Shown;
            this.Select();
            
        }
        private void MainFormGame_Shown(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            pictureBox2.Visible = true;
            label2.Visible = true;

            currentDialogList = bt.GetDialog(0);
            currentDialogIndex = 0;
            isDialogPlaying = true;
            currentSprites = -1;
            currentBackground = -1;
            currentFullText = "";

            ShowNextDialog();
        }

        //Диалоги и скип
        private void LoadImagesToList()
        {
            SpritesImages = new List<Image>
            {
                //Properties.Resources.image1,
                //Properties.Resources.image2
            };

            BackgroundImages = new List<Image>
            {
                //Properties.Resources.BackgroundMiniGame2,
                //Properties.Resources.KoncoBkuBackgroind
            };
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                HandleEnterPress();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MainFormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HandleEnterPress();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void HandleEnterPress()
        {
            if (skipd.IsTyping())
            {
                skipd.Skip();
                currentFullText = skipd.GetFullText();

                if (label2.InvokeRequired)


                    isWaitingForEnter = true;
                return;
            }

            if (isWaitingForEnter)
            {
                isWaitingForEnter = false;
                if (label2.InvokeRequired)
                    label2.Invoke(new Action(() =>
                    {
                        string currentText = label2.Text;
                        label2.Text = currentText;
                    }));
                else
                {
                    string currentText = label2.Text;
                    label2.Text = currentText;
                }
                ShowNextDialog();
            }
        }

        private void ShowNextDialog()
        {
            if (currentDialogIndex < currentDialogList.Count)
            {
                var dialog = currentDialogList[currentDialogIndex];
                string be;
                if (dialog.Name == "Автор") { be = dialog.Text + "\n\n"; }
                else { be = dialog.Name + ":  " + dialog.Text + "\n\n"; }
                richTextBox1.Text += be;
                if (dialog.Name == "Автор")
                {
                    pictureBox2.Visible = false;
                    if (label1.InvokeRequired)
                        label1.Invoke(new Action(() => label1.Visible = false));
                    else
                        label1.Visible = false;
                }
                else
                {
                    pictureBox2.Visible = true;
                    if (label1.InvokeRequired)
                        label1.Invoke(new Action(() =>
                        {
                            label1.Visible = true;
                            label1.Text = dialog.Name;
                        }));
                    else
                    {
                        label1.Visible = true;
                        label1.Text = dialog.Name;
                    }
                }
                if (dialog.indIm != currentSprites)
                {
                    currentSprites = dialog.indIm;
                    if (pictureBox2.InvokeRequired)
                    {
                        pictureBox2.Invoke(new Action(() =>
                        {
                            if (dialog.indIm >= 0 && dialog.indIm < SpritesImages.Count)
                                pictureBox2.Image = SpritesImages[dialog.indIm];
                        }));
                    }
                    else
                    {
                        if (dialog.indIm >= 0 && dialog.indIm < SpritesImages.Count)
                            pictureBox2.Image = SpritesImages[dialog.indIm];
                    }
                }

                if (dialog.intImB != currentBackground)
                {
                    currentBackground = dialog.intImB;
                    if (pictureBox1.InvokeRequired)
                    {
                        pictureBox1.Invoke(new Action(() =>
                        {
                            if (dialog.intImB >= 0 && dialog.intImB < BackgroundImages.Count)
                                pictureBox1.Image = BackgroundImages[dialog.intImB];
                        }));
                    }
                    else
                    {
                        if (dialog.intImB >= 0 && dialog.intImB < BackgroundImages.Count)
                            pictureBox1.Image = BackgroundImages[dialog.intImB];
                    }
                }

                if (label2.InvokeRequired)
                    label2.Invoke(new Action(() => label2.Text = ""));
                else
                    label2.Text = "";

                currentFullText = "";

                skipd.StartTyping(dialog.Text, 30);
                currentDialogIndex++;
                isWaitingForEnter = false;
            }
            else
            {
                if (panel1.InvokeRequired)
                    panel1.Invoke(new Action(() =>
                    {
                        panel1.Visible = false;
                        label1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox1.Image = Properties.Resources.backgroundMiniGame2;

                    }));
                else
                {
                    panel1.Visible = false;
                    label1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Image = Properties.Resources.backgroundMiniGame2;
                }

                isDialogPlaying = false;
                isWaitingForEnter = false;
                currentFullText = "";

                this.Select();
            }
        }



        //Концовки
        private void button1_Click(object sender, EventArgs e)
        {
            EndingsLabel2.Text = eu.ShowAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EndingsLabel2.Text = eu.ShowAllUnlocked();
        }

        public void Unlocking(string a)
        {
            eu.Unlocking(a);
        }
    }
}
