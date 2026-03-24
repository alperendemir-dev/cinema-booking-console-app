// See https://aka.ms/new-console-template for more information
bool weiterfragen = true;
double gesamtpreis = 0;

while (weiterfragen)
{
    Console.WriteLine("Hallo Kinobesucher, hier ist die Filmliste:");
    Console.WriteLine("1 = Recep Ivedik 8 (10 Euro pro Ticket)");
    Console.WriteLine("2 = KV Pusu Darbe (15 Euro pro Ticket)");
    Console.WriteLine("Welchen Film willst du anschauen? (1 oder 2)");

    string eingabe = Console.ReadLine();
    bool erfolgreich = int.TryParse(eingabe, out int filmauswahl);

    if (!erfolgreich)
    {
        Console.WriteLine("Ungültige Eingabe! Bitte gib eine Zahl ein.");
        continue;
    }

    if (filmauswahl != 1 && filmauswahl != 2)
    {
        Console.WriteLine("Ungültige Auswahl! Bitte wähle nur 1 oder 2.");
        continue;
    }

    string filmname = "";
    double ticketpreis = 0;

    if (filmauswahl == 1)
    {
        filmname = "Recep Ivedik 8";
        ticketpreis = 10.0;
    }
    else if (filmauswahl == 2)
    {
        filmname = "KV Pusu Darbe";
        ticketpreis = 15.0;
    }

    Console.WriteLine($"Super, du hast {filmname} gewählt!");
    Console.WriteLine("Wie viele Tickets möchtest du kaufen?");
    string ticketEingabe = Console.ReadLine();
    bool ticketsErfolgreich = int.TryParse(ticketEingabe, out int anzahlTickets);

    if (!ticketsErfolgreich || anzahlTickets <= 0)
    {
        Console.WriteLine("Ungültige Anzahl! Bitte gib eine positive Zahl ein.");
        continue;
    }

    double kosten = ticketpreis * anzahlTickets;
    gesamtpreis += kosten;

    Console.WriteLine($"Du hast {anzahlTickets} Tickets für {filmname} bestellt. Das kostet {kosten} Euro.");

    Console.WriteLine("Möchtest du noch Tickets für einen anderen Film kaufen? (j/n)");
    string antwort = Console.ReadLine();

    if (antwort.ToLower() != "j")
    {
        weiterfragen = false;
        Console.WriteLine("Danke für deine Bestellung und viel Spaß im Kino!");
    }
}

Console.WriteLine($"\nGesamtsumme deiner Bestellung: {gesamtpreis} Euro.");
