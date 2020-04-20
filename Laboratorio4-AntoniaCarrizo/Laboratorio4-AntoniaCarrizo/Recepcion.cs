using System;
namespace Laboratorio4AntoniaCarrizo
{
    public class Recepcion : Base
    {
      


        public Recepcion(string name,int totalMemory)
        {
            this.Name = name;
            this.TotalMemory = totalMemory;
            
        }


       

        public override bool Encendido(int a)
        {

            if (a == 1)
            {
                Console.WriteLine("Encendiendo Maquina Recepcion");
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Apagado(int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Apagando Maquina Recepcion ");

                return true;
            }

            else
            {
                return false;
            }
        }

        public override bool Reinicio(int c)
        { 
            if (c == 2)
            {
                Console.WriteLine("Reiniciando Maquina Recepcion");

                return true;
            }
            else
            {
                return false;
            }
            
            
        }



    }   
}
