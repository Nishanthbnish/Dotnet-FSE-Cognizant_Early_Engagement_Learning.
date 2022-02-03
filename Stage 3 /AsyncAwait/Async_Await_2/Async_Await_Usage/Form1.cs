using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_Await_Usage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(@"C:\Users\admin\Desktop\Handson\AsyncAwait\Async_Await_2\Async_Await_Usage\TextFile1.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            {
                Task<int> tasks = new Task<int>(CountCharacters);
                tasks.Start();
                label.Text = "Processing File Please Wait....";
                int count = await tasks;

                label.Text = count.ToString() + " characters in file";
            }
        }
    }
}
