using System;
namespace Dio.Desafio01
{
    public class Filmes : ClasseBase
    {
       private Generos Genero {get;set;}
       private string Titulo {get;set;}
       private string Descricao{get;set;}
       private int Ano{get;set;}
       private bool Excluido{get;set;}

       public Filmes (int id,Generos genero,string titulo,string descricao,int ano)
       {
           this.id = id;
           this.Genero = genero;
           this.Titulo = titulo;
           this.Descricao = descricao;
           this.Ano = ano;
           this.Excluido = false;
       }
       public override string ToString()
       {
           string retorno = "";
           retorno += "Gênero: " + this.Genero + Environment.NewLine;
           retorno += "Titulo: " + this.Titulo + Environment.NewLine;
           retorno += "Descrição: " + this.Descricao + Environment.NewLine;
           retorno += "Ano: " + this.Ano + Environment.NewLine;
           retorno += "Excluido: " + this.Excluido;
           return retorno;

       }
       public string retornaTitulo()
       {
           return this.Titulo;
       }
       public int retornoId()
       {
           return this.id;
       }
       public bool retornaExcluido()
       {
           return this.Excluido;
       }
       public void Excluir()
       {
           this.Excluido = true;
       }
    }
}   