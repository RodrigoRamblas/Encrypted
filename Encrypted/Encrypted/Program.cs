using System;
using System.Text;
using System.IO;

//Rodrigo Ramblas

namespace Encrypted
{
    class Program
    {
        static string resp = "S";
        static string cripto = "";
        static string texto;
        static int numCarac;

        public static string Criptografar(string[,] subs, string[] carac, int numCarac, string texto, string cripto)
        {
            for (int cont = 0; cont < numCarac; cont++)
            {
                carac[cont] = (texto.Substring(cont, 1));
            }

            for (int cont = 0; cont < numCarac; cont++)
            {
                for (int cont2 = 0; cont2 < (subs.Length / 2); cont2++)
                {
                    if (carac[cont] == subs[cont2, 0])
                    {
                        cripto = cripto + subs[cont2, 1];
                        break;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("+-------------------------------------------------+");
            Console.WriteLine("¦                                                 ¦");
            Console.WriteLine("¦     Seu Texto/Messagem Criptografada é:         ¦");
            Console.WriteLine("¦                                                 ¦");
            Console.WriteLine("+-------------------------------------------------+");
            Console.WriteLine(cripto);
            return (cripto);
        }

        public static string descriptografar(string[,] subs, string[] carac, int numCarac, string texto, string cripto)
        {
            for (int cont = 0; cont < numCarac; cont += 3)
            {
                try
                {
                    carac[cont] = (texto.Substring(cont, 3));//Tratamento de erro
                }
                catch
                {
                    Console.WriteLine("+-------------------------------------------------+");
                    Console.WriteLine("¦                                                 ¦");
                    Console.WriteLine("¦       Texto digitado não pode ser gerado.       ¦");
                    Console.WriteLine("¦                                                 ¦");
                    Console.WriteLine("+-------------------------------------------------+");
                    Console.ReadLine();
                    break;
                }
            }

            for (int cont = 0; cont < numCarac; cont++)
            {
                for (int
                    cont2 = 0; cont2 < (subs.Length / 2); cont2++)
                {
                    if (carac[cont] == subs[cont2, 1])
                    {
                        cripto = cripto + subs[cont2, 0];
                        break;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("+-------------------------------------------------+");
            Console.WriteLine("¦                                                 ¦");
            Console.WriteLine("¦     Seu texto é - Enter para continuar:         ¦");
            Console.WriteLine("¦                                                 ¦");
            Console.WriteLine("+-------------------------------------------------+");
            Console.WriteLine(cripto);
            Console.ReadLine();
            cripto = "";
            return (cripto);
        }
        static void Main(string[] args)
        {
            string opcao = "0";
            string opcao2 = "0";
            string opcao3 = "0";
            string nomeArquivo;
            string caminhoArquivo;

            string[,] subs = {
            { "A", "if1" },
            { "a", "pd#" },
            { "B", "vrs" },
            { "b", "g=§" },
            { "C", "=&*" },
            { "c", "+df" },
            { "D", "dcd" },
            { "d", "+wm" },
            { "E", "b!@" },
            { "e", "sij" },
            { "F", "pza" },
            { "f", "b$%" },
            { "G", "9cd" },
            { "g", "cab" },
            { "H", "cxy" },
            { "h", "hqr" },
            { "I", "=!@" },
            { "i", "!34" },
            { "J", "4Mn" },
            { "j", "!mn" },
            { "K", "-cd" },
            { "k", "@#@" },
            { "L", "Cvt" },
            { "l", "6+=" },
            { "M", "8sv" },
            { "m", "xcd" },
            { "N", "c!@" },
            { "n", "lXy" },
            { "O", ":st" },
            { "o", "qwy" },
            { "P", ".cd" },
            { "p", "sqr" },
            { "Q", "!wY" },
            { "q", "lde" },
            { "R", "+91" },
            { "r", "c()" },
            { "S", "Xcd" },
            { "s", "xqr" },
            { "T", "iYz" },
            { "t", "z++" },
            { "U", "Vcd" },
            { "u", "Xbc" },
            { "V", "ksk" },
            { "v", "con" },
            { "X", "cno" },
            { "x", "plr" },
            { "W", "pns" },
            { "w", "hsr" },
            { "Y", "wda" },
            { "y", "oth" },
            { "Z", "rrt" },
            { "z", "plr" },
            { "á", ">çc" },
            { "Á", "0kr" },
            { "à", "g91" },
            { "À", "3X)"},
            { "â", "fab" },
            { "Â", "b_-" },
            { "ã", "+89" },
            { "Ã", "^vr" },
            { "ä", "-.:" },
            { "Ä", "3_s" },
            { "ç", ".lr" },
            { "Ç", "!sr" },
            { "é", "vef" },
            { "É", "+de" },
            { "è", "1cd" },
            { "È", ",Ab" },
            { "ê", "c!@" },
            { "Ê", "3mn" },
            { "ë", "0de" },
            { "Ë", "0De" },
            { "í", "889" },
            { "Í", "9O2" },
            { "ì", "Uie" },
            { "Ì", "i12" },
            { "î", "md>" },
            { "Î", "]12" },
            { "ï", "!ef" },
            { "Ï", "c45" },
            { "ó", "!de" },
            { "Ó", "+de" },
            { "ò", "0@#" },
            { "Ò", "g!@" },
            { "ô", "l}[" },
            { "Ô", "Pxy" },
            { "õ", "qde" },
            { "Õ", "çxy" },
            { "ö", "mqr" },
            { "Ö", "wTu" },
            { "ú", "Zpu" },
            { "Ú", "´sr" },
            { "ù", "dce" },
            { "Ù", "mce" },
            { "û", "wce" },
            { "Û", "qPr" },
            { "ü", "ama" },
            { "Ü", "=!@" },
            { "1", "3-_" },
            { "2", "d!@" },
            { "3", ")de" },
            { "4", "l?!" },
            { "5", "a!@" },
            { "6", "c:;" },
            { "7", "^dE" },
            { "8", "s!@" },
            { "9", "rij" },
            { "0", "ktk" },
            { "\"", "tel"},
            { "'", "shm" },
            { "!", "jen" },
            { "@", "usy" },
            { "#", "*7¬" },
            { "$", "$2°" },
            { "%", "1S4" },
            { "¨", "1Q$" },
            { "&", "i*¢" },
            { "*", "Xc³" },
            { "(", "^ç¹" },
            { ")", "qx²" },
            { "-", "x<§" },
            { "_", "pX-" },
            { "+", "xXª" },
            { "=", "Xpº" },
            { "§", "iM^" },
            { "¹", "a$~" },
            { "²", "c!º" },
            { "³", "3`§" },
            { "£", "cEr" },
            { "¢", "}wf" },
            { "¬", "p£a" },
            { "´", "d-s" },
            { "`", "#5r" },
            { "[", "8oc" },
            { "{", "9dz" },
            { "ª", "xcw" },
            { "^", "acq" },
            { "~", "eDg" },
            { "}", "0+h" },
            { "]", "lbp" },
            { "º", ".çç" },
            { ":", "xno" },
            { ";", "0ci" },
            { "<", "xD@" },
            { ">", "01¹" },
            { ",", "[)²" },
            { ".", "cI³" },
            { "?", "Kd°" },
            { "/", "wx?" },
            { "°", "oX>" },
            { "\\", "ex<"},
            { "|", "Ik:" },
            { " ", "lk|" }
                          };
            //Exibe a data do sistema atualizado
            DateTime dt = DateTime.Now;
            Console.WriteLine(String.Format("{0:D}\n", dt));
            if (dt.Hour > 6 && dt.Hour < 12) //  Apresenta a mensagem conforme o horario
            {
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("¦                Digite o seu Nome:               ¦");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("+-------------------------------------------------+");
                string nome = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(String.Format("{0:D}\n", dt));
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("              Bom dia, " + nome + "                ");
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("¦             De Entrer para continuar:           ¦");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("+-------------------------------------------------+");
                Console.ReadLine();
                Console.Clear();

            }
            else if (dt.Hour >= 12 && dt.Hour < 18)
            {
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("¦                Digite o seu Nome:               ¦");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("+-------------------------------------------------+");
                string nome = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("              Boa tarde, " + nome + "              ");
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("¦             De Entrer para continuar:           ¦");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("+-------------------------------------------------+");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("¦                Digite o seu Nome:               ¦");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("+-------------------------------------------------+");
                string nome = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("              Boa noite, " + nome + "              ");
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("¦             De Entrer para continuar:           ¦");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("+-------------------------------------------------+");
                Console.ReadLine();
                Console.Clear();
            }

            do
            {
                Console.Clear();
                //Menu
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("¦              CRIPTOGRAFIA DE DADOS              ¦");
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("¦             1 - Deseja Criptografar             ¦");
                Console.WriteLine("¦             2 - Deseja DesCriptografar          ¦");
                Console.WriteLine("¦             3 - Sair                            ¦");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("¦                                                 ¦");
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("Digite uma das opções acima:");
                opcao = Console.ReadLine();
                if (opcao == "1" || opcao == "2" || opcao == "3")
                {



                    switch (opcao)
                    {
                        case "1"://Opção de Criptografar
                            Console.Clear();
                            Console.WriteLine("+-------------------------------------------------+");
                            Console.WriteLine("¦                                                 ¦");
                            Console.WriteLine("¦Digite o Texto/Messagem que deseja criptografar: ¦");
                            Console.WriteLine("¦                                                 ¦");
                            Console.WriteLine("+-------------------------------------------------+");
                            texto = Console.ReadLine();
                            numCarac = texto.Length;
                            string[] carac = new string[numCarac];
                            cripto = Criptografar(subs, carac, numCarac, texto, cripto);
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("+-------------------------------------------------+");
                            Console.WriteLine("¦                   Deseja Salvar?                ¦");
                            Console.WriteLine("+-------------------------------------------------+");
                            Console.WriteLine("¦                                                 ¦");
                            Console.WriteLine("¦                 1 - Sim                         ¦");
                            Console.WriteLine("¦                 2 - Não                         ¦");
                            Console.WriteLine("¦                                                 ¦");
                            Console.WriteLine("+-------------------------------------------------+");

                            opcao3 = Console.ReadLine();
                            if (opcao3 == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("Opção escolhida foi:\n");
                                Console.WriteLine("'" + opcao3 + "-Sim'");
                            }

                            else if (opcao3 == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("+-------------------------------------------------+");
                                Console.WriteLine("¦            Opção escolhida foi:                 ¦ ");
                                Console.WriteLine("¦                 '" + opcao3 + "-Não'                         ¦");
                                Console.WriteLine("+-------------------------------------------------+\n");
                                Console.WriteLine("[>>>  APERTE QUALQUER TECLA PARA PROCEGUIR  <<<]");
                                Console.ReadKey();
                                opcao3 = "0";
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("                     ERRO !");
                                Console.WriteLine("+-------------------------------------------------+");
                                Console.WriteLine("¦    ''" + opcao3 + "'' Opção escolhida está inválida          ¦");
                                Console.WriteLine("¦      Sua Criptografia não  ser salva!           ¦ ");
                                Console.WriteLine("+-------------------------------------------------+\n");
                                Console.WriteLine("[>>>  APERTE QUALQUER TECLA PARA PROCEGUIR  <<<]");
                                Console.ReadKey();


                            }



                            switch (opcao3)
                            {
                                case "1":
                                    Console.WriteLine("+-------------------------------------------------+");
                                    Console.WriteLine("¦                                                 ¦");
                                    Console.WriteLine("¦        Digite o nome para o arquivo:            ¦");
                                    Console.WriteLine("¦                                                 ¦");
                                    Console.WriteLine("+-------------------------------------------------+");
                                    nomeArquivo = Console.ReadLine();
                                    caminhoArquivo = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop));//está função pega o caminho da aréa de trabalho
                                    caminhoArquivo = @caminhoArquivo + "/" + nomeArquivo + ".txt"; //caminho completo
                                    StringBuilder sConteudo = new StringBuilder();
                                    sConteudo.AppendLine(cripto);
                                    File.WriteAllText(caminhoArquivo, sConteudo.ToString());
                                    Console.WriteLine("+-------------------------------------------------+");
                                    Console.WriteLine("¦                                                 ¦");
                                    Console.WriteLine("¦  Segue abaixo local onde foi salvo seu arquivo: ¦");
                                    Console.WriteLine("¦                                                 ¦");
                                    Console.WriteLine("+-------------------------------------------------+");
                                    Console.WriteLine(caminhoArquivo);
                                    Console.ReadKey();
                                    break;

                                case "2":

                                default:
                                    break;
                            }


                            break;

                        case "2": //Opção de DesCriptografar
                            Console.Clear();
                            Console.WriteLine("+-------------------------------------------------+");
                            Console.WriteLine("¦           ESCOLHA UM DAS OPÇÕES ABAIXO:         ¦ ");
                            Console.WriteLine("+-------------------------------------------------+");
                            Console.WriteLine("¦                                                 ¦");
                            Console.WriteLine("¦    1 - Receber Arquivo                          ¦");
                            Console.WriteLine("¦    2 - Digitar texto                            ¦");
                            Console.WriteLine("¦                                                 ¦");
                            Console.WriteLine("+-------------------------------------------------+\n");
                            Console.WriteLine("Digite uma das opções acima:\n");
                            opcao2 = Console.ReadLine();

                            if (opcao2 == "1")
                            {
                                Console.WriteLine("RECEBER ARQUIVO");
                                Console.WriteLine("+-------------------------------------------------+");
                                Console.WriteLine("¦                                                 ¦");
                                Console.WriteLine("¦     Digite o caminho para receber o arquivo:    ¦");
                                Console.WriteLine("¦                                                 ¦");
                                Console.WriteLine("+-------------------------------------------------+");




                                //declarando a variavel do tipo StreamWriter 
                                StreamReader x;

                                //Colocando o caminho físico 
                                string Caminho = Console.ReadLine();

                                if (!File.Exists(Caminho))
                                {
                                    //Determina se existe um arquivo.
                                    Console.Clear();
                                    Console.WriteLine("+-------------------------------------------------+");
                                    Console.WriteLine("¦                                                 ¦");
                                    Console.WriteLine("¦ Arquivo não existe, aperte enter para continuar:¦");
                                    Console.WriteLine("¦                                                 ¦");
                                    Console.WriteLine("+-------------------------------------------------+");
                                    Console.ReadLine();
                                    break;
                                }
                                //abrindo um arquivo texto.
                                x = File.OpenText(Caminho);
                                //enquanto nao retornar valor booleano true 
                                while (x.EndOfStream != true)//quer dizer que não chegou no fim do  
                                                             //arquivo
                                {
                                    //le conteúdo da linha
                                    texto = x.ReadLine();
                                    //escreve na tela o conteúdo da linha
                                    Console.WriteLine(texto);
                                }
                                cripto = cripto = "";

                                numCarac = texto.Length;

                                carac = new string[numCarac];
                                cripto = descriptografar(subs, carac, numCarac, texto, cripto);

                                break;

                            }
                            if (opcao2 == "2")
                            {
                                cripto = cripto = "";
                                Console.Clear();
                                Console.WriteLine("+-------------------------------------------------+");
                                Console.WriteLine("¦                                                 ¦");
                                Console.WriteLine("¦    Escreva a criptografia para gerar o texto.   ¦");
                                Console.WriteLine("¦                                                 ¦");
                                Console.WriteLine("+-------------------------------------------------+");
                                texto = Console.ReadLine();
                                numCarac = texto.Length;

                                carac = new string[numCarac];
                                cripto = descriptografar(subs, carac, numCarac, texto, cripto);
                            }
                            else
                            {
                                Console.WriteLine("Opção errada.");
                                Console.ReadLine();
                            }
                            break;

                        case "3"://Sair e Fechar
                            Environment.Exit(0);
                            Console.Clear();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("opção invalida!");
                            Console.WriteLine("Deseja continuar? S/N?");
                            resp = Console.ReadLine();
                            resp = resp.ToUpper();
                            break;

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n+-------------------------------------------------+");
                    Console.WriteLine("¦                    ERRO !                       ¦");
                    Console.WriteLine("¦          Opção escolhida está inválida          ¦ ");
                    Console.WriteLine("+-------------------------------------------------+\n");
                    Console.WriteLine("[>>>  APERTE ENTER PARA PROCEGUIR  <<<]");
                    Console.ReadKey();
                }

            } while (resp.Equals("S"));
        }
    }

}
