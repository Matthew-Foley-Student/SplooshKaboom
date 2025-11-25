using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BattleShipLibrary.Models;
using BattleShipLibrary.Services.Buisness_Logic;

namespace SplooshKaboom
{
    public partial class frmComputerPlacements : Form
    {
        private BoardModel _board;
        private BoardLogic _boardLogic;
        private Button[,] _buttons;
        int sub = 0;
        int cru = 0;
        int des = 0;
        TimeSpan timeElapse = new TimeSpan();
        bool endturnbool = false;
        private frmPlayerForm playerForm;
        public frmComputerPlacements(frmPlayerForm parent)
        {
            InitializeComponent();
            tmrEndTurn.Enabled = false;
            playerForm = parent;
        }
        private void SetUpButton()
        {
            int buttonSize = pnlBoard.Width / _board.Size;
            pnlBoard.Height = pnlBoard.Width;
            for (int row = 0; row < _board.Size; row++)
            {
                for (int col = 0; col < _board.Size; col++)
                {
                    _buttons[row, col] = new Button();
                    Button button = _buttons[row, col];
                    //set the size's
                    button.Width = buttonSize;
                    button.Height = buttonSize;
                    //Set Button Locations
                    button.Left = row * buttonSize;
                    button.Top = col * buttonSize;
                    _board.Grid[row, col].Revealed = false;
                    _board.Grid[row, col].Ship = false;
                    _board.Grid[row, col].ShipType = "";
                    //Set the Click Capeabilities for the buttons
                    button.MouseDown += btnMouseClick;
                    //store button's capeabilites
                    button.Tag = new Point(row, col);
                    button.Text = $"{row}, {col}";
                    pnlBoard.Controls.Add(_buttons[row, col]);

                }
            }
        }//end of the panel setups

        private void btnMouseClick(object sender, MouseEventArgs e)
        {
            endturnbool = false;
            Button button = (Button)sender;
            Point point = (Point)button.Tag;
            int row = point.X;
            int col = point.Y;
            MessageBox.Show($"You Clicked On Row {row} And Column {col}");
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                if (_board.Grid[row, col].Revealed == false && _board.Grid[row, col].Ship == false)
                {
                    _board.Grid[row, col].Revealed = true;
                    _buttons[row, col].BackColor = Color.LightBlue;
                    _buttons[row, col].Text = "SPLOOSH";
                }
                if (_board.Grid[row, col].Ship == true && _board.Grid[row, col].Revealed == false)
                {
                    _board.Grid[row, col].Revealed = true;
                    if (_board.Grid[row, col].ShipType == "S" || _board.Grid[row, col].ShipType == "Sdl" || _board.Grid[row, col].ShipType == "Sdr" || _board.Grid[row, col].ShipType == "Sul" || _board.Grid[row, col].ShipType == "Sur")
                    {
                        sub++;
                        _buttons[row, col].BackColor = Color.Red;
                        _buttons[row, col].Text = "KABOOM";
                        if (sub == 3)
                        {
                            lblSub.Font = new Font(lblSub.Font, FontStyle.Strikeout | FontStyle.Bold);
                            lblSub.ForeColor = Color.Red;
                        }
                    }
                    if (_board.Grid[row, col].ShipType == "D" || _board.Grid[row, col].ShipType == "Dul" || _board.Grid[row, col].ShipType == "Dur" || _board.Grid[row, col].ShipType == "Ddl" || _board.Grid[row, col].ShipType == "Ddr")
                    {
                        des++;
                        _buttons[row, col].BackColor = Color.Red;
                        _buttons[row, col].Text = "KABOOM";
                        if (des == 4)
                        {
                            lblDestroy.Font = new Font(lblDestroy.Font, FontStyle.Strikeout | FontStyle.Bold);
                            lblDestroy.ForeColor = Color.Red;
                        }
                    }
                    if (_board.Grid[row, col].ShipType == "C" || _board.Grid[row, col].ShipType == "Cur" || _board.Grid[row, col].ShipType == "Cul" || _board.Grid[row, col].ShipType == "Cdr" || _board.Grid[row, col].ShipType == "Cdl")
                    {
                        cru++;
                        _buttons[row, col].BackColor = Color.Red;
                        _buttons[row, col].Text = "KABOOM";
                        if (cru == 3)
                        {
                            lblCruis.Font = new Font(lblCruis.Font, FontStyle.Strikeout | FontStyle.Bold);
                            lblCruis.ForeColor = Color.Red;
                        }
                    }
                }
                for (int i = 0; i < _board.Size; i++)
                {
                    for (int j = 0; j < _board.Size; j++)
                    {
                        _buttons[i, j].Enabled = false;
                    }
                }
                tmrEndTurn.Start();
            }
        }//End of the mouse buttons setUp

        private void StartProgram(object sender, EventArgs e)
        {
            int size = 0;
            try
            {
                size = 10;

                _board = new BoardModel(size);
                _boardLogic = new BoardLogic();
                _buttons = new Button[size, size];
                SetUpButton();

            }
            catch (Exception) { }
            bool sub = false, cruis = false, dest = false;
            while (dest == false)
            {
                Random rand = new Random();
                int row = rand.Next(0, _board.Size);
                int col = rand.Next(0, _board.Size);
                int boat = rand.Next(1, 4);
                if (boat == 1)
                {
                    _boardLogic.MarkLegalLocation(_board, _board.Grid[row, col], "destroyerul");
                }
                if (boat == 2)
                {
                    _boardLogic.MarkLegalLocation(_board, _board.Grid[row, col], "destroyerur");
                }
                if (boat == 3)
                {
                    _boardLogic.MarkLegalLocation(_board, _board.Grid[row, col], "destroyerdl");
                }
                if (boat == 4)
                {
                    _boardLogic.MarkLegalLocation(_board, _board.Grid[row, col], "destroyerdr");
                }
                if (_board.Grid[row, col].ShipType == "D")
                {
                    dest = true;
                }
            }//End of placement of the destroyer Boat

            while (cruis == false)
            {
                Random rand = new Random();
                int row = rand.Next(0, _board.Size);
                int col = rand.Next(0, _board.Size);
                int boat = rand.Next(1, 4);
                if (boat == 1)
                {
                    _boardLogic.MarkLegalLocation(_board, _board.Grid[row, col], "cruiserul");
                }
                if (boat == 2)
                {
                    _boardLogic.MarkLegalLocation(_board, _board.Grid[row, col], "cruiserur");
                }
                if (boat == 3)
                {
                    _boardLogic.MarkLegalLocation(_board, _board.Grid[row, col], "cruiserdl");
                }
                if (boat == 4)
                {
                    _boardLogic.MarkLegalLocation(_board, _board.Grid[row, col], "cruiserdr");
                }
                if (_board.Grid[row, col].ShipType == "C")
                {
                    cruis = true;
                }
            }//End of the placements of the Cruiser

            while (sub == false)
            {
                Random rand = new Random();
                int row = rand.Next(0, _board.Size);
                int col = rand.Next(0, _board.Size);
                int boat = rand.Next(1, 4);
                if (boat == 1)
                {
                    _boardLogic.MarkLegalLocation(_board, _board.Grid[row, col], "submarineul");
                }
                if (boat == 1)
                {
                    _boardLogic.MarkLegalLocation(_board, _board.Grid[row, col], "submarineur");
                }
                if (boat == 1)
                {
                    _boardLogic.MarkLegalLocation(_board, _board.Grid[row, col], "submarinedl");
                }
                if (boat == 1)
                {
                    _boardLogic.MarkLegalLocation(_board, _board.Grid[row, col], "submarinedr");
                }
                if (_board.Grid[row, col].ShipType == "Sdl" || _board.Grid[row, col].ShipType == "Sdr" || _board.Grid[row, col].ShipType == "Sul" || _board.Grid[row, col].ShipType == "Sur")
                {
                    sub = true;
                }
            }//End of the Submarine Placements
            for (int row = 0; row < _board.Size; row++)
            {
                for (int col = 0; col < _board.Size; col++)
                {
                    if (_board.Grid[row, col].ShipType != "")
                    {
                        _board.Grid[row, col].Ship = true;
                    }
                    else
                    {
                    }
                }
            }
        }//Starting the program

        private void tmrEndTurn_Tick(object sender, EventArgs e)
        {
            int interval = tmrEndTurn.Interval;
            timeElapse = timeElapse.Add(TimeSpan.FromMilliseconds(interval));
            if (timeElapse.Seconds % 2 == 0)
            {
                tmrEndTurn.Stop();
                endturnbool = true;
            }
            if (endturnbool == true)
            {
                playerForm.Show();
                this.Hide();    
            }
        }

        private void CheckForButtons(object sender, EventArgs e)
        {
            for (int i = 0; i < _board.Size; i++)
            {
                for (int j = 0; j < _board.Size; j++)
                {
                    _buttons[i, j].Enabled = true;
                }
            }
        }
    }
}
