namespace Testy;
using Bieniek_plecak;
public class Tests
{
    [Test]
    public void poprawna_ilosc_przedmiotow() //tworzymy dobra ilosc przedmiotow
    {
        int n = 10;
        for (int i = 0; i < n; i++)
        {
            Backpack backpack = new Backpack(i);
            backpack.CreateItems(i);
            Assert.AreEqual(i,backpack.items.GetLength(0));
        }
    }

    [Test]
    public void nic_nie_bierzemy()  //przy udzwigu <=1 nie pakujemy nic do plecaka
    {
        int ile_przedmiotow = 5;
        Backpack backpack = new Backpack(ile_przedmiotow);
        int[,] pom = backpack.CreateItems(ile_przedmiotow);
        for (int i = -10; i <= 0; i++)
        {
            backpack.TakenItems(ile_przedmiotow,i, pom);
            Assert.AreEqual(0, backpack.taken_amount);

        }
    }

    [Test]
    public void nic_nie_bierzemy2()  //przy udzwigu <=1 nie pakujemy nic do plecaka
    {
        int ile_przedmiotow = 5;
        Backpack backpack = new Backpack(ile_przedmiotow);
        int[,] pom = backpack.CreateItems(ile_przedmiotow);
        for (int i = -10; i <= 0; i++) //i to udzwig
        {
            backpack.TakenItems(ile_przedmiotow, i, pom);
            for (int j = 0; j < ile_przedmiotow; j++)
            {
                Assert.AreEqual(0, backpack.taken.GetValue(j));
            }
            }
    }


}
