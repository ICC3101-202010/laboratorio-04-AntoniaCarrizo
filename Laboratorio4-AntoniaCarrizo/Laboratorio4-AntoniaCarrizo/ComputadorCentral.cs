using System;
namespace Laboratorio4AntoniaCarrizo
{
    public class ComputadorCentral
    {
        private Base maquina;
        private int piezas;

        public ComputadorCentral(Base maquina,  int piezas)
        {
            this.maquina = maquina;
            this.piezas = piezas;
        }

        public void Encendermaquinas()
        {
            maquina.Encendido(1);

        }

        public void Proceso()
        {
            Console.WriteLine(maquina.Name);
            for (int i = 0; i < piezas;)
            {

                
                if (maquina.Process() == true)
                {
                    if (maquina.Reinicio(2) == true)
                    {
                        maquina.BusyMemory = 0;

                       
                        
                    }
                    
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(" ");

        }

        public void Apagarmaquinas()
        {
            maquina.Apagado(0);

        }


    }
}
