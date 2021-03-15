using Blazor.Dominio.Base;
using Blazor.Dominio.Films;
using Blazor.Dominio.Operaciones.Multiplicacion;
using Blazor.Dominio.Users;
using Blazor.Infraestructura.Datos.Persistencia.Base.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Blazor.Infraestructura.Datos.Persistencia.Base
{
    public class ContextoDb : DbContext, IContextDb
    {
        private readonly DbSettings _settings;

        // Aqui se definen todas las tablas de la base de datos

        #region Tablas db

        public virtual DbSet<FilmEntity> Film { get; set; }
        public virtual DbSet<UserEntity> User { get; set; }

        public DbSet<MultiplicacionEntity> Multiplicacion { get; set; }

        #endregion Tablas db

        public ContextoDb() => _settings = new DbSettings
        {
            ConnectionString = "Data Source=DESKTOP-NE15I70\\BDDUVAN;Initial Catalog=blazor;User ID=sa;Password=3147073260"
        };

        //public ContextoDb(DbContextOptions options, IConfiguration configuration) : base(options) => _settings = new DbSettings
        //{
        //    ConnectionString = configuration.GetSection("DbConnectionString").Get<string>()
        //};

        //public ContextoDb(IOptions<DbSettings> settings) =>
        //   _settings = settings.Value;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(_settings.ConnectionString);

        //public ContextoDb(IConfiguration configuration) => _settings = new DbSettings
        //{
        //    ConnectionString = configuration.GetSection("DbConnectionString").Get<string>()
        //};

        public int Commit() => base.SaveChanges();

        public void Rollback() =>
            base.ChangeTracker
            .Entries()
            .Where(e => e.Entity != null)
            .ToList()
            .ForEach(e => e.State = EntityState.Detached);

        public new DbSet<T> Set<T>() where T : EntidadBase => base.Set<T>();

        public void SetDeatached<T>(T item) where T : EntidadBase => Entry(item).State = EntityState.Detached;
        public void SetModified<T>(T item) where T : EntidadBase => Entry(item).State = EntityState.Modified;

        public void SetAttach<T>(T item) where T : EntidadBase
        {
            if (Entry(item).State == EntityState.Detached)
                base.Set<T>().Attach(item);
        }
    }
}