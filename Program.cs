using v21;

Console.Write("Masukkan panjangnya : ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Masukkan lebarnya : ");
int l = Convert.ToInt32(Console.ReadLine());

Rumus rumus = new Rumus();
int luas = rumus.persegiPanjang(p,l);

Console.WriteLine($"persegi panjang dengan panjang = {p} dan lebar = {l} maka luasnya adalah {luas}");