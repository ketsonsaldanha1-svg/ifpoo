    internal interface IPagamento
{
    
    decimal ValorTransacao {get; }
    bool ProcessarPagamento (decimal valor);
    string ObterComprovante()
    {
        return("fkefodd");
    }
    void CancelarTransacao();


}