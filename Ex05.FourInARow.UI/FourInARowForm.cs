using System;
using System.Drawing;
using System.Windows.Forms;
using C21_Ex05_FourInARow_Logic;

// $G$ DSN-002 (-10) No UI seperation! This class merge the Logic board with the Visual board of the game.

namespace Ex05.FourInARow.UI
{
    public sealed partial class FourInARowForm : Form
    {
        private const int k_ButtonSpacing = 65;
        private const int k_ButtonOffset = 30;
        private const char k_Player1Symbol = 'X';
        private const char k_Player2Symbol = 'O';
        private readonly GameSettings r_BoardForm = new GameSettings();
        private readonly Size r_ControlButtonSize = new Size(50, 30);
        private readonly GameBoard r_GameBoard;
        private readonly Size r_GridButtonSize = new Size(50, 50);
        private readonly Player r_Player1 = new Player(k_Player1Symbol);
        private readonly Label r_Player1Label = new Label();
        private readonly Player r_Player2;
        private readonly Label r_Player2Label = new Label();
        private Button[] m_ControlButtons;
        private Player m_CurrentPlayer;
        private eGameStatus m_GameStatus;
        private Button[,] m_GridButtons;

        public FourInARowForm()
        {
            m_CurrentPlayer = r_Player1;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Padding = new Padding(k_ButtonOffset, k_ButtonOffset, k_ButtonOffset, k_ButtonOffset);

            if (r_BoardForm.ShowDialog() == DialogResult.OK)
            {
                r_GameBoard = new GameBoard((byte)r_BoardForm.Cols, (byte)r_BoardForm.Rows);
                initializeBoard();
                r_Player2 = new Player(k_Player2Symbol, r_BoardForm.Player2Human);
            }
            else
            {
                Environment.Exit(0);
            }

            InitializeComponent();
        }

        private void BoardForm_Load(object sender, EventArgs e)
        {
        }

        private void syncBoardAndButtonsText()
        {
            for (int col = 0; col < r_BoardForm.Cols; col++)
            {
                for (int row = 0; row < r_BoardForm.Rows; row++)
                {
                    m_GridButtons[row, col].Text = r_GameBoard.GetTokenFromCell(row, col);
                }
            }
        }

        private void initializeBoard()
        {
            m_GridButtons = new Button[(byte)r_BoardForm.Rows, (byte)r_BoardForm.Cols];
            m_ControlButtons = new Button[(byte)r_BoardForm.Cols];

            for (int col = 0; col < r_BoardForm.Cols; col++)
            {
                for (int row = 0; row < r_BoardForm.Rows; row++)
                {
                    m_GridButtons[row, col] = new Button();
                    Controls.Add(m_GridButtons[row, col]);
                    m_GridButtons[row, col].Location = new Point(
                        k_ButtonOffset + col * k_ButtonSpacing,
                        (row + 1) * k_ButtonSpacing);
                    m_GridButtons[row, col].Size = r_GridButtonSize;
                }

                m_ControlButtons[col] = new Button();
                m_ControlButtons[col].Location = new Point(k_ButtonOffset + col * k_ButtonSpacing, k_ButtonOffset);
                m_ControlButtons[col].Size = r_ControlButtonSize;
                Controls.Add(m_ControlButtons[col]);
                m_ControlButtons[col].Text = string.Format("{0}", col + 1);
                m_ControlButtons[col].Click += FourInARowForm_Click;
            }

            r_Player1Label.Text = string.Format("{0} : 0", r_BoardForm.FirstPlayer);
            r_Player2Label.Text = string.Format("{0} : 0", r_BoardForm.SecondPlayer);
            r_Player1Label.Location = new Point(
                (r_BoardForm.Cols / 2 - 1) * k_ButtonSpacing,
                (r_BoardForm.Rows + 1) * k_ButtonSpacing);
            r_Player2Label.Location = new Point(
                (r_BoardForm.Cols / 2 + 1) * k_ButtonSpacing,
                (r_BoardForm.Rows + 1) * k_ButtonSpacing);

            Controls.Add(r_Player1Label);
            Controls.Add(r_Player2Label);
        }

        // $G$ DSN-999 (-5) the ui should not know what is AI - the game manger in th elogic section should use ai in computer turns...
        private void FourInARowForm_Click(object sender, EventArgs e)
        {
            int.TryParse((sender as Button).Text, out int columnToInsertTokenIn);
            runRound(columnToInsertTokenIn);

            if (m_CurrentPlayer == r_Player2 && !r_Player2.IsHuman)
            {
                columnToInsertTokenIn = m_CurrentPlayer.ChooseRandomColumn(r_GameBoard.GetAvailableColumns());
                runRound(columnToInsertTokenIn);
            }

            if (m_GameStatus != eGameStatus.NoPlayerWon)
            {
                finishGame();
            }
        }

        private void finishGame()
        {
            string textToDisplayToUser = "";
            string titleMessageBox = "A Win";

            switch (m_GameStatus)
            {
                case eGameStatus.NoPlayerWon:
                    break;
                case eGameStatus.Player1Win:
                    r_Player1.Score++;
                    textToDisplayToUser = $"{r_BoardForm.FirstPlayer} Won!!";
                    break;
                case eGameStatus.Player2Win:
                    r_Player2.Score++;
                    textToDisplayToUser = $"{r_BoardForm.SecondPlayer} Won!!";
                    break;
                case eGameStatus.Tie:
                    r_Player1.Score++;
                    r_Player2.Score++;
                    textToDisplayToUser = "Tie!!";
                    titleMessageBox = "A Tie";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            DialogResult dialogResult = MessageBox.Show(
                textToDisplayToUser += "\nAnother Round?\n",
                titleMessageBox,
                MessageBoxButtons.YesNo);
            checkIfContinue(dialogResult);
        }

        private void runRound(int i_ColumnToInsertTokenIn)
        {
            r_GameBoard.InsertCoin(i_ColumnToInsertTokenIn, m_CurrentPlayer.TokenSymbol);
            syncBoardAndButtonsText();
            if (r_GameBoard.IsColumnFull(i_ColumnToInsertTokenIn))
            {
                m_ControlButtons[i_ColumnToInsertTokenIn - 1].Enabled = false;
            }

            if (r_GameBoard.CheckIfFourConnectedByToken(m_CurrentPlayer.TokenSymbol))
            {
                m_GameStatus = m_CurrentPlayer == r_Player1 ? eGameStatus.Player1Win : eGameStatus.Player2Win;
            }

            if (r_GameBoard.CheckForTie())
            {
                m_GameStatus = eGameStatus.Tie;
            }

            passTurn();
        }

        private void passTurn()
        {
            m_CurrentPlayer = m_CurrentPlayer == r_Player1 ? r_Player2 : r_Player1;
        }

        private void checkIfContinue(DialogResult i_DialogResult)
        {
            switch (i_DialogResult)
            {
                case DialogResult.Yes:
                    newGame();
                    break;
                case DialogResult.No:
                    quitGame();
                    break;
                case DialogResult.Abort:
                    quitGame();
                    break;
                case DialogResult.Cancel:
                    quitGame();
                    break;
                case DialogResult.Ignore:
                    quitGame();
                    break;
                case DialogResult.None:
                    quitGame();
                    break;
                case DialogResult.OK:
                    newGame();
                    break;
                case DialogResult.Retry:
                    quitGame();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(i_DialogResult), i_DialogResult, null);
            }
        }

        private void newGame()
        {
            foreach (Button button in m_ControlButtons)
            {
                button.Enabled = true;
            }

            foreach (Button button in m_GridButtons)
            {
                button.Text = string.Empty;
            }

            r_GameBoard.CleanBoard();
            m_GameStatus = eGameStatus.NoPlayerWon;
            r_Player1Label.Text = $"{r_BoardForm.FirstPlayer} : {r_Player1.Score}";
            r_Player2Label.Text = $"{r_BoardForm.SecondPlayer} : {r_Player2.Score}";
        }

        private static void quitGame()
        {
            MessageBox.Show(string.Format("Bye Bye"), "Game Over");
            Application.Exit();
        }

        private enum eGameStatus
        {
            NoPlayerWon,
            Player1Win,
            Player2Win,
            Tie
        }
    }
}