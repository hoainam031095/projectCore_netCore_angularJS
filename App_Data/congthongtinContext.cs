using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CongThongTin.App_Data
{
    public partial class congthongtinContext : DbContext
    {
        public congthongtinContext()
        {
        }

        public congthongtinContext(DbContextOptions<congthongtinContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAction> TbAction { get; set; }
        public virtual DbSet<TbController> TbController { get; set; }
        public virtual DbSet<TbException> TbException { get; set; }
        public virtual DbSet<TbExceptionLog> TbExceptionLog { get; set; }
        public virtual DbSet<TbPost> TbPost { get; set; }
        public virtual DbSet<TbRoleGroup> TbRoleGroup { get; set; }
        public virtual DbSet<TbRoleGroupAction> TbRoleGroupAction { get; set; }
        public virtual DbSet<TbRoute> TbRoute { get; set; }
        public virtual DbSet<TbTypePost> TbTypePost { get; set; }
        public virtual DbSet<TbUser> TbUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = DESKTOP-QNJLO1S\\SQLEXPRESS; Database = congthongtin; UID = sa; PWD = 26101995;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAction>(entity =>
            {
                entity.ToTable("tb_action");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControllerId).HasColumnName("controller_id");

                entity.Property(e => e.ControllerName)
                    .HasColumnName("controller_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150);

                entity.Property(e => e.Display)
                    .HasColumnName("display")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Namespace)
                    .HasColumnName("namespace")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Controller)
                    .WithMany(p => p.TbAction)
                    .HasForeignKey(d => d.ControllerId)
                    .HasConstraintName("FK_tb_action_tb_controller");
            });

            modelBuilder.Entity<TbController>(entity =>
            {
                entity.ToTable("tb_controller");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Controller)
                    .HasColumnName("controller")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150);

                entity.Property(e => e.Display)
                    .HasColumnName("display")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Namespace)
                    .HasColumnName("namespace")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.SortValue).HasColumnName("sort_value");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbException>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("tb_exception");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValueEn)
                    .HasColumnName("value_en")
                    .HasMaxLength(250);

                entity.Property(e => e.ValueVi)
                    .HasColumnName("value_vi")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TbExceptionLog>(entity =>
            {
                entity.ToTable("tb_exception_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FullNameEx)
                    .HasColumnName("full_name_ex")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(500);

                entity.Property(e => e.NameEx)
                    .HasColumnName("name_ex")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StackTrace).HasColumnName("stack_trace");

                entity.Property(e => e.TimeLog)
                    .HasColumnName("time_log")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbPost>(entity =>
            {
                entity.ToTable("tb_post");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(50);

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EditDate)
                    .HasColumnName("edit_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Introduction).HasColumnName("introduction");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SubmitDate)
                    .HasColumnName("submit_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tag).HasColumnName("tag");

                entity.Property(e => e.Tittle)
                    .HasColumnName("tittle")
                    .HasMaxLength(500);

                entity.Property(e => e.TypePostId).HasColumnName("type_post_id");

                entity.Property(e => e.UserCreateId).HasColumnName("user_create_id");

                entity.Property(e => e.UserEditId).HasColumnName("user_edit_id");
            });

            modelBuilder.Entity<TbRoleGroup>(entity =>
            {
                entity.ToTable("tb_role_group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150);

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("is_active");
            });

            modelBuilder.Entity<TbRoleGroupAction>(entity =>
            {
                entity.ToTable("tb_role_group_action");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionId).HasColumnName("action_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.RoleGroupId).HasColumnName("role_group_id");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.TbRoleGroupAction)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_tb_role_group_action_tb_action");

                entity.HasOne(d => d.RoleGroup)
                    .WithMany(p => p.TbRoleGroupAction)
                    .HasForeignKey(d => d.RoleGroupId)
                    .HasConstraintName("FK_tb_role_group_action_tb_role_group");
            });

            modelBuilder.Entity<TbRoute>(entity =>
            {
                entity.ToTable("tb_route");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionName)
                    .HasColumnName("action_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControllerName)
                    .HasColumnName("controller_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Namespace)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTypePost>(entity =>
            {
                entity.ToTable("tb_type_post");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Controller)
                    .HasColumnName("controller")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Route)
                    .HasColumnName("route")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TypePostName)
                    .HasColumnName("type_post_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.ToTable("tb_user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(250);

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.PassWord)
                    .HasColumnName("pass_word")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoleGroupId).HasColumnName("role_group_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
