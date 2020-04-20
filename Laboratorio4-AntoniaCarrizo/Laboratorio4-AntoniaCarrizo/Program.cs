using System;

namespace Laboratorio4AntoniaCarrizo
{
    enum opciones { si, no }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Recepcion r1 = new Recepcion("Maquina Recepcion", 10);
            Almacenaje a1 = new Almacenaje("Maquina Almacenaje", 2);
            Ensamblaje e1 = new Ensamblaje("Maquina Ensamblaje", 4);
            Verificacion v1 = new Verificacion("Maquina Verificacion", 13);
            Empaque em1 = new Empaque("Maquina Empaque", 10);

            int cantidadpiezas = 5;

            //Para prender las consolas gradualmente, es decir, la primeramaquina primero... la ultima maquina ultima
            Base[] maquinasList = { r1, a1, e1, v1, em1 };
            Console.WriteLine("Inicio del dia");
            for(int i= 0;i<maquinasList.Length;i++)
            {
                ComputadorCentral c = new ComputadorCentral(maquinasList[i], cantidadpiezas);
                c.Encendermaquinas();
               
            }
            //Para realizar los procesos en orden
            Console.WriteLine("\nEmpezando procesos");
            for (int i = 0; i < maquinasList.Length; i++)
            {
                ComputadorCentral c = new ComputadorCentral(maquinasList[i], cantidadpiezas);
                c.Proceso();


            }
            //Para apagar los computadores en orden
            Console.WriteLine("\nFin del dia");
            for (int i = 0; i < maquinasList.Length; i++)
            {
                ComputadorCentral c = new ComputadorCentral(maquinasList[i], cantidadpiezas);
                c.Apagarmaquinas();
            }

        }
    }
}
