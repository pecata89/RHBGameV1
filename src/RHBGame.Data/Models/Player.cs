﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace RHBGame.Data.Models
{
    [Table("Players")]
    public class Player
    {
        public const Int32 SaltLength = 16;
        public const Int32 HashLength = 20;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("player_id")]
        public Int32 Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("name")]
        public String Name { get; set; }

        [Required]
        [MaxLength(50)]
        [JsonIgnore]
        [Column("username")]
        public String Username { get; set; }

        [JsonIgnore]
        [Required]
        [MinLength(HashLength), MaxLength(HashLength)]
        [Column("password_hash")]
        public Byte[] PasswordHash { get; set; }

        [JsonIgnore]
        [Required]
        [MinLength(SaltLength), MaxLength(SaltLength)]
        [Column("password_salt")]
        public Byte[] PasswordSalt { get; set; }

        [Required]
        [MaxLength(100)]
        [JsonIgnore]
        [Column("email")]
        public String Email { get; set; }

        [Required]
        [Column("gender")]
        public Gender Gender { get; set; }

        [Required]
        [Column("birthdate", TypeName = "date")]
        public DateTime Birthdate { get; set; }

        [JsonIgnore]
        [Column("edited", TypeName = "datetime2")]
        public DateTime? Edited { get; set; }

        [Required]
        [JsonIgnore]
        [Column("created", TypeName = "datetime2")]
        public DateTime Created { get; set; }
    }
}