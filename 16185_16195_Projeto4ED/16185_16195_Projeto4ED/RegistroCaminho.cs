using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _16185_16195_Projeto4ED
{
    class RegistroCaminho : Entidade<Caminho>
    {
        public override void LerRegistro(FileStream f, long posicao, ref Caminho dados)
        {
            byte[] cidOrigemLida = new byte[Caminho.CidOrigemEmBytes];
            byte[] cidDestinoLida = new byte[Caminho.CidDestinoEmBytes];
            byte[] pesoLido = new byte[Caminho.PesoEmBytes];

            f.Seek(posicao * Caminho.tamanhoRegistro, SeekOrigin.Begin);

            f.Read(cidOrigemLida, 0, Caminho.CidOrigemEmBytes);
            f.Read(cidDestinoLida, 0, Caminho.CidDestinoEmBytes);
            f.Read(pesoLido, 0, Caminho.PesoEmBytes);

            string CidOrigem = "";
            for (int i = 0; i < Caminho.tamanhoCidOrigem; i++)
                if (cidOrigemLida[i] != 32)
                    CidOrigem += Char.ConvertFromUtf32(cidOrigemLida[i]);
            dados.CidOrigem = CidOrigem;

            string CidDestino = "";
            for (int i = 0; i < Caminho.tamanhoCidDestino; i++)
                if (cidDestinoLida[i] != 32)
                    CidDestino += Char.ConvertFromUtf32(cidDestinoLida[i]);
            dados.CidDestino = CidDestino;
            
            dados.Peso += pesoLido[3];
            dados.Peso += pesoLido[2] << 8;
            dados.Peso += pesoLido[1] << 16;
            dados.Peso += pesoLido[0] << 24;
        }

        public override void GravarRegistro(FileStream f, long posicao, Caminho dados)
        {
            try
            {
                f.Seek(posicao * Caminho.tamanhoRegistro, SeekOrigin.Begin);
            }
            finally
            {
                EscreverString(f, dados.CidOrigem, Caminho.tamanhoCidOrigem);
                EscreverString(f, dados.CidDestino, Caminho.tamanhoCidDestino);

                byte[] intBytes = BitConverter.GetBytes(dados.Peso);
                if (BitConverter.IsLittleEndian)
                    Array.Reverse(intBytes);
                byte[] result = intBytes;
                f.Write(result, 0, Caminho.PesoEmBytes);
            }
        }

        public override void EscreverString(FileStream f, String s, int tamanho)
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
    }
}