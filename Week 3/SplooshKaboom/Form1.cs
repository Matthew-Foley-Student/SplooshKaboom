/*
 * Matthew Foley
 * CST-201-O500
 * December 2025
 * BattleShips
 */
using BattleShipLibrary.Models;
using BattleShipLibrary.Services.Buisness_Logic;

namespace SplooshKaboom
{
    public partial class frmPlayerForm : Form
    {
        private BoardModel _board;
        private BoardLogic _boardLogic;
        private Button[,] _buttons;            
        frmComputerPlacements start = new frmComputerPlacements();
        public frmPlayerForm()
        {
            InitializeComponent();
            _boardLogic = new BoardLogic();            

        }

        private void StartTheGame(object sender, EventArgs e)
        {

            start.Visible = true;
        }
    }
}
