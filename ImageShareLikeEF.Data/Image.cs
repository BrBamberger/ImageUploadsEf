using System;

namespace ImageShareLikeEF.Data
{
    public class Image
    {
        public int Id {get; set;}
        public string Name { get; set; }

        public int Likes { get; set; }

    }
}
