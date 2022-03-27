namespace W05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button4.Enabled = false;
                button2.Enabled = false;
                button5.Enabled = false;
                button3.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
                button2.Enabled = true;
                button5.Enabled = true;
                button3.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while(listBox1.Items.Count != 0)
            {
                for (int i=0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                    listBox1.Items.Remove(listBox1.Items[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            while (listBox2.Items.Count != 0)
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox1.Items.Add(listBox2.Items[i]);
                    listBox2.Items.Remove(listBox2.Items[i]);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Add")
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else if (comboBox1.Text == "Replace")
            {
                if (listBox1.SelectedItems.Count == 1)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    listBox1.Items.Add(textBox1.Text);
                }
                else if (listBox1.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Lebih dari 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Tidak ada yang digganti", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mode belum dipilih", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}