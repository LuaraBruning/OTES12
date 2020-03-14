using System;
using System.Collections.Generic;

public class listaDeItens {
  public List<item> Itens { get; set; }

  public listaDeItens()
  {
  }

  public listaDeItens(List<item> itens)
  {
    this.Itens = itens;
  }
}
