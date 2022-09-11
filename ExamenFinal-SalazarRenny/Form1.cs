using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ExamenFinal_SalazarRenny
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        // T pilas
        Stack pilitaT = new Stack();
        Stack pilita1T = new Stack();
        // R pilas
        Stack pilitaR = new Stack();
        Stack pilita1R = new Stack();
        // P pilas
        Stack pilitaP = new Stack();
        Stack pilita1P = new Stack();

        private void button1_Click(object sender, EventArgs e)
        {
            double altura = 0;
            double area = 0;
            double lado1=0, lado2=0, lado3=0;
            double base1 = 0;
            double perimetro = 0;

            altura = Convert.ToInt32(txtalturat.Text);
            
            base1 = Convert.ToInt32(txtbaset.Text);
            lado1 = Convert.ToInt32(textBox1.Text);
            lado2 = Convert.ToInt32(textBox2.Text);
            lado3 = Convert.ToInt32(textBox3.Text);

            //altura y base aora area ,  lados oara ek perimetro
            area = ((base1 * altura) / 2 ) ;

            perimetro = lado1 + lado2 + lado3;


            

            lbl1.Text = area.ToString("el área del triángulo es: " +area);
            lbl2.Text = perimetro.ToString("el perímetro del triángulo es: " +perimetro);

            //Stack pilitaT = new Stack();
            //Stack pilita1T = new Stack();

            //mientras más cálculos se haga dentro del programa las pilas se siguen acumulando en el orden correcto.
            // el primero es el último en salir

            pilita1T.Push(System.Convert.ToInt32(area) + ": es el area del triángulo");
            pilitaT.Push(System.Convert.ToInt32(perimetro) + ": es el perímetro del triángulo");
            lstPila1.Items.Insert(0, pilitaT.Peek());
            lstPila1.Items.Insert(0, pilita1T.Peek());


        }

        private void button2_Click(object sender, EventArgs e) //Rectángulo
        {

            double alturaR=0;
            double areaR;
            double baseR =0;
            double perimetroR;

            alturaR = Convert.ToInt32(lado1r.Text);

            baseR = Convert.ToInt32(lado2r.Text);

            areaR = alturaR * baseR;
            perimetroR = (alturaR * 2) + (baseR * 2);

            lblresultadot.Text = areaR.ToString("el área del rectángulo es: " + areaR);
            lblresultadot1.Text = perimetroR.ToString("el perímetro del rectángulo es: " +perimetroR);



            //Stack pilitaR = new Stack();
            //Stack pilita1R = new Stack();

            //mientras más cálculos se haga dentro del programa las pilas se siguen acumulando en el orden correcto.
            // el primero es el último en salir

            pilita1R.Push(System.Convert.ToInt32(areaR) + ": es el area del rectángulo");
            pilitaR.Push(System.Convert.ToInt32(perimetroR)+ ": es el perímetro del rectángulo");
            lstPila2.Items.Insert(0, pilitaR.Peek());
            lstPila2.Items.Insert(0, pilita1R.Peek());




        }

        private void button3_Click(object sender, EventArgs e)
        {

            double alturaP = 0;
            double areaP = 0;
            double baseP = 0;
            double perimetroP = 0;

            alturaP = Convert.ToInt32(lado1p.Text);

            baseP = Convert.ToInt32(lado2p.Text);

            areaP = baseP * alturaP;
            perimetroP = (2 * alturaP) + (2 * baseP);

            lblP1.Text = areaP.ToString("el área del paralelogramo es: "+areaP);
            lblP2.Text = perimetroP.ToString("el perímetro del paralelogramo es: "+perimetroP);


            //Stack pilitaP = new Stack();
            //Stack pilita1P = new Stack();
            
            //mientras más cálculos se haga dentro del programa las pilas se siguen acumulando en el orden correcto.
            // el primero es el último en salir

            pilita1P.Push(System.Convert.ToInt32(areaP) + ": es el area del paralelogramo");
            pilitaP.Push(System.Convert.ToInt32(perimetroP) + ": es el perímetro del paralelogramo");
            lstPila3.Items.Insert(0, pilitaP.Peek());
            lstPila3.Items.Insert(0, pilita1P.Peek());


        }

    }
}    