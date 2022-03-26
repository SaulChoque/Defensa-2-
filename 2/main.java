import java.util.Scanner;

public class main {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        Mascota m1=new Mascota("Sasha", "gato", "Atigrado", "25cm", "4kg", 4);
        Mascota m2=new Mascota("Marcy", "perro", "Shiba", "100cm", "12kg", 3);
        Mascota m3=new Mascota("Anne", "perro", "Ridgeback", "110cm", "16kg", 3);
        Mascota m4=new Mascota("Ruby", "pez", "Betta", "8cm", "3gr", 3);
        Mascota m=new Mascota();
        Mascota mr[] ={m,m1,m2,m3,m4};
        System.out.println("\na)	Instanciar 4 objetos Mascota, de diferente forma bajo constructores. Mostrar los objetos.");
        m1.mostrar();m2.mostrar();m3.mostrar();m4.mostrar();
        System.out.println("\nb)	Realizar la lectura de datos de un objeto y mostrar.");
        m.leer();m.mostrar();
        System.out.println("\n\nc)	Verificar si en los objetos se tiene a la mascota con raza X. ");
        System.out.print("Ingrese la raza a buscar => ");String x=sc.nextLine();
        System.out.println("- Resultados: ");
        for (int i = 0; i < mr.length; i++) {
            if(mr[i].getRaza().equals(x)){
                System.out.println("\tLa mascota "+mr[i].getNombre()+" es "+mr[i].getRaza());
            }
        }
        System.out.println("\nd)	Mostrar a las mascotas de tipo X mayores a la edad Y. ");
        System.out.print("Ingrese el tipo => "); x=sc.nextLine();
        System.out.print("Ingrese la edad a comparar => ");int y=sc.nextInt();
        System.out.println("- Resultados: ");
        for (int i = 0; i < mr.length; i++) {
            if(mr[i].getTipo().equals(x) && mr[i].getEdad()>y){
                System.out.println("\tLa mascota "+mr[i].getNombre()+" es mayor a "+mr[i].getEdad());
            }
        }
        sc.nextLine();
        System.out.println("\ne)	Verificar si la mascota con nombre X se encuentra con un peso bajo, un peso normal o sobrepeso.");
        System.out.print("Ingrese el nombre de la mascota a buscar => "); x=sc.nextLine();
        System.out.print("Ingrese el tamaño de la mascota \n1 = pequeño\n2 = mediano\n3 = grande\n => ");String z;
        switch (sc.nextInt()) {
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
        boolean c=false;
        for (int i = 0; i < mr.length; i++) {
            if(mr[i].getNombre().equals(x)){
                a=Integer.parseInt(mr[i].getPeso().substring(0, (mr[i].getPeso().length()-2)));
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
                if(c) System.out.println("La mascota "+mr[i].getNombre()+" tiene sobrepeso; "+'"'+mr[i].getPeso()+'"');
                else System.out.println("La mascota "+mr[i].getNombre()+" no tiene sobrepeso; "+'"'+mr[i].getPeso()+'"');
                break;
            }
        }
        
    }
}
