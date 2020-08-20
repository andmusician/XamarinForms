using App01_ConsultaCEP.Service.Model;
using Newtonsoft.Json;
using System;
using System.Net;

namespace App01_ConsultaCEP.Service
{
    public class ViaCEPService
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCep(string cep)
        {
            string novoEnderecoUrl = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            var conteudo = wc.DownloadString(novoEnderecoUrl);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

            if (string.IsNullOrEmpty(end.UF))
            {
                throw new Exception("CEP inexistente ou não encontrado");
            }

            return end;
        }
    }
}
