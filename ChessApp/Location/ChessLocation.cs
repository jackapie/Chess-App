﻿using ChessApp.Location;

namespace ChessAppTests
{
    public class ChessLocation : ILocation
    {
        public int x { get; protected set; }
        public int y { get; protected set; }

        public ChessLocation(string chessCoordinates)
        {
           //select the relevant character from the string
            var chessX = chessCoordinates[0];
            var chessY = chessCoordinates[1];

            //Use int.Parse(char.ToString()) 
            //converts the chessY character to it's relevant integer
            var chessYValue = int.Parse(chessY.ToString());

            // set y NB. chessYValue is now an integer
            this.y = 8 - chessYValue;

            //set x. NB. the characters 'a' and chessX are thought of as their ASCII value
            this.x = chessX - 'a';

           
        }


    }
}