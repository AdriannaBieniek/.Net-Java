namespace Okienko;

using Bieniek_plecak;
using NUnit.Framework.Internal;
using System.ComponentModel;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }
    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }
    private void podsumowanie_TextChanged(object sender, EventArgs e)
    {

    }
    private void button1_Click(object sender, EventArgs e)
    {
        int ile_przedmiotow = Convert.ToInt32(numericUpDown1.Value);//Czytamy z UpDown
        int udzwig = Convert.ToInt32(numericUpDown2.Value);

        // int ile_przedmiotow = Convert.ToInt32(textBox2.Text); //Czytaja z textboxow
        //int udzwig = Convert.ToInt32(textBox5.Text);

        Backpack backpack = new Backpack(ile_przedmiotow);
        int[,] przedmioty = backpack.CreateItems(ile_przedmiotow); //Tworzymy tablice przedmiotow
        int[] wziete = backpack.TakenItems(ile_przedmiotow, udzwig, przedmioty); //Tworzymy liste wzietych

        textBox3.Text = "Lp.\tWaga\tCennosc\tBiore?\r\n";

        for (int i = 0; i < ile_przedmiotow; i++)
        {
            textBox3.Text += (i + 1 + "\t" + przedmioty[i, 1].ToString() + "\t" + przedmioty[i, 0].ToString() + "\t" + wziete[i] + "\r\n");
        }

        int ilosc_wzietych = backpack.taken_amount; //Ile przedmiotow wzielismy
        int cennosc = backpack.reward; //Cennosc wzietych przedmiotow
        int pozostaly_udzwig = udzwig;

        progressBar1.Maximum = ile_przedmiotow;
        progressBar1.Step = 1;
        progressBar1.Value = 0;
        for (int i = 0; i < ile_przedmiotow; i++)
        {
            if (wziete[i] == 1)
            {
                progressBar1.Value += 1; //ilosc wzietych do ilosci wszystkich przedmiotow
                pozostaly_udzwig = pozostaly_udzwig - przedmioty[i, 1];

            }

        }

        double stosunek = ((double)ilosc_wzietych / (double)ile_przedmiotow) * 100;
        podsumowanie.Text = "Podsumowanie\r\nIlosc wzietych przedmiotow: " + ilosc_wzietych;
        podsumowanie.Text += "\r\nCennosc: " + cennosc;
        podsumowanie.Text += "\r\n% Ilosc zabranych przedmiotow: " + stosunek.ToString("0.00") + "%";
        podsumowanie.Text += "\r\nPozostaly udzwig: " + pozostaly_udzwig;
    }


}