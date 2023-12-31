﻿using System;
namespace lab8
{
    class Song
    {
        public string name; 
        public string author; 
        public Song prev; 
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
        public void Name(string name)
        {
            this.name = name;
        }
        public void Author(string author)
        {
            this.author = author;
        }
        public void Prev(Song prev)
        {
            this.prev = prev;
        }
        public void Info()
        {
            Console.WriteLine($"Название песни:{this.name} Автор:{this.author}");
        }
        public override bool Equals(object d)
        {
            if (d is Song)
            {
                Song song = d as Song;
                return this.name == song.name && this.author == song.author;
            }
            return false;
        }
    }
}
