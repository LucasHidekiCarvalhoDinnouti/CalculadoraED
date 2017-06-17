using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16185_16195_Projeto4ED
{
    class RegistroCidade : Entidade<Cidade>
    {
        public override void EscreverString(FileStream f, string s, int tamanho)
        {
            StringBuilder cadeia = null;
            if (s != null)
                cadeia = new StringBuilder(s);
            else
                cadeia = new StringBuilder(tamanho);
            cadeia.Length = tamanho;
            Byte[] bytes = Encoding.ASCII.GetBytes(cadeia.ToString());
            f.Write(bytes, 0, tamanho);
        }

        public override void GravarRegistro(FileStream f, long posicao, Cidade dados)
        {
            try
            {
                f.Seek(posicao * Cidade.tamanhoRegistro, SeekOrigin.Begin);
            }
            finally
            {
                EscreverString(f, dados.NomeCidade, Cidade.tamanhoNomeCidade);
            }
        }

        public override void LerRegistro(FileStream f, long posicao, ref Cidade dados)
        {
            byte[] nomeCidadeLida = new byte[Cidade.NomeEmBytes];

            f.Seek(posicao * Cidade.tamanhoRegistro, SeekOrigin.Begin);
            f.Read(nomeCidadeLida, 0, Cidade.NomeEmBytes);

            string nomeCidade = "";
            for (int i = 0; i < Caminho.tamanhoCidOrigem; i++)
                if (nomeCidadeLida[i] != 0)
                    nomeCidade += Char.ConvertFromUtf32(nomeCidadeLida[i]);
            dados.NomeCidade = nomeCidade.Trim();
        }
    }
}