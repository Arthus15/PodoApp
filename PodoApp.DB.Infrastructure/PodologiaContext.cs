namespace PodoApp.DB.Infrastructure
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using PodoApp.DB.Infrastructure.Configuration.Entities;
    using PodoApp.DB.Infrastructure.Entities;

    public partial class PodologiaContext : DbContext
    {
        public PodologiaContext()
            : base("name=PodologiaContext")
        {
            Database.Log = Console.WriteLine;
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AnguloFick> anguloFick { get; set; }
        public virtual DbSet<AntecedentesFamiliares> antecedentesFamiliares { get; set; }
        public virtual DbSet<AntecedentesFisiologicos> antecedentesFisiologicos { get; set; }
        public virtual DbSet<AntecedentesPatologicos> antecedentesPatologicos { get; set; }
        public virtual DbSet<AntecedentesPodologicos> antecedentesPodologicos { get; set; }
        public virtual DbSet<Antepie> antepie { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Bipedestacion> bipedestacion { get; set; }
        public virtual DbSet<CalzadoHabitual> calzadoHabitual { get; set; }
        public virtual DbSet<Consulta> consulta { get; set; }
        public virtual DbSet<Deambulacion> deambulacion { get; set; }
        public virtual DbSet<DecubitoPronoExploracionArticular> decubitoPronoExploracionArticular { get; set; }
        public virtual DbSet<DecubitoSupinoAntepiePosicion1Radio> decubitoSupinoAntepiePosicion1Radio { get; set; }
        public virtual DbSet<DecubitoSupinoExploracionArticular> decubitoSupinoExploracionArticular { get; set; }
        public virtual DbSet<DecubitoSupinoExploracionMorfologica> decubitoSupinoExploracionMorfologica { get; set; }
        public virtual DbSet<DecubitoSupinoExploracionMuscular> decubitoSupinoExploracionMuscular { get; set; }
        public virtual DbSet<DecubitoSupinoPosicionAnguloAntepie> decubitoSupinoPosicionAnguloAntepie { get; set; }
        public virtual DbSet<DecubitoSupinoPulsos> decubitoSupinoPulsos { get; set; }
        public virtual DbSet<DecubitoSupinoPulsosTipo> decubitoSupinoPulsosTipo { get; set; }
        public virtual DbSet<Diagnostico> diagnostico { get; set; }
        public virtual DbSet<EstudioOrtopodologico> estudioOrtopodologico { get; set; }
        public virtual DbSet<FormulaDigital> formulaDigital { get; set; }
        public virtual DbSet<FormulaMetatarsal> formulaMetatarsal { get; set; }
        public virtual DbSet<FormulaPodal> formulaPodal { get; set; }
        public virtual DbSet<FPI> FPI { get; set; }
        public virtual DbSet<HistorialClinico> historialClinico { get; set; }
        public virtual DbSet<MaterialSoportePlantar> materialSoportePlantar { get; set; }
        public virtual DbSet<Paciente> paciente { get; set; }
        public virtual DbSet<Persona> persona { get; set; }
        public virtual DbSet<Podologo> podologo { get; set; }
        public virtual DbSet<PrimeraVisita> primeraVisita { get; set; }
        public virtual DbSet<PruebasComplementarias> pruebasComplementarias { get; set; }
        public virtual DbSet<Retropie> retropie { get; set; }
        public virtual DbSet<SedestacionExploracionArticular> sedestacionExploracionArticular { get; set; }
        public virtual DbSet<SedestacionExploracionMuscular> sedestacionExploracionMuscular { get; set; }
        public virtual DbSet<Sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoEstudio> tipoEstudio { get; set; }
        public virtual DbSet<Tratamiento> tratamiento { get; set; }
        public virtual DbSet<VisionFrontal> visionFrontal { get; set; }
        public virtual DbSet<VisionSagital> visionSagital { get; set; }

        public virtual DbSet<Audit> audit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Se ha creado clases de configuración para cada Entidad
            modelBuilder.Configurations.Add(new AnguloFickEntityConfiguration());
            modelBuilder.Configurations.Add(new AntecedentesFamiliaresEntityConfiguration());
            modelBuilder.Configurations.Add(new AntecedentesFisiologicosEntityConfiguration());
            modelBuilder.Configurations.Add(new AntecedentesPatologicosEntityConfiguration());
            modelBuilder.Configurations.Add(new AntecedentesPodologicosEntityConfiguration());
            modelBuilder.Configurations.Add(new AntepieEntityConfiguration());
            modelBuilder.Configurations.Add(new AspNetRolesEntityConfiguration());
            modelBuilder.Configurations.Add(new AspNetUsersEntityConfiguration());
            modelBuilder.Configurations.Add(new AuditEntityConfiguration());
            modelBuilder.Configurations.Add(new BipedestacionEntityConfiguration());
            modelBuilder.Configurations.Add(new CalzadoHabitualEntityConfiguration());
            modelBuilder.Configurations.Add(new DeambulacionEntityConfiguration());
            modelBuilder.Configurations.Add(new DecubitoPronoExploracionArticularEntityConfiguration());
            modelBuilder.Configurations.Add(new DecubitoSupinoAntepiePosicion1RadioEntityConfiguration());
            modelBuilder.Configurations.Add(new DecubitoSupinoExploracionArticularEntityConfiguration());
            modelBuilder.Configurations.Add(new DecubitoSupinoExploracionMorfologicaEntityConfiguration());
            modelBuilder.Configurations.Add(new DecubitoSupinoExploracionMuscularEntityConfiguration());
            modelBuilder.Configurations.Add(new DecubitoSupinoPosicionAnguloAntepieEntityConfiguration());
            modelBuilder.Configurations.Add(new DecubitoSupinoPulsosEntityConfiguration());
            modelBuilder.Configurations.Add(new DecubitoSupinoPulsosTipoEntityConfiguration());
            modelBuilder.Configurations.Add(new EstudioOrtopodologicoEntityConfiguration());
            modelBuilder.Configurations.Add(new FormulaDigitalEntityConfiguration());
            modelBuilder.Configurations.Add(new FormulaMetatarsalEntityConfiguration());
            modelBuilder.Configurations.Add(new FormulaPodalEntityConfiguration());
            modelBuilder.Configurations.Add(new FPIEntityConfiguration());
            modelBuilder.Configurations.Add(new HistorialClinicoEntityConfiguration());
            modelBuilder.Configurations.Add(new PacienteEntityConfiguration());
            modelBuilder.Configurations.Add(new PersonaEntityConfiguration());
            modelBuilder.Configurations.Add(new PodologoEntityConfiguration());
            modelBuilder.Configurations.Add(new PrimeraVisitaEntityConfiguration());
            modelBuilder.Configurations.Add(new RetropieEntityConfiguration());
            modelBuilder.Configurations.Add(new SedestacionExploracionArticularEntityConfiguration());
            modelBuilder.Configurations.Add(new SedestacionExploracionMuscularEntityConfiguration());
            modelBuilder.Configurations.Add(new TipoEstudioEntityConfiguration());
            modelBuilder.Configurations.Add(new TratamientoEntityConfiguration());
            modelBuilder.Configurations.Add(new VisionFrontalEntityConfiguration());
            modelBuilder.Configurations.Add(new VisionSagitalEntityConfiguration());

            modelBuilder.Entity<Audit>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
