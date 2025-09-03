using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToeWinFormsAI
{
    public class Form1 : Form
    {
        private Button[,] buttons = new Button[3, 3];
        private char[,] board = new char[3, 3]; // 'X', 'O', or '\0'
        private bool xTurn = true; // true -> player's turn (X), false -> AI (O)
        private int moves = 0;

        // UI
        private Label lblStatus;
        private Button btnReset;
        private Label lblScore;
        private ComboBox cmbDifficulty;
        private CheckBox chkPlayerStarts;

        // Score
        private int scoreX = 0;
        private int scoreO = 0;
        private int scoreDraw = 0;

        public Form1()
        {
            Text = "Tic Tac Toe — Player vs AI";
            ClientSize = new Size(360, 520);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            InitializeGameUI();
            ResetBoard();
        }

        private void InitializeGameUI()
        {
            int size = 100;
            int spacing = 10;
            int startX = 20;
            int startY = 20;
            Font btnFont = new Font("Segoe UI", 24, FontStyle.Bold);

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    var btn = new Button
                    {
                        Location = new Point(startX + c * (size + spacing), startY + r * (size + spacing)),
                        Size = new Size(size, size),
                        Font = btnFont,
                        Tag = new Point(r, c)
                    };
                    btn.Click += BoardButton_Click;
                    Controls.Add(btn);
                    buttons[r, c] = btn;
                }
            }

            lblStatus = new Label
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Size = new Size(320, 40),
                Location = new Point(20, 340)
            };
            Controls.Add(lblStatus);

            // Difficulty combo
            var lblDiff = new Label
            {
                Text = "AI Difficulty:",
                Location = new Point(20, 390),
                AutoSize = true
            };
            Controls.Add(lblDiff);

            cmbDifficulty = new ComboBox
            {
                Location = new Point(120, 384),
                Size = new Size(120, 28),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbDifficulty.Items.AddRange(new string[] { "Easy", "Hard (Unbeatable)" });
            cmbDifficulty.SelectedIndex = 1; // default to Hard
            Controls.Add(cmbDifficulty);

            // Player starts checkbox
            chkPlayerStarts = new CheckBox
            {
                Text = "Player starts (X)",
                Location = new Point(20, 420),
                Checked = true,
                AutoSize = true
            };
            Controls.Add(chkPlayerStarts);

            // Reset button
            btnReset = new Button
            {
                Text = "New Game",
                Size = new Size(120, 36),
                Location = new Point(20, 450)
            };
            btnReset.Click += BtnReset_Click;
            Controls.Add(btnReset);

            // Score label
            lblScore = new Label
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Size = new Size(200, 36),
                Location = new Point(160, 450)
            };
            UpdateScoreLabel();
            Controls.Add(lblScore);
        }

        private void BoardButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var pt = (Point)btn.Tag;
            int r = pt.X;
            int c = pt.Y;

            if (board[r, c] != '\0') return; // already filled
            if (!xTurn) return; // ignore clicks when it's AI's turn

            MakeMove(r, c, 'X');
            btn.Text = "X";
            btn.Enabled = false;

            moves++;
            char winner = CheckWinner();

            if (winner == 'X' || winner == 'O')
            {
                EndGame(winner);
                return;
            }
            else if (moves == 9)
            {
                EndGame('D');
                return;
            }

            xTurn = false;
            UpdateStatusLabel();

            // Let AI move (immediate; small delay would be nicer but not required)
            Application.DoEvents(); // let UI update
            MakeAIMove();
        }

        private void MakeMove(int r, int c, char player)
        {
            board[r, c] = player;
            buttons[r, c].Text = player.ToString();
            buttons[r, c].Enabled = false;
        }

        private void MakeAIMove()
        {
            if (CheckWinner() != '\0' || moves == 9)
            {
                return;
            }

            var difficulty = cmbDifficulty.SelectedItem?.ToString() ?? "Hard";
            Point move;
            if (difficulty.StartsWith("Easy"))
            {
                move = GetRandomMove();
            }
            else
            {
                move = GetBestMove(); // Minimax
            }

            MakeMove(move.X, move.Y, 'O');
            moves++;

            char winner = CheckWinner();
            if (winner == 'X' || winner == 'O')
            {
                EndGame(winner);
            }
            else if (moves == 9)
            {
                EndGame('D');
            }
            else
            {
                xTurn = true;
                UpdateStatusLabel();
            }
        }

        private Point GetRandomMove()
        {
            var empty = from r in Enumerable.Range(0, 3)
                        from c in Enumerable.Range(0, 3)
                        where board[r, c] == '\0'
                        select new Point(r, c);
            var list = empty.ToList();
            var rnd = new Random();
            return list[rnd.Next(list.Count)];
        }

        private Point GetBestMove()
        {
            int bestScore = int.MinValue;
            Point bestMove = new Point(-1, -1);

            // Try all moves
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[r, c] == '\0')
                    {
                        board[r, c] = 'O';
                        int score = Minimax(board, false, 0, int.MinValue, int.MaxValue);
                        board[r, c] = '\0';

                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestMove = new Point(r, c);
                        }
                    }
                }
            }

            // In rare case bestMove not set (shouldn't happen), pick random
            if (bestMove.X == -1) return GetRandomMove();
            return bestMove;
        }

        /// <summary>
        /// Minimax with simple alpha-beta pruning.
        /// Returns score from AI perspective: +10 for O win, -10 for X win, 0 draw; depth used to prefer quicker wins/slower losses.
        /// </summary>
        private int Minimax(char[,] state, bool isMaximizing, int depth, int alpha, int beta)
        {
            char winner = CheckWinnerState(state);
            if (winner == 'O') return 10 - depth;
            if (winner == 'X') return depth - 10;
            if (IsFull(state)) return 0;

            if (isMaximizing)
            {
                int maxEval = int.MinValue;
                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (state[r, c] == '\0')
                        {
                            state[r, c] = 'O';
                            int eval = Minimax(state, false, depth + 1, alpha, beta);
                            state[r, c] = '\0';
                            maxEval = Math.Max(maxEval, eval);
                            alpha = Math.Max(alpha, eval);
                            if (beta <= alpha) return maxEval; // prune
                        }
                    }
                }
                return maxEval;
            }
            else
            {
                int minEval = int.MaxValue;
                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (state[r, c] == '\0')
                        {
                            state[r, c] = 'X';
                            int eval = Minimax(state, true, depth + 1, alpha, beta);
                            state[r, c] = '\0';
                            minEval = Math.Min(minEval, eval);
                            beta = Math.Min(beta, eval);
                            if (beta <= alpha) return minEval; // prune
                        }
                    }
                }
                return minEval;
            }
        }

        private bool IsFull(char[,] state)
        {
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    if (state[r, c] == '\0') return false;
            return true;
        }

        private char CheckWinnerState(char[,] st)
        {
            for (int i = 0; i < 3; i++)
            {
                if (st[i, 0] != '\0' && st[i, 0] == st[i, 1] && st[i, 1] == st[i, 2])
                    return st[i, 0];
                if (st[0, i] != '\0' && st[0, i] == st[1, i] && st[1, i] == st[2, i])
                    return st[0, i];
            }

            if (st[0, 0] != '\0' && st[0, 0] == st[1, 1] && st[1, 1] == st[2, 2])
                return st[0, 0];
            if (st[0, 2] != '\0' && st[0, 2] == st[1, 1] && st[1, 1] == st[2, 0])
                return st[0, 2];

            return '\0';
        }

        private char CheckWinner()
        {
            return CheckWinnerState(board);
        }

        private void EndGame(char winner)
        {
            if (winner == 'X')
            {
                scoreX++;
                MessageBox.Show("You win! Nice play.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (winner == 'O')
            {
                scoreO++;
                MessageBox.Show("AI wins.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Draw
            {
                scoreDraw++;
                MessageBox.Show("It's a draw.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateScoreLabel();
            DisableBoard();

            lblStatus.Text = winner == 'D' ? "Draw — press New Game" : $"{winner} wins — press New Game";
        }

        private void DisableBoard()
        {
            foreach (var b in buttons)
                b.Enabled = false;
        }

        private void EnableBoard()
        {
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    buttons[r, c].Enabled = (board[r, c] == '\0');
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetBoard();
        }

        private void ResetBoard()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    board[r, c] = '\0';
                    buttons[r, c].Text = "";
                    buttons[r, c].Enabled = true;
                }
            }
            moves = 0;
            xTurn = chkPlayerStarts.Checked;
            UpdateStatusLabel();

            // If AI starts (player chose otherwise), let AI move immediately.
            if (!xTurn)
            {
                Application.DoEvents();
                MakeAIMove();
            }
        }

        private void UpdateStatusLabel()
        {
            lblStatus.Text = $"Turn: {(xTurn ? "X (You)" : "O (AI)")}";
        }

        private void UpdateScoreLabel()
        {
            lblScore.Text = $"Score — You (X): {scoreX}    AI (O): {scoreO}    Draws: {scoreDraw}";
        }
    }
}
