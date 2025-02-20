var outroParafrafo = "C# é uma linguaguem moderna e versátil "+
"Com C# consigo desenvolver para Web, Desktop, jogos  "+
"Mobile, entre outros";

// indexOf 
var indexOf = outroParafrafo.IndexOf("C#");


// LastindexOf 
var lasfindexOf = outroParafrafo.LastIndexOf("C#");

// Starswich 
var starswich = outroParafrafo.StartsWith("C#");

// Substring
var IndexOfMobile = outroParafrafo.IndexOf("Mobile");
var substringMobile = outroParafrafo.Substring(IndexOfMobile, 6);

// Contatos 
var containsJogos = outroParafrafo.Contains("Jogos",StringComparison.OrdinalIgnoreCase);
var containsJogosExact = outroParafrafo.Contains("Jogos Exact");
var contaisRUim = outroParafrafo.Contains("RUim");

