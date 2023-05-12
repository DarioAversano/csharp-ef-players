
using C__Entity_Framework_Players;

bool go = true;

Console.WriteLine("------- MENU -------");

Console.WriteLine("0. Esci");

Console.WriteLine("1. Insert a new player");

Console.WriteLine("2. Search and print a player by Id");

Console.WriteLine("3. Search and print a player by its Name and Surname");

Console.WriteLine("4. Modify player matches and score of player by its Id");

Console.WriteLine("-------------------");

while (go)

{

    Console.Write("Choose an option: ");

    int response = int.Parse(Console.ReadLine());

    switch (response)

    {

        case 0:

            Console.WriteLine("Thank you and goodbye");

            go = false;

            break;

        case 1:

            Console.Write("Insert the name of the player: ");

            string playerName = Console.ReadLine();

            Console.WriteLine("Insert the surname : ");

            string playerSurname = Console.ReadLine();

            using (PlayerContext db = new PlayerContext())

            {

                Random random = new Random();

                int randomScore = random.Next(1, 10);

                int randomNumberOfMatches = random.Next(1, 101);

                int randomNumberOfVicories = random.Next(1, randomNumberOfMatches);

                Player newPlayer = new Player { Name = playerName, LastName = playerSurname, PlayerMatches = randomNumberOfMatches, PlayerScore = randomScore, PlayerVictories = randomNumberOfVicories };

                db.Add(newPlayer);

                db.SaveChanges();

            }

            break;

        case 2:

            Console.Write("Insert the Id to search: ");

            int playerIdToSearch = int.Parse(Console.ReadLine());
            using (PlayerContext db = new PlayerContext())

            {

                Player playerFound = db.Players.Where(player => player.PlayerId == playerIdToSearch).First();

                Console.WriteLine(playerFound);

            }

            break;

        case 3:

            Console.Write("Insert the name of the player you want to search:");

            string playerNameToSearch = Console.ReadLine();

            Console.WriteLine("Insert the surname of the player you want to search : ");

            string playerSurnameToSearch = Console.ReadLine();

            using (PlayerContext db = new PlayerContext())

            {

                Player playerFound = db.Players.Where(player => player.Name == playerNameToSearch && player.LastName == playerSurnameToSearch).First();

                Console.WriteLine(playerFound.ToString());

            }

            break;
        case 4:

            Console.Write("Insert the Id to search: ");

            int playerIdToModify = int.Parse(Console.ReadLine());


            using (PlayerContext db = new PlayerContext())

            {

                if (db.Players.Where(player => player.PlayerId == playerIdToModify).Any())

                {

                    Player playerToModify = db.Players.Where(player => player.PlayerId == playerIdToModify).First();

                    Console.Write("Insert the new player matches done: ");

                    int newPlayerMatches = int.Parse(Console.ReadLine());

                    Console.Write("Insert the new score points done: ");

                    int newPlayerScore = int.Parse(Console.ReadLine());

                    playerToModify.PlayerMatches = newPlayerMatches;

                    playerToModify.PlayerScore = newPlayerScore;

                    db.SaveChanges();

                }
                else

                {

                    Console.WriteLine("Non è stato trovato nessun giocatore con id = " + playerIdToModify);

                }



            }

            break;

        default:

            Console.WriteLine("Non hai inserito un'opzione valida! Ritenta!");

            break;



    }

}


/*
 * 
 repo: csharp-ef-players
 * 
bool continuare = true;
while (continuare)
{
    Console.WriteLine("Seleziona un numero corrispondente: ");
    Console.WriteLine("1 Inserisci una Squadra");
    Console.WriteLine("2 Inserisci un Giocatore");
    Console.WriteLine("3 Trova il Giocatre per nome");
    Console.WriteLine("4 Trova il Giocatore per ID");
    Console.WriteLine("5 Modifica il nome e cognome");
    Console.WriteLine("6 Cancella un giocatore");
    Console.WriteLine("7 Esci");

    int rispostaUtente = int.Parse(Console.ReadLine());

    switch (rispostaUtente)
    {
        case 1:
            break;
        case 2:
            Console.Write("Nome del giocatore: ");
            string nomeScelto = Console.ReadLine();

            Console.Write("Cognome del giocatore: ");
            string cognomeScelto = Console.ReadLine();

            // CREAZIONE GIOCATORE
            Player giocatore = new Player(nomeScelto, cognomeScelto);

            // APERTURA DATABASE
            using (PlayerContext db = new PlayerContext())
            {
                // AGGIUNTA GIOCATORE
                db.Add(giocatore);

                // SALVATAGGIO MODIFICHE
                db.SaveChanges();
            }

            Console.WriteLine(giocatore.ToString());
            break;

        case 3:
            Console.Write("Cerca giocatore per nome: ");
            string nomeDaCercare = Console.ReadLine();

            using (PlayerContext db = new PlayerContext())
            {
                List<Player> nomeDaTrovare = db.Player.Where(giocatoreTrovato => Nome.Contains(nomeDaCercare).ToList<Player>();
                foreach (Player giocatoreTrovato in nomeDaTrovare)
                {
                    Console.WriteLine(giocatoreTrovato.ToString());
                }
            }
            break;

        case 4:
            Console.Write("Cerca giocatore per Id: ");
            int idDaCercare = int.Parse(Console.ReadLine());

            using (PlayerContext db = new PlayerContext())
            {
                Player idDaTrovare = db.Player.Where(giocatoreTrovato => giocatoreTrovato.PlayerId.Equals(idDaCercare)).First();
                Console.WriteLine(idDaTrovare.ToString());
            }
            break;

        case 5:
            Console.WriteLine("Id del giocatore da cambiare nome o cognome");
            int giocatoreDaCambiare = int.Parse(Console.ReadLine());

            using (PlayerContext db = new PlayerContext())
            {
                Player giocatoreDaAggiornare = db.Player.Where(GiocatoreTrovato => giocatoreDaCambiare.PlayerId.Equals(giocatoreDaCambiare)).First();
                Console.WriteLine(giocatoreDaAggiornare.ToString());

                Console.WriteLine("Nuovo nome ");
                string nomeCambiato = Console.ReadLine();

                giocatoreDaAggiornare.Nome = nomeCambiato;

                Console.WriteLine("Nuovo Cognome ");
                string cognomeCambiato = Console.ReadLine();

                giocatoreDaAggiornare.Cognome = cognomeCambiato;

                db.SaveChanges();
            }
            break;

        case 6:
            Console.Write("id del giocatore da cancellare: ");
            int idDaCancellare = int.Parse(Console.ReadLine());

            using (PlayerContext db = new PlayerContext())
            {
                Player giocatoreDaCancellare = db.Player.Where(giocatoreDaTrovare => giocatoreDaTrovare.PlayerId.Equals(idDaCancellare)).First();

                db.Player.Remove(giocatoreDaCancellare);
                db.SaveChanges();

                Console.WriteLine("Giocatore rimosso");
            }
            break;

        case 7:
            Console.WriteLine("Fine!");
            continuare = false;
            break;
    }
}
*/