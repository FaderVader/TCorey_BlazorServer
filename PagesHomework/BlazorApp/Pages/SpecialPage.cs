using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class SpecialPage
    {
        public int YesVotes { get; set; }
        public int NoVotes { get; set; }

        public void YesVote()
        {
            YesVotes++;
        }

        public void NoVote()
        {
            NoVotes++;
        }
    }
}
