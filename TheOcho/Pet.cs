using System;

namespace TheOcho
{
    public abstract class Pet
    {
        public string? OwnerName { get; set; }
        public DateTime Birthday { get; set; } = DateTime.Now;
    }
}