using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;

namespace EncriptacaoArquivosConfiguracaoNegocio
{
    public class Funcoes
    {
        public static Parametros GetParametros(string path)
        {
            return JsonConvert.DeserializeObject<Parametros>(File.ReadAllText(path));
        }
        public static void CriarDiretoriosTempResultado(Parametros parametros)
        {
            if (!Directory.Exists(parametros.PathArquivoConfigTemp))
                Directory.CreateDirectory(parametros.PathArquivoConfigTemp);

            if (!Directory.Exists(parametros.PathResultado))
                Directory.CreateDirectory(parametros.PathResultado);
        }
        public static void ApagarDiretorioTemp(Parametros parametros)
        {
            if (!Directory.Exists(parametros.PathArquivoConfigTemp))
                Directory.CreateDirectory(parametros.PathArquivoConfigTemp);

            if (!Directory.Exists(parametros.PathResultado))
                Directory.CreateDirectory(parametros.PathResultado);
        }
        private static void Encriptacao(bool criptografar, Parametros parametros)
        {

            var comandoCriptografaDescriptografa = criptografar ? "pef" : "pdf";
            var argumentos = $@"/k {parametros.PathAspNetRegiis}\\aspnet_regiis.exe -{comandoCriptografaDescriptografa} ""appSettings"" ""{parametros.PathArquivoConfigTemp}"" & exit";

            var process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = argumentos;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            process.Start();
            process.WaitForExit();

        }
        public static void ExecutarIncriptacaoDecriptacaoReplace(string[] arquivos, Parametros parametros)
        {
            foreach (var item in arquivos)
            {
                var arquivo = new FileInfo(item);
                var backupName = arquivo.Name;
                var arquivoTemporario = $"{parametros.PathArquivoConfigTemp}\\web.config";
                arquivo.CopyTo(arquivoTemporario);
                if (parametros.Descriptar)
                    Encriptacao(false, parametros);
                if (parametros.Replace)
                {
                    if (parametros.ValoresReplace != null && parametros.ValoresReplace.Count > 0)
                    {
                        var arquivoEmAjuste = File.ReadAllText(arquivoTemporario);
                        foreach (var itemReplace in parametros.ValoresReplace)
                        {
                            arquivoEmAjuste = arquivoEmAjuste.Replace(itemReplace.Atual, itemReplace.NovoValor);
                        }
                        File.Delete(arquivoTemporario);
                        using (StreamWriter sw = new StreamWriter(arquivoTemporario))
                        {
                            sw.WriteLine(arquivoEmAjuste);
                        }
                    }
                }
                if (parametros.Encriptar)
                    Encriptacao(true, parametros);
                arquivo = new FileInfo(arquivoTemporario);
                arquivo.MoveTo($"{parametros.PathResultado}{backupName}");
            }
        }
    }
}
