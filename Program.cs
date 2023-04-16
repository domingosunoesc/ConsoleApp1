namespace ConsoleApp1.classes
{
    class Bv
    {
        static void Main(string[] args)
        {
            Pessoas[] pessoas = new Pessoas[]
            {
            new Gerente{
            Name = "Benvindo"
            ,Nascimento = new (year: 2001, month: 5, day: 1)
            ,Sexo = "M"
            ,Cargo = "Auxiliar de Produção"
            },
            new Operario {
             Name = "Dirceu"
            ,Nascimento = new (year: 1990, month: 7 , day: 1)
            ,Sexo = "M"
            ,Cargo = "Técnico"
            },

            new SuperVisor {
            Name = "Taciane"
            ,Nascimento = new (year : 1995 , month : 9 , day: 3 )
            ,Sexo = "F"
            ,Cargo = "Supervisão do Sector"
            },
           
            };


            for (int i = 0; i < pessoas.Length; i++)
            {
              if (pessoas[i]!=null)
                {
                    Console.WriteLine($"NOME:{pessoas[i].Name.ToUpper()}");
                    Console.WriteLine("");
                    Console.WriteLine($"SEXO:{pessoas[i].Sexo}");
                    Console.WriteLine("");
                    Console.WriteLine($"CARGO:{pessoas[i].Cargo.ToUpper()}");
                    Console.WriteLine("");
                    Console.WriteLine($"{pessoas[i].Nascimento.ToLongDateString().ToUpper()}");

                }
            }
        }
    }
}