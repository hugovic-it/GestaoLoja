using GestaoLojaAPI.Context;
using GestaoLojaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoLojaAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class TestDbController : ControllerBase
{
    private readonly AppDbContext _context;
    public TestDbController(AppDbContext context)
    {
        _context = context;
    }
    [HttpPost] // Popular Tabela Clientes  |  POST Clientes  // 
    [ActionName("PostCLientes")]
    public async Task<ActionResult> PostClientes()
    {

        var clientes = new List<Cliente>
        {
            //Inserir Lista Inicial dos Clientes
            new Cliente { Nome = "Hugo Victor" , Apelido = "Pequod" , Telefone=83986849899, Cidade="Bayeux", Bairro="Jardim Aeroporto",Rua="Luis Porfirio de Lima",NumeroResidencia="700",EstaDevendo=true,ValorDivida=200,Observacao="Cliente Antigo"},
            new Cliente { Nome = "Ana Clara", Apelido = "Clarinha", Telefone=83998765432, Cidade="João Pessoa", Bairro="Tambaú", Rua="Avenida Epitácio Pessoa", NumeroResidencia="123", EstaDevendo=false, ValorDivida=0, Observacao="Cliente novo" },
            new Cliente { Nome = "Carlos Eduardo", Apelido = "Cadu", Telefone=83991234567, Cidade="Campina Grande", Bairro="Bodocongó", Rua="Rua Almirante Barroso", NumeroResidencia="456", EstaDevendo=true, ValorDivida=350, Observacao="Pago em parcelas" },
            new Cliente { Nome = "Fernanda Souza", Apelido = "Nanda", Telefone=83992345678, Cidade="Cabedelo", Bairro="Centro", Rua="Rua Mar Vermelho", NumeroResidencia="789", EstaDevendo=false, ValorDivida=0, Observacao="Cliente frequente" },
            new Cliente { Nome = "João Pedro", Apelido = "JP", Telefone=83993456789, Cidade="Santa Rita", Bairro="Popular", Rua="Rua Boa Vista", NumeroResidencia="321", EstaDevendo=true, ValorDivida=150, Observacao="Devedor regular" },
            new Cliente { Nome = "Maria Eduarda", Apelido = "Duda", Telefone=83994567890, Cidade="Bayeux", Bairro="Imaculada", Rua="Rua Dom Pedro II", NumeroResidencia="654", EstaDevendo=false, ValorDivida=0, Observacao="Cliente antiga, sem dívidas" },
            new Cliente { Nome = "Rafael Silva", Apelido = "Rafa", Telefone=83995678901, Cidade="João Pessoa", Bairro="Mangabeira", Rua="Avenida Hilton Souto Maior", NumeroResidencia="987", EstaDevendo=true, ValorDivida=450, Observacao="Cliente em atraso" },
            new Cliente { Nome = "Camila Almeida", Apelido = "Cami", Telefone=83996789012, Cidade="Campina Grande", Bairro="Catolé", Rua="Rua Floriano Peixoto", NumeroResidencia="147", EstaDevendo=false, ValorDivida=0, Observacao="Boa pagadora" },
            new Cliente { Nome = "Gabriel Costa", Apelido = "Biel", Telefone=83997890123, Cidade="Cabedelo", Bairro="Intermares", Rua="Rua do Sol", NumeroResidencia="258", EstaDevendo=true, ValorDivida=300, Observacao="Cliente em negociação" },
            new Cliente { Nome = "Larissa Mendes", Apelido = "Lari", Telefone=83998901234, Cidade="Santa Rita", Bairro="Centro", Rua="Rua das Palmeiras", NumeroResidencia="369", EstaDevendo=false, ValorDivida=0, Observacao="Cliente esporádica" },
            new Cliente { Nome = "Lucas Fernandes", Apelido = "Luquinha", Telefone=83999012345, Cidade="Bayeux", Bairro="Jardim Aeroporto", Rua="Rua Santos Dumont", NumeroResidencia="741", EstaDevendo=true, ValorDivida=250, Observacao="Cliente problemático" },
            new Cliente { Nome = "Mariana Lopes", Apelido = "Mari", Telefone=83990123456, Cidade="João Pessoa", Bairro="Valentina", Rua="Avenida Panorâmica", NumeroResidencia="852", EstaDevendo=false, ValorDivida=0, Observacao="Cliente satisfeita" },
            new Cliente { Nome = "Paulo Henrique", Apelido = "PH", Telefone=83991234567, Cidade="Campina Grande", Bairro="Tambor", Rua="Rua Ministro José Américo", NumeroResidencia="963", EstaDevendo=true, ValorDivida=600, Observacao="Cliente em débito" },
            new Cliente { Nome = "Renata Oliveira", Apelido = "Rê", Telefone=83992345678, Cidade="Cabedelo", Bairro="Renascer", Rua="Rua do Porto", NumeroResidencia="159", EstaDevendo=false, ValorDivida=0, Observacao="Sempre em dia" },
            new Cliente { Nome = "Thiago Martins", Apelido = "Thigo", Telefone=83993456789, Cidade="Santa Rita", Bairro="Tibiri", Rua="Rua da Saudade", NumeroResidencia="753", EstaDevendo=true, ValorDivida=320, Observacao="Cliente antigo com dívidas" },
            new Cliente { Nome = "Vanessa Silva", Apelido = "Vê", Telefone=83994567890, Cidade="Bayeux", Bairro="Mário Andreazza", Rua="Rua Pedro Américo", NumeroResidencia="864", EstaDevendo=false, ValorDivida=0, Observacao="Boa cliente" },
            new Cliente { Nome = "Wagner Sousa", Apelido = "Wag", Telefone=83995678901, Cidade="João Pessoa", Bairro="Jardim Cidade Universitária", Rua="Avenida Pedro II", NumeroResidencia="975", EstaDevendo=true, ValorDivida=500, Observacao="Atraso recorrente" },
            new Cliente { Nome = "Yasmin Freitas", Apelido = "Yas", Telefone=83996789012, Cidade="Campina Grande", Bairro="Jardim Paulistano", Rua="Rua Boa Esperança", NumeroResidencia="186", EstaDevendo=false, ValorDivida=0, Observacao="Pagadora pontual" },
            new Cliente { Nome = "Zeca Rodrigues", Apelido = "Zecão", Telefone=83997890123, Cidade="Cabedelo", Bairro="Jardim Jericó", Rua="Rua do Mar", NumeroResidencia="297", EstaDevendo=true, ValorDivida=100, Observacao="Cliente com pequena dívida" },
            new Cliente { Nome = "Isabela Moura", Apelido = "Bela", Telefone=83998901234, Cidade="Santa Rita", Bairro="Centro", Rua="Rua Santo Antônio", NumeroResidencia="308", EstaDevendo=false, ValorDivida=0, Observacao="Cliente fiel" },
            new Cliente { Nome = "Vitor Hugo", Apelido = "Vitinho", Telefone=83999012345, Cidade="Bayeux", Bairro="Sesi", Rua="Rua Alberto de Brito", NumeroResidencia="419", EstaDevendo=true, ValorDivida=200, Observacao="Cliente com dívida recente" }
        };

        _context.Clientes.AddRange(clientes);
        await _context.SaveChangesAsync();

        return Ok($"{clientes.Count} clientes foram adicionados com sucesso.");
    }


    [HttpPut] // Popular Tabela Produtos  |  POST Produtos  // 
    [ActionName("PostProdutos")]
    public async Task<ActionResult> PostProdutos()
    {

        var produtos = new List<Produto>
        {
            //Inserir Lista Inicial dos Produtos
            new Produto {Nome = "Kit 3x Cuecas Masculinas da Diamantes" , Tipo = "Roupa intima para Adulto" , Genero="Masculino", Idade = 34 , ValorAtacado = 60, ValorFinal = 120, Status="Disponivel", ImagemUrl="./kitcueca3xdiamante.jpeg", Observacao="Produto de ótima qualidade"},
            new Produto { Nome = "Meias Cano Alto 5x", Tipo = "Roupa íntima para Adulto", Genero = "Unissex", Idade = 30, ValorAtacado = 25, ValorFinal = 50, Status = "Disponivel", ImagemUrl = "./meiascanoalto5x.jpeg", Observacao = "Pacote com 5 pares de meias" },
            new Produto { Nome = "Kit 2x Sutiãs Confort", Tipo = "Roupa íntima para Adulto", Genero = "Feminino", Idade = 28, ValorAtacado = 80, ValorFinal = 160, Status = "Disponivel", ImagemUrl = "./kit2xsutiasconfort.jpeg", Observacao = "Sutiãs confortáveis para o dia a dia" },
            new Produto { Nome = "Kit 4x Cuecas Boxer", Tipo = "Roupa íntima para Adulto", Genero = "Masculino", Idade = 32, ValorAtacado = 70, ValorFinal = 140, Status = "Disponivel", ImagemUrl = "./kit4xcuecasboxer.jpeg", Observacao = "Cuecas boxer de alta qualidade" },
            new Produto { Nome = "Pijama Feminino de Seda", Tipo = "Roupa íntima para Adulto", Genero = "Feminino", Idade = 27, ValorAtacado = 90, ValorFinal = 180, Status = "Disponivel", ImagemUrl = "./pijamafemsedaa.jpeg", Observacao = "Pijama confortável e elegante" },
            new Produto { Nome = "Cueca Slip Algodão 3x", Tipo = "Roupa íntima para Adulto", Genero = "Masculino", Idade = 35, ValorAtacado = 50, ValorFinal = 100, Status = "Disponivel", ImagemUrl = "./cuecaslipalgodao3x.jpeg", Observacao = "Cuecas slip 100% algodão" },
            new Produto { Nome = "Kit 2x Lingerie Sensual", Tipo = "Roupa íntima para Adulto", Genero = "Feminino", Idade = 26, ValorAtacado = 100, ValorFinal = 200, Status = "Disponivel", ImagemUrl = "./kit2xlingeriesensual.jpeg", Observacao = "Lingerie de alta qualidade e conforto" },
            new Produto { Nome = "Camiseta Térmica Masculina", Tipo = "Roupa íntima para Adulto", Genero = "Masculino", Idade = 33, ValorAtacado = 80, ValorFinal = 160, Status = "Disponivel", ImagemUrl = "./camisetatermicamasculina.jpeg", Observacao = "Camiseta térmica para atividades físicas" },
            new Produto { Nome = "Meias Invisíveis Femininas 6x", Tipo = "Roupa íntima para Adulto", Genero = "Feminino", Idade = 29, ValorAtacado = 30, ValorFinal = 60, Status = "Disponivel", ImagemUrl = "./meiasinvisiveisfem6x.jpeg", Observacao = "Pacote com 6 pares de meias invisíveis" },
            new Produto { Nome = "Kit 3x Boxer Seamless", Tipo = "Roupa íntima para Adulto", Genero = "Masculino", Idade = 36, ValorAtacado = 75, ValorFinal = 150, Status = "Disponivel", ImagemUrl = "./kit3xboxerseamless.jpeg", Observacao = "Cuecas boxer sem costura" },
            new Produto { Nome = "Calcinha de Algodão 5x", Tipo = "Roupa íntima para Adulto", Genero = "Feminino", Idade = 31, ValorAtacado = 40, ValorFinal = 80, Status = "Disponivel", ImagemUrl = "./calcinhaalgodao5x.jpeg", Observacao = "Calcinhas de algodão, pacote com 5" },
            new Produto { Nome = "Kit 3x Cuecas Brief Masculinas", Tipo = "Roupa íntima para Adulto", Genero = "Masculino", Idade = 34, ValorAtacado = 60, ValorFinal = 120, Status = "Disponivel", ImagemUrl = "./kit3xcuecasbrief.jpeg", Observacao = "Cuecas brief de alta qualidade" },
            new Produto { Nome = "Sutiã Esportivo Feminino", Tipo = "Roupa íntima para Adulto", Genero = "Feminino", Idade = 27, ValorAtacado = 85, ValorFinal = 170, Status = "Disponivel", ImagemUrl = "./sutiaesportivofem.jpeg", Observacao = "Sutiã esportivo com suporte extra" },
            new Produto { Nome = "Cueca Long Leg 2x", Tipo = "Roupa íntima para Adulto", Genero = "Masculino", Idade = 35, ValorAtacado = 65, ValorFinal = 130, Status = "Disponivel", ImagemUrl = "./cuecalongleg2x.jpeg", Observacao = "Cuecas long leg para maior conforto" },
            new Produto { Nome = "Camiseta Segunda Pele Feminina", Tipo = "Roupa íntima para Adulto", Genero = "Feminino", Idade = 28, ValorAtacado = 70, ValorFinal = 140, Status = "Disponivel", ImagemUrl = "./camiseta2pelefem.jpeg", Observacao = "Camiseta segunda pele, perfeita para o inverno" },
            new Produto { Nome = "Kit 2x Cuecas de Seda Masculinas", Tipo = "Roupa íntima para Adulto", Genero = "Masculino", Idade = 36, ValorAtacado = 100, ValorFinal = 200, Status = "Disponivel", ImagemUrl = "./kit2xcuecasdeseda.jpeg", Observacao = "Cuecas de seda, pacote com 2" },
            new Produto { Nome = "Short Doll Feminino de Cetim", Tipo = "Roupa íntima para Adulto", Genero = "Feminino", Idade = 26, ValorAtacado = 90, ValorFinal = 180, Status = "Disponivel", ImagemUrl = "./shortdollcetimfem.jpeg", Observacao = "Short doll de cetim para maior conforto" },
            new Produto { Nome = "Kit 4x Cuecas Boxer Antibacterianas", Tipo = "Roupa íntima para Adulto", Genero = "Masculino", Idade = 33, ValorAtacado = 95, ValorFinal = 190, Status = "Disponivel", ImagemUrl = "./kit4xcuecasantibacterianas.jpeg", Observacao = "Cuecas com tecnologia antibacteriana" },
            new Produto { Nome = "Top Rendado Feminino", Tipo = "Roupa íntima para Adulto", Genero = "Feminino", Idade = 29, ValorAtacado = 60, ValorFinal = 120, Status = "Disponivel", ImagemUrl = "./toprendadofem.jpeg", Observacao = "Top rendado com design elegante" },
            new Produto { Nome = "Kit 3x Meias Sociais Masculinas", Tipo = "Roupa íntima para Adulto", Genero = "Masculino", Idade = 37, ValorAtacado = 50, ValorFinal = 100, Status = "Disponivel", ImagemUrl = "./kit3xmeiassociais.jpeg", Observacao = "Meias sociais para o dia a dia" },


        };

        _context.Produtos.AddRange(produtos);
        await _context.SaveChangesAsync();

        return Ok($"{produtos.Count} produtos foram adicionados com sucesso.");
    }
}
