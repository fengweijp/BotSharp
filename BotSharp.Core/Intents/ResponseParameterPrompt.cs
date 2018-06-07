﻿using EntityFrameworkCore.BootKit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BotSharp.Core.Intents
{
    [Table("Bot_ResponseParameterPrompt")]
    public class ResponseParameterPrompt : DbRecord, IDbRecord
    {
        [Required]
        [StringLength(36)]
        public String ResponseParameterId { get; set; }

        [MaxLength(256)]
        public string Prompt { get; set; }
    }
}
