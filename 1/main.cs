using System;
public class main {
    public static void Main(string[] args) {
        Mascota m1=new Mascota("Sasha", "gato", "Atigrado", "25cm", "4kg", 4);
        Mascota m2=new Mascota("Marcy", "perro", "Shiba", "100cm", "12kg", 3);
        Mascota m3=new Mascota("Anne", "perro", "Ridgeback", "110cm", "16kg", 3);
        Mascota m4=new Mascota("Ruby", "pez", "Betta", "8cm", "3gr", 3);
        Mascota m=new Mascota();
        Mascota []mr ={m,m1,m2,m3,m4};
        Console.WriteLine("\na)	Instanciar 4 objetos Mascota, de diferente forma bajo constructores. Mostrar los objetos.");
        m1.mostrar();m2.mostrar();m3.mostrar();m4.mostrar();
        Console.WriteLine("\nb)	Realizar la lectura de datos de un objeto y mostrar.");
        m.leer();m.mostrar();
        Console.WriteLine("\n\nc)	Verificar si en los objetos se tiene a la mascota con raza X. ");
        Console.Write("Ingrese la raza a buscar => ");string x=Console.ReadLine();;
        Console.WriteLine("- Resultados: ");
        for (int i = 0; i < mr.Length; i++) {
            if(mr[i].Raza==(x)){
                Console.WriteLine("\tLa mascota "+mr[i].Nombre+" es "+mr[i].Raza);
            }
        }
        Console.WriteLine("\nd)	Mostrar a las mascotas de tipo X mayores a la edad Y. ");
        Console.Write("Ingrese el tipo => "); x=Console.ReadLine();
        Console.Write("Ingrese la edad a comparar => ");int y=int.Parse(Console.ReadLine());
        Console.WriteLine("- Resultados: ");
        for (int i = 0; i < mr.Length; i++) {
            if(mr[i].Tipo==(x) && mr[i].Edad>y){
                Console.WriteLine("\tLa mascota "+mr[i].Nombre+" es mayor a "+mr[i].Edad);
            }
        }
        Console.WriteLine("\ne)	Verificar si la mascota con nombre X se encuentra con un peso bajo, un peso normal o sobrepeso.");
        Console.Write("Ingrese el nombre de la mascota a buscar => "); x=Console.ReadLine();
        Console.Write("Ingrese el tamaño de la mascota \n1 = pequeño\n2 = mediano\n3 = grande\n => ");String z;
        switch (int.Parse(Console.ReadLine())) {
        case 1:
            z="pequeño";
            break;
        case 2:
            z="mediano";
            break;
        case 3:
            z="grande";
            break;
        default:
            z="indeterminado";
            break;
        }
        int a;
        bool c=false;
        for (int i = 0; i < mr.Length; i++) {
            if(mr[i].Nombre==(x)){
                a=int.Parse(mr[i].Peso.Substring(0, (mr[i].Peso.Length-2)));
                switch(z){ 
                    case "pequeño":
                        if(a>15) c=true;
                        else c=false;
                        break;
                    case "mediano":
                        if(a>25) c=true;
                        else c=false;
                        break;
                    case "grande":
                        if(a>45) c=true;
                        else c=false;
                        break;
                }
                if(c) Console.WriteLine("La mascota "+mr[i].Nombre+" tiene sobrepeso; "+'"'+mr[i].Peso+'"');
                else Console.WriteLine("La mascota "+mr[i].Nombre+" no tiene sobrepeso; "+'"'+mr[i].Peso+'"');
                break;
            }
        }
    }
}
