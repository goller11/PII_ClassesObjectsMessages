using System;
using Metods;


namespace ProgramaPrincipal {

    public class Program {

        static void Main (string[] args) {
            Character Thanos = new Character ("Thanos", 100, 80, "Infinity Stones");
            Character Hulk = new Character ("Hulk", 100, 90, "Extreme Fury");
            Hulk.Attack (Thanos);
            if (Thanos.Health ()) {
                Console.WriteLine (true);
            }

        }
    }
}