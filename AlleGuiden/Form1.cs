namespace AlleGuiden
{
    public partial class Form1 : Form
    {
        private int BetygsIndex = 0;
        private List<string> �mnen = new List<string>
        {
            "Bild", "Biologi", "Engelska", "Fysik", "Geografi",
            "Hkk", "Historia", "Idrott", "Kemi", "Matematik",
            "Moderna Spr�k", "Modersm�l", "Musik", "Religion",
            "Samh�llskunskap", "Sl�jd", "Svenska/Svenska som andra Spr�k", "Teknik"
        };

        Dictionary<string, (int lowest, int average, int midAverage)> programMeritValues = new Dictionary<string, (int, int, int)>
{
    // H�gskolef�rberedande programs
    { "Ekonomi", (172, 251, 211) },
    { "Natur", (178, 273, 226) },
    { "Samh�ll", (154, 240, 197) },
    { "Teknik", (143, 252, 197) },

    // Yrkesprogram
    { "Barn", (105, 192, 148) },
    { "Bygg", (86, 175, 131) },
    { "El", (140, 205, 172) },
    { "Fordon", (109, 176, 143) },
    { "F�rs�ljning", (140, 175, 157) },
    { "Industri", (93, 181, 137) },
    { "Resturang", (83, 185, 134) },
    { "V�rd", (105, 197, 151) }
};
        Dictionary<string, List<(string �mne, string betyg)>> program�mnesKrav = new Dictionary<string, List<(string, string)>>
{
    // Yrkesprogram
    { "Industritekniska", new List<(string, string)> { ("Teknik", "E") } },
    { "Fordon och Transport", new List<(string, string)> { ("Teknik", "E") } },
    { "Handels- och administration", new List<(string, string)> { ("Hkk", "E") } },
    { "El- och energi", new List<(string, string)> { ("Fysik", "E"), ("Teknik", "E") } },
    { "Barn- och Fritidsprogrammet", new List<(string, string)> { ("Samh�llskunskap", "E") } },
    { "V�rd- och omsorgsprogrammet", new List<(string, string)> { ("Samh�llskunskap", "E"), ("Biologi", "E") } },
    { "Restaurang- och livsmedel", new List<(string, string)> { ("Hkk", "E") } },
    { "Bygg- och anl�ggning", new List<(string, string)> { ("Teknik", "E") } },

    // H�gskolef�rberedande program
    { "Teknik", new List<(string, string)> { ("Fysik", "C"), ("Matematik", "C") } },
    { "Ekonomi", new List<(string, string)> { ("Matematik", "D") } },
    { "Estetiska", new List<(string, string)> { ("Musik", "C"), ("Bild", "C") } },
    { "Naturvetenskap", new List<(string, string)> { ("Fysik", "C"), ("Kemi", "C"), ("Biologi", "C") } },
    { "Samh�llsvetenskapliga", new List<(string, string)> { ("Samh�llskunskap", "C") } },
    { "Humanistiska", new List<(string, string)> { ("Moderna Spr�k", "E") } }
};

        private Dictionary<string, string> �mnesBetyg = new Dictionary<string, string>();
        private Dictionary<string, double> BetygV�rden = new Dictionary<string, double>
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
            foreach (string cls in �mnen)
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
            if (BetygsIndex >= �mnen.Count)
            {
                MessageBox.Show("Alla betyg har blivit insatta.");
                MeritBer�kning(); // Trigger final calculation after all grades are entered
                return;
            }

            Button betygsknapp = sender as Button;
            if (betygsknapp == null) return;

            string betyg = betygsknapp.Text;
            string currentClass = �mnen[BetygsIndex];

            merit.Add(betyg);
            �mnesBetyg[currentClass] = betyg;

            listBoxBetyg.Items[BetygsIndex] = $"{currentClass}: {betyg}";
            BetygsIndex++;

            if (BetygsIndex < �mnen.Count)
            {
                listBoxBetyg.SelectedIndex = BetygsIndex;
            }
            else
            {
                MessageBox.Show("Alla betyg �r insatta.");
                MeritBer�kning(); // Final calculation after the last grade
            }
        }

        private void MeritBer�kning()
        {
            double totaltMeritV�rde = 0;

            foreach (var betyg in merit)
            {
                if (BetygV�rden.ContainsKey(betyg))
                {
                    totaltMeritV�rde += BetygV�rden[betyg];
                }
                else
                {
                    MessageBox.Show($"Ogiltigt betyg: {betyg}");
                }
            }

            tbxMerit.Text = totaltMeritV�rde.ToString();
            k�rn�mnesKontroll();
            ProgramAlternativ(); // Finalize program suggestions based on grades
        }

        private void k�rn�mnesKontroll()
        {
            listBoxF.Items.Clear();

            string[] k�rn�mnen = { "Matematik", "Svenska/Svenska som andra Spr�k", "Engelska" };
            foreach (string �mne in k�rn�mnen)
            {
                if (�mnesBetyg.ContainsKey(�mne) && �mnesBetyg[�mne] == "F")
                {
                    listBoxF.Items.Add($"{�mne}: F");
                }
            }
        }

        private void ProgramAlternativ()
        {
            listboxProgram.Items.Clear();

            // 1. K�rn�mneskrav
            string[] k�rn�mnen = { "Svenska/Svenska som andra Spr�k", "Matematik", "Engelska" };
            bool k�rn�mnenGodk�nda = k�rn�mnen.All(�mne =>
                �mnesBetyg.ContainsKey(�mne) &&
                �mnesBetyg[�mne] != "F"
            );

            if (!k�rn�mnenGodk�nda)
            {
                listboxProgram.Items.Add("Du har inte klarat k�rn�mnena och beh�ver s�ka Introduktionsprogram (IM).");
                return;
            }

            // 2. Antal godk�nda �mnen
            int godk�nda�mnen = �mnesBetyg.Values.Count(betyg =>
                BetygV�rden.ContainsKey(betyg) && BetygV�rden[betyg] > 0
            );

            if (godk�nda�mnen < 8)
            {
                listboxProgram.Items.Add("Du har f�rre �n 8 godk�nda �mnen och beh�ver s�ka Introduktionsprogram (IM).");
                return;
            }

            // 3. Meritv�rde
            double meritpo�ng = �mnesBetyg.Values
                .Where(betyg => BetygV�rden.ContainsKey(betyg))
                .Sum(betyg => BetygV�rden[betyg]);

            if (meritpo�ng < 120.0)
            {
                listboxProgram.Items.Add("Du har mindre �n 120 i meritv�rde och kan inte s�ka h�gskolef�rberedande program.");
                return;
            }

            // 4. Kontrollera programkrav
            foreach (var program in program�mnesKrav)
            {
                string programNamn = program.Key;
                var krav = program.Value;

                var saknadeEllerOtillr�ckligaKrav = krav.Where(k =>
                    !�mnesBetyg.ContainsKey(k.�mne) ||
                    BetygV�rden[�mnesBetyg[k.�mne]] < BetygV�rden[k.betyg]
                ).ToList();

                if (saknadeEllerOtillr�ckligaKrav.Count == 0)
                {
                    listboxProgram.Items.Add($"{programNamn} - Du uppfyller alla krav!");
                }
                else
                {
                    foreach (var k in saknadeEllerOtillr�ckligaKrav)
                    {
                        listboxProgram.Items.Add($"{programNamn} - F�r {k.�mne}: Minimikrav {k.betyg}, du har {�mnesBetyg.GetValueOrDefault(k.�mne, "F")}");
                    }
                }
            }

        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            merit.Clear();
            �mnesBetyg.Clear();
            listBoxF.Items.Clear();
            listboxProgram.Items.Clear();

            BetygsIndex = 0;
            listBoxBetyg.Items.Clear();
            foreach (var �mne in �mnen)
            {
                listBoxBetyg.Items.Add(�mne);
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


