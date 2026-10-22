// BELAJAR METHOD 

static void Salam()
{
    Console.WriteLine("Hello World");
}


// memanggil method tanpa return value dan tanpa parameter
Salam();


// METHOD DENGAN PARAMETER
static void Sapa(string nama)
{
    Console.WriteLine("Halo " + nama);
}

//memanggil method dengan parameter
Sapa("Budi");


// METHOD DENGAN RETURN VALUE
static int Tambah(int a, int b)
{
    return a + b; 
}

// memanggil method dengan return value 
Console.WriteLine(Tambah(5, 10)); 