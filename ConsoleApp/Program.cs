using EncriptacaoArquivosConfiguracaoNegocio;
using System;
using System.IO;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teste
            var pathArquivoConfiguracao = $"{AppDomain.CurrentDomain.BaseDirectory}EncriptacaoArquivosConfiguracao.json";
            if (!File.Exists(pathArquivoConfiguracao))
            {
                GerarTemplanteConfiguracao();
                Console.WriteLine("O arquivo de configuração não foi encontrado!");
                Console.WriteLine("Foi Gerado o Templante no caminho abaixo:");
                Console.WriteLine("{0}EncriptacaoArquivosConfiguracao.json", AppDomain.CurrentDomain.BaseDirectory);
                Console.WriteLine("Aperte Qualquer tecla para sair");
                Console.ReadKey();
            }
            else
            {
                var parametros = Funcoes.GetParametros(pathArquivoConfiguracao);

                if (parametros != null)
                {
                    var arquivos = Directory.GetFiles(parametros.PathArquivoConfig);

                    if (arquivos != null && arquivos.Length > 0)
                    {
                        Funcoes.CriarDiretoriosTempResultado(parametros);
                        Funcoes.ExecutarIncriptacaoDecriptacaoReplace(arquivos, parametros);
                        Funcoes.ApagarDiretorioTemp(parametros);
                    }
                }
            }
            Console.WriteLine("Processo executado com sucesso!");
            Console.WriteLine("Aperte Qualquer tecla para sair");
            Console.ReadKey();

            
        }
        public static void GerarTemplanteConfiguracao()
        {
            var templante = Parametros.GetTemplante();

            using (StreamWriter sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}EncriptacaoArquivosConfiguracao.json"))
            {
                sw.WriteLine(templante);
            }
        }
    }
}
