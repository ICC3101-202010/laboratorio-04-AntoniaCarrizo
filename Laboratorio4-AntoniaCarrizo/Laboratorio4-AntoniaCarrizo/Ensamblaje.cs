using System;
namespace Laboratorio4AntoniaCarrizo
{
    public class Ensamblaje:Base
    {
        public Ensamblaje(string name, int totalMemory)
        {
            this.Name = name;
            this.TotalMemory = totalMemory;

        }




        public override bool Encendido(int a)
        {

            if (a == 1)
            {
                Console.WriteLine("Encendiendo Maquina Ensamblaje");
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
                Console.WriteLine("Apagando Maquina Ensamblaje ");

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
                Console.WriteLine("Reiniciando Maquina Ensamblaje");

                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
