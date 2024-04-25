using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    internal class Program {
        static void Main(string[] args) {
            var songs = new Song[] {
                new Song("ドライフラワー","優里",252),
                new Song("アイドル","ヨアソビ",273),
                new Song("KING","オカリナ",195),
            };
            PrintSongs(songs);
        }
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine(@"{0},{1},{2:mm\:ss}",song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}
