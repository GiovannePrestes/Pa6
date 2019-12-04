using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlePatrimonios.Models
{
    public class Message
    {
        public Message(string title, string text, string icon)
        {
            this.Title = title;
            this.Text = text;
            this.Icon = icon;
        }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
    }
}
