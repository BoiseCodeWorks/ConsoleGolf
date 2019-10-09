using System;

namespace golfcard.Models
{
    public class Message
    {

        public ConsoleColor Color { get; set; }
        public string Content { get; set; }
        public Message(ConsoleColor color, string content)
        {
            Color = color;
            Content = content;
        }
    }
}