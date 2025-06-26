class ProdutoDigital : Produto
{
    private string linkDownload;

    public ProdutoDigital(string nome, string descricao, decimal preco, string imagem, string linkDownload)
    : base(nome, descricao, preco, imagem)
    {
        this.LinkDownload = linkDownload;
    }

    public string LinkDownload
    {
        get
        {
            return linkDownload;
        }
        set
        {
            if (value.Length > 0)
            {
                this.linkDownload = value;
            }
        }
    }

}