using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Entity_Framework_Players
{
    [Table("players_table")]
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int PlayerScore { get; set; }
        public int PlayerMatches { get; set; }
        public int PlayerVictories { get; set; }


        public string PlayerIDConvertToString()
        {
            string PlayerIDReturn = "";
            PlayerIDReturn = PlayerId.ToString();
            return PlayerIDReturn;
        }

        public override string ToString()
        {

            string PlayerInfo = $"Nome: {Name}\n" +
                $"Cognome: {LastName}\n" +
                $"Punteggio: {PlayerScore}\n" +
                $"Partite Giocate: {PlayerMatches}\n" +
                $"Partite Vinte: {PlayerVictories}\n";

            return PlayerInfo;
        }


    }
}







/*
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Entity_Framework_Players
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Column("player_nome")]
        public string Nome { get; set; }
        [Column("player_cognome")]
        public string Cognome { get; set; }
        [Column("player_punteggio")]
        public int Punteggio { get; set; }
        [Column("player_partitegiocate")]
        public int PartiteGiocate { get; set; }
        [Column("player_partitevinte")]
        public int PartiteVinte { get; set; }




        // COSTRUTTORE

        public Player(string Nome, string Cognome)
        {
            Random random = new Random();
            this.Nome = Nome;
            this.Cognome = Cognome;
            Punteggio = random.Next(11);
            PartiteGiocate = random.Next(1, 101);
            PartiteVinte = random.Next(1, PartiteGiocate + 1);
        }

        public override string ToString()
        {
            // = poi +=
            string rapprstring = "PlayerId: " + PlayerId + "\n";
            rapprstring += "Nome: " + Nome + "\n";
            rapprstring += "Cognome: " + Cognome + "\n";
            rapprstring += "Punteggio: " + Punteggio + "\n";
            rapprstring += "Partite giocate: " + PartiteGiocate + "\n";
            rapprstring += "Partite vinte: " + PartiteVinte + "\n";
            return rapprstring;
        }

    }
}

*/