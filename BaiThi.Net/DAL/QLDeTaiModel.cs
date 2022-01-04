using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiThi.Net
{
    public partial class QLDeTaiModel : DbContext
    {
        public QLDeTaiModel()
            : base("name=QLDeTaiModelApp")
        {
        }

        public virtual DbSet<DeTai> DeTais { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<DeTai>()
                .Property(e => e.ID)
                .IsUnicode(false);*/
        }
    }
}
