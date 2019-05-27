namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("decubitoSupinoExploracionArticular")]
    public partial class DecubitoSupinoExploracionArticular
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DecubitoSupinoExploracionArticular()
        {
            estudioOrtopodologico = new HashSet<EstudioOrtopodologico>();
        }

        [Key]
        [Column(Order = 0)]
        public Guid idEArticularIzdo { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid idEArticularDcho { get; set; }

        public double? dismetriaPiesAltosIzdo { get; set; }

        public double? dismetriaPiesAltosDcho { get; set; }

        public double? dismetriaPiesBajosIzdo { get; set; }

        public double? dismetriaPiesBajosDcho { get; set; }

        public double? caderaFlexionIzda { get; set; }

        public double? caderaFlexionDcha { get; set; }

        public double? caderaExtensionIzda { get; set; }

        public double? caderaExtensionDcha { get; set; }

        public double? caderaHiperextensionIzda { get; set; }

        public double? caderaHiperextensionDcha { get; set; }

        public double? caderaAbduccionIzda { get; set; }

        public double? caderaAbduccionDcha { get; set; }

        public double? caderaAduccionIzda { get; set; }

        public double? caderaAduccionDcha { get; set; }

        public double? caderaRotInternaIzda { get; set; }

        public double? caderaRotInternaDcha { get; set; }

        public double? caderaRotExternaIzda { get; set; }

        public double? caderaRotExternaDcha { get; set; }

        public double? rodillaFlexionIzda { get; set; }

        public double? rodillaFlexionDcha { get; set; }

        public double? rodillaExtensionIzda { get; set; }

        public double? rodillaExtensionDcha { get; set; }

        public double? rodillaHiperextensionIzda { get; set; }

        public double? rodillaHiperextensionDcha { get; set; }

        public bool genuValgoReductibleIzda { get; set; }

        public bool genuValgoReductibleDcha { get; set; }

        public bool genuValgoIrreductibleIzda { get; set; }

        public bool genuValgoIrreductibleDcha { get; set; }

        public bool genuVaroReductibleIzda { get; set; }

        public bool genuVaroReductibleDcha { get; set; }

        public bool genuVaroIrreductibleIzda { get; set; }

        public bool genuVaroIrreductibleDcha { get; set; }

        public double? anguloQizda { get; set; }

        public double? anguloQdcha { get; set; }

        public double? tpaFpIzda { get; set; }

        public double? tpaFpDcha { get; set; }

        public double? tpaFdIzda { get; set; }

        public double? tpaFdDcha { get; set; }

        public double? retropieAsaEversionIzda { get; set; }

        public double? retropieAsaEversionDcha { get; set; }

        public double? retropieAsaInversionIzda { get; set; }

        public double? retropieAsaInversionDcha { get; set; }

        public double? mediopiePronacionIzda { get; set; }

        public double? mediopiePronacionDcha { get; set; }

        public double? mediopieSupinacionIzda { get; set; }

        public double? mediopieSupinacionDcha { get; set; }

        public double? antepie1radioAmtfFpIzda { get; set; }

        public double? antepie1radioAmtfFpDcha { get; set; }

        public double? antepie1radioAmtfFdIzda { get; set; }

        public double? antepie1radioAmtfFdDcha { get; set; }

        public double? antepie1radioFalangeFpIzda { get; set; }

        public double? antepie1radioFalangeFpDcha { get; set; }

        public bool antepie1radioHallusLimitusIzdo { get; set; }

        public bool antepie1radioHallusLimitusDcho { get; set; }

        public bool antepie1radioHallusRigidusIzdo { get; set; }

        public bool antepie1radioHallusRigidusDcho { get; set; }

        public bool antepie1radioHallusFlexusIzdo { get; set; }

        public bool antepie1radioHallusFlexusDcho { get; set; }

        public bool antepie1radioHallusHiperextensusIzdo { get; set; }

        public bool antepie1radioHallusHiperextensusDcho { get; set; }

        public bool antepie1radioHallusVizdo { get; set; }

        public bool antepie1radioHallusVdcho { get; set; }

        public string antepie1radioOtrosIzdo { get; set; }

        public string antepie1radioOtrosDcho { get; set; }

        public double? antepie25radioAmtfFpIzdo { get; set; }

        public double? antepie25radioAmtfFpDcho { get; set; }

        public double? antepie25radioAmtfFdIzdo { get; set; }

        public double? antepie25radioAmtfFdDcho { get; set; }

        public double? antepie25radioProximalFpIzdo { get; set; }

        public double? antepie25radioProximalFpDcho1 { get; set; }

        public double? antepie25radioProximalFdIzdo1 { get; set; }

        public double? antepie25radioProximalFdDcho { get; set; }

        public double? antepie25radioDistalFpIzdo { get; set; }

        public double? antepie25radioDistalFpDcho { get; set; }

        public double? antepie25radioDistalFdIzdo { get; set; }

        public double? antepie25radioDistalFdDcho { get; set; }

        public bool antepie25radio5metaCortoIzdo { get; set; }

        public bool antepie25radio5metaCortoDcho { get; set; }

        public bool antepie25radio5varoIzdo { get; set; }

        public bool antepie25radio5varoDcho { get; set; }

        public bool antepie25radio5hipermovilIzdo { get; set; }

        public bool antepie25radio5hipermovilDcho { get; set; }

        public bool antepie25radioJuaneteSastreIzdo { get; set; }

        public bool antepie25radioJuaneteSastreDcho { get; set; }

        public string antepie25radioOtrosIzdo { get; set; }

        public string antepie25radioOtrosDcho { get; set; }

        public Guid? id_posicion_angulo_antepie { get; set; }

        public Guid? id_posicion_1_radio { get; set; }

        [JsonIgnore]
        public virtual DecubitoSupinoAntepiePosicion1Radio decubitoSupinoAntepiePosicion1Radio { get; set; }

        [JsonIgnore]
        public virtual DecubitoSupinoPosicionAnguloAntepie decubitoSupinoPosicionAnguloAntepie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<EstudioOrtopodologico> estudioOrtopodologico { get; set; }
    }
}
