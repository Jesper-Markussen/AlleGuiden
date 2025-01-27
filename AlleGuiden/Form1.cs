namespace AlleGuiden
{
    public partial class Form1 : Form
    {
        private int BetygsIndex = 0;
        private List<string> Ämnen = new List<string>
        {
            "Bild", "Biologi", "Engelska", "Fysik", "Geografi",
            "Hkk", "Historia", "Idrott", "Kemi", "Matematik",
            "Moderna Språk", "Modersmål", "Musik", "Religion",
            "Samhällskunskap", "Slöjd", "Svenska/Svenska som andra Språk", "Teknik"
        };

        Dictionary<string, (int lowest, int average, int midAverage)> programMeritValues = new Dictionary<string, (int, int, int)>
{
    // Högskoleförberedande programs
    { "Ekonomi", (172, 251, 211) },
    { "Natur", (178, 273, 226) },
    { "Samhäll", (154, 240, 197) },
    { "Teknik", (143, 252, 197) },

    // Yrkesprogram
    { "Barn", (105, 192, 148) },
    { "Bygg", (86, 175, 131) },
    { "El", (140, 205, 172) },
    { "Fordon", (109, 176, 143) },
    { "Försäljning", (140, 175, 157) },
    { "Industri", (93, 181, 137) },
    { "Resturang", (83, 185, 134) },
    { "Vård", (105, 197, 151) }
};
        Dictionary<string, List<(string ämne, string betyg)>> programÄmnesKrav = new Dictionary<string, List<(string, string)>>
{
    // Yrkesprogram
    { "Industritekniska", new List<(string, string)> { ("Teknik", "E") } },
    { "Fordon och Transport", new List<(string, string)> { ("Teknik", "E") } },
    { "Handels- och administration", new List<(string, string)> { ("Hkk", "E") } },
    { "El- och energi", new List<(string, string)> { ("Fysik", "E"), ("Teknik", "E") } },
    { "Barn- och Fritidsprogrammet", new List<(string, string)> { ("Samhällskunskap", "E") } },
    { "Vård- och omsorgsprogrammet", new List<(string, string)> { ("Samhällskunskap", "E"), ("Biologi", "E") } },
    { "Restaurang- och livsmedel", new List<(string, string)> { ("Hkk", "E") } },
    { "Bygg- och anläggning", new List<(string, string)> { ("Teknik", "E") } },

    // Högskoleförberedande program
    { "Teknik", new List<(string, string)> { ("Fysik", "C"), ("Matematik", "C") } },
    { "Ekonomi", new List<(string, string)> { ("Matematik", "D") } },
    { "Estetiska", new List<(string, string)> { ("Musik", "C"), ("Bild", "C") } },
    { "Naturvetenskap", new List<(string, string)> { ("Fysik", "C"), ("Kemi", "C"), ("Biologi", "C") } },
    { "Samhällsvetenskapliga", new List<(string, string)> { ("Samhällskunskap", "C") } },
    { "Humanistiska", new List<(string, string)> { ("Moderna Språk", "E") } }
};

        private Dictionary<string, string> ämnesBetyg = new Dictionary<string, string>();
        private Dictionary<string, double> BetygVärden = new Dictionary<string, double>
        {
            { "A", 20 },
            { "B", 17.5 },
            { "C", 15 },
            { "D", 12.5 },
            { "E", 10 },
            { "F", 0 }
        };

        private List<string> merit = new List<string>();

        public Form1()
        {
            InitializeComponent();
            KursLista();            
        }

        private void KursLista()
        {
            listBoxBetyg.Items.Clear();
            foreach (string cls in Ämnen)
            {
                listBoxBetyg.Items.Add(cls);
            }

            if (listBoxBetyg.Items.Count > 0)
            {
                listBoxBetyg.SelectedIndex = 0;
            }
        }

        private void Betygs_Click(object sender, EventArgs e)
        {
            if (BetygsIndex >= Ämnen.Count)
            {
                MessageBox.Show("Alla betyg har blivit insatta.");
                MeritBeräkning(); // Trigger final calculation after all grades are entered
                return;
            }

            Button betygsknapp = sender as Button;
            if (betygsknapp == null) return;

            string betyg = betygsknapp.Text;
            string currentClass = Ämnen[BetygsIndex];

            merit.Add(betyg);
            ämnesBetyg[currentClass] = betyg;

            listBoxBetyg.Items[BetygsIndex] = $"{currentClass}: {betyg}";
            BetygsIndex++;

            if (BetygsIndex < Ämnen.Count)
            {
                listBoxBetyg.SelectedIndex = BetygsIndex;
            }
            else
            {
                MessageBox.Show("Alla betyg är insatta.");
                MeritBeräkning(); // Final calculation after the last grade
            }
        }

        private void MeritBeräkning()
        {
            double totaltMeritVärde = 0;

            foreach (var betyg in merit)
            {
                if (BetygVärden.ContainsKey(betyg))
                {
                    totaltMeritVärde += BetygVärden[betyg];
                }
                else
                {
                    MessageBox.Show($"Ogiltigt betyg: {betyg}");
                }
            }

            tbxMerit.Text = totaltMeritVärde.ToString();
            kärnÄmnesKontroll();
            ProgramAlternativ(); // Finalize program suggestions based on grades
        }

        private void kärnÄmnesKontroll()
        {
            listBoxF.Items.Clear();

            string[] kärnÄmnen = { "Matematik", "Svenska/Svenska som andra Språk", "Engelska" };
            foreach (string ämne in kärnÄmnen)
            {
                if (ämnesBetyg.ContainsKey(ämne) && ämnesBetyg[ämne] == "F")
                {
                    listBoxF.Items.Add($"{ämne}: F");
                }
            }
        }

        private void ProgramAlternativ()
        {
            listboxProgram.Items.Clear();

            // 1. Kärnämneskrav
            string[] kärnÄmnen = { "Svenska/Svenska som andra Språk", "Matematik", "Engelska" };
            bool kärnÄmnenGodkända = kärnÄmnen.All(ämne =>
                ämnesBetyg.ContainsKey(ämne) &&
                ämnesBetyg[ämne] != "F"
            );

            if (!kärnÄmnenGodkända)
            {
                listboxProgram.Items.Add("Du har inte klarat kärnämnena och behöver söka Introduktionsprogram (IM).");
                return;
            }

            // 2. Antal godkända ämnen
            int godkändaÄmnen = ämnesBetyg.Values.Count(betyg =>
                BetygVärden.ContainsKey(betyg) && BetygVärden[betyg] > 0
            );

            if (godkändaÄmnen < 8)
            {
                listboxProgram.Items.Add("Du har färre än 8 godkända ämnen och behöver söka Introduktionsprogram (IM).");
                return;
            }

            // 3. Meritvärde
            double meritpoäng = ämnesBetyg.Values
                .Where(betyg => BetygVärden.ContainsKey(betyg))
                .Sum(betyg => BetygVärden[betyg]);

            if (meritpoäng < 120.0)
            {
                listboxProgram.Items.Add("Du har mindre än 120 i meritvärde och kan inte söka högskoleförberedande program.");
                return;
            }

            // 4. Kontrollera programkrav
            foreach (var program in programÄmnesKrav)
            {
                string programNamn = program.Key;
                var krav = program.Value;

                var saknadeEllerOtillräckligaKrav = krav.Where(k =>
                    !ämnesBetyg.ContainsKey(k.ämne) ||
                    BetygVärden[ämnesBetyg[k.ämne]] < BetygVärden[k.betyg]
                ).ToList();

                if (saknadeEllerOtillräckligaKrav.Count == 0)
                {
                    listboxProgram.Items.Add($"{programNamn} - Du uppfyller alla krav!");
                }
                else
                {
                    foreach (var k in saknadeEllerOtillräckligaKrav)
                    {
                        listboxProgram.Items.Add($"{programNamn} - För {k.ämne}: Minimikrav {k.betyg}, du har {ämnesBetyg.GetValueOrDefault(k.ämne, "F")}");
                    }
                }
            }

        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            merit.Clear();
            ämnesBetyg.Clear();
            listBoxF.Items.Clear();
            listboxProgram.Items.Clear();

            BetygsIndex = 0;
            listBoxBetyg.Items.Clear();
            foreach (var ämne in Ämnen)
            {
                listBoxBetyg.Items.Add(ämne);
            }

            if (listBoxBetyg.Items.Count > 0)
            {
                listBoxBetyg.SelectedIndex = 0;
            }

            tbxMerit.Clear();
            MessageBox.Show("Alla betyg har rensats!");
        }


        

        private void BtnA_Click(object sender, EventArgs e)
        {

        }

        private void BtnB_Click(object sender, EventArgs e)
        {

        }

        private void BtnC_Click(object sender, EventArgs e)
        {

        }

        private void BtnD_Click(object sender, EventArgs e)
        {

        }

        private void BtnE_Click(object sender, EventArgs e)
        {

        }

        private void BtnF_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBoxBetyg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


