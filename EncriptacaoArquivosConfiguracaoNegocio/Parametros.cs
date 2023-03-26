using System.Collections.Generic;

namespace EncriptacaoArquivosConfiguracaoNegocio
{
    public class Parametros
    {
        public string PathAspNetRegiis { get; set; }
        public string PathArquivoConfig { get; set; }
        public List<ValoresReplace> ValoresReplace { get; set; }
        public string PathArquivoConfigTemp { get { return $"{PathArquivoConfig}\\Temp"; ; } }
        public string PathResultado { get { return $"{PathArquivoConfig}\\Resultado\\"; ; } }
        public string TagEncriptar { get; set; } = "appSettings";
        public bool Descriptar { get; set; }
        public bool Encriptar { get; set; }
        public bool Replace { get; set; }

        public static string GetTemplante()
        {
            return @"
                {
                    ""Descriptar"" : ""true"",
                    ""Encriptar"" : ""true"",
                    ""Replace"" : ""true"",
                    ""TagEncriptar"" : ""appSettings"",
                    ""PathAspNetRegiis"" : ""<<Informar o path que está exe do aspnet_reggis>>"",
                    ""PathArquivoConfig"" : ""<<Informar o path que estão os arquivos de configuração>>"",
                    ""ValoresReplace"" : [{ ""Atual"" : ""<<Exemplo>>"", ""NovoValor"" : ""<<exemploNovoValor>>""}]
                }
            ";
        }

    }

}
