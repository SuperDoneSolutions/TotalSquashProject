//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TotalSquash.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ladder
    {
        public Ladder()
        {
            this.UserLadders = new HashSet<UserLadder>();
        }
    
        public int ladderId { get; set; }
        public string ladderDescription { get; set; }
        public int ladderRuleId { get; set; }
    
        public virtual ICollection<UserLadder> UserLadders { get; set; }
        public virtual LadderRule LadderRule { get; set; }
    }
}
