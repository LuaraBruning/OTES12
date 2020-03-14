using System;
using System.IO;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    int numeroDeItens = 0;

    //Console.WriteLine ("Digite o numero de itens:");

    //numeroDeItens = Convert.ToInt32(Console.ReadLine());

    //Console.WriteLine (numeroDeItens);

    List<item> listaDeItens = new List<item>();
    List<item> decisaoPessoal = new List<item>();
    List<item> decisaoDoGrupo = new List<item>();
    List<item> modeloCorreto = new List<item>();


    /*var itemTeste = new item(){
      PosicaoModelo = 1,
      Descricao = "teste"
    };*/

    listaDeItens.Add(new item(){
      PosicaoModelo = 1,
      Descricao = "Caixa de fósforo"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 2,
      Descricao = "Alimento concentrado"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 3,
      Descricao = "Corda de nylon"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 4,
      Descricao = "Seda de para-quedas"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 5,
      Descricao = "Um aquecedor portátil"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 6,
      Descricao = "Duas pistolas de calibre 45"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 7,
      Descricao = "Uma caixa de leite em pó"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 8,
      Descricao = "Um mapa estelar da constelação lunar"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 9,
      Descricao = "Uma balsa salva-vidas"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 10,
      Descricao = "Dois tanques de oxigênio de 100 libras cada"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 11,
      Descricao = "Uma bússula"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 12,
      Descricao = "Cinco galões de água"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 13,
      Descricao = "Sinais luminosos (pistola)"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 14,
      Descricao = "Um estojo de primeiro socorros com agulhas de injeção"
    });

    listaDeItens.Add(new item(){
      PosicaoModelo = 15,
      Descricao = "Um receptor e transmissor FM, movido a força solar"
    });

    Console.WriteLine ("\n\n\n\n-----------------------------DESAFIO NASA-----------------------------");

    Console.WriteLine ("\n\n  Você é um membro da tripulação de uma nave espacial, que programou um encontro, junto com outra nave na superfície luminosa da Lua… entretanto dificuldades mecânicas obrigaram sua nave a uma descida forçada, num ponto distante a 100 Km do planejado encontro. A maior parte do equipamento, na descida forçada ficou avariada e já que sua sobrevivência depende de encontrar o ponto de encontro a 100 Km, é preciso escolher, dos itens abaixo, os mais essenciais, para este percurso.");

    Console.WriteLine ("\n  Abaixo, há uma lista de 15 itens de coisas que não ficaram estragadas na descida. Seu trabalho será de numerar esses itens em termos de sua importância para alcançar o ponto de encontro. Coloque o número 1 para o item mais importante, o número 2 para o segundo, até o número 15 para o item menos importante.");

    Console.WriteLine ("\n  No final iremos comparar a sua escolha com o gabarito oficial. O objetivo e ter a menor divergência possível, assim, sua sobrevivência será mais fácil.");

    Console.WriteLine ("\n\nEstes são os itens disponíveis:\n");

    foreach (item itemDaLista in listaDeItens) {
      Console.WriteLine ("("+ itemDaLista.PosicaoModelo +") " + itemDaLista.Descricao);
    }

    foreach (item itemDaLista in listaDeItens) {
      //parts.Find(x => x.PartName.Contains("seat"))

    }

    string line;
    item jaCadastrado;

    for (int i = 0; i != listaDeItens.Count ; i++) {
      line = "";
      do {
        if (line != "") {
          Console.WriteLine (" x\t-\tEste elemento já foi adicionado na lista!");
        }
        line = Console.ReadLine();
        jaCadastrado = listaDeItens.Find(x => x.PosicaoModelo == Convert.ToInt32(line));
      } while(jaCadastrado != null);

      decisaoPessoal.Add(listaDeItens.Find(x => x.PosicaoModelo == Convert.ToInt32(line)));

      Console.WriteLine (" v");
    }

    foreach (item itemDaLista in decisaoPessoal) {
      Console.WriteLine ("("+ itemDaLista.PosicaoModelo +") " + itemDaLista.Descricao);
    }

    //Console.WriteLine ("Digite o numero de itens:");

    /*
    for (i = 0; i < numeroDeItens; i++) {
      Console.WriteLine ("Digite a Descricao do item:");
    }
    */
//    var decisaoPessoal = new listaDeItens(itens = listaPessoal);
  }

  public static string stringReadLine() {
    int tabSize = 4;
    string line;
    string newLine = "";
    while ((line = Console.ReadLine()) != null)
    {
      newLine = line.Replace(("").PadRight(tabSize, ' '), "\t");
    }
    return newLine;
  }
}

//https://www.rhportal.com.br/dinamicas-de-grupo/o-caso-da-nasa/
