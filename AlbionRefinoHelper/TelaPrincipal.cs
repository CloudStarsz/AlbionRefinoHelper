using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq; // Necessário para GroupBy, Min, Max
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbionRefinoHelper
{
    public partial class TelaPrincipal : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        private string _Itens { get; set; }
        private string _Refino { get; set; }
        private bool _EscolheuTier { get; set; } = false;
        private int _Encantamento { get; set; } = -1;
        private bool _EscolheuCidadeCompra { get; set; } = false;
        private bool _EscolheuCidadeVenda { get; set; } = false;
        private const string _cidades = "Caerleon,Bridgewatch,Thetford,FortSterling,Martlock,Lymhurst";

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private async void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (_Itens == null || _Refino == null)
            {
                MessageBox.Show("Por favor selecione o tipo de item que deseja refinar");
                return;
            }


            btn_atualizar.Enabled = false;


            var todosDados = await BuscarDados();

            var queryColeta = todosDados.Where(x => EhColeta(x));
            var queryRefino = todosDados.Where(x => !EhColeta(x));

            var melhoresPrecosColeta = queryColeta
                .GroupBy(x => x.item_id)
                .ToDictionary(g => g.Key, g => (long)(g.Where(x => x.sell_price_min > 0).Min(x => (long?)x.sell_price_min) ?? 0));

            var melhoresPrecosRefino = queryRefino
                .GroupBy(x => x.item_id)
                .ToDictionary(g => g.Key, g => (long)g.Max(x => x.buy_price_max));

            if (_EscolheuCidadeCompra && cb_cidade_compra.SelectedItem != null)
            {
                string cidadeFiltro = cb_cidade_compra.SelectedItem.ToString().Trim().Replace(" ", "");
                queryColeta = queryColeta.Where(x => x.city.Trim().Replace(" ", "") == cidadeFiltro);
            }

            if (_EscolheuCidadeVenda && cb_cidade_venda.SelectedItem != null)
            {
                string cidadeFiltro = cb_cidade_venda.SelectedItem.ToString().Trim().Replace(" ", "");
                queryRefino = queryRefino.Where(x => x.city.Trim().Replace(" ", "") == cidadeFiltro);
            }

            var listaColetaFinal = queryColeta
                .OrderBy(x => x.item_id)
                .ThenBy(x => x.city)
                .ToList();

            var listaRefinoFinal = queryRefino
                .OrderBy(x => x.item_id)
                .ThenBy(x => x.city)
                .ToList();

            dataGrid_materiais.Rows.Clear();
            dataGrid_Refinos.Rows.Clear();

            PreencherGridColeta(listaColetaFinal, melhoresPrecosColeta);
            PreencherGridRefino(listaRefinoFinal, melhoresPrecosRefino);

            btn_atualizar.Enabled = true;
        }

        private void PreencherGridColeta(List<Mercado> itens, Dictionary<string, long> melhoresPrecos)
        {
            foreach (var item in itens)
            {
                int index = dataGrid_materiais.Rows.Add(
                    item.item_id,
                    item.city,
                    item.sell_price_min,
                    item.sell_price_max_date
                );

                if (item.sell_price_min > 0 && melhoresPrecos.ContainsKey(item.item_id) && item.sell_price_min == melhoresPrecos[item.item_id])
                {
                    dataGrid_materiais.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void PreencherGridRefino(List<Mercado> itens, Dictionary<string, long> melhoresPrecos)
        {
            foreach (var item in itens)
            {
                int index = dataGrid_Refinos.Rows.Add(
                    item.item_id,
                    item.city,
                    item.buy_price_max,
                    item.buy_price_max_date
                );

                if (item.buy_price_max > 0 && melhoresPrecos.ContainsKey(item.item_id) && item.buy_price_max == melhoresPrecos[item.item_id])
                {
                    dataGrid_Refinos.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private bool EhColeta(Mercado item)
        {
            return item.item_id.Contains("HIDE");
        }

        private async Task<List<Mercado>> BuscarDados()
        {
            try
            {
                string url = $"https://west.albion-online-data.com/api/v2/stats/prices/{_Itens},{_Refino}?locations={_cidades}&qualities=1";
                string json = await GetDataAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return new List<Mercado>();

                return JsonSerializer.Deserialize<List<Mercado>>(json, jsonOptions);
            }
            catch
            {
                return new List<Mercado>();
            }
        }

        private async Task<string> GetDataAsync(string url)
        {
            using HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        private void cb_itens_SelectedIndexChanged(object sender, EventArgs e)
        {
            _EscolheuTier = cb_itens.SelectedIndex != -1;

            if (cb_itens.SelectedItem.ToString() == "Pelego T2")
            {
                _Itens = "T2_HIDE";
                _Refino = "T2_LEATHER";
                return;
            }
            if (cb_itens.SelectedItem.ToString() == "Pelego T3")
            {
                _Itens = "T3_HIDE";
                _Refino = "T3_LEATHER";
                return;
            }


            string tier = cb_itens.SelectedItem.ToString() switch
            {
                "Pelego T4" => "T4",
                "Pelego T5" => "T5",
                "Pelego T6" => "T6",
                "Pelego T7" => "T7",
                "Pelego T8" => "T8",
                _ => "T4"
            };

            _Itens = GerarItens($"{tier}_HIDE");
            _Refino = GerarItens($"{tier}_LEATHER");
        }

        private string GerarItens(string ItemBase)
        {
            string itens = string.Empty;

            switch (_Encantamento)
            {
                case 0:
                    itens = $"{ItemBase}";
                    break;
                case 1:
                    itens = $"{ItemBase}_LEVEL1@1";
                    break;
                case 2:
                    itens = $"{ItemBase}_LEVEL2@2";
                    break;
                case 3:
                    itens = $"{ItemBase}_LEVEL3@3";
                    break;
                case 4:
                    itens = $"{ItemBase}_LEVEL4@4";
                    break;
                default:
                    itens = $"{ItemBase},{ItemBase}_LEVEL1@1,{ItemBase}_LEVEL2@2,{ItemBase}_LEVEL3@3,{ItemBase}_LEVEL4@4";
                    break;
            }

            return itens;
        }

        private void cb_encantamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Encantamento = cb_encantamento.SelectedItem.ToString() switch
            {
                "Encantamento 0" => 0,
                "Encantamento 1" => 1,
                "Encantamento 2" => 2,
                "Encantamento 3" => 3,
                "Encantamento 4" => 4,
                _ => -1
            };
        }

        private void cb_cidade_compra_SelectedIndexChanged(object sender, EventArgs e)
        {
            _EscolheuCidadeCompra = cb_cidade_compra.SelectedIndex != -1 ? cb_cidade_compra.SelectedIndex != 0 : false;
        }

        private void cb_cidade_venda_SelectedIndexChanged(object sender, EventArgs e)
        {
            _EscolheuCidadeVenda = cb_cidade_venda.SelectedIndex != -1 ? cb_cidade_venda.SelectedIndex != 0 : false;
        }

        private async void dataGrid_materiais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            tb_material_1.Text = dataGrid_materiais.Rows[e.RowIndex].Cells[0].Value.ToString();
            string cidadeSelecionada = dataGrid_materiais.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_material_1_preco.Text = dataGrid_materiais.Rows[e.RowIndex].Cells[2].Value.ToString();
            Mercado material2 = await ObterMaterialAnterior(tb_material_1.Text, cidadeSelecionada);

            if (material2 != null)
            {
                tb_material_2.Text = material2.item_id;
                tb_material_2_preco.Text = material2.sell_price_min.ToString();
            }
            else
            {
                tb_material_2.Text = "N/A";
                tb_material_2_preco.Text = "0";
            }
        }

        private async Task<Mercado> ObterMaterialAnterior(string nomePelegoAtual, string cidadeAlvo)
        {
            string tierAtual = nomePelegoAtual.Split('_')[0];

            string tierAnterior = tierAtual switch
            {
                "T4" => "T3",
                "T5" => "T4",
                "T6" => "T5",
                "T7" => "T6",
                "T8" => "T7",
                _ => null
            };

            if (tierAnterior == null) return null;

            string sufixoEncantamento = "";

            if (tierAnterior != "T3" && nomePelegoAtual.Contains("LEVEL"))
            {
                int index = nomePelegoAtual.IndexOf("_LEVEL");
                if (index != -1)
                {
                    sufixoEncantamento = nomePelegoAtual.Substring(index);
                }
            }

            string idMaterialAnterior = $"{tierAnterior}_LEATHER{sufixoEncantamento}";

            List<Mercado> materiaisAnteriores = await GetMaterialAnterior(idMaterialAnterior);

            return materiaisAnteriores
                .Where(x => x.city == cidadeAlvo && x.sell_price_min > 0)
                .OrderBy(x => x.sell_price_min)
                .FirstOrDefault();
        }

        private async Task<List<Mercado>> GetMaterialAnterior(string idMaterialAnterior)
        {
            try
            {
                string url = $"https://west.albion-online-data.com/api/v2/stats/prices/{idMaterialAnterior}?&qualities=1";
                string json = await GetDataAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return new List<Mercado>();

                return JsonSerializer.Deserialize<List<Mercado>>(json, jsonOptions);
            }
            catch
            {
                return new List<Mercado>();
            }
        }

        private void dataGrid_Refinos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_item_refinado.Text = dataGrid_Refinos.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_item_refinado_preco.Text = dataGrid_Refinos.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            decimal precoRefinado = decimal.TryParse(tb_item_refinado_preco.Text, out decimal val1) ? val1 : 0;
            decimal precoPelego = decimal.TryParse(tb_material_1_preco.Text, out decimal val2) ? val2 : 0;
            decimal precoCouroAnt = decimal.TryParse(tb_material_2_preco.Text, out decimal val3) ? val3 : 0;
            decimal taxaNutricao = decimal.TryParse(tb_taxa_nutricao.Text, out decimal val4) ? val4 : 0;
            decimal quantidade = decimal.TryParse(tb_quantidade.Text, out decimal val5) ? val5 : 1;
            int nivelFoco = int.TryParse(tb_nivel_foco.Text, out int val6) ? val6 : 0;

            int tier = cb_itens.SelectedIndex + 2;

            bool usaFoco = checkBox_usa_foco.Checked;
            bool cidadeBonus = checkBox_cidade_bonus.Checked;
            decimal taxaDevolucao;

            if (cidadeBonus && usaFoco) taxaDevolucao = 0.539m;
            else if (cidadeBonus && !usaFoco) taxaDevolucao = 0.367m;
            else if (!cidadeBonus && usaFoco) taxaDevolucao = 0.435m;
            else taxaDevolucao = 0.152m;

            var (lucroUnitario, custoUnitario) = CalcularLucroUnitario(
                precoRefinado,
                precoPelego,
                precoCouroAnt,
                tier,
                taxaDevolucao,
                taxaNutricao
            );

            decimal lucroTotal = lucroUnitario * quantidade;

            decimal margemLucro = 0;
            if (custoUnitario > 0)
            {
                margemLucro = (lucroUnitario / custoUnitario) * 100;
            }

            tb_lucro_porcentagem.Text = margemLucro.ToString("F2") + "%";
            tb_lucro_total.Text = lucroTotal.ToString("N0");

            if (lucroTotal > 0)
                tb_lucro_total.ForeColor = Color.Green;
            else
                tb_lucro_total.ForeColor = Color.Red;

            tb_investimento_total.Text = (custoUnitario * quantidade).ToString("N0");

            decimal fatorConsumo = 1 - taxaDevolucao;

            int qtdBasePelegos = tier switch
            {
                4 => 2,
                5 => 3,
                6 => 4,
                _ => 5
            };

            decimal qtdPelegosReal = (qtdBasePelegos * quantidade) * fatorConsumo;
            decimal qtdCouroReal = quantidade * fatorConsumo;

            tb_quant_material_1.Text = qtdPelegosReal.ToString("N0");
            tb_quant_material_2.Text = qtdCouroReal.ToString("N0");

            if (usaFoco)
            {
                int custoFocoTotal = CalcularFocoTotal(tier, _Encantamento, nivelFoco, (int)quantidade);
                tb_custo_foco.Text = custoFocoTotal.ToString("N0");
            }
            else
            {
                tb_custo_foco.Text = "0";
            }
        }

        private int CalcularFocoTotal(int tier, int encantamento, int nivelSpec, int quantidade)
        {
            int[,] baseCostTable = new int[,]
            {
            { 15, 28, 48, 86, 150 },   // T4 (.0, .1, .2, .3, .4)
            { 28, 51, 88, 159, 279 },  // T5
            { 55, 99, 172, 310, 542 }, // T6
            { 109, 197, 342, 615, 1076 }, // T7
            { 218, 393, 681, 1226, 2146 } // T8
            };

            if (tier < 4 || tier > 8) return 0;
            if (encantamento < 0) encantamento = 0;
            if (encantamento > 4) encantamento = 4;

            int baseCost = baseCostTable[tier - 4, encantamento];

            double eficiencia = nivelSpec * 250;

            double custoUnitario = baseCost * Math.Pow(0.5, eficiencia / 10000.0);

            return (int)(custoUnitario * quantidade);
        }

        private (decimal lucro, decimal custoTotal) CalcularLucroUnitario(decimal precoVenda, decimal precoPelego, decimal precoCouroAnterior, int tier, decimal taxaDevolucao, decimal taxaUsoLoja)
        {
            int qtdPelegos = tier switch
            {
                4 => 2,
                5 => 3,
                6 => 4,
                _ => 5
            };

            decimal nutricaoItem = tier switch
            {
                4 => 1.7m,
                5 => 3.4m,
                6 => 6.8m,
                7 => 13.6m,
                8 => 27.2m,
                _ => 1.7m
            };

            decimal custoSilverLoja = nutricaoItem * (taxaUsoLoja / 100m);
            decimal custoBrutoMateriais = (precoPelego * qtdPelegos) + precoCouroAnterior;

            decimal custoRealMateriais = custoBrutoMateriais * (1 - taxaDevolucao);

            decimal custoTotalUnitario = custoRealMateriais + custoSilverLoja;
            decimal lucroUnitario = precoVenda - custoTotalUnitario;

            return (lucroUnitario, custoTotalUnitario);
        }

    }
}