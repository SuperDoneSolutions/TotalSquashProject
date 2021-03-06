﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PrimarySquashDBContext : DbContext
    {
        public PrimarySquashDBContext()
            : base("name=PrimarySquashDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<BookingRule> BookingRules { get; set; }
        public virtual DbSet<BookingType> BookingTypes { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Court> Courts { get; set; }
        public virtual DbSet<Ladder> Ladders { get; set; }
        public virtual DbSet<LadderRule> LadderRules { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TournamentRule> TournamentRules { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserLadder> UserLadders { get; set; }
        public virtual DbSet<UserMatch> UserMatches { get; set; }
    }
}
