﻿using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "Yanzada";
            objetoPersonagem1.idade = 17;
            objetoPersonagem1.armadura = "Força";

            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "Everson Zoio";
            objetoPersonagem2.idade = 20;
            objetoPersonagem2.armadura = "Mental";

            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Atacar()}");
        }
    }
}
