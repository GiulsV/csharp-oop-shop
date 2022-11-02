// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
-codice(numero intero)
-nome
-descrizione
-prezzo
-iva
Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
-alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
-Il codice prodotto sia accessibile solo in lettura
-Gli altri attributi siano accessibili sia in lettura che in scrittura
-Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
-Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)*/


//Istanza prodotto con tutte le informazioni
Product prodottoprova = new Product("iPhone 14 ", "Core processore: 6-Core; Descrizione processore: A15 Bionic; Capacità di memoria: 256 GB", 1109, 22);

//Stampa il codice prodotto
Console.WriteLine(prodottoprova.GetProductCode());
//Legge il nome
Console.WriteLine(prodottoprova.GetName());
//Leggere la descrizione
Console.WriteLine(prodottoprova.GetDescription());
//Prezzo senza iva
Console.WriteLine(prodottoprova.Price());
//Prezzo con iva
Console.WriteLine(prodottoprova.TaxPrice());
//Nome esteso
Console.Write("codice + nome: ");
prodottoprova.FullName();
//Bonus
Console.WriteLine(prodottoprova.GetPadLeft());

//stampa intero prodotto 
prodottoprova.Print();



//PRODUCT
public class Product
{
    private int productCode;
    public string name;
    public string description;
    private float price;
    private int iva = 25;

    //Costruttore
    public Product() {
        productCode = new Random().Next(1, 100000);
    }
    public Product(string name, string description, float price, int iva)
    {
        productCode = new Random().Next(1, 100000);
        this.name = name;
        this.description = description;
        this.price = price;
        this.iva = iva;
    }

    //Leggere il codice
    public int GetProductCode()
    {
        return productCode;
    }

    //Leggere o modificare il nome
    public string GetName()
    {
        return name;
    }
    public void SetName(string input)
    {
        this.name = input;
        ;
    }
    //Leggere o modificare la descrizione 
    public string GetDescription()
    {
        return description;
    }
    public void SetDescription(string input)
    {
        this.description = input;
        ;
    }
    public double Price()
    {
        return price;
    }
    public double TaxPrice()
    {
        return price + (price * 0.22);
    }

    public void FullName()
    {
        Console.WriteLine(productCode + " " + name);
    }


    //Bonus
    public string GetPadLeft()
    {
        string codice = Convert.ToString(this.productCode);
        while (codice.Length < 8)
        {
            codice = '0' + codice;
        }
        return codice;
    }

    //Stampa
    public void Print()
    {
        Console.WriteLine("Stampa info prodotto");
        Console.WriteLine("Codice prodotto: " + productCode);
        Console.WriteLine("Nome prodotto: " + name);
        Console.WriteLine("Descrizione prodotto: " + description);
        Console.WriteLine("Prezzo: " + price + " euro");
        Console.WriteLine("Prezzo ivato: " + TaxPrice() + " euro");
        Console.WriteLine("Iva: " + iva);
        Console.WriteLine("Codice con pad left: " + GetPadLeft());
    }
}
