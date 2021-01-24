using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AOC.Common;

namespace AOC.Day06
{
    public class Solver: ISolver
    {
        private readonly IList<string> answers;
        
        public Solver(IEnumerable<string> input)
        {
            answers = generateAnswers(input);
        }
        
        public string GetPartOneSolution()
        {
            return answers.Select(ans => ans.Replace(" ", "").Distinct().Count()).Sum().ToString();
        }

        public string GetPartTwoSolution()
        {
            int sum = 0;
            foreach (string ans in answers)
            {
                var answersList = new List<char>();
                var temp = ans.Split(" ").Select(x => x.Distinct().ToList()).Where(x => x.Count > 0).ToList();
                for (int i = 0; i < temp.Count; i++)
                {
                    var a = temp[i];
                    if (i == 0)
                    {
                        answersList.AddRange(a);
                    }
                    else
                    {
                        answersList = new List<char>(answersList.Intersect(a).ToList());
                    }
                }

                sum += answersList.Count;
            }

            return sum.ToString();
        }

        private IList<string> generateAnswers(IEnumerable<string> input)
        {
            var answers = new List<string>();
            var answer = string.Empty;

            foreach (var data in input)
            {
                if (string.IsNullOrWhiteSpace(data))
                {
                    answer = answer.Trim();
                    answers.Add(answer);
                    answer = string.Empty;
                    continue;
                }
                
                answer += " " + data;
            }
            
            answer = answer.Trim();
            answers.Add(answer);

            return answers;
        }
    }
}