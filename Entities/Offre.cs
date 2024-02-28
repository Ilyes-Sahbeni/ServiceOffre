namespace ServiceOffre.Entities
{
    public class Offre
    {
        public int Id { get; set; } // par convension le nom "Id" est Clé primare
        public long Code { get; set; } = 0;
        public string Intitule { get; set; } = "";
        public string Specialite { get; set; } = "";
        public string Societe { get; set; } = "";
        public int NbrPostes { get; set; } = 0;
        public string Pays { get; set; } = "";

    }

}
