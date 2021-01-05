using System.Collections.Generic;
using System.Linq;
using AOC.Common;

namespace AOC.Day05
{
    public class Solver: ISolver
    {
        private readonly IEnumerable<BoardingPass> boardingPasses;

        public Solver(IEnumerable<BoardingPass> boardingPasses)
        {
            this.boardingPasses = boardingPasses;
        }
        
        public string GetPartOneSolution()
        {
            return boardingPasses
                .OrderByDescending(bp => bp.SeatId)
                .Select(bp => bp.SeatId)
                .FirstOrDefault()
                .ToString();
        }

        public string GetPartTwoSolution()
        {
            var passBeforeMy = boardingPasses
                .OrderBy(bp => bp.SeatId)
                .FirstOrDefault(bp => !boardingPasses.ToList().Exists(tempBp => tempBp.SeatId == bp.SeatId + 1));
            return (passBeforeMy.SeatId + 1).ToString();
        }
    }
}