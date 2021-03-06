﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCaro.Model
{
    public class ChessBoard
    {
        public static int ChessSize { get; } = 30;
        public static int BoardRows { get; } = 20;
        public static int BoardColumns { get; } = 20;
        public static int BoardPaddingLeft { get; } = 80;
        public static int BoardPaddingTop { get; } = 110;
        public static int MoveTime { get; set; } = 15;

        public int Id { get; set; }
        public Chess[,] Chesses { get; set; }        
        public int TurnOwner { get; set; }
        public bool IsEnd { get; set; }    
        public List<string> Moves { get; set; }        
        public int GameDuration { get; set; }
        public DateTime StartTime { get; set; }
        public int Winner { get; set; }
        public int RemainMoves { get; set; }
        public int CoTheGameId { get; set; }
        public List<string> InitMoves { get; set; }
        public bool IsCoTheGame { get; set; } = false;
        public ChessBoard()
        {
            Chesses = initChesses();            
            TurnOwner = 1;
            IsEnd = false;
            MoveTime = 20;
            Moves = new List<string>();
            InitMoves = new List<string>();
            StartTime = DateTime.Now;
            Winner = 0;
            RemainMoves = -1;
        }

        public ChessBoard(int id) : this()
        {
            this.Id = id;
        }

        public ChessBoard(int id, Chess[,] initMoves, bool isCoTheGame) : this()
        {
            this.Id = id;
            this.Chesses = initMoves;
            this.IsCoTheGame = IsCoTheGame;
        }

        public static Chess[,] initChesses()
        {
            Chess[,] chess = new Chess[BoardRows + 1, BoardColumns + 1];
            for(int i = 1; i <= BoardRows; i++)
            {
                for(int j = 1; j <= BoardColumns; j++)
                {
                    chess[i, j] = new Chess(j, i, 0);
                }
            }
            return chess;
        }
    }
}
