namespace WebApplication1
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Model1 : DbContext
	{
		public Model1()
			: base("name=DB_usuarios")
		{
		}

		public virtual DbSet<UserProfile> UserProfiles { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<UserProfile>()
				.Property(e => e.UserName)
				.IsUnicode(false);

			modelBuilder.Entity<UserProfile>()
				.Property(e => e.Password)
				.IsUnicode(false);

			modelBuilder.Entity<UserProfile>()
				.Property(e => e.tipoUsuario)
				.IsUnicode(false);
		}
	}
}
