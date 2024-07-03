namespace libreriaClase{

    class Persona
    {

//        private string nombre;


        public string Nombre;

        public string Apellido;
        public string FechaNacimiento;

        public int DNI;



       

        public  Persona(string rNombre,string rApellido ,string rFechaNacimiento, int rDni){
            Nombre = rNombre;
            Apellido= rApellido;
            FechaNacimiento = rFechaNacimiento;
            DNI = rDni;

        }

        public Persona(){
            
        }
        public string caminar(){

            return "Caminando....";

        }

        public void mostrarPersona(){
            Console.WriteLine("Nombre: {0}", Nombre);
            System.Console.WriteLine("Apellido: "+ Apellido  );
            Console.WriteLine("Fecha Nacimiento: {0}", FechaNacimiento);
            Console.WriteLine("DNI: {0}", DNI);
        }

        public void devolverEdad(){
            Console.WriteLine("La edad es:.....");
        }

    }


    class Alumno : Persona {

        private int legajo;
        private string curso;

        private int[] notas;


        public void estudiar(){
            Console.WriteLine("Estudiando....");
        }

        public void devolverCurso(){
            Console.WriteLine("El curso es: {0}", this.curso);
        }
    }

}