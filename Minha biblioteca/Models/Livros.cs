using System;
using System.Collections.Generic;
using System.Text;

namespace Minha_biblioteca.Models
{
    internal class Livros
    {
        private int id;
        private int nome;
        private int ano;
        private string autor;
        private string descricao;
        private string capa;

        public int Id { get => id; set => id = value; }
        public int Nome { get => nome; set => nome = value; }
        public int Ano { get => ano; set => ano = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Capa { get => capa; set => capa = value; }

        public string addLivro()
        {
            return "Livro adicionado com sucesso!";
        }
        public string removerLivro()
        {
            return "Livro removido com sucesso!";
        }
        public string updateLivro()
        {
            return "Livro atualizado com sucesso!";
        }
        public string getLivro()
        {
            return "Livro encontrado com sucesso!";
    }

    }
}
