class contapoupanca : conta{
  private float tx_rendimento;

  public contapoupanca(string t, string n, float tx)
  :base (t, n)
  {
     tx_rendimento = tx;
  }
}