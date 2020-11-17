using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration des var
            int nb = 0;
            char caract = '*';
            string total_chaine = "";
            char forme = 'T';
            string tmp = "";
            int tmp2 = 1;
            int tmp3 = 0;

            //Demande valeurs
            Console.WriteLine("Forme: ");
            forme = char.Parse(Console.ReadLine());

            Console.WriteLine("Valeur: ");
            nb = int.Parse(Console.ReadLine());

            //si triangle
            if(forme == 'T')
            {
                for(int i=nb; i>0; i--)
                {
                    tmp2 = 1;
                    for(int j=1; j<i; j++)
                    {
                        tmp2 = tmp2 + 2;
                    }
                    tmp3 = tmp2/2;
                    tmp="";
                    for(int k=0; k<(nb-tmp3); k++){
                        tmp+=" ";
                    }
                    for (int j = 0; j < tmp2; j++)
                    {
                        tmp += "*";
                    }         
                    total_chaine = "  " + tmp+ "\n"+total_chaine;

                }
            } else { //Si carré
                for (int i = 0; i < nb; i++)
                {
                    if ((i == 0) || (i == nb - 1))
                    {
                        for (int j = 0; j < nb; j++)
                        {
                            total_chaine += caract+" ";
                        }
                    } else {
                        total_chaine+=caract;
                        for (int j = 1; j < nb-1; j++)
                        {
                            total_chaine += "  ";
                        }
                        total_chaine += " "+caract;
                    }
                    total_chaine += "\n";
                }
            }
            Console.WriteLine(total_chaine);
            Console.ReadKey();
        }
    }
}
