﻿namespace Mixer.Base.Model.Chat
{
    public class UserEventModel
    {
        public uint id { get; set; }
        public string username { get; set; }
        public string[] roles { get; set; }
        public string[] permissions { get; set; }
    }
}
