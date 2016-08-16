using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncDemo
{
    public partial class Form1 : Form
    {
        internal delegate IEnumerable<int> PrimesDelegate(int num1, int num2);
       

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            PrimesDelegate primesDelegate = CalcPrimes;
            primesList.Items.Clear();
            int number1;
            int number2;
            if (!int.TryParse(num1.Text,out number1))
            {
                primesList.Items.Add("Wrong number1, int only");
                return;
            }

            if (!int.TryParse(num2.Text, out number2))
            {
                primesList.Items.Add("Wrong number2, int only");
                return;
            }

            primesDelegate.BeginInvoke(number1, number2,ar=>CallBack(primesDelegate,ar), primesDelegate);
        }

        private void CallBack(PrimesDelegate pd, IAsyncResult ar)
        {
            var list = pd.EndInvoke(ar);
            primesList.Invoke(new Action(() =>
            {
                foreach (var prime in list)
                {
                    primesList.Items.Add(prime);
                }
            }));
        }

        private IEnumerable<int> CalcPrimes(int number1, int number2)
        {
            var primeList = new List<int>();

            if (number2<number1||number1<0)
            {
                return primeList;
            }

            for (var i = number1; i <= number2; i++)
            {
                if (IsPrime(i))
                {
                    primeList.Add(i);
                }
            }
            return primeList;
        }

        private static bool IsPrime(int num)
        {
            if (num<2)
            {
                return false;
            }
            if (num==2||num==3)
            {
                return true;
            }

            for (var i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
