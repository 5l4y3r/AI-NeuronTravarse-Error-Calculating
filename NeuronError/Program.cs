using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuronError
{
   public  static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
           double i1=0.0, i2=0.0, h1, h2, o1, o2, neth1, neth2, w1=.15, w2=.2,w3=.25,w4=.3,w5=.4,w6=.45,w7=.5,w8=.55,b1=.35,b2=.60;
            double outh1, outh2, net01, out01, out02, net02, target01=.01, target02=.99, e01, e02, etotal;

            double[] ett = new double[110];
            List<double> iList = new List<double>();
            Random r1 = new Random((int)DateTime.Now.Ticks);
            for (int j = 0; j < 100; j++)
            {
               

                i1 = r1.NextDouble();
                
                i2 = r1.NextDouble();

               
                neth1 = w1 * i1 + w2 * i2 + b1 * 1;
                neth2 = w3 * i1 + w4 * i2 + b1 * 1;

                double temp = Math.Exp(-neth1);
                outh1 = 1 / (1 + temp);

                double temp2 = Math.Exp(-neth2);
                outh2 = 1 / (1 + temp2);

                net01 = w5 * outh1 + w6 * outh2 + b2 * 1;
                net02 = w7 * outh1 + w8 * outh2 + b2 * 1;

                double temp3 = Math.Exp(-net01);
                out01 = 1 / (1 + temp3);

                double temp4 = Math.Exp(-net02);
                out02 = 1 / (1 + temp4);

                e01 = .5 * ((target01 - out01) * (target01 - out01));
                e02 = .5 * ((target02 - out02) * (target02 - out02));

                etotal = e01 + e02;

                Console.WriteLine(j + " " + i1 + "  " + i2);
                iList.Add(etotal);
               
            }
            iList.Sort();
            foreach (Object obj in iList) {

                Console.WriteLine(obj +"  ");
            }
         

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(i1,i2,iList[0]));




        }
    }
}
