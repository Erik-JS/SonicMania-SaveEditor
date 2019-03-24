using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicMania_SaveEditor
{
    public partial class Form1 : Form
    {

        private string _lastHandledFile;
        private int _currentSlot;
        private CheckBox[] _emeraldCheckboxes;
        private RadioButton[] _slotOptButtons;
        private Button[] _medalButtons;
        private Color[] _medalColors;
        private Button[] _encoreCharButtons;
        private int[] _encoreCurrentChars;
        private Dictionary<int, string> _charDesc;

        public Form1()
        {
            InitializeComponent();
            _lastHandledFile = null;
            _currentSlot = 0;
            _encoreCharButtons = new Button[] { btnChar1, btnChar2, btnChar3, btnChar4, btnChar5 };
            _charDesc = new Dictionary<int, string>() { { 0, "" }, { 1, "S" }, { 2, "T" }, { 3, "K" }, { 4, "M" }, { 5, "R" } };
            _emeraldCheckboxes = new CheckBox[] { chkEmerald1, chkEmerald2, chkEmerald3, chkEmerald4, chkEmerald5, chkEmerald6, chkEmerald7 };
            _slotOptButtons = new RadioButton[] { opt1, opt2, opt3, opt4, opt5, opt6, opt7, opt8, null, null, opt11, opt12, opt13 };
            _medalButtons = new Button[32];
            _medalButtons[0] = btnBS1;
            int x = 0;
            Size medalButtonSize = new Size(32, 32);
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 8; b++)
                {
                    if (x != 0) // we already have the first button
                    {
                        _medalButtons[x] = new Button();
                        _medalButtons[x].Size = medalButtonSize;
                        _medalButtons[x].BackColor = Color.White;
                        _medalButtons[x].Location = new Point(b * 32 + btnBS1.Location.X, a * 32 + btnBS1.Location.Y);
                        tabPage2.Controls.Add(_medalButtons[x]);
                    }
                    _medalButtons[x].TabIndex = 1 + x;
                    x++;
                }
            }
            _medalColors = new Color[] { Color.White, Color.Silver, Color.Gold };
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SaveData.bin|SaveData.bin";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            if (!Savedata.LoadFromFile(ofd.FileName, true))
                return;
            _lastHandledFile = ofd.FileName;
            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
            tabControl1.Visible = true;
            UpdateSaveSlotPage();
            UpdateMedalPage();
        }

        private void UpdateSaveSlotPage()
        {
            cboState.SelectedIndex = Savedata.GetSlotState(_currentSlot);
            UpdateCharacterView();
            txtLives.Text = Savedata.GetLivesCount(_currentSlot).ToString();
            txtContinues.Text = Savedata.GetContinues(_currentSlot).ToString();
            txtScore.Text = Savedata.GetScore(_currentSlot).ToString();
            txtTargetScore.Text = Savedata.GetTargetScore(_currentSlot).ToString();
            cboZone.SelectedIndex = Savedata.GetZone(_currentSlot);
            for (int i = 0; i < _emeraldCheckboxes.Length; i++)
                _emeraldCheckboxes[i].Checked = Savedata.IsEmeraldActive(_currentSlot, i);
            cboSpecialStage.SelectedIndex = Savedata.GetNextSpecialStage(_currentSlot);
            btnResetGR.Enabled = Savedata.WasGiantRingUsedInCurrentZone(_currentSlot);
        }

        private void UpdateCharacterView()
        {
            bool isEncore = _currentSlot > 8;

            cboCharacter.Visible = !isEncore;
            foreach (var btn in _encoreCharButtons)
                btn.Visible = isEncore;

            if (!isEncore)
            {
                cboCharacter.SelectedIndex = Savedata.GetPlayableCharacter(_currentSlot);
                return;
            }

            _encoreCurrentChars = Savedata.GetEncoreCharacters(_currentSlot);

            for (int i = 0; i < _encoreCharButtons.Length; i++)
            {
                _encoreCharButtons[i].Text = _charDesc[_encoreCurrentChars[i]];
            }
        }

        private void UpdateMedalPage()
        {
            for (int i = 0; i < _medalButtons.Length; i++)
            {
                MedalButtonTag mbt = (MedalButtonTag)_medalButtons[i].Tag;
                mbt.value = Savedata.GetBonusStageStatus(mbt.index);
                _medalButtons[i].BackColor = _medalColors[mbt.value];
            }
            txtSilver.Text = Savedata.GetSilverMedalCount().ToString();
            txtGold.Text = Savedata.GetGoldMedalCount().ToString();
        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            Savedata.SetSlotState(_currentSlot, cboState.SelectedIndex);
        }

        private void cboZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            Savedata.SetZone(_currentSlot, cboZone.SelectedIndex);
        }

        private void txtLives_TextChanged(object sender, EventArgs e)
        {
            int lives;
            if (!int.TryParse(txtLives.Text, out lives))
                return;
            Savedata.SetLivesCount(_currentSlot, lives);
        }

        private void txtLives_Leave(object sender, EventArgs e)
        {
            txtLives.Text = Savedata.GetLivesCount(_currentSlot).ToString();
        }

        private void txtContinues_TextChanged(object sender, EventArgs e)
        {
            int continues;
            if (!int.TryParse(txtContinues.Text, out continues))
                return;
            Savedata.SetContinues(_currentSlot, continues);
        }

        private void txtContinues_Leave(object sender, EventArgs e)
        {
            txtContinues.Text = Savedata.GetContinues(_currentSlot).ToString();
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            int score;
            if (!int.TryParse(txtScore.Text, out score))
                return;
            Savedata.SetScore(_currentSlot, score);
        }

        private void txtScore_Leave(object sender, EventArgs e)
        {
            txtScore.Text = Savedata.GetScore(_currentSlot).ToString();
        }

        private void txtTargetScore_TextChanged(object sender, EventArgs e)
        {
            int targetScore;
            if (!int.TryParse(txtTargetScore.Text, out targetScore))
                return;
            Savedata.SetTargetScore(_currentSlot, targetScore);
        }

        private void txtTargetScore_Leave(object sender, EventArgs e)
        {
            txtTargetScore.Text = Savedata.GetTargetScore(_currentSlot).ToString();
        }

        private void cboCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Savedata.SetPlayableCharacter(_currentSlot, cboCharacter.SelectedIndex);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Savedata.SaveToFile(_lastHandledFile))
                MessageBox.Show("Done.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*.bin|*.bin";
            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            if (!Savedata.SaveToFile(sfd.FileName))
                return;
            _lastHandledFile = sfd.FileName;
            MessageBox.Show("Done.\n\n" + _lastHandledFile, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetUpEmeraldCheckboxTagsAndEvents();
            SetUpSlotOptButtonsTagsAndEvents();
            SetUpMedalButtonsTagsAndEvents();
            SetUpEncoreCharButtonsTagsAndEvents();
        }

        private void SetUpEncoreCharButtonsTagsAndEvents()
        {
            for(int i = 0; i < _encoreCharButtons.Length; i++)
            {
                _encoreCharButtons[i].Click += EncoreCharButton_Click;
                _encoreCharButtons[i].Tag = i;
            }
        }

        private void EncoreCharButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int idx = (int)clickedButton.Tag;
            _encoreCurrentChars[idx] = (_encoreCurrentChars[idx] + 1) % 6;
            clickedButton.Text = _charDesc[_encoreCurrentChars[idx]];
            Savedata.SetEncoreCharacters(_currentSlot, _encoreCurrentChars);
        }

        private void SetUpEmeraldCheckboxTagsAndEvents()
        {
            for(int i = 0; i < _emeraldCheckboxes.Length; i++)
            {
                _emeraldCheckboxes[i].CheckedChanged += EmeraldCheckboxes_CheckedChanged;
                _emeraldCheckboxes[i].Tag = i;
            }
        }

        private void EmeraldCheckboxes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int emerald = (int)checkBox.Tag;
            Savedata.SetEmeraldState(_currentSlot, emerald, checkBox.Checked);
        }

        private void SetUpSlotOptButtonsTagsAndEvents()
        {
            for (int x = 0; x < _slotOptButtons.Length; x++)
            {
                if (_slotOptButtons[x] != null)
                {
                    _slotOptButtons[x].CheckedChanged += SlotOptButtons_CheckedChanged;
                    _slotOptButtons[x].Tag = x;
                }
            }
        }

        private void SlotOptButtons_CheckedChanged (object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender; // Happy now, Microsoft?
            _currentSlot = (int)radioButton.Tag;
            UpdateSaveSlotPage();
        }

        private void SetUpMedalButtonsTagsAndEvents()
        {
            for (int m = 0; m < _medalButtons.Length; m++)
            {
                _medalButtons[m].Click += MedalButton_Click;
                MedalButtonTag mbt = new MedalButtonTag() { index = m, value = 0 };
                _medalButtons[m].Tag = mbt;
            }
        }

        private void MedalButton_Click(object sender, EventArgs e)
        {
            Button medalButton = (Button)sender;
            MedalButtonTag mbt = (MedalButtonTag)medalButton.Tag;
            mbt.value = ++mbt.value % 3;
            medalButton.BackColor = _medalColors[mbt.value];
            Savedata.SetBonusStageStatus(mbt.index, mbt.value);
            int s = Savedata.CalculateSilverMedals();
            int g = Savedata.CalculateGoldMedals();
            Savedata.SetSilverMedalCount(s);
            txtSilver.Text = s.ToString();
            Savedata.SetGoldMedalCount(g);
            txtGold.Text = g.ToString();
        }

        private class MedalButtonTag
        {
            public int index;
            public int value;
        }

        private void cboSpecialStage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Savedata.SetNextSpecialStage(_currentSlot, cboSpecialStage.SelectedIndex);
        }

        private void btnResetGR_Click(object sender, EventArgs e)
        {
            Savedata.ResetGiantRingsForCurrentZone(_currentSlot);
            btnResetGR.Enabled = false;
        }

        private void btnAllBlank_Click(object sender, EventArgs e)
        {
            Savedata.SetBonusStageStatusAll(0);
            Savedata.SetSilverMedalCount(0);
            Savedata.SetGoldMedalCount(0);
            UpdateMedalPage();
        }

        private void btnAllSilver_Click(object sender, EventArgs e)
        {
            Savedata.SetBonusStageStatusAll(1);
            Savedata.SetSilverMedalCount(32);
            Savedata.SetGoldMedalCount(0);
            UpdateMedalPage();
        }

        private void btnAllGold_Click(object sender, EventArgs e)
        {
            Savedata.SetBonusStageStatusAll(2);
            Savedata.SetSilverMedalCount(32);
            Savedata.SetGoldMedalCount(32);
            UpdateMedalPage();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog(this);
        }

    }
}
