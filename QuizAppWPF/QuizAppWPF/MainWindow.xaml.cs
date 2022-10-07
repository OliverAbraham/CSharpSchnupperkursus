using System.Collections.Generic;
using System.Windows;

namespace QuizAppWPF
{
    public partial class MainWindow : Window
    {
        private List<Frage> _quizfragen = new List<Frage>()
        {
            new Frage("", "", "", "", "", ""),

            new Frage("Welche Naturschutzorganisation führt einen Panda in ihrem Logo?", 
                "A Greenpeace", 
                "B Robin Wood", 
                "C WWF", 
                "D NABU",
                "C"),

            new Frage("Welche Tiere übernehmen in George Orwells 'Farm der Tiere' das Kommando auf dem Hof?", 
                "A Die Pferde",
                "B Die Schweine",
                "C Die Hunde",
                "D Die Schafe",
                "B"),

            new Frage("Wie heißt die größte heimische Wespenart?", 
                "A Hornisse",
                "B Deutsche Wespe",
                "C Biene",
                "D Hummel",
                "A"),

            new Frage("Welche Frucht schoss Wilhelm Tell mit der Armbrust vom Kopf seines Sohnes?", 
                "A Banane",
                "B Birne",
                "C Apfel",
                "D Kirsche",
                "C")
        };

        private int _aktuelleFrage = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ZeigeNächsteFrage();
        }

        private void ZeigeNächsteFrage()
        {
            if (Frage is null)
                return;

            _aktuelleFrage++;
            if (_aktuelleFrage >= _quizfragen.Count)
            {
                Frage.Text = "Ende";
                AntwortA.Visibility = Visibility.Collapsed;
                AntwortB.Visibility = Visibility.Collapsed;
                AntwortC.Visibility = Visibility.Collapsed;
                AntwortD.Visibility = Visibility.Collapsed;
            }
            else
            {
                Frage.Text       = _quizfragen[_aktuelleFrage].Fragetext;
                AntwortA.Content = _quizfragen[_aktuelleFrage].Antworten[1];
                AntwortB.Content = _quizfragen[_aktuelleFrage].Antworten[2];
                AntwortC.Content = _quizfragen[_aktuelleFrage].Antworten[3];
                AntwortD.Content = _quizfragen[_aktuelleFrage].Antworten[4];
            }
        }

        private void AntwortA_Click(object sender, RoutedEventArgs e) { Reaktion("A"); }
        private void AntwortB_Click(object sender, RoutedEventArgs e) { Reaktion("B"); }
        private void AntwortC_Click(object sender, RoutedEventArgs e) { Reaktion("C"); }
        private void AntwortD_Click(object sender, RoutedEventArgs e) { Reaktion("D"); }

        private void Reaktion(string tipp)
        {
            if (_quizfragen[_aktuelleFrage].RichtigeAntwort == tipp)
                MessageBox.Show("Richtig !");
            else
                MessageBox.Show("Leider falsch !");
            ZeigeNächsteFrage();
        }
    }

    internal class Frage
    {
        public string   Fragetext       { get; set; }
        public string[] Antworten       { get; set; }
        public string   RichtigeAntwort { get; set; }

        public Frage(string fragetext, string antwortA, string antwortB, string antwortC, string antwortD, string richtigeAntwort)
        {
            Fragetext       = fragetext;
            Antworten       = new string[5];
            Antworten[1]    = antwortA;
            Antworten[2]    = antwortB;
            Antworten[3]    = antwortC;
            Antworten[4]    = antwortD;
            RichtigeAntwort = richtigeAntwort;
        }
    }
}
