﻿namespace Le6pergram.Models
{
    using System.Collections.Generic;

    public class Tag
    {
        public Tag()
        {
            this.Pictures = new HashSet<Picture>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }
    }
}