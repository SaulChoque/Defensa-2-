using System;
public class Mascota {
    private string nombre,tipo,raza,tamaño,peso;
    private int edad;
    public Mascota(){
        this.nombre="";
        this.tipo="";
        this.raza="";
        this.tamaño="";
        this.peso="";
        this.edad=0;
    }
    public Mascota(string a, string b, string c, string d, string e, int f){
        this.nombre=a;
        this.tipo=b;
        this.raza=c;
        this.tamaño=d;
        this.peso=e;
        this.edad=f;
    }
    public void leer(){
        Console.WriteLine("\n // LECTURA DE DATOS MASCOTA //");
        Console.Write("\tInserte nombre => ");this.nombre=Console.ReadLine();;
        Console.Write("\tInserte tipo => ");this.tipo=Console.ReadLine();;
        Console.Write("\tInserte edad => ");this.edad=int.Parse(Console.ReadLine());
        Console.Write("\tInserte raza => ");this.raza=Console.ReadLine();;
        Console.Write("\tInserte tamaño => ");this.tamaño=Console.ReadLine();;
        Console.Write("\tInserte peso => ");this.peso=Console.ReadLine();;
    }
    public void mostrar(){
        Console.WriteLine("\n\n// Mascota: "+nombre+" //");
        Console.Write("Tipo: "+tipo+" // Edad: "+edad+" // Raza:"+raza+"\nTamaño: "+tamaño+" // Peso:"+peso);
    }
    public string Nombre {get{return this.nombre;}set{this.nombre = value;}}
    public string Tipo {get{return this.tipo;}set{this.tipo = value;}}
    public string Raza {get{return this.raza;}set{this.raza = value;}}
    public string Tamaño {get{return this.tamaño;}set{this.tamaño = value;}}
    public string Peso {get{return this.peso;}set{this.peso = value;}}
    public int Edad {get{return this.edad;}set{this.edad = value;}}
}


