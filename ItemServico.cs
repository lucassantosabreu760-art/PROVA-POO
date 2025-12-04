public class ItemServico
{

    public int idItemServico;
    public double _valorUnd;
    public int _quantidade;
    public Servico servico;
    public OrdemServico ordemServico;


void GetQuantidade()
    {
        if(_quantidade <= 0)
        {
            throw new Exception("A quantidade deve ser maior que zero");
        }

       
    }    




}