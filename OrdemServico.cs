using System.Runtime.CompilerServices;

public class OrdemServico
{
    public int idOS;
    public string dataInicio;
    public List<ItemServico> listaItemServico;
    public string status;
    public double porcentagemDesconto;
    public double valorFinalOrdem;
    public Veiculo veiculo;
    public Cliente cliente;



   public void OS()
    {
        listaItemServico = new List<ItemServico>();
        CalculoValorfinal();
    }


      public void CalculoValorfinal()
    {

    }




}