﻿using System.ComponentModel.DataAnnotations;

namespace MaturitaDatabaseEdit
{
    public class Bike
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Power { get; set; }
    }
}
