namespace LibVoiture
{
    public class Reservoir
    {
        private int capacite;
        private int contenu;

        public Reservoir(int capacite)
        {
            this.capacite = capacite;
            this.contenu = 0;
        }
        public Reservoir() { }

        public int GetCapacite() => this.capacite;
        public int GetContenu() => this.contenu;

        public void Vider()
        {
            this.contenu = 0;
        }

        public void Remplir(int quantite)
        {
            // ensure we don't exceed capacity
            if (quantite < 0) return;
            this.contenu = Math.Min(quantite, this.capacite);
        }

        public override string ToString()
        {
            return $"Reservoir [capacite={this.capacite}, contenu={this.contenu}]";
        }
    }

}

