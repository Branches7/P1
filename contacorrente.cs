class contacorrente : conta{
  private float tx_moviment;

  public contacorrente(string t, string n, float tx)
  :base (t, n)
  {
     tx_moviment = tx;
  }

  public bool Sacar(float vlr_saque) {
    float aux = vlr_saque + tx_moviment;
    return base.Sacar(aux);
  }

}