using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro_Assistencia_Tecnica.Model
{
    /// <summary>
    /// classe de modelo com entrada de atributos cadastro de ficha
    /// </summary>
    class Ficha
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime dataEntrada;

        public DateTime DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }

        private String nroFicha;

        public String NroFicha
        {
            get { return nroFicha; }
            set { nroFicha = value; }
        }

        private String cliente;

        public String Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }


        private String telefone;

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private String endereco;

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private String nroEndereco;

        public String NroEndereco
        {
            get { return nroEndereco; }
            set { nroEndereco = value; }
        }

        private String aparelho;

        public String Aparelho
        {
            get { return aparelho; }
            set { aparelho = value; }
        }

        private String marca;

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private String modelo;

        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private String acessorios;

        public String Acessorios
        {
            get { return acessorios; }
            set { acessorios = value; }
        }

        private String estado;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private Decimal valor;

        public Decimal Valor
        {
            get { return valor; }
            set
            {
                if (value.Equals(""))
                    throw new FormatException("Campo Invalido");
                valor = value;
            }
        }

        private String aprovado;

        public String Aprovado
        {
            get { return aprovado; }
            set { aprovado = value; }
        }

        private String dataAprovado;

        public String DataAprovado
        {
            get { return dataAprovado; }
            set { dataAprovado = value; }
        }

        private String ok;

        public String Ok
        {
            get { return ok; }
            set { ok = value; }
        }

        private String dataOk;

        public String DataOk
        {
            get { return dataOk; }
            set { dataOk = value; }
        }

        private String entrega;

        public String Entrega
        {
            get { return entrega; }
            set { entrega = value; }
        }

        private String dataEntrega;

        public String DataEntrega
        {
            get { return dataEntrega; }
            set { dataEntrega = value; }
        }



        private String detalhes;

        public String Detalhes
        {
            get { return detalhes; }
            set { detalhes = value; }
        }


        public string[] ListaAparelhos()
        {
            var data = new[] {  "2 Ferros",
                                "2 Secadores",
                                "2 Chapinhas",
                                "2 Ventiladores",
                                "Airfryer",
                                "Aquecedor",
                                "Aspirador",
                                "Batedeira",
                                "Chapinha",
                                "Cafeteira",
                                "Centrifuga de Fruta",
                                "Centrifuga de Roupas",
                                "Churrasqueira elétrica",
                                "Circulador de Ar",
                                "Climatizador",
                                "Enceradeira",
                                "Espremedor",
                                "Ferro",
                                "Forninho",
                                "Forno",
                                "Fritadeira",
                                "Furadeira",
                                "Grill",
                                "Inalador",
                                "Jarra Elétrica",
                                "Liquidificador",
                                "Luminária",
                                "Master",
                                "Mega Master",
                                "Microondas",
                                "Massageador",
                                "Mix",
                                "Multiprocessador",
                                "Panela Elétrica",
                                "Panificadora",
                                "Pelix",
                                "Prancha",
                                "Radio",
                                "Secador",
                                "Som",
                                "Televisor",
                                "Termocera",
                                "Torradeira",
                                "Umidificador",
                                "Vaporetto",
                                "Ventilador",
                                "Ventilador de Coluna",
                                "Ventilador de Torre",
                                "Ventilador de Teto"
                              };
            return data;
        }

        public string[] ListaMarcas()
        {
            var data = new[] {  "2 Arno",
                                "2 Black & Decker",
                                "2 Electrolux",
                                "2 Taiff",
                                "2 Walita",
                                "AOC",
                                "Arge",
                                "Arno",
                                "Black & Decker",
                                "Black + Decker",
                                "Bluesky",
                                "Bosch",
                                "Brastemp",
                                "Braun",
                                "Brisa",
                                "Britânia",
                                "Cadence",
                                "Carrefour",
                                "CCE",
                                "Conair",
                                "Consul",
                                "Continental",
                                "Cougar",
                                "Dako",
                                "Dellar",
                                "Delta",
                                "Durabrand",
                                "Eco",
                                "Electrolux",
                                "Faet",
                                "Fama",
                                "Fischer",
                                "Fogatti",
                                "Ford",
                                "Formula",
                                "Fun Kitchen",
                                "Gama",
                                "General Eletric",
                                "George Foreman",
                                "GoldStar",
                                "Gradiente",
                                "Hamilton",
                                "Home",
                                "Home Leader",
                                "Huttman",
                                "hyundai",
                                "Inalar",
                                "Industrial",
                                "Karcher",
                                "LG",
                                "Latina",
                                "Layr",
                                "Lizz",
                                "Loren Sid",
                                "Makita",
                                "Mallory",
                                "Mega",
                                "Midea",
                                "Mitsubishi",
                                "Mondial",
                                "Nano",
                                "NKS",
                                "Oster",
                                "Panasonic",
                                "Parlux",
                                "Philco",
                                "Philips",
                                "Philips Walita",
                                "Polti",
                                "Prosdócimo",
                                "Pulmosonic",
                                "Remington",
                                "Revlon",
                                "Samsung",
                                "Sanyo",
                                "Sharp",
                                "Sield",
                                "Singer",
                                "Skymsen",
                                "Sony",
                                "Star Line",
                                "Suggar",
                                "Suzuki",
                                "Taiff",
                                "Tany",
                                "Tatanium",
                                "Toshiba",
                                "Tufão",
                                "Ultra",
                                "Vent Norte",
                                "Venti Delta",
                                "Venti Silva",
                                "Ventisol",
                                "Viva vento",
                                "Walita"
                             };
            return data;
        }

        public string[] ListaModelos()
        {
            var data = new[] {
                                "Airfryer",
                                "AJ2032-BR",
                                "AJ2054-BR",
                                "AJ2056-BR",
                                "Alívio",
                                "Alívio Maxx",
                                "All in one",
                                "All in one 2",
                                "Antigo",
                                "Aquarela",
                                "Aquaspeed",
                                "ASP 1000",
                                "ASP 1450",
                                "Ative!",
                                "Auto Clean",
                                "B30",
                                "B40",
                                "BBR12",
                                "Bella Arome",
                                "Bella Arome 26",
                                "Bianca Rice",
                                "Black Ion",
                                "Boreal",
                                "BPA",
                                "Branco",
                                "Bravo",
                                "Buon Giorno",
                                "C400",
                                "C45",
                                "Carousel",
                                "Carousel II",
                                "Ceramic",
                                "Ceramic Gliss",
                                "Ceramic ION",
                                "Cerâmica",
                                "Chef",
                                "Chef Luxo",
                                "Cinza",
                                "Clean",
                                "Clic Lav",
                                "CM500",
                                "Compact",
                                "Confort",
                                "CP 15",
                                "CP 15 Inox",
                                "Daihatsu",
                                "DCM 1000",
                                "Diamante",
                                "Easy",
                                "Easy 2",
                                "EasyBox",
                                "Easycord",
                                "Easyline",
                                "Eletronic",
                                "Eletronic Filter",
                                "ErgoLite",
                                "Exportline",
                                "F-40",
                                "Faciclic",
                                "Faciliq",
                                "Family",
                                "Family Plus",
                                "FB",
                                "FB 160",
                                "FB 167",
                                "FB 991",
                                "Fire Fox",
                                "Firenze",
                                "Flash Ceramic",
                                "Forma 20",
                                "Fox ION",
                                "FTC",
                                "FTD",
                                "FU40",
                                "FU50",
                                "FV-3210.11 (Ultragliss)",
                                "FV-4250.11 (Easycord)",
                                "Gloss",
                                "Golf",
                                "Grill",
                                "GT",
                                "GT 2000",
                                "GT 3000",
                                "Hepamaxx",
                                "Hidro",
                                "Hidrovac 1300 (Hidro)",
                                "Inox",
                                "Inverter",
                                "ION",
                                "Italy",
                                "Jet Defrost",
                                "Junior",
                                "Kalispo",
                                "L-25",
                                "L-31",
                                "L-51",
                                "Laranja",
                                "Linea",
                                "LiqArt",
                                "LiqFaz",
                                "LiqStar",
                                "Listo",
                                "Look",
                                "Lumina",
                                "Magiclean",
                                "MAGD",
                                "MAGF",
                                "Mais Você",
                                "Max ION",
                                "Max Trio",
                                "Max Trio 1400W",
                                "Max Trio 1600W",
                                "Maxxion",
                                "ME18S",
                                "ME21S",
                                "ME27F",
                                "ME28S",
                                "ME33F",
                                "MEF41",
                                "MEG41",
                                "Master",
                                "MegaMaster",
                                "Mondo",
                                "Multiprocessador",
                                "Neo",
                                "Neo Compact",
                                "NV-15",
                                "NV-32",
                                "ODI02",
                                "ODI03",
                                "ODI04",
                                "ODI05",
                                "ODI10",
                                "ODI11",
                                "One",
                                "Onixx",
                                "Optimix",
                                "PA10",
                                "PA10 Prime",
                                "Papa-Pó",
                                "Perfect",
                                "Perfectta",
                                "Performa",
                                "Performa Magiclean",
                                "Performa Magiclean Chrome",
                                "Perola",
                                "Perola Maxx",
                                "PH14",
                                "PH700",
                                "PH900",
                                "Piccolo",
                                "Planetária",
                                "PLAV2",
                                "Plus",
                                "Power",
                                "Power 2",
                                "Power Life",
                                "Pratic 10",
                                "Premium",
                                "Pro 1000",
                                "Professional",
                                "Protect 30",
                                "Red ION",
                                "RI1364",
                                "RI1717",
                                "RI1764",
                                "RI2008",
                                "RI2030",
                                "RI2034",
                                "RI2044",
                                "Roma",
                                "RS3",
                                "Sem Modelo",
                                "Seco",
                                "SIE10",
                                "SIE20",
                                "SIE30",
                                "Silencium",
                                "Silencium II",
                                "Silent",
                                "SIP10",
                                "Smart",
                                "Style",
                                "Super",
                                "Thermo Coffe",
                                "Titanium",
                                "Tourmaline",
                                "Trio",
                                "Trio 1200W",
                                "Triton",
                                "Turbo",
                                "Turbo 6000",
                                "Turbo ion",
                                "Turbo Silêncio",
                                "Ultragliss",
                                "Ultragliss 60",
                                "Ultragliss 70",
                                "V-45",
                                "Versátile",
                                "VFA1110T (seco)",
                                "Vitamix",
                                "X305",
                                "X307",
                                "X309",
                                "X315",
                                "X320",
                                "X380",
                                "X500",
                                "X500 tipo 2",
                                "X520",
                                "X520 tipo 2",
                                "X525",
                                "X560",
                                "X560 tipo 2",
                                "X600",
                                "X600 tipo 2",
                                "X5000",
                                "X5200",
                                "X6000",
                                "XT2020",
                                "Zefiro",
                                "Zion"
                             };
            return data;
        }

        public string[] ListaAcessorios()
        {
            var data = new[] {
                               "Não",
                               "Sim",
                               "Base",
                               "Bico",
                               "Bocal",
                               "Cabo",
                               "Copo",
                               "Copo e Tampa",
                               "Copo sem tampa",
                               "Fio",
                               "Garfos",
                               "Jarra",
                               "Mangueira",
                               "Prato",
                               "Sem Bocal",
                               "Sem Copo",
                               "Sem Grades",
                               "Sem Grade Frontal",
                               "Sem Jarra",
                               "Sem Mangueira",
                               "Sem Prato"
                             };
            return data;
        }

        public string[] ListaDefeitos()
        {
            var data = new[] {
                                "2 Não funciona",
                                "2 Parou de funcionar",
                                "2 Não esquenta",
                                "Acende a luz e não funciona",
                                "Acende a luz e não esquenta",
                                "Arraste",
                                "Arraste e engate",
                                "Arraste e acoplamento",
                                "Aspira pouco",
                                "Barulhento",
                                "Barulho",
                                "Barulho estranho",
                                "Base",
                                "Base Troca",
                                "Botão",
                                "Botão Liga/Desliga",
                                "Cabo quebrado",
                                "Caiu",
                                "Caiu, vazando",
                                "Caiu, quebrado",
                                "Caiu, Não esquenta",
                                "Caiu, Aberto",
                                "Chave",
                                "Cheira queimado",
                                "Cheirou queimado, parou",
                                "Conserto do fio",
                                "Copo e Arraste",
                                "Desliga durante o uso",
                                "Desligando sozinho",
                                "Deu estouro e parou",
                                "Engrenagens",
                                "Esquenta Muito",
                                "Esquenta o cabo",
                                "Esquenta só de um lado",
                                "Esquenta pouco",
                                "Esquenta, vazando",
                                "Esquenta saiu fumaça",
                                "Esquenta só uma cima",
                                "Esquenta só em baixo",
                                "Fio",
                                "Fio troca",
                                "Fio (Conserto)",
                                "Fraco",
                                "Hélice",
                                "Ligou no 220V",
                                "Membrana",
                                "Mola",
                                "Não Funciona",
                                "Não liga",
                                "Não esquenta",
                                "Não aquece",
                                "Não aspira",
                                "Não Desliga", 
                                "Não Gira",
                                "Não puxa",
                                "Não soube dizer defeito",
                                "Não sai vapor",
                                "Não suga",
                                "Parou",
                                "Parou de funcionar",
                                "Parou de esquentar",
                                "Pino",
                                "Pino (tomada)",
                                "Pino derretido",
                                "Placa de proteção",
                                "Quebrado",
                                "Queimou",
                                "Resistência",
                                "Revisão",
                                "Troca do fio",
                                "Travado",
                                "Vazando",
                                "Ventoinha",
                                "Trouxe desmontado"
                             };
            return data;
        }





    }
}
