using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要：点数データを集計しScoreオブジェクトを返す 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> scores = new List<Student>();
            string[] list = File.ReadAllLines(filePath);
            foreach (var line in list) {
                string[] items = line.Split(',');
                Student score = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(score);
            }
            return scores;
        }

        //メソッドの概要： 科目別の点数を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var item in _score) {
                if (dict.ContainsKey(item.Subject)) {
                    dict[item.Subject] += item.Score;
                }else {
                    dict[item.Subject] = item.Score;
                }
            }
            return dict;
        }
    }
}
