// Belajar Percabangan (IF, ELSE, ELSE IF DAN SWITCH)

// IF
int umur = 13;

if (umur >= 17)
{ 
    Console.WriteLine("Anda Boleh Membuat KTP");
}

// ELSE 
if (umur >= 17)
{
    Console.WriteLine("Anda Boleh Membuat KTP");
}
else
{
    Console.WriteLine("Anda Belum Boleh Membuat KTP");
}

// ELSE IF

int nilai = 85;

if (nilai >= 90)
{
    Console.WriteLine("grade A");

}
else if (nilai >= 75)
{
    Console.WriteLine("grade B");

}
else 
{ 
        Console.WriteLine("grade C");

}

// SWITCH 

string Hari = "minggu"; 

switch (Hari)
{
    case "Senin":
        Console.WriteLine("Hari pertama");
        break;
    case "minggu":
        Console.WriteLine("Hari ke tujuh");
        break;

    default: 
        Console.WriteLine("Hari lain"); 
        break;
} 
