﻿


var persona = new Persona
{
    Nome = "Luisa",
    Cognome = "Marcon",
    Eta = 26
};

Console.WriteLine(persona.GetDettagli());

public class Persona
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int Eta { get; set; }

    public string GetNome()
    {
        return Nome;
    }

    public string GetCognome()
    {
        return Cognome;
    }

    public int GetEta()
    {
        return Eta;
    }

    public string GetDettagli()
    {
        return $"Nome: {Nome}, Cognome: {Cognome}, Età: {Eta}";
    }


}
