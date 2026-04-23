using System;
using System.Collections.Generic;

namespace MusicApp
{
    class PlaylistSystem
    {
        private LinkedList<string> playlist = new LinkedList<string>();
        private SortedList<int, string> songsByRating = new SortedList<int, string>();
        private SortedDictionary<string, string> artistSongs = new SortedDictionary<string, string>();

        public void AddSong(string song, string artist, int rating)
        {
            playlist.AddLast(song);

            if (!songsByRating.ContainsKey(rating))
            {
                songsByRating.Add(rating, song);
            }
            else
            {
                Console.WriteLine($"Rating {rating} already exists, song {song} not added to sorted list.");
            }

            if (!artistSongs.ContainsKey(artist))
            {
                artistSongs.Add(artist, song);
            }
            else
            {
                Console.WriteLine($"Artist {artist} already mapped to a song.");
            }

            Console.WriteLine($"Song '{song}' by {artist} added with rating {rating}");
        }

        public void RemoveSong(string song)
        {
            if (playlist.Contains(song))
            {
                playlist.Remove(song);
                Console.WriteLine($"Song '{song}' removed from playlist");
            }

            foreach (var kvp in songsByRating)
            {
                if (kvp.Value == song)
                {
                    songsByRating.Remove(kvp.Key);
                    break;
                }
            }

            foreach (var kvp in artistSongs)
            {
                if (kvp.Value == song)
                {
                    artistSongs.Remove(kvp.Key);
                    break;
                }
            }
        }

        public void ShowPlaylist()
        {
            Console.WriteLine("Playlist:");
            foreach (var song in playlist)
            {
                Console.WriteLine(song);
            }
        }

        public void ShowSongsByRating()
        {
            Console.WriteLine("Songs Sorted by Rating:");
            foreach (var kvp in songsByRating)
            {
                Console.WriteLine($"Rating {kvp.Key}: {kvp.Value}");
            }
        }

        public void ShowSongsByArtist()
        {
            Console.WriteLine("Songs Sorted by Artist:");
            foreach (var kvp in artistSongs)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PlaylistSystem system = new PlaylistSystem();

            system.AddSong("Shape of You", "Ed Sheeran", 5);
            system.AddSong("Blinding Lights", "The Weeknd", 4);
            system.AddSong("Levitating", "Dua Lipa", 3);

            system.ShowPlaylist();
            system.ShowSongsByRating();
            system.ShowSongsByArtist();

            system.RemoveSong("Levitating");

            system.ShowPlaylist();
            system.ShowSongsByRating();
            system.ShowSongsByArtist();
        }
    }
}
