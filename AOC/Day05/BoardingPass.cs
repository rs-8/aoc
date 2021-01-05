using System;
using System.Linq;

namespace AOC.Day05
{
    public class BoardingPass
    {
        private readonly int row;
        private readonly int column;
        
        public BoardingPass(string seatCode)
        {
            row = generateRow(seatCode);
            column = generateColumn(seatCode);
        }

        public int SeatId => row * 8 + column;

        private int generateRow(string seatCode)
        {
            var seatCodeRowPart = seatCode.Substring(0, seatCode.Length - 3);
            var lowerRowLimit = 0;
            var upperRowLimit = 127;

            foreach (var command in seatCodeRowPart)
            {
                switch (command)
                {
                    case 'F':
                        upperRowLimit = (lowerRowLimit + upperRowLimit) / 2;
                        break;
                    case 'B':
                        lowerRowLimit = (int)Math.Ceiling((decimal)(lowerRowLimit + upperRowLimit) / 2);
                        break;
                    default:
                        break;
                }
            }

            return upperRowLimit;
        }

        private int generateColumn(string seatCode)
        {
            var seatCodeColumnPart = seatCode.Substring(seatCode.Length - 3);
            var lowerColumnLimit = 0;
            var upperColumnLimit = 7;
            
            foreach (var command in seatCodeColumnPart)
            {
                switch (command)
                {
                    case 'L':
                        upperColumnLimit = (lowerColumnLimit + upperColumnLimit) / 2;
                        break;
                    case 'R':
                        lowerColumnLimit = (int)Math.Ceiling((decimal)(lowerColumnLimit + upperColumnLimit) / 2);
                        break;
                    default:
                        break;
                }
            }

            return upperColumnLimit;
        }
    }
}