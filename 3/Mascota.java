import java.util.Scanner;
public class Mascota {
    private String nombre,tipo,raza,tamaño,peso;
    private int edad;
    public Mascota(){
        this.nombre="";
        this.tipo="";
        this.raza="";
        this.tamaño="";
        this.peso="";
        this.edad=0;
    }
    public Mascota(String a, String b, String c, String d, String e, int f){
        this.nombre=a;
        this.tipo=b;
        this.raza=c;
        this.tamaño=d;
        this.peso=e;
        this.edad=f;
    }
    public void leer(){
        Scanner sc=new Scanner(System.in);
        System.out.println("\n // LECTURA DE DATOS MASCOTA //");
        System.out.print("\tInserte nombre => ");this.nombre=sc.nextLine();
        System.out.print("\tInserte tipo => ");this.tipo=sc.nextLine();
        System.out.print("\tInserte edad => ");this.edad=sc.nextInt();
        sc.nextLine();
        System.out.print("\tInserte raza => ");this.raza=sc.nextLine();
        System.out.print("\tInserte tamaño => ");this.tamaño=sc.nextLine();
        System.out.print("\tInserte peso => ");this.peso=sc.nextLine();
    }
    public void mostrar(){
        System.out.println("\n\n// Mascota: "+nombre+" //");
        System.out.print("Tipo: "+tipo+" // Edad: "+edad+" // Raza:"+raza+"\nTamaño: "+tamaño+" // Peso:"+peso);
    }
    public String getTipo() {return tipo;}
    public int getEdad() {return edad;}
    public String getRaza() {return raza;}
    public String getNombre() {return nombre;}
    public String getPeso() {return peso;}
}
