﻿using SberAPI.ViewModels;
using System;
using System.Collections.Generic;

#nullable disable

namespace SberAPI.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public int ChatId { get; set; }
        public string Timestamp { get; set; }

        public virtual Chat Chat { get; set; }
        public virtual User User { get; set; }

        public MessageViewModel ToViewModel()
        {
            return new MessageViewModel()
            {
                Chat = Chat.ToViewModel(),
                Id = Id,
                Text = Text,
                TimeStamp = Timestamp,
                User = User.ToViewModel()
            };
        }
    }
}
