namespace TupiniquimRobo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y, x;
            char direcao;
            string comandos;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===========================================================");
                Console.WriteLine("Digite o valor de X");
                x = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("===========================================================");
                Console.WriteLine("Digite o valor de Y");
                y = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("===========================================================");
                Console.WriteLine("Digite a direcao [Norte = N, Sul = S, Leste = L, Oeste = O]");
                direcao = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("===========================================================");
                Console.WriteLine("Posicao inicial: " +" "+ x +" "+ y +" "+ direcao);
                Console.WriteLine("===========================================================");
                Console.WriteLine("Digite os comandos");
                Console.WriteLine("===========================================================");
                comandos = Console.ReadLine();
                ProcessarComando(comandos);
                Console.WriteLine("===========================================================");
                Console.WriteLine("Posicao final robo: " +" "+ x +" "+ y +" "+ direcao);
                Console.WriteLine("===========================================================");
                Console.ReadLine();
                void Mover()
                {
                    switch (direcao)
                    {
                        case 'N':
                            y += 1;
                            break;
                        case 'S':
                            y -= 1;
                            break;
                        case 'L':
                            x += 1;
                            break;
                        case 'O':
                            x -= 1;
                            break;
                    }
                }
                void VirarEsquerda()
                {
                    switch (direcao)
                    {
                        case 'N':
                            direcao = 'O';
                            break;
                        case 'S':
                            direcao = 'L';
                            break;
                        case 'L':
                            direcao = 'N';
                            break;
                        case 'O':
                            direcao = 'S';
                            break;
                    }
                }
                void VirarDireita()
                {
                    switch (direcao)
                    {
                        case 'N':
                            direcao = 'L';
                            break;
                        case 'S':
                            direcao = 'O';
                            break;
                        case 'L':
                            direcao = 'S';
                            break;
                        case 'O':
                            direcao = 'N';
                            break;
                    }
                }
                void ProcessarComando(string comandos)
                {
                    foreach (char comando in comandos)
                    {
                        switch (comando)
                        {
                            case 'M':
                                Mover();
                                break;
                            case 'E':
                                VirarEsquerda();
                                break;
                            case 'D':
                                VirarDireita();
                                break;
                            default:
                                throw new ArgumentException($"Invalid command: {comando}");
                        }
                    }
                }
            }
        }
    }
}