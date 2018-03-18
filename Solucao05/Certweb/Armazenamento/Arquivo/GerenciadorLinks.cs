using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Certweb.Armazenamento.Modelo;
using Newtonsoft.Json;

namespace Certweb.Armazenamento.Arquivo {
    public class GerenciadorLinks {
        private static string NomeArquivo = "links.txt"; // Definição de uma constante
        private static List<Link> ListaLinks { get; set; }

        public static void AdicionarLinks(Link link) {
            ListaLinks.Add(link);
        }
        public static void RemoverLinks(Link link) {
            ListaLinks.Remove(link);
        }
        public static List<Link> LerLinks() {
            if ( ListaLinks == null ) {
                string conteudoArquivo = new GerenciadorArquivos().Ler(NomeArquivo);
                ListaLinks = JsonConvert.DeserializeObject<List<Link>>(conteudoArquivo); 
            } else {
                return ListaLinks;
            }
            return ListaLinks;
        }
        public static void SalvarLinks() {
            string jsonLink = JsonConvert.SerializeObject(ListaLinks);
            new GerenciadorArquivos().Escrever(NomeArquivo, jsonLink);
        }
    }
}
