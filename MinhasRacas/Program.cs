using System;
using System.Linq;

namespace MinhasRacas
{
    class Program
    {
        static void Main(string[] args)
        {
            string raca;
            string caracteristica;

            listaRacaCachorro();

            Animal oAnimal = new Animal();

            Console.WriteLine("Qual seu tipo de animal?\n");
            Console.WriteLine("- Cachorro");
            Console.WriteLine("- Gato");
            Console.WriteLine("\nEscreva o tipo escolhido: ");
            oAnimal.tipoAnimal.tipo = Console.ReadLine();

            Console.WriteLine("Qual a raça de animal?\n");
            Console.WriteLine("\nEscreva o tipo escolhido: ");
            oAnimal.tipoAnimal.raca = Console.ReadLine();



            oAnimal.tipoAnimal.raca = "";
            oAnimal.caracteristica.origem = "";
            oAnimal.caracteristica.temperamento = "";
            oAnimal.caracteristica.idadeMaxima = 0;
            oAnimal.caracteristica.altura = 0.0F;
            oAnimal.caracteristica.peso = 0.0F;
            oAnimal.caracteristica.temperamento = "";
            oAnimal.caracteristica.nivelDeCuidado = "";
        }

        static bool listaRacaCachorro(string racaCachorro = "")
        {
            Animal[] lista = new Animal[89];

            lista[0] = new Animal
            {
                tipoAnimal = new TipoAnimal
                {
                    tipo = "Cachorro",
                    raca = "Vira-Lata",
                },
                caracteristica = new Caracteristica
                {
                    altura = 1.3F,
                    idadeMaxima = 20,
                    nivelDeCuidado = "Baixo",
                    origem = "Sem origem conhecida",
                    peso = 30.4F,
                    temperamento = "Dócil;Amoroso;Companheiro;Cão de Guarda;Fiel",
                }
            };
            //lista[1] = "Afegão Hound";
            //lista[2] = "Affenpinscher";
            //lista[3] = "Airedale Terrier";
            //lista[4] = "Akita";
            //lista[5] = "American Staffordshire Terrier";
            //lista[6] = "Basenji";
            //lista[7] = "Basset Hound";
            //lista[8] = "Beagle";
            //lista[9] = "Beagle Terrier";
            //lista[10] = "Bearded Collie";
            //lista[11] = "Bedlington Terrier";
            //lista[12] = "Bichon Frisé";
            //lista[13] = "Bloodhound";
            //lista[14] = "Bobtail";
            //lista[15] = "Boiadeiro Australiano";
            //lista[16] = "Boiadeiro Bernês";
            //lista[17] = "Boder Collie";
            //lista[18] = "Border Terrier";
            //lista[19] = "Borzoi";
            //lista[20] = "Boston Terrier";
            //lista[21] = "Boxer";
            //lista[22] = "Buldogue Francês";
            //lista[23] = "Buldogue Inglês";
            //lista[24] = "Bull Terrier";
            //lista[25] = "Bulmastife";
            //lista[26] = "Cairn Terrier";
            //lista[27] = "Cane Corso";
            //lista[28] = "Cão de Água Português";
            //lista[29] = "Cão de Crista Chinês";
            //lista[30] = "Cavalier King Charles Spaniel";
            //lista[31] = "Chesapeake Bay Retriever";
            //lista[32] = "Chihuahua";
            //lista[33] = "Chow Chow";
            //lista[34] = "Cocker Spaniel Americano";
            //lista[35] = "Cocker Spaniel Inglês";
            //lista[36] = "Collie";
            //lista[37] = "Coton de Tuléar";
            //lista[38] = "Dachshund";
            //lista[39] = "Dálmata";
            //lista[40] = "Dandie Dinmont Terrier";
            //lista[41] = "Dobermann";
            //lista[42] = "Dogo Argentino";
            //lista[43] = "Dogue Alemão";
            //lista[44] = "Fila";
            //lista[45] = "Fox Terrier";
            //lista[46] = "Foxhound Inglês";
            //lista[47] = "Galgo Escocês";
            //lista[48] = "Galgo Irlandês";
            //lista[49] = "Golden Retriever";
            //lista[50] = "Grande Boiadeiro Suiço";
            //lista[51] = "Greyhound";
            //lista[52] = "Grifo da Bélgica";
            //lista[53] = "Husky Siberiano";
            //lista[54] = "Jack Russell Terrier";
            //lista[55] = "King Charles";
            //lista[56] = "Komondor";
            //lista[57] = "Labradoodle";
            //lista[58] = "Labrador Terrier";
            //lista[59] = "Lakeland Terrier";
            //lista[60] = "Leonberger";
            //lista[61] = "Lhasa Apso";
            //lista[62] = "Lulu da Pomerânia";
            //lista[63] = "Malamute do Alasca";
            //lista[64] = "Maltês";
            //lista[65] = "Mastife";
            //lista[66] = "Mastim Napolitano";
            //lista[67] = "Mastim Tibetano";
            //lista[68] = "Norfolk Terrier";
            //lista[69] = "Norwich Terrier";
            //lista[70] = "Papillon";
            //lista[71] = "Pastor Alemão";
            //lista[72] = "Pastor Australiano";
            //lista[73] = "Pinscher Miniatura";
            //lista[74] = "Poodle";
            //lista[75] = "Pug";
            //lista[76] = "Rottweiler";
            //lista[77] = "ShihTzu";
            //lista[78] = "Silky Terrier";
            //lista[79] = "Skye Terrier";
            //lista[80] = "Staffordshire Bull Terrier";
            //lista[81] = "Terra Nova";
            //lista[82] = "Terrier Escocês";
            //lista[83] = "Tosa";
            //lista[84] = "Weimaraner";
            //lista[85] = "Welsh Corgi (Cardigan)";
            //lista[86] = "Welsh Corgi (Pembroke)";
            //lista[87] = "West Highland Write Terrier";
            //lista[88] = "Whippet";
            //lista[89] = "Xoloitzcuintli";
            //lista[90] = "Yorkshire Terrier";

            return false;
        }
        static bool listaRacaGato(string racaGato)
        {
            string[] raca = { };

            raca[0] = "Abyssinian";
            raca[1] = "American Bobtail";
            raca[2] = "Longhair";
            raca[3] = "American Bobtail Shorthair";
            raca[4] = "American Shorthair";
            raca[5] = "American Wirehair";
            raca[6] = "Arabian Mau";
            raca[7] = "Asian Semi-Long Hair";
            raca[8] = "Australian Mist";
            raca[9] = "Bengal";
            raca[10] = "Bobtail Japonês";
            raca[11] = "Bombaim";
            raca[12] = "Brazilian Shorthair";
            raca[13] = "British Longhair";
            raca[14] = "Burmês";
            raca[15] = "California Spangled Cat";
            raca[16] = "Chausie";
            raca[17] = "Cornish Rex";
            raca[18] = "Curl Americano Pelo Curto";
            raca[19] = "Curl Americano Pelo Longo";
            raca[20] = "Cymric";
            raca[21] = "Devon Rex";
            raca[22] = "Domestic Long-Haired";
            raca[23] = "Domestic Short-Haired";
            raca[24] = "Don Sphynx";
            raca[25] = "Egyptian Mau";
            raca[26] = "European";
            raca[27] = "Exotic Shotthair";
            raca[28] = "German Rex";
            raca[29] = "Havanas";
            raca[30] = "Himalaio";
            raca[31] = "Khao Manee";
            raca[32] = "Korat";
            raca[33] = "Kurilian Bobtail Longhair";
            raca[34] = "Kurilian Bobtail Shorthair";
            raca[35] = "LePerm Longhair";
            raca[36] = "LePerm Shorthair";
            raca[37] = "Maine Coon";
            raca[38] = "Manx";
            raca[39] = "MekongBobtail";
            raca[40] = "Munchkin Longhair";
            raca[41] = "Munchkin Shorthair";
            raca[42] = "Nebelung";
            raca[43] = "Norwegian Forest Cat";
            raca[44] = "Ocicat";
            raca[45] = "Ojos Azules Shorthair";
            raca[46] = "Oriental Longhair";
            raca[47] = "Oriental Shorthair";
            raca[48] = "Persa";
            raca[49] = "Peterbald";
            raca[50] = "Pixiebob Longhair";
            raca[51] = "Pixiebob Shorthair";
            raca[52] = "Ragamuffin";
            raca[53] = "Ragdoll";
            raca[54] = "Russo Azul";
            raca[55] = "Sagrado da Birmânia";
            raca[56] = "Savannah Cat";
            raca[57] = "Scottish Fold";
            raca[58] = "Selkirk Rex Longhair";
            raca[59] = "Selkirk Rex Shorthair";
            raca[60] = "Serengeti";
            raca[61] = "Siamês";
            raca[62] = "Siberian";
            raca[63] = "Singapura";
            raca[64] = "Snowshoe";
            raca[65] = "Sokoke";
            raca[66] = "Somali";
            raca[67] = "Sphynx";
            raca[68] = "Thai";
            raca[69] = "Tonkinese Shorthair";
            raca[70] = "Toyger";
            raca[71] = "Turkish Angorá";
            raca[72] = "Turkish Van";
            raca[73] = "York Chocolate";

            return false;
        }
    }
}
