using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace r_EFGetStarted.AspNetCore.ExistingDb.Views.Shared.model
{
    public partial class Blog
    {
        public Blog()
        {
            Post = new HashSet<Post>();
        }

        public int BlogId { get; set; }
        public string Url { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }

    
}