using ChessApp.Location;

namespace ChessApp
{
    public class WhatWhere
    {
        public string PieceType {get;set;}

        public ILocation Location { get; set; }
    }
}