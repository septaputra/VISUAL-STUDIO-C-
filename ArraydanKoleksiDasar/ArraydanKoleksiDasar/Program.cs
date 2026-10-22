// BELAJAR ARRAY DAN DASAR KOLEKSI 


// ARRAY 

string[] namaBuah = { "Apel", "Mangga", "Jeruk" };
Console.WriteLine(namaBuah[0]);
Console.WriteLine(namaBuah[2]);

// array dengan menggunakan perulangan foreach
foreach (string buah in namaBuah) 
{
    Console.WriteLine(buah);
}





// KOLEKSI DASAR

List<string> namaSiswa = new List<string>();

namaSiswa.Add("Budi");
namaSiswa.Add("Anton");
namaSiswa.Add("Siti");

foreach (string siswa in namaSiswa)
{
    Console.WriteLine(siswa);
}