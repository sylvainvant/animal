using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {
            //objet animal 1 + affiche nombre de pattes et si il a une queue
            Animal animal1 = new Animal();
            Console.WriteLine("le nombre de pattes est :"+animal1.NombreDePattes+ "\n il y a une queue :"+animal1.Queue);
            //objet araignee + affiche nombre de pattes et si il a une queue
            Animal araignee = new Animal(8,false);
            Console.WriteLine("le nombre de pattes est :" + araignee.NombreDePattes + "\n il a une queue :" + araignee.Queue);
            //objet chien1 1 affiche nombre de pattes et si il a une queue
            Chien chien1 = new Chien();
            Console.WriteLine("le nombre de pattes est :" + chien1.NombreDePattes + "\n il y a une queue :" + chien1.Queue +"\n la race :"+ chien1.Race );
            chien1.aboyer();
            //objet chien2 affiche nombre de pattes et si il a une queue
            Chien chien2 = new Chien("Berger allemand");           
            Console.WriteLine("la race :" + chien2.Race);
            
            System.Console.WriteLine(" \n Appuier sur n'importe quel touche pour quitter");
            System.Console.ReadKey();          
        }
        
    }
}
