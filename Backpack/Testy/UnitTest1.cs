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
    [Test]
    public void bierzemy_jeden_przedmiot()
    {
        int i = 1;
        Backpack backpack = new Backpack(i);
        int[,] pom = backpack.CreateItems(i);
        int udzwig = 10;
        backpack.TakenItems(i, udzwig, pom);
        Assert.AreEqual(1, backpack.taken_amount);
    }

    [Test]
    public void bierzemy_kilka_przedmiotow() //jezeli jakis przedmiot mniejszy niz udzwig to cos bierzemy
    {

        Random random = new Random();
        int udzwig = random.Next(10, 20);

        int ile_przedmiotow_max = 10;
        Backpack backpack = new Backpack(ile_przedmiotow_max);

        int[,] pom = backpack.CreateItems(ile_przedmiotow_max);
        backpack.TakenItems(ile_przedmiotow_max, udzwig, pom);
        for (int i = 0; i < ile_przedmiotow_max; i++)
        {
            if (backpack.items[i,1] < udzwig)
            {
                Assert.LessOrEqual(1,backpack.taken_amount);
            }
        }
    }

}
