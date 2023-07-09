using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Game
{
    public partial class Chess : Form
    {
        const int Dimension = 8;
        Piece[,] Pieces = new Piece[Dimension, Dimension];
        Cell[,] Cells = new Cell[Dimension, Dimension];
        bool SelectSource = true;
        MYCOLOR Player = MYCOLOR.WHITE;
        Cell Source, Destination;

        public Chess()
        {
            InitializeComponent();
        }

        public void Init()
        {
            ChessPanel.Controls.Clear();
            for(int row = 0; row < Dimension; row++)
            {
                for(int col = 0; col < Dimension; col++)
                {
                    if (row == 1)
                    {
                        Pieces[row, col] = new Pawn(MYCOLOR.BLACK, "b_pawn.png"); 
                    }
                    else if ((row == 0 && col == 0) || (row == 0 && col == 7))
                    {
                        Pieces[row, col] = new Rook(MYCOLOR.BLACK, "b_rook.png");
                    }
                    else if ((row == 0 && col == 1) || (row == 0 && col == 6))
                    {
                        Pieces[row, col] = new Knight(MYCOLOR.BLACK, "b_knight.png");
                    }
                    else if ((row == 0 && col == 2) || (row == 0 && col == 5))
                    {
                        Pieces[row, col] = new Bishop(MYCOLOR.BLACK, "b_bishop.png");
                    }
                    else if (row == 0 && col == 3)
                    {
                        Pieces[row, col] = new Queen(MYCOLOR.BLACK, "b_queen.png");
                    }
                    else if (row == 0 && col == 4)
                    {
                        Pieces[row, col] = new King(MYCOLOR.BLACK, "b_king.png");
                    }
                    else if (row == 6)
                    {
                        Pieces[row, col] = new Pawn(MYCOLOR.WHITE, "w_pawn.png");
                    }
                    else if ((row == 7 && col == 0) || (row == 7 && col == 7))
                    {
                        Pieces[row, col] = new Rook(MYCOLOR.WHITE, "w_rook.png");
                    }
                    else if ((row == 7 && col == 1) || (row == 7 && col == 6))
                    {
                        Pieces[row, col] = new Knight(MYCOLOR.WHITE, "w_knight.png");
                    }
                    else if ((row == 7 && col == 2) || (row == 7 && col == 5))
                    {
                        Pieces[row, col] = new Bishop(MYCOLOR.WHITE, "w_bishop.png");
                    }
                    else if (row == 7 && col == 3)
                    {
                        Pieces[row, col] = new Queen(MYCOLOR.WHITE, "w_queen.png");
                    }
                    else if (row == 7 && col == 4)
                    {
                        Pieces[row, col] = new King(MYCOLOR.WHITE, "w_king.png");
                    }
                    else
                    {
                        Pieces[row, col] = null;
                    }
                    // ----------------------------------------------- //
                    MYCOLOR boxColor = (((row + col) % 2 == 0) ? MYCOLOR.WHITE : MYCOLOR.BLACK);
                    Cells[row, col] = new Cell(row, col, boxColor, Pieces[row, col], ChessPanel.Height, ChessPanel.Width, Dimension);
                    Cells[row, col].Click += new System.EventHandler(CellSelected);

                    ChessPanel.Controls.Add(Cells[row, col]);
                }
            }
        }

        private void SourceSelection(object sender, EventArgs e)
        {
            Source = (Cell)sender;
        }

        private void MovePiece()
        {
            Piece sourcePiece = Source.piece;
            int startRow = Source.rowIndex;
            int startCol = Source.colIndex;
            int destRow = Destination.rowIndex;
            int destCol = Destination.colIndex;

            // Check if the move is legal
            if (sourcePiece.isLegalMove(startRow, startCol, destRow, destCol, Pieces))
            {
                Source.piece = null;
                Destination.piece = sourcePiece;
                Pieces[destRow, destCol] = Pieces[startRow, startCol];
                Pieces[startRow, startCol] = null;

                Destination.piece.Draw(Destination);
                Source.RemovePiece(Source);
            }
            else
            {
                MessageBox.Show("Invalid Move.");
            }
            //Piece sourcePiece = Source.piece;
            //Source.piece = null;
            //Destination.piece = sourcePiece;

            //int startRow = Source.rowIndex, startCol = Source.colIndex;
            //int destRow = Destination.rowIndex, destCol = Destination.colIndex;
            //Pieces[destRow, destCol] = Pieces[startRow, startCol];
            //Pieces[startRow, startCol] = null;

            //Destination.piece.Draw(Destination);
            //Source.RemovePiece(Source);
        }

        private void TurnChange()
        {
            if (Player == MYCOLOR.WHITE)
                Player = MYCOLOR.BLACK; 
            else
                Player = MYCOLOR.WHITE;
        } 

        private void DestinationSelection(object sender, EventArgs e)
        {
            Destination = (Cell)sender;
        }

        private bool IsValidPieceSelection()
        {
            return Player == Source.piece.getColor();
        }

        private bool IsValidPieceDestination()
        {
            return (Destination.piece == null || Destination.piece.getColor() != Player);
        }

        private void CellSelected(object sender, EventArgs e)
        {
            if (SelectSource)
            {
                SourceSelection(sender, e);
                if (IsValidPieceSelection())
                    SelectSource = false;
                else
                    MessageBox.Show("Not Your Player.");
            }
            else
            {
                DestinationSelection(sender, e);
                if (IsValidPieceDestination())
                {
                    MovePiece();
                    TurnChange();
                }
                else
                {
                    MessageBox.Show("Wrong Destination.");
                }
                SelectSource = true;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Init();
        }
    }
}
