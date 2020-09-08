using System;
using System.Collections.Generic;
using System.Text;

namespace MinhasRacas
{
    class Animal
    {
        public TipoAnimal tipoAnimal;
        public Caracteristica caracteristica;
    }

    class TipoAnimal
    {
        public string tipo;
        public string raca;
    }

    class  Caracteristica
    {
        public string origem;
        public int idadeMaxima;
        public float peso;
        public float altura;
        public string nivelDeCuidado;
        public string temperamento;
    }
}
