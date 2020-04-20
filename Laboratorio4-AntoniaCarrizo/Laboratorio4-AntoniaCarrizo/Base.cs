using System;
namespace Laboratorio4AntoniaCarrizo
{
    public abstract class Base:Ialarm,Iencender,Iapagar,Ireiniciar
    {   //Las definiran las propias clases
        private string name;
        private int totalMemory;
      

        public string Name { get => name; set => name = value; }
        public int TotalMemory { get => totalMemory; set => totalMemory = value; }
        public int BusyMemory { get; set; } = 0;

        public abstract bool Encendido(int a);
        public abstract bool Reinicio(int c);
        public abstract bool Apagado(int b);

      
        public bool Process()
        {
            //Cuando la maquina alcance su maxima capacidad, se lo indicara al computador 
            if (BusyMemory == TotalMemory)
            { 
                Console.WriteLine("La memoria ocupada es: " + BusyMemory);
                return true;
            }
            else
            {
                Console.WriteLine("Realizando proceso");
                BusyMemory++;
                return false;
            }
        }

       

        
    }
}
