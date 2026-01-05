namespace AlbionRefinoHelper
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            dataGrid_materiais = new DataGridView();
            item = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            ultimaData = new DataGridViewTextBoxColumn();
            dataGrid_Refinos = new DataGridView();
            item_2 = new DataGridViewTextBoxColumn();
            cidade_2 = new DataGridViewTextBoxColumn();
            preco_2 = new DataGridViewTextBoxColumn();
            ultimaData_2 = new DataGridViewTextBoxColumn();
            lucro_2 = new DataGridViewTextBoxColumn();
            lucro_liq_2 = new DataGridViewTextBoxColumn();
            btn_atualizar = new Button();
            img_Item = new Label();
            cb_itens = new ComboBox();
            cb_encantamento = new ComboBox();
            cb_cidade_compra = new ComboBox();
            label_cb_encantamento = new Label();
            label_cb_cidade_compra = new Label();
            label_cb_idade_venda = new Label();
            cb_cidade_venda = new ComboBox();
            label1 = new Label();
            gb_craft = new GroupBox();
            label18 = new Label();
            tb_custo_foco = new TextBox();
            label17 = new Label();
            tb_nivel_foco = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            tb_investimento_total = new TextBox();
            tb_quant_material_2 = new TextBox();
            tb_quant_material_1 = new TextBox();
            label13 = new Label();
            tb_quantidade = new TextBox();
            label12 = new Label();
            label11 = new Label();
            tb_lucro_porcentagem = new TextBox();
            tb_lucro_total = new TextBox();
            btn_calcular = new Button();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_taxa_nutricao = new TextBox();
            checkBox_cidade_bonus = new CheckBox();
            checkBox_usa_foco = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label_quantidade_recurso = new Label();
            tb_material_2_preco = new TextBox();
            tb_material_2 = new TextBox();
            tb_material_1_preco = new TextBox();
            tb_material_1 = new TextBox();
            tb_item_refinado_preco = new TextBox();
            tb_item_refinado = new TextBox();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_materiais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Refinos).BeginInit();
            gb_craft.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid_materiais
            // 
            dataGrid_materiais.AllowUserToAddRows = false;
            dataGrid_materiais.AllowUserToDeleteRows = false;
            dataGrid_materiais.AllowUserToResizeColumns = false;
            dataGrid_materiais.AllowUserToResizeRows = false;
            dataGrid_materiais.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGrid_materiais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_materiais.Columns.AddRange(new DataGridViewColumn[] { item, cidade, preco, ultimaData });
            dataGrid_materiais.Location = new Point(304, 66);
            dataGrid_materiais.MultiSelect = false;
            dataGrid_materiais.Name = "dataGrid_materiais";
            dataGrid_materiais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_materiais.ShowCellErrors = false;
            dataGrid_materiais.ShowCellToolTips = false;
            dataGrid_materiais.ShowEditingIcon = false;
            dataGrid_materiais.ShowRowErrors = false;
            dataGrid_materiais.Size = new Size(512, 328);
            dataGrid_materiais.TabIndex = 0;
            dataGrid_materiais.CellClick += dataGrid_materiais_CellClick;
            // 
            // item
            // 
            item.HeaderText = "item";
            item.Name = "item";
            item.Width = 200;
            // 
            // cidade
            // 
            cidade.HeaderText = "cidade";
            cidade.Name = "cidade";
            // 
            // preco
            // 
            preco.HeaderText = "preço";
            preco.Name = "preco";
            // 
            // ultimaData
            // 
            ultimaData.HeaderText = "ultima data";
            ultimaData.Name = "ultimaData";
            ultimaData.Width = 250;
            // 
            // dataGrid_Refinos
            // 
            dataGrid_Refinos.AllowUserToAddRows = false;
            dataGrid_Refinos.AllowUserToDeleteRows = false;
            dataGrid_Refinos.AllowUserToResizeColumns = false;
            dataGrid_Refinos.AllowUserToResizeRows = false;
            dataGrid_Refinos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGrid_Refinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Refinos.Columns.AddRange(new DataGridViewColumn[] { item_2, cidade_2, preco_2, ultimaData_2 });
            dataGrid_Refinos.Location = new Point(822, 66);
            dataGrid_Refinos.MultiSelect = false;
            dataGrid_Refinos.Name = "dataGrid_Refinos";
            dataGrid_Refinos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Refinos.ShowCellErrors = false;
            dataGrid_Refinos.ShowCellToolTips = false;
            dataGrid_Refinos.ShowEditingIcon = false;
            dataGrid_Refinos.ShowRowErrors = false;
            dataGrid_Refinos.Size = new Size(543, 328);
            dataGrid_Refinos.TabIndex = 1;
            dataGrid_Refinos.CellClick += dataGrid_Refinos_CellClick;
            // 
            // item_2
            // 
            item_2.HeaderText = "item";
            item_2.Name = "item_2";
            item_2.Width = 200;
            // 
            // cidade_2
            // 
            cidade_2.HeaderText = "cidade";
            cidade_2.Name = "cidade_2";
            // 
            // preco_2
            // 
            preco_2.HeaderText = "preço";
            preco_2.Name = "preco_2";
            // 
            // ultimaData_2
            // 
            ultimaData_2.HeaderText = "Ultima Data";
            ultimaData_2.Name = "ultimaData_2";
            ultimaData_2.Width = 250;
            // 
            // lucro_2
            // 
            lucro_2.Name = "lucro_2";
            // 
            // lucro_liq_2
            // 
            lucro_liq_2.Name = "lucro_liq_2";
            // 
            // btn_atualizar
            // 
            btn_atualizar.Location = new Point(1205, 31);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(160, 23);
            btn_atualizar.TabIndex = 2;
            btn_atualizar.Text = "Pesquisar";
            btn_atualizar.UseVisualStyleBackColor = true;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // img_Item
            // 
            img_Item.AutoSize = true;
            img_Item.Image = (Image)resources.GetObject("img_Item.Image");
            img_Item.Location = new Point(81, 57);
            img_Item.MinimumSize = new Size(150, 150);
            img_Item.Name = "img_Item";
            img_Item.Size = new Size(150, 150);
            img_Item.TabIndex = 3;
            // 
            // cb_itens
            // 
            cb_itens.FormattingEnabled = true;
            cb_itens.Items.AddRange(new object[] { "Pelego T2", "Pelego T3", "Pelego T4", "Pelego T5", "Pelego T6", "Pelego T7", "Pelego T8" });
            cb_itens.Location = new Point(49, 233);
            cb_itens.Name = "cb_itens";
            cb_itens.Size = new Size(214, 23);
            cb_itens.TabIndex = 4;
            cb_itens.SelectedIndexChanged += cb_itens_SelectedIndexChanged;
            // 
            // cb_encantamento
            // 
            cb_encantamento.FormattingEnabled = true;
            cb_encantamento.Items.AddRange(new object[] { "Todos", "Encantamento 0", "Encantamento 1", "Encantamento 2", "Encantamento 3", "Encantamento 4" });
            cb_encantamento.Location = new Point(344, 32);
            cb_encantamento.Name = "cb_encantamento";
            cb_encantamento.Size = new Size(203, 23);
            cb_encantamento.TabIndex = 5;
            cb_encantamento.SelectedIndexChanged += cb_encantamento_SelectedIndexChanged;
            // 
            // cb_cidade_compra
            // 
            cb_cidade_compra.FormattingEnabled = true;
            cb_cidade_compra.Items.AddRange(new object[] { "Todas", "Caerleon", "Bridgewatch", "Thetford", "FortSterling", "Martlock", "Lymhurst" });
            cb_cidade_compra.Location = new Point(576, 32);
            cb_cidade_compra.Name = "cb_cidade_compra";
            cb_cidade_compra.Size = new Size(187, 23);
            cb_cidade_compra.TabIndex = 6;
            cb_cidade_compra.SelectedIndexChanged += cb_cidade_compra_SelectedIndexChanged;
            // 
            // label_cb_encantamento
            // 
            label_cb_encantamento.AutoSize = true;
            label_cb_encantamento.Location = new Point(344, 14);
            label_cb_encantamento.Name = "label_cb_encantamento";
            label_cb_encantamento.Size = new Size(84, 15);
            label_cb_encantamento.TabIndex = 7;
            label_cb_encantamento.Text = "Encantamento";
            // 
            // label_cb_cidade_compra
            // 
            label_cb_cidade_compra.AutoSize = true;
            label_cb_cidade_compra.Location = new Point(576, 14);
            label_cb_cidade_compra.Name = "label_cb_cidade_compra";
            label_cb_cidade_compra.Size = new Size(104, 15);
            label_cb_cidade_compra.TabIndex = 8;
            label_cb_cidade_compra.Text = "Cidade de compra";
            // 
            // label_cb_idade_venda
            // 
            label_cb_idade_venda.AutoSize = true;
            label_cb_idade_venda.Location = new Point(822, 14);
            label_cb_idade_venda.Name = "label_cb_idade_venda";
            label_cb_idade_venda.Size = new Size(95, 15);
            label_cb_idade_venda.TabIndex = 10;
            label_cb_idade_venda.Text = "Cidade de venda";
            // 
            // cb_cidade_venda
            // 
            cb_cidade_venda.FormattingEnabled = true;
            cb_cidade_venda.Items.AddRange(new object[] { "Todas", "Caerleon", "Bridgewatch", "Thetford", "FortSterling", "Martlock", "Lymhurst" });
            cb_cidade_venda.Location = new Point(822, 32);
            cb_cidade_venda.Name = "cb_cidade_venda";
            cb_cidade_venda.Size = new Size(187, 23);
            cb_cidade_venda.TabIndex = 9;
            cb_cidade_venda.SelectedIndexChanged += cb_cidade_venda_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 216);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 11;
            label1.Text = "Tipo Item";
            // 
            // gb_craft
            // 
            gb_craft.Controls.Add(label18);
            gb_craft.Controls.Add(tb_custo_foco);
            gb_craft.Controls.Add(label17);
            gb_craft.Controls.Add(tb_nivel_foco);
            gb_craft.Controls.Add(label16);
            gb_craft.Controls.Add(label15);
            gb_craft.Controls.Add(label14);
            gb_craft.Controls.Add(tb_investimento_total);
            gb_craft.Controls.Add(tb_quant_material_2);
            gb_craft.Controls.Add(tb_quant_material_1);
            gb_craft.Controls.Add(label13);
            gb_craft.Controls.Add(tb_quantidade);
            gb_craft.Controls.Add(label12);
            gb_craft.Controls.Add(label11);
            gb_craft.Controls.Add(tb_lucro_porcentagem);
            gb_craft.Controls.Add(tb_lucro_total);
            gb_craft.Controls.Add(btn_calcular);
            gb_craft.Controls.Add(label8);
            gb_craft.Controls.Add(label6);
            gb_craft.Controls.Add(label7);
            gb_craft.Controls.Add(label2);
            gb_craft.Controls.Add(label3);
            gb_craft.Controls.Add(tb_taxa_nutricao);
            gb_craft.Controls.Add(checkBox_cidade_bonus);
            gb_craft.Controls.Add(checkBox_usa_foco);
            gb_craft.Controls.Add(label5);
            gb_craft.Controls.Add(label4);
            gb_craft.Controls.Add(label_quantidade_recurso);
            gb_craft.Controls.Add(tb_material_2_preco);
            gb_craft.Controls.Add(tb_material_2);
            gb_craft.Controls.Add(tb_material_1_preco);
            gb_craft.Controls.Add(tb_material_1);
            gb_craft.Controls.Add(tb_item_refinado_preco);
            gb_craft.Controls.Add(tb_item_refinado);
            gb_craft.Location = new Point(304, 426);
            gb_craft.Name = "gb_craft";
            gb_craft.Size = new Size(1061, 294);
            gb_craft.TabIndex = 12;
            gb_craft.TabStop = false;
            gb_craft.Text = "Crafting";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(503, 214);
            label18.Name = "label18";
            label18.Size = new Size(169, 15);
            label18.TabIndex = 36;
            label18.Text = "Quantidade de foco necessaria";
            // 
            // tb_custo_foco
            // 
            tb_custo_foco.Enabled = false;
            tb_custo_foco.Location = new Point(524, 232);
            tb_custo_foco.Name = "tb_custo_foco";
            tb_custo_foco.Size = new Size(125, 23);
            tb_custo_foco.TabIndex = 35;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(525, 159);
            label17.Name = "label17";
            label17.Size = new Size(77, 15);
            label17.TabIndex = 34;
            label17.Text = "Nivel de spec";
            // 
            // tb_nivel_foco
            // 
            tb_nivel_foco.Location = new Point(524, 177);
            tb_nivel_foco.Name = "tb_nivel_foco";
            tb_nivel_foco.Size = new Size(125, 23);
            tb_nivel_foco.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(307, 204);
            label16.Name = "label16";
            label16.Size = new Size(124, 15);
            label16.TabIndex = 32;
            label16.Text = "Quantidade material 2";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(177, 204);
            label15.Name = "label15";
            label15.Size = new Size(124, 15);
            label15.TabIndex = 31;
            label15.Text = "Quantidade material 1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(745, 186);
            label14.Name = "label14";
            label14.Size = new Size(103, 15);
            label14.TabIndex = 30;
            label14.Text = "Investimento total";
            // 
            // tb_investimento_total
            // 
            tb_investimento_total.Location = new Point(745, 204);
            tb_investimento_total.Name = "tb_investimento_total";
            tb_investimento_total.Size = new Size(125, 23);
            tb_investimento_total.TabIndex = 29;
            // 
            // tb_quant_material_2
            // 
            tb_quant_material_2.Enabled = false;
            tb_quant_material_2.Location = new Point(306, 222);
            tb_quant_material_2.Name = "tb_quant_material_2";
            tb_quant_material_2.Size = new Size(125, 23);
            tb_quant_material_2.TabIndex = 28;
            // 
            // tb_quant_material_1
            // 
            tb_quant_material_1.Enabled = false;
            tb_quant_material_1.Location = new Point(177, 222);
            tb_quant_material_1.Name = "tb_quant_material_1";
            tb_quant_material_1.Size = new Size(125, 23);
            tb_quant_material_1.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(40, 204);
            label13.Name = "label13";
            label13.Size = new Size(125, 15);
            label13.TabIndex = 26;
            label13.Text = "Quantidade a produzir";
            // 
            // tb_quantidade
            // 
            tb_quantidade.Location = new Point(40, 222);
            tb_quantidade.Name = "tb_quantidade";
            tb_quantidade.Size = new Size(125, 23);
            tb_quantidade.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(901, 183);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 24;
            label12.Text = "Lucro total";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(901, 137);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 23;
            label11.Text = "Lucro (%)";
            // 
            // tb_lucro_porcentagem
            // 
            tb_lucro_porcentagem.Enabled = false;
            tb_lucro_porcentagem.Location = new Point(901, 159);
            tb_lucro_porcentagem.Name = "tb_lucro_porcentagem";
            tb_lucro_porcentagem.Size = new Size(89, 23);
            tb_lucro_porcentagem.TabIndex = 22;
            // 
            // tb_lucro_total
            // 
            tb_lucro_total.Enabled = false;
            tb_lucro_total.Location = new Point(901, 204);
            tb_lucro_total.Name = "tb_lucro_total";
            tb_lucro_total.Size = new Size(126, 23);
            tb_lucro_total.TabIndex = 21;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(901, 233);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(144, 23);
            btn_calcular.TabIndex = 20;
            btn_calcular.Text = "Calcular!";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(824, 44);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 19;
            label8.Text = "Taxa nutrição preço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(565, 96);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 18;
            label6.Text = "preço";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(565, 44);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 17;
            label7.Text = "Material 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 96);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 16;
            label2.Text = "preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 44);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 15;
            label3.Text = "Material 1";
            // 
            // tb_taxa_nutricao
            // 
            tb_taxa_nutricao.Location = new Point(824, 62);
            tb_taxa_nutricao.Name = "tb_taxa_nutricao";
            tb_taxa_nutricao.Size = new Size(203, 23);
            tb_taxa_nutricao.TabIndex = 14;
            // 
            // checkBox_cidade_bonus
            // 
            checkBox_cidade_bonus.AutoSize = true;
            checkBox_cidade_bonus.Location = new Point(160, 164);
            checkBox_cidade_bonus.Name = "checkBox_cidade_bonus";
            checkBox_cidade_bonus.Size = new Size(104, 19);
            checkBox_cidade_bonus.TabIndex = 13;
            checkBox_cidade_bonus.Text = "Cidade bonus?";
            checkBox_cidade_bonus.UseVisualStyleBackColor = true;
            // 
            // checkBox_usa_foco
            // 
            checkBox_usa_foco.AutoSize = true;
            checkBox_usa_foco.Location = new Point(40, 164);
            checkBox_usa_foco.Name = "checkBox_usa_foco";
            checkBox_usa_foco.Size = new Size(79, 19);
            checkBox_usa_foco.TabIndex = 12;
            checkBox_usa_foco.Text = "Usa Foco?";
            checkBox_usa_foco.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 96);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 11;
            label5.Text = "preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 44);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 10;
            label4.Text = "Item refinado";
            // 
            // label_quantidade_recurso
            // 
            label_quantidade_recurso.AutoSize = true;
            label_quantidade_recurso.Location = new Point(299, 62);
            label_quantidade_recurso.Name = "label_quantidade_recurso";
            label_quantidade_recurso.Size = new Size(13, 15);
            label_quantidade_recurso.TabIndex = 8;
            label_quantidade_recurso.Text = "x";
            // 
            // tb_material_2_preco
            // 
            tb_material_2_preco.Location = new Point(565, 114);
            tb_material_2_preco.Name = "tb_material_2_preco";
            tb_material_2_preco.Size = new Size(203, 23);
            tb_material_2_preco.TabIndex = 5;
            // 
            // tb_material_2
            // 
            tb_material_2.Enabled = false;
            tb_material_2.Location = new Point(565, 62);
            tb_material_2.Name = "tb_material_2";
            tb_material_2.Size = new Size(203, 23);
            tb_material_2.TabIndex = 4;
            // 
            // tb_material_1_preco
            // 
            tb_material_1_preco.Location = new Point(324, 114);
            tb_material_1_preco.Name = "tb_material_1_preco";
            tb_material_1_preco.Size = new Size(203, 23);
            tb_material_1_preco.TabIndex = 3;
            // 
            // tb_material_1
            // 
            tb_material_1.Enabled = false;
            tb_material_1.Location = new Point(324, 62);
            tb_material_1.Name = "tb_material_1";
            tb_material_1.Size = new Size(203, 23);
            tb_material_1.TabIndex = 2;
            // 
            // tb_item_refinado_preco
            // 
            tb_item_refinado_preco.Location = new Point(40, 114);
            tb_item_refinado_preco.Name = "tb_item_refinado_preco";
            tb_item_refinado_preco.Size = new Size(203, 23);
            tb_item_refinado_preco.TabIndex = 1;
            // 
            // tb_item_refinado
            // 
            tb_item_refinado.Enabled = false;
            tb_item_refinado.Location = new Point(40, 62);
            tb_item_refinado.Name = "tb_item_refinado";
            tb_item_refinado.Size = new Size(203, 23);
            tb_item_refinado.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(304, 397);
            label9.Name = "label9";
            label9.Size = new Size(134, 15);
            label9.TabIndex = 13;
            label9.Text = "Selecionar cidade acima";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(822, 397);
            label10.Name = "label10";
            label10.Size = new Size(134, 15);
            label10.TabIndex = 14;
            label10.Text = "Selecionar cidade acima";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 752);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(gb_craft);
            Controls.Add(label1);
            Controls.Add(label_cb_idade_venda);
            Controls.Add(cb_cidade_venda);
            Controls.Add(label_cb_cidade_compra);
            Controls.Add(label_cb_encantamento);
            Controls.Add(cb_cidade_compra);
            Controls.Add(cb_encantamento);
            Controls.Add(cb_itens);
            Controls.Add(img_Item);
            Controls.Add(btn_atualizar);
            Controls.Add(dataGrid_Refinos);
            Controls.Add(dataGrid_materiais);
            Name = "TelaPrincipal";
            Text = "RefinoHelper";
            ((System.ComponentModel.ISupportInitialize)dataGrid_materiais).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Refinos).EndInit();
            gb_craft.ResumeLayout(false);
            gb_craft.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid_materiais;
        private DataGridView dataGrid_Refinos;
        private Button btn_atualizar;
        private Label img_Item;
        private ComboBox cb_itens;
        private DataGridViewTextBoxColumn item_2;
        private DataGridViewTextBoxColumn cidade_2;
        private DataGridViewTextBoxColumn preco_2;
        private DataGridViewTextBoxColumn ultimaData_2;
        private DataGridViewTextBoxColumn lucro_2;
        private DataGridViewTextBoxColumn lucro_liq_2;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn cidade;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn ultimaData;
        private ComboBox cb_encantamento;
        private ComboBox cb_cidade_compra;
        private Label label_cb_encantamento;
        private Label label_cb_cidade_compra;
        private Label label_cb_idade_venda;
        private ComboBox cb_cidade_venda;
        private Label label1;
        private GroupBox gb_craft;
        private TextBox tb_material_2_preco;
        private TextBox tb_material_2;
        private TextBox tb_material_1_preco;
        private TextBox tb_material_1;
        private TextBox tb_item_refinado_preco;
        private TextBox tb_item_refinado;
        private Label label5;
        private Label label4;
        private Label label_quantidade_recurso;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label2;
        private Label label3;
        private TextBox tb_taxa_nutricao;
        private CheckBox checkBox_cidade_bonus;
        private CheckBox checkBox_usa_foco;
        private Label label9;
        private Label label10;
        private Button btn_calcular;
        private Label label12;
        private Label label11;
        private TextBox tb_lucro_porcentagem;
        private TextBox tb_lucro_total;
        private Label label13;
        private TextBox tb_quantidade;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox tb_investimento_total;
        private TextBox tb_quant_material_2;
        private TextBox tb_quant_material_1;
        private Label label18;
        private TextBox tb_custo_foco;
        private Label label17;
        private TextBox tb_nivel_foco;
    }
}
