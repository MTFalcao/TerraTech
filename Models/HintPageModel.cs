namespace WebSite.Models
{
    public class HintPageModel
    {
        public List<Hint> IrrigacaoTips { get; set; } = new();
        public List<Hint> PlantioTips { get; set; } = new();
        public List<Hint> ManutencaoTips { get; set; } = new();
        public List<Hint> AvancadoTips { get; set; } = new();
        public Dictionary<string, string> EstacoesHints { get; set; }

        public List<(string Titulo, string Descricao, List<Hint> Dicas)> Sections { get; set; }

        public HintPageModel()
        {
            IrrigacaoTips = new List<Hint>
            {
                new Hint(
                    "Avançado",
                    "Níveis Ideais por Tipo de Planta.",
                    "Saiba e mantenha os níveis de umidade para cada tipo de planta",
                    "• Suculentas/Cactos:\r\n" +
                    "     Umidade em 10–30%: Quase seco,\r\n" +
                    "     Temperatura ideal: 20°C – 35°C,\r\n" +
                    "     Rega: Regue só quando totalmente seco.\r\n\r\n" +
                    "• Folhagens Tropicais:\r\n" +
                    "     Umidade em 40–60%: Levemente úmido,\r\n" +
                    "     Temperatura ideal: 18°C – 28°C,\r\n" +
                    "     Rega: Regue quando superfície secar.\r\n\r\n" +
                    "• Hortaliças (tomate, alface):\r\n" +
                    "     Umidade em 50–70%: Úmido,\r\n" +
                    "     Temperatura ideal: 15°C – 25°C,\r\n" +
                    "     Rega: Mantenha solo sempre úmido (não encharcado).\r\n\r\n" +
                    "• Orquídeas:\r\n" +
                    "     Umidade em 30–50%: Úmido, mas com drenagem,\r\n" +
                    "     Temperatura ideal: 20°C – 30°C,\r\n" +
                    "     Rega: Regue quando quase seco."
                ),
                    new Hint(
                        "Iniciante",
                        "Frequência de rega ideal",
                        "Descubra qual é a frequência ideal para diferentes tipos de plantas domésticas.",
                        "• Espada-de-São-Jorge:\r\n" +
                        "     Regue a cada 15 a 20 dias, permitindo o solo secar entre as regas.\r\n\r\n" +
                        "• Jiboia:\r\n" +
                        "     Regue quando os primeiros 2 cm do solo estiverem secos.\r\n\r\n" +
                        "• Lírio da Paz:\r\n" +
                        "     Mantenha o solo úmido, regando uma vez por semana.\r\n\r\n" +
                        "• Costela-de-Adão:\r\n" +
                        "     Regue moderadamente, aproximadamente a cada 7 dias, evitando encharcar.\r\n\r\n" +
                        "• Samambaia:\r\n" +
                        "     Regue frequentemente para manter o solo sempre úmido, mas não encharcado."
                    ),
                new Hint(
                    "Intermediário",
                    "Condicionamento do Solo",
                    "Aprenda a identificar e corrigir problemas de umidade no solo para evitar danos às raízes.",
                    "Solo muito úmido + frio (ex.: >70% umidade + <15°C): Risco de apodrecimento das raízes.\r\nSolução: Reduza regas e melhore a drenagem (coloque pedras no vaso).\r\n \nSolo seco + quente (ex.: <20% umidade + >30°C): Plantas murchas ou com folhas crocantes.\r\nSolução: Regue mais frequentemente e use cobertura morta (palha) para reter umidade."

                    )
            };

            PlantioTips = new List<Hint>
            {
                new Hint(
                    "Intermediário",
                    "Problemas comuns e como evitá-los",
                    "Técnicas eficientes para cuidar do solo",
                    "Plantas com crescimento lento, folhas amareladas ou solo endurecido são sinais de problemas comuns no plantio.\r\n\r\nPara evitar isso, faça aeração periódica no solo, evite encharcamento e garanta uma boa drenagem.\r\n\r\nRotacione culturas e adicione matéria orgânica como húmus ou compostagem para restaurar nutrientes."
                ),
                new Hint(
                    "Iniciante",
                    "Cultivo de ervas",
                    "Guia completo para cultivar ervas aromáticas em casa.",
                    "Ervas como manjericão, alecrim e hortelã são fáceis de cultivar em casa.\r\n\r\nPlante em vasos com furos para drenagem, utilize substrato leve e regue sempre que a superfície do solo estiver seca.\r\n\r\nColoque os vasos em locais com boa iluminação e colha com frequência para estimular o crescimento."
                ),
                new Hint(
                    "Intermediário",
                    "Plantas companheiras",
                    "Descubra plantas que se beneficiam mutuamente no plantio.",
                    "Plantar espécies que se ajudam mutuamente melhora o crescimento e reduz pragas naturalmente.\r\n\r\nExemplos:\r\n• Tomate + Manjericão: repele insetos e melhora o sabor.\r\n• Milho + Feijão: o feijão enriquece o solo com nitrogênio.\r\n• Cenoura + Cebolinha: cebolinha espanta pragas da cenoura.\r\n\r\nEvite combinar plantas que competem por nutrientes ou luz."
                )
            };

            ManutencaoTips = new List<Hint>
            {
                new Hint(
                    "Iniciante",
                    "Horarios ideais para regar",
                    "Os melhores horarios para regar sua planta.",
                    "Manhã cedo: A água evapora menos e a planta absorve melhor.\n" +
                    "\n\nEvite regar à noite: Solo úmido por muitas horas pode atrair fungos."
                    ),
                new Hint(
                    "Avançado",
                    "Ajuste de Rega com o sensor",
                    "Melhores ajustes para o sensor no solo",
                    "Se a umidade subir >80%, a drenagem está ruim (adicione areia ao solo).\r\n\r\nSe voltar a <30% em 1 dia, o vaso é pequeno demais (transplante)."
                    ),
                new Hint(
                    "Intermediário",
                    "Compostagem caseira",
                    "Como criar e manter uma composteira em casa.",
                    "• O que é compostagem?\r\n" +
                    "     Compostagem é o processo natural de decomposição de materiais orgânicos, transformando resíduos em húmus rico para o solo.\r\n\r\n" +
                    "• Materiais para compostagem:\r\n" +
                    "     Restos de frutas e legumes, folhas secas, borra de café, cascas de ovos, aparas de grama e pequenos galhos.\r\n\r\n" +
                    "• Materiais a evitar:\r\n" +
                    "     Carnes, laticínios, gorduras, plantas doentes e fezes de animais domésticos.\r\n\r\n" +
                    "• Como montar a composteira:\r\n" +
                    "     Escolha um local arejado e sombreado; faça uma pilha ou use um recipiente específico.\r\n" +
                    "     Alterne camadas de materiais úmidos (restos de cozinha) e secos (folhas, papel picado).\r\n\r\n" +
                    "• Manutenção:\r\n" +
                    "     Revolva o composto a cada 1 ou 2 semanas para oxigenar e acelerar a decomposição.\r\n" +
                    "     Mantenha o material úmido, como uma esponja torcida, evitando o encharcamento.\r\n\r\n" +
                    "• Tempo de compostagem:\r\n" +
                    "     Geralmente entre 2 a 6 meses, dependendo da temperatura, materiais e manejo.\r\n\r\n" +
                    "• Benefícios:\r\n" +
                    "     Fertilizante natural para plantas, melhora a estrutura do solo, ajuda a reter água e reduz o lixo doméstico."
                )
            };

            AvancadoTips = new List<Hint>
            {
                new Hint(
                    "Avançado",
                    "Plantas Específicas e Requisitos de Umidade",
                    "Dicas avançadas para manejo de umidade em plantas comuns e menos comuns.",
                    "Tomates: Solo deve ficar entre 50–70% de umidade durante a frutificação.\r\n\r\n" +
                    "Suculentas: Se o sensor marcar umidade alta por >3 dias, PARE de regar!\r\n\r\n" +
                    "Samambaias: Umidade do solo nunca abaixo de 40% (folhas ficam marrons).\r\n\r\n" +

                    "Orquídeas Vandáceas: Solo ou substrato deve manter umidade entre 40–60%. Evite encharcar, pois raízes aéreas podem apodrecer facilmente.\r\n\r\n" +
                    "Bromélias: Necessitam de umidade relativa alta (60–80%) e solo que drene rápido. Mantenha substrato úmido, mas nunca encharcado, com picos de umidade em torno de 50%.\r\n\r\n" +
                    "Avenca (Adiantum): Solo deve ficar constantemente úmido, com umidade entre 60–80%. Evite deixar abaixo de 50%, pois as folhas ficam secas e amareladas.\r\n\r\n" +
                    "Café (Coffea arabica): Solo ideal entre 70–80% de umidade, preferindo regas frequentes para manter umidade constante, evitando encharcamento para não causar doenças nas raízes."
                ),

                new Hint(
                    "Avançado",
                    "Enxertia de frutíferas",
                    "Aprenda a enxertar plantas frutíferas com sucesso.",
                    "A enxertia é uma técnica horticultural que consiste em unir duas plantas distintas para que cresçam como uma só, combinando as melhores características de cada uma.\r\n\r\n" +
                    "Existem vários tipos de enxertia, entre os mais comuns estão:\r\n" +
                    "• Garfagem: onde um ramo ou garfo doador é inserido no porta-enxerto com um corte em formato de 'V' ou fenda.\r\n" +
                    "• Borbulhia: consiste em inserir um único botão (ou gema) do enxerto no porta-enxerto.\r\n\r\n" +
                    "Cuidados essenciais incluem realizar cortes limpos e precisos para facilitar a união dos tecidos e garantir que o fluxo de seiva não seja interrompido.\r\n" +
                    "É importante também proteger a área enxertada com fitas ou parafinas para evitar desidratação e contaminação por fungos ou bactérias.\r\n\r\n" +
                    "O tempo de cicatrização varia conforme a espécie, clima e condições do local, mas geralmente leva de algumas semanas a meses. Durante esse período, mantenha a planta em local protegido e monitore o desenvolvimento para garantir o sucesso da enxertia."
                ),
                new Hint(
                    "Avançado",
                    "Controle Biológico de Pragas",
                    "Métodos naturais para proteger suas plantas contra pragas.",
                    "O controle biológico utiliza organismos vivos para combater pragas e doenças no jardim sem o uso de produtos químicos nocivos.\r\n\r\n" +
                    "Insetos benéficos como joaninhas, vespas parasitóides e nematoides auxiliam no controle natural de pulgões, lagartas e outros inimigos das plantas.\r\n\r\n" +
                    "Além disso, a introdução de fungos e bactérias específicas pode fortalecer a resistência das plantas e promover um equilíbrio saudável do ecossistema do solo.\r\n\r\n" +
                    "Essa técnica avançada exige monitoramento constante e conhecimento detalhado sobre as espécies envolvidas, mas oferece uma alternativa sustentável e eficiente para a proteção das culturas."
                )
            };


            Sections = new List<(string, string, List<Hint>)>
            {
                ("Irrigação", "Dicas sobre métodos eficientes de irrigação.", IrrigacaoTips),
                ("Plantio", "Técnicas e truques para um plantio bem-sucedido.", PlantioTips),
                ("Manutenção", "Cuidados essenciais para manter seu jardim saudável.", ManutencaoTips),
                ("Avançado", "Desafios para jardineiros experientes.", AvancadoTips)
            };

            EstacoesHints = new Dictionary<string, string>
            {
                {
                    "Primavera",
                    "<strong>Preparando seu jardim para a primavera</strong><br><br>" +
                    "A primavera marca o despertar da natureza após o inverno, sendo o momento ideal para iniciar novos plantios, revitalizar o solo e estimular o crescimento das plantas. A combinação de aumento da luminosidade, chuvas mais regulares e temperaturas amenas cria um ambiente propício ao desenvolvimento vegetativo e floral.<br><br>" +
                    "• <strong>Revitalize o solo:</strong> Remexa a terra e incorpore adubos orgânicos, como esterco curtido, húmus de minhoca ou compostagem caseira. Isso melhora a estrutura do solo e aumenta a retenção de nutrientes e umidade. <em>(Fonte: Embrapa, 2020)</em><br>" +
                    "• <strong>Corrija o pH:</strong> Utilize calcário dolomítico ou sulfato de alumínio conforme a necessidade, preferencialmente após análise do solo. Um pH ideal (entre 6,0 e 6,5) favorece a absorção de macro e micronutrientes. <br><em>(Fonte: Instituto Agronômico de Campinas)</em><br>" +
                    "• <strong>Escolha plantas sazonais:</strong> Priorize espécies que florescem bem nessa estação, como petúnias, cravos, margaridas, manjericão, tomate-cereja e girassol. Essas espécies aproveitam melhor a energia solar e respondem com maior vigor. <br><em>(Fonte: Sociedade Brasileira de Floricultura)</em><br>" +
                    "• <strong>Planeje o layout do jardim:</strong> Agrupe plantas com necessidades semelhantes de luz e irrigação. Isso facilita a manutenção e favorece a saúde geral das espécies.<br>" +
                    "• <strong>Reforce a irrigação:</strong> A primavera pode apresentar variações climáticas. Regue no início da manhã ou no fim da tarde para reduzir a evaporação, evitando encharcamentos e doenças fúngicas. <br><em>(Fonte: Manual do Cultivo Sustentável, UFV)</em><br>" +
                    "• <strong>Controle biológico de pragas:</strong> Realize inspeções frequentes. Caldas naturais como bordalesa, extrato de alho e óleo de neem são eficazes contra pulgões, cochonilhas e ácaros. <br><em>(Fonte: Agroecologia no Brasil, 2021)</em><br>" +
                    "• <strong>Adubação de manutenção:</strong> A cada 15 a 20 dias, aplique fertilizantes equilibrados, como NPK 10-10-10 ou específicos para flores. Isso garante um florescimento uniforme e prolongado. <br><em>(Fonte: EMBRAPA Hortaliças)</em><br>" +
                    "• <strong>Podas de formação:</strong> Retire folhas secas e galhos malformados para estimular brotações vigorosas e manter o aspecto visual do jardim.<br><br>" +
                    "Como já dizia Luther Burbank, um dos maiores horticultores do século XX: <em>“A flor é a poesia da reprodução vegetal”</em>. Ao cuidar bem do seu jardim na primavera, você não só promove beleza, mas também contribui para a saúde ambiental e o equilíbrio do ecossistema local."

                },
                {
                    "Verão",
                    "<strong>Cuidados com o jardim no verão</strong><br><br>" +
                    "O verão é uma estação marcada por temperaturas elevadas, intensa radiação solar e maior evaporação de água do solo. Esses fatores exigem uma atenção redobrada com a hidratação e o sombreamento das plantas, a fim de garantir sua saúde e produtividade.<br><br>" +
                    "• <strong>Reforce a irrigação:</strong> A evaporação é mais intensa no verão. Regue as plantas diariamente, preferencialmente no início da manhã ou ao entardecer, evitando horários de sol forte. Utilize regadores de bico fino ou sistemas de gotejamento para evitar o desperdício.<br><em>(Fonte: EMBRAPA Hortaliças)</em><br>" +
                    "• <strong>Mulching (cobertura morta):</strong> Aplique palha, folhas secas ou cascas de madeira ao redor das plantas. Essa técnica reduz a evaporação, regula a temperatura do solo e inibe o crescimento de plantas daninhas.<br><em>(Fonte: Manual Agroecológico, FAO)</em><br>" +
                    "• <strong>Evite podas drásticas:</strong> Podas severas expõem os galhos ao sol forte, causando queimaduras. Realize apenas podas leves de manutenção e remoção de galhos secos.<br>" +
                    "• <strong>Utilize sombrites ou telas:</strong> Cultivos sensíveis ao sol direto podem se beneficiar de sombrites (30% a 50% de sombreamento), especialmente durante ondas de calor.<br><em>(Fonte: Instituto Agronômico de Campinas)</em><br>" +
                    "• <strong>Adubação equilibrada:</strong> O calor acelera o metabolismo das plantas, aumentando a demanda por nutrientes. Aplique adubos orgânicos ou fertilizantes balanceados (NPK 15-10-15, por exemplo) com intervalo quinzenal.<br><em>(Fonte: UFV - Boletim Técnico de Cultivo)</em><br>" +
                    "• <strong>Vigilância contra pragas:</strong> As altas temperaturas favorecem a proliferação de pragas como pulgões, lagartas e ácaros. Inspecione o jardim regularmente e, se necessário, aplique soluções naturais como óleo de neem ou extrato de pimenta.<br><em>(Fonte: Agroecologia no Brasil)</em><br>" +
                    "• <strong>Evite o uso excessivo de vasos escuros:</strong> Vasos pretos ou de cores escuras absorvem mais calor, aquecendo demais o sistema radicular. Prefira vasos claros ou proteja os recipientes com materiais isolantes.<br><br>" +
                    "O botânico inglês John Lindley dizia: <em>“A natureza nunca se apressa, mas tudo é realizado.”</em> No verão, a paciência e os cuidados constantes com o jardim garantem que a natureza retribua com vigor, beleza e vitalidade."

                },
                {
                    "Outono",
                    "<strong>Preparação para a queda das folhas</strong><br><br>" +
                    "O outono marca uma transição importante no ciclo das plantas, com a queda natural das folhas e redução gradual da atividade vegetativa. Esse é um momento estratégico para preparar o jardim para o inverno e revitalizar o solo com nutrientes naturais.<br><br>" +
                    "• <strong>Aproveite as folhas caídas para compostagem:</strong> Folhas secas são uma excelente base para compostagem. Ao misturá-las com restos verdes (como cascas de frutas), você cria um adubo orgânico rico em nutrientes.<br><em>(Fonte: EMBRAPA - Sistema de Compostagem Doméstica)</em><br>" +
                    "• <strong>Faça aeração do solo:</strong> Revolver levemente o solo com uma enxada ou garfo facilita a penetração de água e ar, essenciais para as raízes durante os meses frios que se aproximam.<br><em>(Fonte: UFPR - Manual de Horticultura)</em><br>" +
                    "• <strong>Adube com matéria orgânica:</strong> Este é o momento ideal para aplicar húmus de minhoca, esterco curtido ou compostos naturais que irão agir lentamente e fortalecer o solo para a primavera.<br><em>(Fonte: SENAR - Curso de Jardinagem Sustentável)</em><br>" +
                    "• <strong>Faça podas de formação e limpeza:</strong> Remover ramos doentes ou mal posicionados previne a disseminação de fungos e melhora a estrutura da planta antes da dormência.<br><em>(Fonte: Instituto Biológico de São Paulo)</em><br>" +
                    "• <strong>Plante espécies de clima ameno:</strong> Algumas hortaliças como alface, rúcula e couve crescem bem com as temperaturas mais baixas do outono.<br><em>(Fonte: EPAGRI - Boletim Técnico de Cultivo de Hortaliças)</em><br><br>" +
                    "O jardineiro inglês Alan Titchmarsh disse: <em>“Outono é o momento em que a natureza se despede com um último espetáculo — e deixa em nossas mãos a missão de preparar o palco para o próximo ato.”</em> Cuide do solo e da estrutura do seu jardim agora, e a primavera retribuirá com vigor e beleza."

                },
                {
                    "Inverno",
                    "<strong>Proteja seu jardim no inverno</strong><br><br>" +
                    "O inverno representa um período de dormência para muitas espécies vegetais. As baixas temperaturas, geadas e menor incidência solar exigem medidas de proteção e manutenção para garantir a sobrevivência e preparação para o crescimento na primavera.<br><br>" +
                    "• <strong>Utilize cobertura vegetal:</strong> Aplique uma camada espessa de palha, folhas secas ou serragem ao redor das raízes. Isso funciona como um isolante térmico natural, protegendo o solo do congelamento.<br><em>(Fonte: EMBRAPA Clima Temperado)</em><br>" +
                    "• <strong>Evite regar em excesso:</strong> No inverno, a evaporação diminui e o excesso de umidade pode causar apodrecimento radicular. Regue com moderação e apenas quando o solo estiver seco ao toque.<br><em>(Fonte: Instituto Federal Catarinense - Curso de Jardinagem)</em><br>" +
                    "• <strong>Proteja plantas sensíveis:</strong> Use estufas caseiras, coberturas plásticas, cloches ou até mesmo garrafas PET cortadas para criar microclimas mais quentes para espécies tropicais ou delicadas.<br><em>(Fonte: UFSM - Horticultura)</em><br>" +
                    "• <strong>Poda de limpeza:</strong> Remova galhos secos, doentes ou danificados para evitar o acúmulo de fungos e pragas. A poda também melhora a circulação de ar, essencial em climas frios e úmidos.<br><em>(Fonte: SEBRAE - Boletim de Jardinagem)</em><br>" +
                    "• <strong>Evite o uso de fertilizantes nitrogenados:</strong> Esses estimulam o crescimento de brotos tenros, que são mais suscetíveis ao frio. Prefira adubações ricas em potássio e fósforo, que fortalecem as raízes.<br><em>(Fonte: Instituto Biológico de São Paulo)</em><br>" +
                    "• <strong>Transplantes e replantios:</strong> Evite durante o inverno, pois as plantas estão menos ativas e a recuperação é mais lenta. Se necessário, faça com muito cuidado e regue moderadamente.<br><br>" +
                    "O horticultor francês Jean-Baptiste de La Quintinie escreveu: <em>“O inverno é o tempo em que o jardineiro prepara, mais com paciência do que com ferramentas, os milagres da primavera.”</em> Com cuidado e planejamento, seu jardim pode atravessar essa estação com força renovada para florescer com intensidade nos meses seguintes."

                }
            };
        }

        public class Hint
        {
            public string Nivel { get; set; }
            public string Titulo { get; set; }
            public string Descricao { get; set; }
            public string TextoCompleto { get; set; }

            public Hint(string nivel, string titulo, string descricao, string textoCompleto = null)
            {
                Nivel = nivel;
                Titulo = titulo;
                Descricao = descricao;
                TextoCompleto = textoCompleto ?? descricao;
            }

        }
    }
}
