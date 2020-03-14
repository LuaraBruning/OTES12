public class item {
  public int Posicao { get; set; }
  public int PosicaoModelo { get; set; }
  public string Descricao { get; set; }

  public item()
  {
  }

  public item(int posicao, string descricao)
  {
    this.Posicao = posicao;
    this.Descricao = descricao;
  }
}
